using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Афінний_шифр
{
    class Program
    {
        static void Main(string[] args)
        {

            int f;
            Console.WriteLine("\nОберiть дiю: \n0. Зашифрувати текст. \n1. Розшифрувати текст. \n2. Вийти.");
            f = Convert.ToInt16(Console.ReadLine());
            if ((f != 0) && (f != 1))
                Environment.Exit(0);

            Console.WriteLine("\nВведiть повiдомлення: ");
            string povidomlennja = Console.ReadLine();


            Console.WriteLine("\nВведiть ключ 'а' i ключ 'b': ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if ((Evklid(a, 34) != 1)|| (a <= 0) || (a >= 34)||(b<0)||(b>34))
            {
                Console.WriteLine("\nВи ввели не вiрнi ключi. \nКлючi мають вiдповiдати таким умовам:\n   0<a<34; \n   0<b<m.\n ");
                Console.WriteLine("\nВведiть ще раз ключi 'а' i 'b': ");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
            }

            
            if (f == 0)
            {
                Shifr shyfrovka = new Shifr(povidomlennja, a, b);
                shyfrovka.Print();
            }

            else 
            {
                DShifr text = new DShifr(povidomlennja, a, b);
                text.Print();
            }
            
                Console.ReadKey();           
        }

        static int Evklid(int a, int b)//функція Евкліда
        {
            int c;
            while (b != 0)
            {
                c = a % b;
                a = b;
                b = c;
            }
            return (a);
        }
    }
}
