// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 

Console.Clear();

Console.WriteLine("Enter first object");
string a = Console.ReadLine();
Console.WriteLine("Enter second object");
string b = Console.ReadLine();
Console.WriteLine("Enter third object");
string c = Console.ReadLine();
Console.WriteLine("Enter fourth object");
string d = Console.ReadLine();

Console.WriteLine();

string[] firstArray = new string [4] { a, b, c, d};  
string[] secondArray = new string [firstArray.Length];

RewriteArray(firstArray, secondArray);
Console.WriteLine("before changes");
PrintArray(firstArray);
Console.WriteLine();
Console.WriteLine("after changes");
PrintArray(secondArray);

void RewriteArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
