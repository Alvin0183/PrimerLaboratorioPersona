using Persona.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona.Negocio
{
    class NClsPersona
    {
        public String Reir(ClsPersona persona)
        {
            return " La persona de nombre " + persona.Nombre + " de edad " + persona.Edad + " Esta Riendo ";


        }

        public String Caminar(ClsPersona persona)
        {
            return " La persona de nombre " + persona.Nombre + " de edad " + persona.Edad + " Comenzo a caminar ";


        }

        public String Hablando(ClsPersona persona)
        {
            return " La persona " + persona.Nombre + " comenzo a hablar con Martin";

        }

        public String Observar(ClsPersona persona)
        {
            return " La persona " + persona.Nombre + " de edad " + persona.Edad + " Te esta observando ";

        }
    }
}
