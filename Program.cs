using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using CsvHelper;
using System.Globalization;
namespace JavascriptProject11
{
    class Program
    {
        static void Main(string[] args)
        {

            /*var reader = new StreamReader(@"C:\Users\yogen\source\repos\JavascriptProject1\WestBengal.csv");
            var rows = new CsvReader(reader, CultureInfo.InvariantCulture);
            Dictionary<string, int> AuthorizedCap = new Dictionary<string, int>
            {
                ["<=1L"] = 0,
                ["1L to 10L"] = 0,
                ["10L to 1Cr"] = 0,
                ["1Cr to 10Cr"] = 0,
                [">10Cr"] = 0
            };
            foreach (var row in rows.GetRecords<WestBengal>())
            {
                double x = Convert.ToDouble(row.AUTHORIZED_CAP);
                if (x <= 100000)
                    AuthorizedCap["<=1L"]++;

                else if (x > 100000 && x <= 1000000)
                    AuthorizedCap["1L to 10L"]++;

                else if (x > 1000000 && x <= 10000000)
                    AuthorizedCap["10L to 1Cr"]++;

                else if (x > 10000000 && x <= 100000000)
                    AuthorizedCap["1Cr to 10Cr"]++;

                else
                    AuthorizedCap[">10Cr"]++;
            }
            string Json = JsonConvert.SerializeObject(AuthorizedCap, Formatting.Indented);
            string writePath = @"C:\Users\yogen\source\repos\JavascriptProject11\Test1.json";
            System.IO.File.WriteAllText(writePath, Json);
            Console.WriteLine(Json);
            Console.ReadLine();


            */

            /*

            //testcase2
            var reader = new StreamReader(@"C:\Users\yogen\source\repos\JavascriptProject1\WestBengal.csv");
            var rows = new CsvReader(reader, CultureInfo.InvariantCulture);
            Dictionary<string, int> DATEOFREGISTRATION = new Dictionary<string, int>();
            for (int i = 2000; i <= 2019; i++)
            {
                DATEOFREGISTRATION[i.ToString()] = 0;
            }
            //foreach (KeyValuePair<string, int> ele2 in DATEOFREGISTRATION)
            //{ Console.WriteLine("Key={0} value={1}", ele2.Key, ele2.Value); }

            foreach (var row in rows.GetRecords<WestBengal>())
            {
                if (row.DATE_OF_REGISTRATION != "NA")
                {
                    DateTime dt = Convert.ToDateTime(row.DATE_OF_REGISTRATION);
                    int year = dt.Year;  //fetch the year

                    if (year >= 2000 && year <= 2019)
                    { DATEOFREGISTRATION[year.ToString()]++; }
                }
            }


            string Json = JsonConvert.SerializeObject(DATEOFREGISTRATION, Formatting.Indented);
            string writePath = @"C:\Users\yogen\source\repos\JavascriptProject11\Test2.json";
            System.IO.File.WriteAllText(writePath, Json);
            Console.WriteLine(Json);
            Console.ReadLine();

            */
            /*
            //testcase3
            var reader = new StreamReader(@"C:\Users\yogen\source\repos\Projectt1\WestBengal.csv");
            var rows = new CsvReader(reader, CultureInfo.InvariantCulture);

            Dictionary<string, int> PrincipalActivity = new Dictionary<string, int>();
            foreach (var row in rows.GetRecords<WestBengal>())
            {
                if (row.DATE_OF_REGISTRATION != "NA")
                {
                    DateTime dt = Convert.ToDateTime(row.DATE_OF_REGISTRATION);
                    int year = dt.Year;  //fetch the year

                    if (year == 2015)
                    {
                        string x = row.PRINCIPAL_BUSINESS_ACTIVITY_AS_PER_CIN;
                        if (PrincipalActivity.ContainsKey(x))
                            PrincipalActivity[x]++;
                        else
                            PrincipalActivity[x] = 1;
                    }
                }
            }

            string Json = JsonConvert.SerializeObject(PrincipalActivity, Formatting.Indented);
            string writePath = @"C:\Users\yogen\source\repos\JavascriptProject11\Test3.json";
            System.IO.File.WriteAllText(writePath, Json);
            Console.WriteLine(Json);
            Console.ReadLine();

            */



            //testcase4

            var reader = new StreamReader(@"C:\Users\yogen\source\repos\Projectt1\WestBengal.csv");
            var rows = new CsvReader(reader, CultureInfo.InvariantCulture);
            Dictionary<string, Dictionary<string, int>> PrincipalActivity = new Dictionary<string, Dictionary<string, int>>();
            foreach (var row in rows.GetRecords<WestBengal>())//2000:(Agricuture:1)
            {
                if (row.DATE_OF_REGISTRATION != "NA")
                {
                    DateTime dt = Convert.ToDateTime(row.DATE_OF_REGISTRATION);
                    int year = dt.Year;  //fetch the year
                    if (year >= 2000 && year <= 2019)
                    {
                        if (PrincipalActivity.ContainsKey(year.ToString()) && PrincipalActivity[year.ToString()].ContainsKey(row.PRINCIPAL_BUSINESS_ACTIVITY_AS_PER_CIN))
                        {
                            PrincipalActivity[year.ToString()][row.PRINCIPAL_BUSINESS_ACTIVITY_AS_PER_CIN]++;
                        }
                        else if (PrincipalActivity.ContainsKey(year.ToString()))
                        {
                            PrincipalActivity[year.ToString()].Add(row.PRINCIPAL_BUSINESS_ACTIVITY_AS_PER_CIN, 1);
                        }
                        else
                        {
                            PrincipalActivity.Add(year.ToString(), new Dictionary<string, int>());
                            PrincipalActivity[year.ToString()].Add(row.PRINCIPAL_BUSINESS_ACTIVITY_AS_PER_CIN, 1);
                        }




                    }
                }
            }
            string Json = JsonConvert.SerializeObject(PrincipalActivity, Formatting.Indented);
            string writePath = @"C:\Users\yogen\source\repos\JavascriptProject11\Test4.json";
            System.IO.File.WriteAllText(writePath, Json);
            Console.WriteLine(Json);
            Console.ReadLine();
        }
    }
}
