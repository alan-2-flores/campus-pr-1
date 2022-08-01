using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceReview
{
    public class Asincrono
    {
        public async Task<string> imprimir() {
            Task.Delay(10000).Wait();
            Console.WriteLine("El cafe esta listo en proceoso");
            return "El cafe esta listo";
        }
    }
}
