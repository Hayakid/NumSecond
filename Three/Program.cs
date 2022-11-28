// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// class program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Input how much");
//         string N = Console.ReadLine();
//         {
//             for (int i = 1; i <= N; i++)
//             {
//                 i=i*i*i;
//                 Console.WriteLine(i);
               
//             }

//         }
//     }
// }


void Sqrt1(int N)
{
    for (int i = 1; i <= N; i++)
    {
        Console.WriteLine($"{i}-->{i*i*i}");
    }
}
Console.WriteLine("Input N = ");
int N = Convert.ToInt32(Console.ReadLine());
Sqrt1(N);