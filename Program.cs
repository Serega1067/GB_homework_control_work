/* Итоговая проверочная работа.
Задача:
Написать программу, которая из имеющегося массива строк формирует 
массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать 
на старте выполнения алгоритма. При решении не рекомендуется 
пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]\
["1234", "1567", "-2", "computer science"] -> ["-2"]\
["Russia", "Denmark", "Kazan"] -> []
*/

// Создадим метод, который будет возвращать массив состоящий из строк.
// На вход метод будит получать переменную, которая показывает длину
// строкового элемента. Так же метод будит прлучать массив состоящий
// из строковых элементов.
string[] FindLengthString(int lenElem, string[] arrayInput)
{
    // Измерил длину массива и записал в переменную
    int len = arrayInput.Length;
    // Заводим переменную счётчик
    int count = 0;
    // В этом цикле считаем количество строк в массиве нужной длины
    for (int i = 0; i < len; i++)
    {
        if (arrayInput[i].Length <= lenElem)
        {
            count++;
        }
    }
    // Создаём новый массив в который будем записывать строки нужной длины
    string[] resultArray = new string[count];
    count = 0;
    // В этом цикле берём определённые элементы из старого массива
    // и записываем их в новый
    for (int i = 0; i < len; i++)
    {
        if (arrayInput[i].Length <= lenElem)
        {
            resultArray[count] = arrayInput[i];
            count++;
        }
    }
    return resultArray;
}

// Сделаем метод, который будет печатать результирующий массив в консоль
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write(array[i]);
        }
        else
        {
            Console.Write(array[i] + ", ");
        }
    }
    Console.WriteLine("]");
}

// В эту переменную записывается не большу какой длины должны быть
// элементы результирующего массива
int lenElemArray = 3;
// Печатаем три примера работы метода
Console.WriteLine("Максимальный размер элементов в массиве: " + lenElemArray);
string[] array1 = new string[] {"hello", "2", "world", ":-)"};
PrintArray(FindLengthString(lenElemArray, array1));
string[] array2 = new string[] {"1234", "1567", "-2", "computer science"};
PrintArray(FindLengthString(lenElemArray, array2));
string[] array3 = new string[] {"Russia", "Denmark", "Kazan"};
PrintArray(FindLengthString(lenElemArray, array3));
