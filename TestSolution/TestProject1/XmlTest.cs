namespace TestProject1;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void PaidAmountTest()
    {
        var xmlFilePath = @"TestDataFiles/SNC_AOD_01102023_061442.xml";
        var parser = new XmlParser(xmlFilePath);

        var values = parser.GetValuesByTag("PaidAmount");
        
        var castedValues = values.Select(x => Convert.ToDouble(x));

        const double expectedResult = 3.50;

        Assert.AreEqual(expectedResult, castedValues.Sum());
    }
}