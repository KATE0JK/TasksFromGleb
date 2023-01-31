using TestProject1.Models;

namespace TestProject1;

[TestClass]
public class UnitTest1
{
    private const string WorkingDirectoryName = "UnzippedFiles";

    [TestInitialize]
    public void TestInit()
    {
        if (!Directory.Exists(WorkingDirectoryName))
        {
            Directory.CreateDirectory(WorkingDirectoryName);
        }
    }

    [TestCleanup]
    public void TestCleanup()
    {
        var di = new DirectoryInfo(WorkingDirectoryName);

        foreach (var file in di.GetFiles())
        {
            file.Delete(); 
        }
        
        foreach (var dir in di.GetDirectories())
        {
            dir.Delete(true); 
        }
    }
    
    [TestMethod]
    [DataRow("PaidAmount", 3.50)]
    public void PaidAmountTest(string paidAmountTag, double expectedResult)
    {
        var xmlFilePath = @"TestDataFiles/SNC_AOD_01102023_061442.xml";
        var parser = new XmlParser(xmlFilePath);

        var values = parser.GetValuesByTag(paidAmountTag);
        
        var castedValues = values.Select(x => Convert.ToDouble(x));

        Assert.AreEqual(expectedResult, castedValues.Sum());
    }
    
    [TestMethod]
    public void PaymentNumberTest()
    {
        var xmlFilePath = @"TestDataFiles/SNC_AOD_01102023_061442.xml";
        var parser = new XmlParser(xmlFilePath);

        var values = parser.GetValuesByTag("PaymentNumber");

        const string expectedResult = "0000000325";

        Assert.AreEqual(expectedResult, values.First());
    }

    [TestMethod]
    [DataRow("PaidAmount", 3.50)]
    public void PaidAmountZipTest(string paidAmountTag, double expectedResult)
    {
        var zipFilePath = @"ZipFiles/SNC_AOD_01102023_061442.xml.zip";

        ZipHelper.Unzip(zipFilePath, WorkingDirectoryName);
        
        var xmlFilePath = WorkingDirectoryName + @"/SNC_AOD_01102023_061442.xml";
        var parser = new XmlParser(xmlFilePath);

        var values = parser.GetValuesByTag(paidAmountTag);
        
        var castedValues = values.Select(x => Convert.ToDouble(x));

        Assert.AreEqual(expectedResult, castedValues.Sum());
    }
    
    [TestMethod]
    public void PaidAmountDeserializeTest()
    {
        var xmlFilePath = @"TestDataFiles/SNC_AOD_01102023_061442.xml";
        var parser = new XmlParser(xmlFilePath);

        var payment = parser.DeserializeObject<PaymentFile>();
        
        Assert.IsNotNull(payment);

        var expectedPaymentNumber = "0000000325";

        Assert.AreEqual(expectedPaymentNumber, payment.PaymentDetail.PaymentNumber);
    }
}