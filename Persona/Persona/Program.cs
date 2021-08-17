using Persona.Entidades;
using Persona.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsPersona clspersona = new ClsPersona();
            NClsPersona nclspersona = new NClsPersona();

            clspersona.Nombre = "Martin";
            clspersona.Apellido = "Fernandez ";
            clspersona.Edad = 25  ;
            clspersona.Sexo = "Masculino";

            Console.WriteLine(nclspersona.Hablando(clspersona));

            Console.ReadLine();
        }
    }
}
