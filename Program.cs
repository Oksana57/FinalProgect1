// Написать программу, которая из имеющегося массива 
// строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


// string[] arg = {"Hello", "2", "wotld", ":-"};


string[] arg;
int size = 4;
string a;

arg = new string[size];

Console.WriteLine("Введите массив:");

      for (int i=0; i<arg.Length; i++)
      {
        Console.Write("arg[{0}] = ", i);
        arg[i] = Console.ReadLine();
     
      }
 

void PrintArray (string[] arg)
{
    Console.Write("[");
    for (int i = 0; i<arg.Length; i++)
    {
        Console.Write(arg[i]);
        if (i<arg.Length-1) Console.Write(",");
    }
    Console.WriteLine("]");
}

void StringArraySize(string[]arg)
{
    string[] newarg;
    int count = 0;
    newarg = new string [count];
    for(int i = 0; i<newarg.Length;i++)
    {
    if(arg.Length<=3) 
    {
        count++; 
        newarg[i] = arg[i];
    
}
}
}

PrintArray(arg);
StringArraySize(arg);
// PrintArray(StringArraySize);