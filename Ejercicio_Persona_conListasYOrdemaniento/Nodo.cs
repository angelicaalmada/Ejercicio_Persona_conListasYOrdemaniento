using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Persona_conListasYOrdemaniento
{
    public class Nodo
    {
        private Persona _valor;
        private Nodo _Siguiente;

        public Nodo(Persona valor)
        {
            _valor = valor;
            _Siguiente = null;
        }

        public Nodo(Persona valor, Nodo siguiente)
        {
            _valor = valor;
            _Siguiente = siguiente;
        }

        public Persona getValor()
        {
            return _valor;
        }

        public string getValorString()
        {
            return ($"nombre: {_valor.Nombre}, edad: {_valor.Edad}");
        }

        public Nodo getSiguiente()
        {
            return _Siguiente;
        }

        public void setSiguiente(Nodo siguiente)
        {
            _Siguiente = _Siguiente;
        }
    }
}
