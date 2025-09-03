using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppTask1Ver7.Services
{
    public class ServiceTask1V7
    {
        public double sumEllements(double numberE)
        {
            if (numberE < 0) throw new Exception("Число отрицательное");
            double response = 0;
            double indexEllement = 1;
            double elementValue = (4 * indexEllement) / (Math.Pow(indexEllement, 2) + 8 * Math.Sqrt(indexEllement));
            while (numberE <= elementValue)
            {
                response += elementValue;
                indexEllement++;
                elementValue = (4 * indexEllement) / (Math.Pow(indexEllement, 2) + 8 * Math.Sqrt(indexEllement));
            }
            return Math.Round(response, 3);
        }
    }

}
