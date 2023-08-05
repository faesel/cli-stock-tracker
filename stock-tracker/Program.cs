using System.Text.Json;
using AlphaVantage.Net.Common;
using AlphaVantage.Net.Core.Client;
using AppSettings;
using Factory;
using Models;
using Spectre.Console;

var elapsedTime = DateTime.Now;
var stocks = new List<string> { "MSFT", "AAPL", "GOOG" };

foreach(var stock in stocks)
{
    if(DateTime.Now >= elapsedTime)
    {
        Console.WriteLine("Getting data for {0}", stock);

        using var client = new AlphaVantageClient(Settings.ApiKey);

        var query = new Dictionary<string, string>()
        {
            {"symbol", stock},
            {"interval", "15min"}
        };

        string incomeStatementJson = await client.RequestPureJsonAsync(ApiFunction.INCOME_STATEMENT, query);
        var incomeStatement = JsonSerializer.Deserialize<IncomeStatement>(incomeStatementJson);

        string balanceSheetJson = await client.RequestPureJsonAsync(ApiFunction.BALANCE_SHEET, query);
        var balanceSheet = JsonSerializer.Deserialize<BalanceSheet>(incomeStatementJson);

        string cashflowJson = await client.RequestPureJsonAsync(ApiFunction.CASH_FLOW, query);
        var cashflow = JsonSerializer.Deserialize<CashFlow>(incomeStatementJson);

        if(incomeStatement?.annualReports != null) {
            var annualReport = incomeStatement.annualReports;
            var table = new Table();

            table.AddColumn("Metric");
            table.AddColumn(annualReport[0].fiscalDateEnding);
            table.AddColumn(annualReport[1].fiscalDateEnding);
            table.AddColumn(annualReport[2].fiscalDateEnding);
            table.AddColumn(annualReport[3].fiscalDateEnding);

            table.AddRow(ColouredColumn.GetColouredColumn("Total Revenue", incomeStatement.annualReports.Select(x => decimal.Parse(x.totalRevenue)).Take(5).ToList()));
            table.AddRow(ColouredColumn.GetColouredColumn("Cost of Revenue", incomeStatement.annualReports.Select(x => decimal.Parse(x.costOfRevenue)).Take(5).ToList()));
            table.AddRow(ColouredColumn.GetColouredColumn("Cost of Revenue", incomeStatement.annualReports.Select(x => decimal.Parse(x.costofGoodsAndServicesSold)).Take(5).ToList()));
            table.AddRow(ColouredColumn.GetColouredColumn("Gross Profit", incomeStatement.annualReports.Select(x => decimal.Parse(x.grossProfit)).Take(5).ToList()));
            table.AddRow("[underline]Operating Expenses[/]", "[yellow]-[/]", "[yellow]-[/]", "[yellow]-[/]", "[yellow]-[/]");
            table.AddRow(ColouredColumn.GetColouredColumn("> Research & Development", incomeStatement.annualReports.Select(x => decimal.Parse(x.researchAndDevelopment)).Take(5).ToList()));
            table.AddRow(ColouredColumn.GetColouredColumn("> Selling general & Administrative", incomeStatement.annualReports.Select(x => decimal.Parse(x.sellingGeneralAndAdministrative)).Take(5).ToList()));
            table.AddRow(ColouredColumn.GetBoldColouredColumn("> Operating Expenses", incomeStatement.annualReports.Select(x => decimal.Parse(x.operatingExpenses)).Take(5).ToList()));
            table.AddRow(ColouredColumn.GetBoldColouredColumn("> Total Operating Expenses", incomeStatement.annualReports.Select(x => decimal.Parse(x.researchAndDevelopment) + decimal.Parse(x.sellingGeneralAndAdministrative)).Take(5).ToList()));
            table.AddRow(ColouredColumn.GetBoldColouredColumn("Operating Income or Loss", incomeStatement.annualReports.Select(x => decimal.Parse(x.grossProfit) - decimal.Parse(x.researchAndDevelopment) - decimal.Parse(x.sellingGeneralAndAdministrative)).Take(5).ToList()));
            table.AddRow(ColouredColumn.GetColouredColumn("Interest Expense", incomeStatement.annualReports.Select(x => decimal.Parse(x.interestExpense)).Take(5).ToList()));
            table.AddRow(ColouredColumn.GetColouredColumn("Income before tax", incomeStatement.annualReports.Select(x => decimal.Parse(x.incomeBeforeTax)).Take(5).ToList()));
            table.AddRow(ColouredColumn.GetColouredColumn("Income tax expense", incomeStatement.annualReports.Select(x => decimal.Parse(x.incomeTaxExpense)).Take(5).ToList()));
            table.AddRow(ColouredColumn.GetColouredColumn("Income from continuing operations", incomeStatement.annualReports.Select(x => decimal.Parse(x.netIncomeFromContinuingOperations)).Take(5).ToList()));
            table.AddRow(ColouredColumn.GetBoldColouredColumn("Net income", incomeStatement.annualReports.Select(x => decimal.Parse(x.netIncome)).Take(5).ToList()));
            table.AddRow(ColouredColumn.GetColouredColumn("EBITDAH", incomeStatement.annualReports.Select(x => decimal.Parse(x.ebitda)).Take(5).ToList()));
            
            AnsiConsole.Write(table);
        }

        elapsedTime = DateTime.Now.AddMinutes(1);
    }

    Thread.Sleep(300000);
}
