//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

namespace CSharpFinalProject
{   
    /// <summary>
    /// Класс, предоставляющий функционал, связаный с случайно заполненой строкой.
    /// </summary>
     internal class RndString
     {   /// <summary>
         /// Метод для генерации случайного размера слова от 1 до maxValue.
         /// </summary>
         /// <param name="rand"> Объект класса Random.</param>
         /// <param name="maxValue">Максимальное значение длинны слова.</param>
         /// <returns>Строку заполненную случайными значениями.</returns>
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


