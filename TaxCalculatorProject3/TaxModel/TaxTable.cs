using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace TaxModel
{

    public class TaxTable
    {
        private List<double> _Break = new List<double>();
        
        private List<double> _Percent = new List<double>();

        public TaxTable()
        {
            Breaks.Add(150);
            Breaks.Add(350);
            Percents.Add(.1);
            Percents.Add(.2);
            Percents.Add(.3);
        }

        public double computeTax(double income)
        {
            double tax = 0;
            int i;
            double lower = 0;

            for (i = 0; i < Breaks.Count && income > Breaks[i]; i++)
            {
                tax += (Breaks[i] - lower) * Percents[i];
                lower = Breaks[i];

            }
            tax += (income - lower) * Percents[i];
            return tax;
        }

        public TaxTable(string taxTableFilePath)
        {
            StreamReader file = new StreamReader(taxTableFilePath);
            int initial = int.Parse(file.ReadLine());
            
            for (int i = 0; i < initial; i++)
            {
                    _Break.Add (double.Parse(file.ReadLine()));
            }

            for (int i = 0; i < initial + 1; i++)
            {
                _Percent.Add (double.Parse(file.ReadLine()));
            }
            file.Close();
        }

        public List<double> Breaks
        {
            get { return _Break; }
        }

        public List<double> Percents
        {
            get { return _Percent; }
        }
        
    }
}
