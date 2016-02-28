using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;    //для роботи з файлами

namespace Цезарь
{
    class Program
    {
        static void Main(string[] args)
        {
            string povidomlennja=null;
            int f;

            Console.WriteLine("Введiть повiдомлення: ");
            povidomlennja=Console.ReadLine();

            Console.Write("\nВведiть довжину ключа: ");            
            int key = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nВиберiть дiю: \n0. Зберегти результат у файл на робочий стiл \n1. Продовжити без збереження");
            f =Convert.ToInt16(Console.ReadLine());

            Shifr shyfrovka = new Shifr(povidomlennja, key);
            shyfrovka.Print();

            if (f == 0)
            shyfrovka.File();
            
            Console.ReadKey();
        }
    }
}
