using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleWhere
{
    internal class Class1
    {





        public void Metodic()
        {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //usamos o método Where na lista de numeros e passamos uma função lambda onde a condi
            //ção é o resto ser igual a 0, sendo assim somente os numeros armazenados em numerosPares
            //serão pares por conta de nosso filtro where
            List<int> numerosPares = new List<int>(numeros.Where(numero => numero % 2 == 0));

            int numb = 4;

            foreach (int num in numerosPares)
            {
                Console.WriteLine(num);
            };


            
        }
    }
}
