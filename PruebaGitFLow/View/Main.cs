using PruebaGitFLow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    class View
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Name = "Peperino";
            persona.Edad = 20;
            persona.Apodo = "Pepe";
            persona.Email = "persona@gmail.com";
            Console.WriteLine(persona.Name+" / "+persona.Edad+" / "+persona.Email + " / " + persona.Apodo);
            Console.ReadLine();
        }
    }
}
