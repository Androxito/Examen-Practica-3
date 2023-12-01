using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Examen_Unidad_3
{
    public class Listas
    {
        private Nodo primero;
        private Nodo ultimo;
        public Listas()
        {
            primero = ultimo = null;
        }
        public bool Esnulo()
        {
            return primero == null;
        }
        public void InsertarAlInicio(Persona persona)
        {
            if (Esnulo())
            {
                primero = ultimo = new Nodo(persona);
            }
            else
            {
                Nodo actual = primero;
                while(actual != null)
                {
                    if(actual.gSiguiente == null)
                    {
                        actual = actual.gSiguiente = new Nodo(persona);
                        break;
                    }
                    else
                    {
                        actual = actual.gSiguiente;
                    }
                }
            }
        }
        public void BuscarNodo(string nombre)
        {
            if (Esnulo())
            {
                Console.WriteLine("No tiene valores la lista");
                return;
            }
            else
            {
                Nodo actual = primero;
                bool Bandera = false;
                int cont = 0;
                while(actual != null)
                {
                    cont++;
                    if(actual.gPersona.Nombre == nombre)
                    {
                        Console.WriteLine($"La persona {actual.gPersona.Nombre} esta en la lista en la posicion");
                        Bandera = true;
                        break;
                    }
                    else
                    {
                        actual = actual.gSiguiente;
                        Console.WriteLine("A");
                    }
                }
                if (!Bandera)
                {
                    Console.WriteLine("El nombre no se encuentra en la lista");
                    return;
                }
            }
        }
        public void MostrarLista()
        {
            if (Esnulo())
            {
                Console.WriteLine("La lista se enceuntra vacia");
                return;
            }
            else
            {
                
                Nodo actual = ultimo;
                while(actual != null)
                {
                    Console.WriteLine($"El nombre es: {actual.gPersona.Nombre} y la edad es: {actual.gPersona.Edad}");
                    actual = actual.gSiguiente;
                }
            }
        }
    }
}
