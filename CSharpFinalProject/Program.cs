//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

using CSharpFinalProject;

//Метод для создания массива случайного размера и заполнения массива случайными значениями.
static string[] RandomStringArray(RndString rndStr, Random rnd, int maxValue)
{
	string[] resultArr = new string[rnd.Next(1, maxValue)];

	for (int i = 0; i < resultArr.Length; i++)
	{
		resultArr[i] = rndStr.ReturnRndString(rnd, maxValue / 10);
	}
	return resultArr;
}

//Метод для формирования массива с элементами размер которых меньше либо равен strLength (по условию задачи равно 3).
static string[] ThreeOrLessValueString(string[] str, int strLength)
{
	string[] resultArr = new string[str.Length];

	for (int i = 0; i < str.Length; i++)
	{
		if (str[i].Length <= strLength)
		{
			resultArr[i] = str[i];
		}
	}
	resultArr = resultArr.Where(x => !string.IsNullOrEmpty(x)).ToArray();

    return resultArr;
}

//Метод для вывода массива в консоль.
static void PrintArray(string[] str)
{
    foreach (var item in str)
    {
        Console.Write(string.Join(", ", str));
    }
    Console.WriteLine();
    Console.WriteLine();
}


Random rnd = new Random();
RndString rndStr = new RndString();
string[] str = RandomStringArray(rndStr, rnd, 100);
string[] resStr = ThreeOrLessValueString(str,3);

PrintArray(str);
PrintArray(resStr);



