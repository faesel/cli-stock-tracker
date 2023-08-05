namespace Models
{
    public class AnnualReportBalanceSheet
    {
        public string fiscalDateEnding { get; set; }
        public string reportedCurrency { get; set; }
        public string totalAssets { get; set; }
        public string totalCurrentAssets { get; set; }
        public string cashAndCashEquivalentsAtCarryingValue { get; set; }
        public string cashAndShortTermInvestments { get; set; }
        public string inventory { get; set; }
        public string currentNetReceivables { get; set; }
        public string totalNonCurrentAssets { get; set; }
        public string propertyPlantEquipment { get; set; }
        public string accumulatedDepreciationAmortizationPPE { get; set; }
        public string intangibleAssets { get; set; }
        public string intangibleAssetsExcludingGoodwill { get; set; }
        public string goodwill { get; set; }
        public string investments { get; set; }
        public string longTermInvestments { get; set; }
        public string shortTermInvestments { get; set; }
        public string otherCurrentAssets { get; set; }
        public string otherNonCurrentAssets { get; set; }
        public string totalLiabilities { get; set; }
        public string totalCurrentLiabilities { get; set; }
        public string currentAccountsPayable { get; set; }
        public string deferredRevenue { get; set; }
        public string currentDebt { get; set; }
        public string shortTermDebt { get; set; }
        public string totalNonCurrentLiabilities { get; set; }
        public string capitalLeaseObligations { get; set; }
        public string longTermDebt { get; set; }
        public string currentLongTermDebt { get; set; }
        public string longTermDebtNoncurrent { get; set; }
        public string shortLongTermDebtTotal { get; set; }
        public string otherCurrentLiabilities { get; set; }
        public string otherNonCurrentLiabilities { get; set; }
        public string totalShareholderEquity { get; set; }
        public string treasuryStock { get; set; }
        public string retainedEarnings { get; set; }
        public string commonStock { get; set; }
        public string commonStockSharesOutstanding { get; set; }
    }

    public class QuarterlyReportBalanceSheet
    {
        public string fiscalDateEnding { get; set; }
        public string reportedCurrency { get; set; }
        public string totalAssets { get; set; }
        public string totalCurrentAssets { get; set; }
        public string cashAndCashEquivalentsAtCarryingValue { get; set; }
        public string cashAndShortTermInvestments { get; set; }
        public string inventory { get; set; }
        public string currentNetReceivables { get; set; }
        public string totalNonCurrentAssets { get; set; }
        public string propertyPlantEquipment { get; set; }
        public string accumulatedDepreciationAmortizationPPE { get; set; }
        public string intangibleAssets { get; set; }
        public string intangibleAssetsExcludingGoodwill { get; set; }
        public string goodwill { get; set; }
        public string investments { get; set; }
        public string longTermInvestments { get; set; }
        public string shortTermInvestments { get; set; }
        public string otherCurrentAssets { get; set; }
        public string otherNonCurrentAssets { get; set; }
        public string totalLiabilities { get; set; }
        public string totalCurrentLiabilities { get; set; }
        public string currentAccountsPayable { get; set; }
        public string deferredRevenue { get; set; }
        public string currentDebt { get; set; }
        public string shortTermDebt { get; set; }
        public string totalNonCurrentLiabilities { get; set; }
        public string capitalLeaseObligations { get; set; }
        public string longTermDebt { get; set; }
        public string currentLongTermDebt { get; set; }
        public string longTermDebtNoncurrent { get; set; }
        public string shortLongTermDebtTotal { get; set; }
        public string otherCurrentLiabilities { get; set; }
        public string otherNonCurrentLiabilities { get; set; }
        public string totalShareholderEquity { get; set; }
        public string treasuryStock { get; set; }
        public string retainedEarnings { get; set; }
        public string commonStock { get; set; }
        public string commonStockSharesOutstanding { get; set; }
    }

    public class BalanceSheet
    {
        public string symbol { get; set; }
        public List<AnnualReportBalanceSheet> annualReports { get; set; }
        public List<QuarterlyReportBalanceSheet> quarterlyReports { get; set; }
    }
}
