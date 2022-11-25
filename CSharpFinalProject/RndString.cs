using CSharpFinalProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinalProject
{   /// <summary>
    /// Класс, предоставляющий функционал, связаный с случайно заполненой строкой.
    /// </summary>
     internal class RndString
     {   /// <summary>
         /// 
         /// </summary>
         /// <param name="rand"> Объект класса Random для генерации случайного размера слова от 1 до maxValue.</param>
         /// <param name="maxValue">Максимальное значение длинны слова.</param>
         /// <returns></returns>
         internal string ReturnRndString(Random rand, int maxValue)
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


