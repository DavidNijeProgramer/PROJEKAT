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

           if (k < 92)
            {
                b[0] = 0;
                b[1] = 0;
                b[2] = 0;
                 
            }

            else if (k < 97)
            {
                b[0] = 51;
                b[1] = 0;
                b[2] = 25;

            }
            else if (k < 102)
            {
                b[0] = 0;
                b[1] = 0;
                b[2] = 51;

            }
            else if (k < 107)
            {
                b[0] = 0;
                b[1] = 51;
                b[2] = 51;

            }
            else if (k < 112)
            {
                b[0] = 0;
                b[1] = 51;
                b[2] = 25;

            }
            else if (k < 117)
            {
                b[0] = 51;
                b[1] = 51;
                b[2] = 0;

            }
            else if (k < 122)
            {
                b[0] = 51;
                b[1] = 25;
                b[2] = 0;

            }
            else if (k < 127)
            {
                b[0] = 64;
                b[1] = 64;
                b[2] = 64;

            }
            else if (k < 132)
            {
                b[0] = 102;
                b[1] = 0;
                b[2] = 51;

            }
            else if (k < 137)
            {
                b[0] = 102;
                b[1] = 0;
                b[2] = 102;

            }
            else if (k < 142)
            {
                b[0] = 51;
                b[1] = 0;
                b[2] = 102;

            }
            else if (k < 147)
            {
                b[0] = 0;
                b[1] = 0;
                b[2] = 102;

            }
            else if (k < 152)
            {
                b[0] = 0;
                b[1] = 51;
                b[2] = 102;

            }
            else if (k < 157)
            {
                b[0] = 0;
                b[1] = 102;
                b[2] = 102;

            }
            else if (k < 162)
            {
                b[0] = 0;
                b[1] = 102;
                b[2] = 51;

            }
            else if (k < 167)
            {
                b[0] = 0;
                b[1] = 102;
                b[2] = 0;

            }
            else if (k < 172)
            {
                b[0] = 51;
                b[1] = 102;
                b[2] = 0;

            }
            else if (k < 177)
            {
                b[0] = 102;
                b[1] = 0;
                b[2] = 102;

            }
            else if (k < 182)
            {
                b[0] = 102;
                b[1] = 51;
                b[2] = 0;

            }
            else if (k < 187)
            {
                b[0] = 102;
                b[1] = 0;
                b[2] = 0;

            }
            else if (k < 192)
            {
                b[0] = 153;
                b[1] = 0;
                b[2] = 76;

            }
            else if (k < 197)
            {
                b[0] = 76;
                b[1] = 0;
                b[2] = 153;

            }
            else if (k < 202)
            {
                b[0] = 0;
                b[1] = 76;
b[2] = 153;

            }
            else if (k < 207)
            {
                b[0] = 255;
                b[1] = 128;
b[2] = 0;

            }
            else if (k < 212)
            {
                b[0] = 204;
                b[1] = 0;
b[2] = 0;

            }
            else if (k < 217)
            {
                b[0] = 0;
                b[1] = 153;
b[2] = 76;

            }
            else if (k < 222)
            {
                b[0] = 0;
                b[1] = 102;
b[2] = 204;

            }
            else if (k < 227)
            {
                b[0] = 102;
                b[1] = 0;
                b[2] = 204;

            }
            else if (k < 232)
            {
                b[0] = 255;
                b[1] = 0;
b[2] = 127;

            }
            else if (k < 237)
            {
                b[0] = 128;
                b[1] = 128;
b[2] = 128;

            }
            else if (k < 242)
            {
                b[0] = 255;
                b[1] = 0;
b[2] = 0;

            }
            else if (k < 247)
            {
                b[0] = 255;
                b[1] = 128;
b[2] = 0;

            }
            else if (k < 252)
            {
                b[0] = 255;
                b[1] = 255;
b[2] = 0;

            }
            else if (k < 257)
            {
                b[0] = 128;
                b[1] = 255;
b[2] = 0;

            }
            else if (k < 262)
            {
                b[0] = 0;
                b[1] = 255;
b[2] = 0;

            }
            else if (k < 267)
            {
                b[0] = 0;
                b[1] = 255;
b[2] = 255;

            }
            else if (k < 272)
            {
                b[0] = 178;
                b[1] = 102;
b[2] = 255;

            }
            else if (k < 277)
            {
                b[0] = 255;
                b[1] = 51;
b[2] = 255;

            }
            else if (k < 282)
            {
                b[0] = 255;
                b[1] = 204;
b[2] = 153;

            }
            else if (k < 288)
            {
                b[0] = 153;
                b[1] = 255;
b[2] = 153;

            }
            else if (k < 292)
            {
                b[0] = 153;
                b[1] = 255;
b[2] = 255;

            }
            else if (k < 297)
            {
                b[0] = 255;
                b[1] = 204;
b[2] = 204;

            }
            else if (k < 302)
            {
                b[0] = 224;
                b[1] = 224;
b[2] = 224;

            }
            else if (k < 307)
            {
                b[0] = 227;
                b[1] = 102;
b[2] = 43;

            }
            else if (k < 312)
            {
                b[0] = 220;
                b[1] = 220;
b[2] = 220;

            }
            else if (k < 317)
            {
                b[0] = 255;
                b[1] = 215;
b[2] = 0;

            }
            else if (k > 316)
            {
                b[0] = 255;
                b[1] = 255;
                b[2] = 255;

            }
            

            return b;
        }
    }
}
