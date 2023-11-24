﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Persona_conListasYOrdemaniento
{
    public class Listas
    {
        Nodo primero;
        Nodo ultimo;

        public Listas()
        {
            primero = ultimo = null;
        }

        public bool ListaVacia()
        {
            if (primero == null)
            {
                return true;
            }
            return false;
        }

        public int LongitudLista()
        {
            int contador = 0;
            if (ListaVacia())
            {
                return contador;
            }
            else
            {
                Nodo actual = primero;
                if (actual.getSiguiente() == null)
                {
                    return (contador + 1);
                }
                else
                {
                    while (actual.getSiguiente() != null)
                    {
                        contador++;
                        actual = actual.getSiguiente();
                    }
                    return contador + 1;
                }
            }
        }

        public void ImprimirLista()
        {
            if (ListaVacia())
            {
                Console.WriteLine("Lista vacia");
            }
            else
            {
                Nodo actual = primero;
                while (actual != null)
                {
                    Console.WriteLine($"Los datos son {actual.getValorString()}");
                    actual = actual.getSiguiente();
                }
                Console.WriteLine("--> null");
            }
        }

        public void BuscarNombre(string nombre)
        {
            bool encontrado = false;
            if (ListaVacia())
            {
                Console.WriteLine("El numero solicitado no existe");
            }
            else
            {
                Nodo actual = primero;
                while (actual != null && encontrado == false)
                {
                    if (actual.getValor().Nombre == nombre)
                    {
                        Console.WriteLine("Si se encuentra el elemento deseado");
                        encontrado = true;
                    }
                    else
                    {
                        actual = actual.getSiguiente();
                    }
                   
                }
                if (!encontrado)
                {
                    Console.WriteLine("No se encuentra");
                }
            }
        }


        public void InsertarElemento(Persona valor)
        {
            if (ListaVacia())
            {
                primero = new Nodo(valor);
            }
            else
            {
                primero = new Nodo(valor, primero);
            }
        }


        public void InsertarMedio(Persona datos)
        {
            if (ListaVacia())
            {
                primero = new Nodo(datos);
            }
            else
            {
                Nodo anterior = null;
                int iterador = 1;
                int longitud = LongitudLista();
                Nodo actual = primero;
                Console.WriteLine(longitud);
                while (actual.getSiguiente() != null && iterador < longitud / 2)
                {
                    actual = actual.getSiguiente();
                    iterador++;
                }
                Console.WriteLine(actual.getValor());
                anterior = actual;
                Nodo nuevo = new Nodo(datos, actual.getSiguiente());
                anterior.setSiguiente(nuevo);
            }
        }


        public void InsertarAlFinal(Persona valor)
        {
            Nodo nuevoNodo = new Nodo(valor);

            if (primero == null)
            {
                primero = nuevoNodo;
            }
            else
            {
                Nodo actual = primero;

                while (actual.getSiguiente() != null)
                {
                    actual = actual.getSiguiente();
                }

                actual.setSiguiente(nuevoNodo);
            }
        }


        public void InsertarEnPosicion(Persona valor, int posicion)
        {
            Nodo nuevoNodo = new Nodo(valor);

            if (posicion == 0)
            {
                nuevoNodo.setSiguiente(primero);
                primero = nuevoNodo;
            }
            else
            {
                Nodo actual = primero;
                int contador = 0;

                while (actual != null && contador < posicion - 1)
                {
                    actual = actual.getSiguiente();
                    contador++;
                }

                if (actual == null)
                {
                    Console.WriteLine("La posición especificada está fuera de los límites de la lista.");
                    return;
                }

                nuevoNodo.setSiguiente(actual.getSiguiente());
                actual.setSiguiente(nuevoNodo);
            }
        }


        public void EliminarPrimerElemento()
        {
            if (primero != null)
            {
                primero = primero.getSiguiente();
            }
        }


        public void EliminarElementoDelMedio(string nombre)
        {
            if (primero == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            Nodo anterior = null;
            Nodo actual = primero;

            while (actual != null && actual.getValor().Nombre != nombre)
            {
                anterior = actual;
                actual = actual.getSiguiente();
            }

            if (actual == null)
            {
                Console.WriteLine("Elemento no encontrado en la lista.");
                return;
            }

            // Eliminar el nodo actual
            if (anterior == null)
            {
                primero = actual.getSiguiente();
            }
            else
            {
                anterior.setSiguiente(actual.getSiguiente());
            }
        }


        public void EliminarUltimoElemento()
        {
            if (primero == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            if (primero.getSiguiente() == null)
            {
                // Si hay solo un nodo en la lista, eliminamos la cabeza
                primero = null;
                return;
            }

            Nodo actual = primero;
            Nodo anterior = null;

            while (actual.getSiguiente() != null)
            {
                anterior = actual;
                actual = actual.getSiguiente();
            }

            // El nodo anterior ahora será el último
            anterior.setSiguiente(null);
        }


        public void EliminarElemDeseado(string nombre)
        {
            if (primero == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            if (primero.getValor().Nombre == nombre)
            {
                // Si el elemento a eliminar está en la cabeza de la lista
                primero = primero.getSiguiente();
                return;
            }

            Nodo actual = primero;
            Nodo anterior = null;

            while (actual != null && actual.getValor().Nombre != nombre)
            {
                anterior = actual;
                actual = actual.getSiguiente();
            }

            if (actual == null)
            {
                Console.WriteLine("Elemento no encontrado en la lista.");
                return;
            }

            // El elemento a eliminar está en algún lugar de la lista
            anterior.setSiguiente(actual.getSiguiente());
        }

    }
}
