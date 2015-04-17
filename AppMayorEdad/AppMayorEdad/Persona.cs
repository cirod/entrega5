using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMayorEdad
{
    class Persona
    {
        //atributos
        string nombre;
        int edad;
        //metodo constructor
        public Persona()
        {
 
        }
        public Persona(string nom, int ed)
        {
            nombre = nom;
            edad = ed;
        }
        public string Nombre
        {
            get { return nombre;}
            set { Nombre = value; }
        }
        public int Edad
        {
            get { return edad;}
            set { Edad = value; }
         
        }
       
            

    }
}
