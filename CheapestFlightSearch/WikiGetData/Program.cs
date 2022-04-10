using HtmlAgilityPack;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace WikiGetData
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("DOWNLOAD AIRPORTS");
            Console.Write("PRESS [Y] FOR DOWNLOADING\n");

            var keyValue = Console.ReadKey();

            Console.WriteLine();

            if(keyValue.Key==ConsoleKey.Y)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("IATA", typeof(string));
                dt.Columns.Add("ICAO", typeof(string));
                dt.Columns.Add("AirportName", typeof(string));
                dt.Columns.Add("AirportLocation", typeof(string));

                var brojDohvacenihPodataka = 0;

                using HttpClient httpClient = new HttpClient();

                for (char letter = 'A'; letter <= 'Z'; letter++)
                {
                    var url = $"https://en.wikipedia.org/wiki/List_of_airports_by_IATA_code:_{letter}";

                    HtmlDocument htmlDocument = new();
                    htmlDocument.LoadHtml(await httpClient.GetStringAsync(url));

                    var table = htmlDocument
                        .DocumentNode
                        .SelectSingleNode("//table")
                        .Descendants("tr")
                        .Where(tr => tr.Elements("td").Count() > 2)
                        .Select(tr => tr.Elements("td").Select(td => td.InnerText.Trim().Replace("&apos", "").Replace("1&#93;", "").Replace("2&#93;", "").Replace("&#91;", "").Replace("3&#93;", "").Replace("4&#93;", "").Replace(";", "")).ToList())
                        .ToList();


                    foreach (var row in table)
                    {
                        Console.WriteLine($"{row[0]} - {row[1]} - {row[2]} - {row[3]}");

                        DataRow dr = dt.NewRow();
                        dr["IATA"] = row[0];
                        dr["ICAO"] = row[1];
                        dr["AirportName"] = row[2];
                        dr["AirportLocation"] = row[3];
                        dt.Rows.Add(dr);
                        brojDohvacenihPodataka += 1;
                    }
                }
                Console.WriteLine("##################################################");
                Console.WriteLine("##################################################");
                Console.WriteLine("##################################################");
                Console.WriteLine("##################################################");
                Console.WriteLine($"Dohvaćeno {brojDohvacenihPodataka} podataka. \n Molimo pricekajte...");

                Thread.Sleep(3000);

                Console.WriteLine("##################################################");
                Console.WriteLine("##################################################");
                Console.WriteLine("SLIJEDI SPREMANJE DOHVACENIH PODATAKA...\n");

                string connectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=CheapestFlightsDB;Integrated Security=True";
                using SqlConnection con = new SqlConnection(connectionString);
                using SqlBulkCopy bulk = new(con);

                bulk.DestinationTableName = "Airports";
                bulk.ColumnMappings.Add("IATA", "IATA");
                bulk.ColumnMappings.Add("ICAO", "ICAO");
                bulk.ColumnMappings.Add("AirportName", "AirportName");
                bulk.ColumnMappings.Add("AirportLocation", "AirportLocation");

                con.Open();

                using (SqlCommand command = new SqlCommand("DELETE FROM Airports;", con))
                {
                    command.ExecuteScalar();
                }

                bulk.WriteToServer(dt);
                con.Close();
            }

            else
            {
                Console.WriteLine("##################################################");
                Console.WriteLine("PODACI SE NE SKIDAJU, PROGRAM JE U PROCESU GAŠENJA");
            }

            Thread.Sleep(2000);
            Environment.Exit(0);
        }
    }
}
