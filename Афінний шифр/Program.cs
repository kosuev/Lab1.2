using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;    //для роботи з файлами

namespace Афінний
{
    class Program
    {
        static void Main(string[] args)
        {
            string povidomlennja = null;
            int f;

            Console.WriteLine("Введiть повiдомлення: ");
            povidomlennja = Console.ReadLine();

            Console.Write("\nВведiть ключ 'а' i ключ 'b': ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nВиберiть дiю: \n0. Зберегти результат у файл на робочий стiл \n1. Продовжити без збереження");
            f = Convert.ToInt16(Console.ReadLine());

            Shifr shyfrovka = new Shifr(povidomlennja, a, b);
            shyfrovka.Print();

            if (f == 0)
                shyfrovka.File();

            Console.ReadKey();
        }
    }
}
