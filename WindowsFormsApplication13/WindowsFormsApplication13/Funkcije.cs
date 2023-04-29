using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication13
{
    class Funkcije
    {
        public int[] Konverzija(string s)
        {   
            int[] b = new int[3];

            
            if (s.Length == 7)
            {
                b[0] =Convert.ToInt32( s.Substring(0, 2));
                b[1] = Convert.ToInt32(s.Substring(3, 2));
                b[2] = Convert.ToInt32(s.Substring(5, 2));
            }
            else if (s.Length == 8)
            { if (s[0] == '3')
                {  
                    b[0] = Convert.ToInt32(s.Substring(4, 2));
                    b[1] = Convert.ToInt32(s.Substring(0, 3));
                    b[2] = Convert.ToInt32(s.Substring(6, 2));
                }
                else
                {
                    b[0] = Convert.ToInt32(s.Substring(4, 2));
                    b[1] = Convert.ToInt32(s.Substring(0, 3));
                    b[2] = Convert.ToInt32(s.Substring(6, 2));
                }
            }

            if (b[0] > 255) { b[0] = b[0] - 255; }
            if (b[1] > 255) { b[1] = b[1] - 255; }
            if (b[2] > 255) { b[2] = b[2] - 255; }

            return b;
        }
    }
}
