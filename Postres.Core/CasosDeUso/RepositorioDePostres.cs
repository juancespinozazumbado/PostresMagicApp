using Postres.Core.Dominio;
using System;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Postres.Core.CasosDeUso
{
    public class RepositorioDePostres : IRepositorioDePostres
    {

        private readonly  ArregloDeObjetos<Postre> _Postres;

        public RepositorioDePostres(ArregloDeObjetos<Postre> postres)
        {
          _Postres = postres;
        }


        void OrdenarLista()
        {
            _Postres.setDatos( _Postres.OrderBy(p => p.Nombre).ToArray());
        }
        public void AgregarUnPostre(Postre postre)
        {
            _Postres.Agregar(postre);
            OrdenarLista();
          


        }
        public void AgregarUnIngrediente(string Id, Ingrediente ingrediente)
        {
            var Postre = ObtenerUnPostrePorId(Id);
            if(Postre != null)
            {
                Postre.Ingredientes.AddLast(ingrediente);
            }
        }


        public Postre ObtenerUnPostrePorId(string Id)
        {
            return _Postres.First(p => p.Id.Equals(Id));  
        }

        public bool DarDeAltaUnPostre(string Id)
        {
            return ObtenerUnPostrePorId(Id).EstaEnAlta = true;
        }

        public bool DarDeBajaUnPostre(string Id)
        {
            return ObtenerUnPostrePorId(Id).EstaEnAlta = false;
        }

        public void EliminarUnIngrediente(string Id_Postre, string Id_Ingrediente)
        {
            var Postre = ObtenerUnPostrePorId(Id_Postre);
            if (Postre != null)
            {
                var ingrediente = Postre.Ingredientes.First(i => i.Id.Equals(Id_Ingrediente));
                Postre.Ingredientes.Remove(ingrediente);
            }
        }

        public Postre[] ObtenerListaDePostres()
        {
            if (!_Postres.EstaVacia())
            {
                return _Postres.ToArray();
            }
            else return null;
        }

        public Postre[] ObtenerUnPostrePorNombre(string nombre)
        {
            if (!_Postres.EstaVacia())
            {
                return _Postres.Where(p => p.Nombre.Equals(nombre)).ToArray();
            }else return null;
                
        }
    }
}
