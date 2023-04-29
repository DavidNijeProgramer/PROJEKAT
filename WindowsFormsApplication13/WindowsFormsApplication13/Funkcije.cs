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
            if (s.Contains('.') == true)
            {
                s = s.Substring(0, s.IndexOf('.'));
            }
            int k = Convert.ToInt32(s);

           if (k < 100)
            {
                b[0] = 0;
                b[1] = (k % 100)/10 * 20;
                b[2] = (k % 10) * 20;
                 
            }

           else  if (k < 201)
            {
                b[0] = (k /10) * 5;
                b[1] = 0;
                b[2] = (k % 10) * 20;

            }
            else if (k < 301)
            {
                b[0] = (k / 10) * 5;
                b[1] = 0;
                b[2] = (k % 10) * 20;

            }
            else if (k > 300)
            {
                b[0] = (k / 100)*65;
                b[1] = ((k / 10)%10) *50;
                b[2] = (k % 10) * 35;

            }


            //return b;
            return b;
        }
    }
}
