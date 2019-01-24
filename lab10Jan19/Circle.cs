using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10Jan19
{
    class Circle
    {
        private double radius;
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }
        public const double Pi = Math.PI;
        public Circle(double radius)
        {           
        }
        public double CalculateCircumference()
        {
            double circumference = 2 * Pi * radius;
            return circumference;
        }
        public string CalculateFormattedCircumference()
        {
            double formattedCircumference = Math.Round(CalculateCircumference(), 2);
            string FC = formattedCircumference.ToString();
            return FC;
        }
        public double CalculateArea()
        {
            double area = Pi * radius * radius;
            return area;
        }
        public string CalculateFormattedArea()
        {
            double formattedArea = Math.Round(CalculateArea(), 2);
            string FA = formattedArea.ToString();
            return FA;
        }
        private string FormatNumber(double x)
        {
            string formatNum = Convert.ToString(x);
            return formatNum;
        }
    }
}