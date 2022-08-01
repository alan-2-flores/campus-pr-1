using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PerformanceReview
{
    class Program
    {
        static async Task Main()
        {
            Asincrono asincrono = new Asincrono();
            Console.WriteLine(await asincrono.imprimir());

            //Parte 1
            Delegados delegados = new Delegados();
            Console.WriteLine(delegados.suma(1,2));
            Console.WriteLine(delegados.resta(1,2));
            //delegados.zeroException(0, 0);

            Persona obj = new Persona();
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona("Alan","alanwasher@gmail.com",DateTime.Parse("08/13/1999")));
            personas.Add(new Persona("Pepe","pepe@gmail.com",DateTime.Parse("08/14/1999")));
            personas.Add(new Persona("Migue","migue@gmail.com",DateTime.Parse("08/15/1999")));
            personas.Add(new Persona("Jack","jack@gmail.com",DateTime.Parse("08/16/1999")));
            personas.Add(new Persona("Felipe","felipe@gmail.com",DateTime.Parse("08/17/1999")));
            personas.Add(new Persona("Juan","juan@gmail.com",DateTime.Parse("08/18/1999")));

            foreach (string mail in obj.GetMails(personas))
            {
                Console.WriteLine(mail);
            }

            Persona personaRecibida = obj.MayorPrimero(personas);
            Console.WriteLine(personaRecibida.BirthDate);

        }
    }
}
