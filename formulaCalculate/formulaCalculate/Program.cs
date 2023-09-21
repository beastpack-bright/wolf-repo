using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formulaCalculate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Setting up variables.
            double x = 0;
            double y = 0;
            double z = 0;

            int nX = 0;
            int nY = 0;
             
            double[,,] zFunction = new double[1,2,3]; //The intervals between. 

            for (x = -1; x <= 1; x += 0.1, nX++) //The values being used for x.
            {
                x = Math.Round(x, 1); //rounding time
                nY = 0;

                for (y = 1; y <= 4; y += 0.1, ++nY) { //The values being used for y. 
                    y = Math.Round(y, 1); //rounding time

                    z = 3 * Math.Pow(y, 2) + 2 * Math.Pow(x, 1) -1; //Math time! This calculates the mathy bits. 

                    z = Math.Round(z, 3);

                    zFunction[nX, nY, 0] = x; 
                    zFunction[nX, nY, 1] = y;
                    zFunction[nX, nY, 2] = z;
                }
            }
            
        }
    }
}
