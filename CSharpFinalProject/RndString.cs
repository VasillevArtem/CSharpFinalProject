using CSharpFinalProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinalProject
{
    static internal class RndString
    {                 
        static public string ReturnRndString(Random rand, int maxValue)
        {
            char[] chars = new char[rand.Next(1, maxValue)];

            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = (char)rand.Next(0x0410, 0x44F);
            }
            return new string(chars);
        }
    }
    

}


