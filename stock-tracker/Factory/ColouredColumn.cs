namespace Factory
{
    public static class ColouredColumn
    {
        public static string[] GetColouredColumn(string columnName, List<decimal> columns)
        {
            List<string> colouredColumns = new()
            {
                columnName
            };

            for (int i = 0; i < columns.Count; i++)
            {
                if (i < columns.Count - 1)
                {
                    colouredColumns.Add(columns[i] > columns[i + 1] ? $"[green]{columns[i]:n}[/]" : $"[red]{columns[i]:n}[/]");
                }
            }

            return colouredColumns.ToArray();
        }

        public static string[] GetBoldColouredColumn(string columnName, List<decimal> columns)
        {
            List<string> colouredColumns = new()
            {
                $"[bold]{columnName}[/]"
            };

            for (int i = 0; i < columns.Count; i++)
            {
                if (i < columns.Count - 1)
                {
                    colouredColumns.Add(columns[i] > columns[i + 1] ? $"[bold green]{columns[i]:n}[/]" : $"[bold red]{columns[i]:n}[/]");
                }
            }

            return colouredColumns.ToArray();
        }
    }
}