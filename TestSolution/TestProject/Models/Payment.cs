using System.Xml.Serialization;

namespace TestProject1.Models
{
	[XmlRoot(ElementName="TransactionDetail")]
	public class TransactionDetail 
	{
		[XmlElement(ElementName="PlanName")]
		public string PlanName { get; set; }
		
		[XmlElement(ElementName="ServiceStartDate")]
		public string ServiceStartDate { get; set; }
		
		[XmlElement(ElementName="ServiceEndDate")]
		public string ServiceEndDate { get; set; }
		
		[XmlElement(ElementName="ReimbursementDate")]
		public string ReimbursementDate { get; set; }
		
		[XmlElement(ElementName="BatchNumber")]
		public string BatchNumber { get; set; }
		
		[XmlElement(ElementName="ClaimNumber")]
		public string ClaimNumber { get; set; }
		
		[XmlElement(ElementName="TransactionAmount")]
		public string TransactionAmount { get; set; }
		
		[XmlElement(ElementName="PaidAmount")]
		public string PaidAmount { get; set; }
		
		[XmlElement(ElementName="PendingAmount")]
		public string PendingAmount { get; set; }
		
		[XmlElement(ElementName="DeniedAmount")]
		public string DeniedAmount { get; set; }
		
		[XmlElement(ElementName="AmountThisCycle")]
		public string AmountThisCycle { get; set; }
		
		[XmlElement(ElementName="MerchantProvider")]
		public string MerchantProvider { get; set; }
	}

	[XmlRoot(ElementName="TransactionTable")]
	public class TransactionTable 
	{
		[XmlElement(ElementName="TransactionHeader")]
		public string TransactionHeader { get; set; }
		
		[XmlElement(ElementName="TransactionDetail")]
		public TransactionDetail TransactionDetail { get; set; }
	}

	[XmlRoot(ElementName="PlanDetail")]
	public class PlanDetail 
	{
		[XmlElement(ElementName="PlanName")]
		public string PlanName { get; set; }
		
		[XmlElement(ElementName="EligibleAmount")]
		public string EligibleAmount { get; set; }
		
		[XmlElement(ElementName="IgnoreEligibleAmount")]
		public string IgnoreEligibleAmount { get; set; }
		
		[XmlElement(ElementName="SubmittedClaims")]
		public string SubmittedClaims { get; set; }
		
		[XmlElement(ElementName="PaidAmount")]
		public string PaidAmount { get; set; }
		
		[XmlElement(ElementName="PendingAmount")]
		public string PendingAmount { get; set; }
		
		[XmlElement(ElementName="DeniedAmount")]
		public string DeniedAmount { get; set; }
		
		[XmlElement(ElementName="PlanYearBalance")]
		public string PlanYearBalance { get; set; }
		
		[XmlElement(ElementName="IgnorePlanYearBalance")]
		public string IgnorePlanYearBalance { get; set; }
		
		[XmlElement(ElementName="YTDContributionAmount")]
		public string YTDContributionAmount { get; set; }
	}

	[XmlRoot(ElementName="PlanBalanceTable")]
	public class PlanBalanceTable 
	{
		[XmlElement(ElementName="PlanDetail")]
		public List<PlanDetail> PlanDetail { get; set; }
	}

	[XmlRoot(ElementName="ReimbursementEOB")]
	public class ReimbursementEOB 
	{
		[XmlElement(ElementName="TransactionTable")]
		public TransactionTable TransactionTable { get; set; }
		
		[XmlElement(ElementName="PlanBalanceTable")]
		public PlanBalanceTable PlanBalanceTable { get; set; }
	}

	[XmlRoot(ElementName="Image")]
	public class Image 
	{
		[XmlAttribute(AttributeName="type")]
		public string Type { get; set; }
		
		[XmlAttribute(AttributeName="contenttype")]
		public string Contenttype { get; set; }
	}

	[XmlRoot(ElementName="ClaimForms")]
	public class ClaimForms {
		[XmlElement(ElementName="Image")]
		public Image Image { get; set; }
		
		[XmlElement(ElementName="FormDetailTable")]
		public string FormDetailTable { get; set; }
	}

	[XmlRoot(ElementName="PaymentDetail")]
	public class PaymentDetail 
	{
		[XmlElement(ElementName="PaymentID")]
		public string PaymentID { get; set; }
		
		[XmlElement(ElementName="SourceAccountName")]
		public string SourceAccountName { get; set; }
		
		[XmlElement(ElementName="SourceAccountAddressLine1")]
		public string SourceAccountAddressLine1 { get; set; }
		
		[XmlElement(ElementName="SourceAccountAddressLine2")]
		public string SourceAccountAddressLine2 { get; set; }
		
		[XmlElement(ElementName="SourceAccountAddressLine3")]
		public string SourceAccountAddressLine3 { get; set; }
		
		[XmlElement(ElementName="SourceAccountAddressCity")]
		public string SourceAccountAddressCity { get; set; }
		
		[XmlElement(ElementName="SourceAccountAddressState")]
		public string SourceAccountAddressState { get; set; }
		
		[XmlElement(ElementName="SourceAccountAddressZipCode")]
		public string SourceAccountAddressZipCode { get; set; }
		
		[XmlElement(ElementName="ConsumerIdentifierDisplayName")]
		public string ConsumerIdentifierDisplayName { get; set; }
		
		[XmlElement(ElementName="ConsumerCommunicationId")]
		public string ConsumerCommunicationId { get; set; }
		
		[XmlElement(ElementName="EMailIndicator")]
		public string EMailIndicator { get; set; }
		
		[XmlElement(ElementName="ConsumerFirstName")]
		public string ConsumerFirstName { get; set; }
		
		[XmlElement(ElementName="ConsumerMiddleName")]
		public string ConsumerMiddleName { get; set; }
		
		[XmlElement(ElementName="ConsumerLastName")]
		public string ConsumerLastName { get; set; }
		
		[XmlElement(ElementName="ConsumerSSN")]
		public string ConsumerSSN { get; set; }
		
		[XmlElement(ElementName="ConsumerDOB")]
		public string ConsumerDOB { get; set; }
		
		[XmlElement(ElementName="PayeeFullName")]
		public string PayeeFullName { get; set; }
		
		[XmlElement(ElementName="PayeeAddressLine1")]
		public string PayeeAddressLine1 { get; set; }
		
		[XmlElement(ElementName="PayeeAddressLine2")]
		public string PayeeAddressLine2 { get; set; }
		
		[XmlElement(ElementName="PayeeAddressLine3")]
		public string PayeeAddressLine3 { get; set; }
		
		[XmlElement(ElementName="PayeeAddressCity")]
		public string PayeeAddressCity { get; set; }
		
		[XmlElement(ElementName="PayeeAddressState")]
		public string PayeeAddressState { get; set; }
		
		[XmlElement(ElementName="PayeeAddressZipCode")]
		public string PayeeAddressZipCode { get; set; }
		
		[XmlElement(ElementName="PayeeAddressCountryCode")]
		public string PayeeAddressCountryCode { get; set; }
		
		[XmlElement(ElementName="PayeeAddressCountryName")]
		public string PayeeAddressCountryName { get; set; }
		
		[XmlElement(ElementName="Reprint")]
		public string Reprint { get; set; }
		
		[XmlElement(ElementName="PaymentNumber")]
		public string PaymentNumber { get; set; }
		
		[XmlElement(ElementName="PaymentDate")]
		public string PaymentDate { get; set; }
		
		[XmlElement(ElementName="PaymentAmount")]
		public string PaymentAmount { get; set; }
		
		[XmlElement(ElementName="PaymentAmountLongHand")]
		public string PaymentAmountLongHand { get; set; }
		
		[XmlElement(ElementName="CheckInformation")]
		public string CheckInformation { get; set; }
		
		[XmlElement(ElementName="LogoImage")]
		public string LogoImage { get; set; }
		
		[XmlElement(ElementName="SignatureImage")]
		public string SignatureImage { get; set; }
		
		[XmlElement(ElementName="EmployerName")]
		public string EmployerName { get; set; }
		
		[XmlElement(ElementName="EmployerCode")]
		public string EmployerCode { get; set; }
		
		[XmlElement(ElementName="EmployerDivision")]
		public string EmployerDivision { get; set; }
		
		[XmlElement(ElementName="BusinessParty")]
		public string BusinessParty { get; set; }
		
		[XmlElement(ElementName="AdministratorCode")]
		public string AdministratorCode { get; set; }
		
		[XmlElement(ElementName="ContactAdministratorName")]
		public string ContactAdministratorName { get; set; }
		
		[XmlElement(ElementName="ContactName")]
		public string ContactName { get; set; }
		
		[XmlElement(ElementName="ContactAddressLine1")]
		public string ContactAddressLine1 { get; set; }
		
		[XmlElement(ElementName="ContactAddressLine2")]
		public string ContactAddressLine2 { get; set; }
		
		[XmlElement(ElementName="ContactAddressLine3")]
		public string ContactAddressLine3 { get; set; }
		
		[XmlElement(ElementName="ContactAddressCity")]
		public string ContactAddressCity { get; set; }
		
		[XmlElement(ElementName="ContactAddressState")]
		public string ContactAddressState { get; set; }
		
		[XmlElement(ElementName="ContactAddressZipCode")]
		public string ContactAddressZipCode { get; set; }
		
		[XmlElement(ElementName="ContactPhoneNumber")]
		public string ContactPhoneNumber { get; set; }
		
		[XmlElement(ElementName="ContactTollFreeNumber")]
		public string ContactTollFreeNumber { get; set; }
		
		[XmlElement(ElementName="ContactFaxNumber")]
		public string ContactFaxNumber { get; set; }
		
		[XmlElement(ElementName="ContactEmailAddress")]
		public string ContactEmailAddress { get; set; }
		
		[XmlElement(ElementName="CustomText")]
		public string CustomText { get; set; }
		
		[XmlElement(ElementName="ReimbursementEOB")]
		public ReimbursementEOB ReimbursementEOB { get; set; }
		
		[XmlElement(ElementName="ClaimForms")]
		public ClaimForms ClaimForms { get; set; }
	}

	[XmlRoot(ElementName="PaymentFile")]
	public class PaymentFile 
	{
		[XmlElement(ElementName="PaymentDetail")]
		public PaymentDetail PaymentDetail { get; set; }
		
		[XmlAttribute(AttributeName="type")]
		public string Type { get; set; }
		
		[XmlAttribute(AttributeName="version")]
		public string Version { get; set; }
	}
}
