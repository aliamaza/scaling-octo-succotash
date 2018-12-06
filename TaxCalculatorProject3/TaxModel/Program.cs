using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TaxModel
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteTables1();
            WriteLine("=====================");
            Test1();
            WriteLine("=====================");
            WriteLine("=====================");
            WriteTables2();
            WriteLine("=====================");
            Test2();
            WriteLine("=====================");
            WriteLine("=====================");
            WriteTables3();
            WriteLine("=====================");
            Test3();
            ReadKey();
        }

        static void Test1()
        {
            double[] incomes = { 100, 150, 200, 350, 400 };
            double[] expectedTax = { 10, 15, 25, 55, 70 };
            TaxTable txtb = new TaxTable();
            WriteLine("{0,10} {1,10} {2,10} {3,15}",
                "Income", "Expected", "Computed", "Difference");
            for (int i = 0; i < incomes.Length; i++)
            {
                double computedTax = txtb.computeTax(incomes[i]);
                double diff = computedTax - expectedTax[i];
                WriteLine("{0,10:c} {1,10:c} {2,10:c} {3,15:e}",
                    incomes[i], expectedTax[i], computedTax, diff);
            }

        }

        static void WriteTables1()
        {
            WriteTables(new TaxTable());
        }

        static void WriteTables2()
        {
            WriteTables(new TaxTable("../../tax_table_1.txt"));
        }

        static void Test2()
        {
            double[] incomes = { 100, 150, 200, 350, 400 };
            double[] expectedTax = { 10, 15, 25, 55, 70 };
            TaxTable txtb = new TaxTable("../../tax_table_1.txt");
            WriteLine("{0,10} {1,10} {2,10} {3,15}",
                "Income", "Expected", "Computed", "Difference");
            for (int i = 0; i < incomes.Length; i++)
            {
                double computedTax = txtb.computeTax(incomes[i]);
                double diff = computedTax - expectedTax[i];
                WriteLine("{0,10:c} {1,10:c} {2,10:c} {3,15:e}",
                    incomes[i], expectedTax[i], computedTax, diff);
            }

        }

        static void WriteTables3()
        {
            WriteTables(new TaxTable("../../tax_table_2.txt"));
        }



        static void Test3()
        {
            double[] incomes = { 8000, 30000, 80000, 100000, 300000, 417000, 500000 };
            double[] expectedTax = { 800, 4033.75, 15738.75,
                    20981.75, 82399.25, 121015.25, 153818.85};
            TaxTable txtb = new TaxTable("../../tax_table_2.txt");
            WriteLine("{0,15} {1,15} {2,15} {3,15}",
                "Income", "Expected", "Computed", "Difference");
            
            for (int i = 0; i < incomes.Length; i++)
            {
                double computedTax = txtb.computeTax(incomes[i]);
                double diff = computedTax - expectedTax[i];
                WriteLine("{0,15:c} {1,15:c} {2,15:c} {3,15:e}",
                    incomes[i], expectedTax[i], computedTax, diff);
            }

        }


        static void WriteTables(TaxTable txtb)
        {
            //TaxTable txtb = new TaxTable();
            List<double> breaks = txtb.Breaks;
            List<double> percents = txtb.Percents;
            List<double> layers = getLayers(breaks, percents);
            //layers.ForEach((x) => Write(x + ", "));
            //WriteLine();

            WriteLine("{0,15}  {1,8}  {2,15}",
                "Break", "Rate", "Layer");

            for (int i = 0; i < breaks.Count; i++)
            {
                WriteLine("{0,15:c}  {1,8:p}  {2,15:c}",
                    breaks[i], percents[i], layers[i]);
            }
            WriteLine("{0,15}  {1,8:p}  {2,15}",
                "", percents[percents.Count - 1], "");




        }

        /**
        * Compute tax for each layer
        */
        public static List<double> getLayers(List<double> breaks,
                List<double> percents)
        {
            List<double> layers = new List<double>();
            double lower = 0;
            double layer = 0;
            for (int i = 0; i < breaks.Count; i++)
            {
                layer += (breaks[i] - lower) * percents[i];
                layers.Add(layer);
                lower = breaks[i];
            }
            return layers;
        }

    }
}

/*
    $150.00   10.00 %      $15.00
    $350.00   20.00 %      $55.00
             30.00 %




     100    .1*100               10
     150    .1*150               15
     200    .20 * 50 + 15        25
     350    .20 * 200 + 15       55
     350    .30 * 0  + 55        55
     400    .30 * 50 + 55        70

    {100, 150, 200, 350, 400}
    {10, 15, 25, 55, 70}

 */

