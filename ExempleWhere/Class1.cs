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
            List<int> numerosPares = new List<int>(numeros.Where(numero => numero % 2 == 0));

            

            foreach (int num in numerosPares)
            {
                Console.WriteLine(num);
            }


            
        }
    }
}
