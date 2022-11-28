// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input numer(5)");
        string b = Console.ReadLine();

        Console.ReadKey();  

        if (b[0]==b[4] && b[1]==b[3])
        {
               
                Console.WriteLine("--> this palindrom");
        }
        
    

        else

        {
            Console.WriteLine("--> this s not palindrom");
        }

    }

}

// int n2 = 0;
// string n1 =Console.ReadLine();           тут мои тщетные попытки выполнить это задание математическим способом
            //                                но я постараюсь вам выслать нормальный код,а не безобразие сверху        
// while  ( n1>0 );
//     int digit = n1%10
//     n1   = n1 / 10

//     n2=n2 *10 + digit;
