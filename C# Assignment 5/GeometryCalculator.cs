using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignment_5
{
   
        public class GeometryCalculator
        {
            public void CalculateCircle(double radius, out double area, out double circumference)
            {
                area = Math.PI * radius * radius;

                circumference = 2 * Math.PI * radius;
            }
        }
    }
