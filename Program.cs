// Написать программу, которая из имеющегося массива 
// строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


// string[] arg = {"Hello", "2", "wotld", ":-"};

// void Array (string[]arg)
// {
//     string[]A = new string [size];

// }


string[] AS;
int size = 4;
string a;

AS = new string[size];

Console.WriteLine("Введите массив:");

      for (int i=0; i<AS.Length; i++)
      {
        Console.Write("AS[{0}] = ", i);
        AS[i] = Console.ReadLine();
        // Console.WriteLine($"{AS[i]}");
      }
       Console.WriteLine($"{AS}");

