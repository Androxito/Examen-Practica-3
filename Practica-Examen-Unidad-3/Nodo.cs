using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Examen_Unidad_3
{
    public class Nodo
    {
        private Persona _persona;
        private Nodo _Siguiente;

        public Nodo(Persona persona)
        {
            _persona = persona;
            _Siguiente = null;
        }
        public Nodo(Persona persona, Nodo siguiente)
        {
            _persona = persona;
            _Siguiente = siguiente;
        }
        public Nodo gSiguiente
        {
            get { return _Siguiente; }
            set { _Siguiente = value; }
        }
        public Persona gPersona
        {
            get { return _persona; }
            set { _persona = value; }
        }
    }
}
