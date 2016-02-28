using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Афінний_шифр
{
    class Shifr
    {
        public string zt = null;
        public char[] dict = new char[] { 'а', 'б', 'в', 'г', 'д','е', 'є','ж', 'з', 'и', 'i', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р',
            'с', 'т', 'у', 'ф', 'х', 'ц','ч', 'ш', 'щ','ь', 'ю', 'я', ' ', ',', '.' };

        public Shifr(string text, int a, int b)
        {
            int n = 0;                                      //номер літери при шифруванні
            int[] let = new int[text.Length];              //номер в словнику
            for (int i = 0; i < text.Length; i++)
                for (int j = 0; j < dict.Length; j++)
                    if (text[i] == dict[j])
                    {
                        let[i] = j;                        //присвоюємо номер із словника
                    }
            for (int i = 0; i < text.Length; i++)
            {
                n = (a*let[i] + b) % 34;             
                zt += dict[n];
            }
        }

        public void Print()                                //функція виводу
        {
            Console.Write("\n\n" + zt);
        }        
    }
}
