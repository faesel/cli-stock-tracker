namespace Models
{
    public class AnnualReportIncomeStatement
    {
        public string fiscalDateEnding { get; set; }
        public string reportedCurrency { get; set; }
        public string grossProfit { get; set; }
        public string totalRevenue { get; set; }
        public string costOfRevenue { get; set; }
        public string costofGoodsAndServicesSold { get; set; }
        public string operatingIncome { get; set; }
        public string sellingGeneralAndAdministrative { get; set; }
        public string researchAndDevelopment { get; set; }
        public string operatingExpenses { get; set; }
        public string investmentIncomeNet { get; set; }
        public string netInterestIncome { get; set; }
        public string interestIncome { get; set; }
        public string interestExpense { get; set; }
        public string nonInterestIncome { get; set; }
        public string otherNonOperatingIncome { get; set; }
        public string depreciation { get; set; }
        public string depreciationAndAmortization { get; set; }
        public string incomeBeforeTax { get; set; }
        public string incomeTaxExpense { get; set; }
        public string interestAndDebtExpense { get; set; }
        public string netIncomeFromContinuingOperations { get; set; }
        public string comprehensiveIncomeNetOfTax { get; set; }
        public string ebit { get; set; }
        public string ebitda { get; set; }
        public string netIncome { get; set; }
    }

    public class QuarterlyReportIncomeStatement
    {
        public string fiscalDateEnding { get; set; }
        public string reportedCurrency { get; set; }
        public string grossProfit { get; set; }
        public string totalRevenue { get; set; }
        public string costOfRevenue { get; set; }
        public string costofGoodsAndServicesSold { get; set; }
        public string operatingIncome { get; set; }
        public string sellingGeneralAndAdministrative { get; set; }
        public string researchAndDevelopment { get; set; }
        public string operatingExpenses { get; set; }
        public string investmentIncomeNet { get; set; }
        public string netInterestIncome { get; set; }
        public string interestIncome { get; set; }
        public string interestExpense { get; set; }
        public string nonInterestIncome { get; set; }
        public string otherNonOperatingIncome { get; set; }
        public string depreciation { get; set; }
        public string depreciationAndAmortization { get; set; }
        public string incomeBeforeTax { get; set; }
        public string incomeTaxExpense { get; set; }
        public string interestAndDebtExpense { get; set; }
        public string netIncomeFromContinuingOperations { get; set; }
        public string comprehensiveIncomeNetOfTax { get; set; }
        public string ebit { get; set; }
        public string ebitda { get; set; }
        public string netIncome { get; set; }
    }

    public class IncomeStatement
    {
        public string symbol { get; set; }
        public List<AnnualReportIncomeStatement> annualReports { get; set; }
        public List<QuarterlyReportIncomeStatement> quarterlyReports { get; set; }
    }
}