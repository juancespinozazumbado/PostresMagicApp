
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Postres.Core.CasosDeUso
{
    public class ArregloDeObjetos<T> : IEnumerable<T> where T : class 
    {
        int Tamaño  = 0;
        T[] Datos;

        public ArregloDeObjetos()
        {

            Datos = new T[Tamaño];   
            
        }

        public void Agregar(T Dato)
        {
           Datos = (T[]) Datos.Append(Dato).ToArray();
           Tamaño = Datos.Length;
            
          
        }

       
        public T Obtener(int indice)
        {
            if (!EstaVacia() && Datos.Length > indice )
            {
                return Datos[indice];
            }
            else return null;
            
        }

        public T Obtener(T Dato)
        {
            if (!EstaVacia() )
            {
                if (ExisteLaInstancia(Dato))
               
                return Obtener(IndiceDeInstancia(Dato));
            }
            return null;
        }

        public void Eliminar(T Dato)
        {
            Datos = (T[])Datos.Where(i => !i.Equals(Dato)).ToArray();
            Tamaño--;
        }

        public void Eliminar(int indice)
        {
            if (!EstaVacia() && indice < Datos.Length)
            {
                
                Datos = (T[])Datos.Where((i, index) => index != indice).ToArray();
                Tamaño --;
            }
            
        }


        public bool EstaVacia()
        {
            return Tamaño == 0; 
        }

        public int IndiceDeInstancia(T Dato)
        {
            return Array.IndexOf<T>(Datos, Dato);   
        }

        private bool ExisteLaInstancia( T Dato)
        {
            return IndiceDeInstancia(Dato) >= 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            int indice =0;
            T current = Datos[indice];
            while ( current != null && indice < Datos.Length )
            { 
                yield return current;
                indice++;
                if( indice < Datos.Length )    
                current = Datos[indice];
                
            }
            indice = 0;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator(); 
        }

        public int Capacidad()
        {
            return Tamaño;
        }
    }
   
}
