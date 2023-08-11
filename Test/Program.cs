using Postres.Core.CasosDeUso;
using Postres.Core.Dominio;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        private static RepositorioDePostres _repo = new RepositorioDePostres(new ArregloDeObjetos<Postre>());
        static void Main(string[] args)
        {
            //string[] ints = { "Mimo","Momo", "Alpa", "Azi"};
            //ints = (string[])ints.Append("A").ToArray();

            //Array.Sort(ints, (a,b) => string.Compare(a, b) );

            //ints = (string[])ints.Where( i => !i.Equals("A") ).ToArray();

            //int index = Array.IndexOf(ints, "Alpa");
            //var o = ints[index];
            //ints.OrderBy(a => a);


            //Console.WriteLine(ints);

            addData();

            _repo.AgregarUnIngrediente("ID000001", new Ingrediente { Id = "IG00001",Nombre= "Chile",Cantidad = 2 });
            _repo.AgregarUnIngrediente("ID000001", new Ingrediente { Id = "IG00003", Nombre = "Salsa", Cantidad = 1 });
            _repo.AgregarUnIngrediente("ID000002", new Ingrediente { Id = "IG00002", Nombre = "Papas", Cantidad = 2 });
            _repo.AgregarUnIngrediente("ID000003", new Ingrediente { Id = "IG00004", Nombre = "Olores", Cantidad = 5});


            _repo.EliminarUnIngrediente("ID000001", "IG00001");
            _repo.EliminarUnIngrediente("ID000003", "IG00004");



            Console.WriteLine("");

        }
          

        static void addData()
        {
            _repo.AgregarUnPostre(new Postre { Id = "ID000001", Nombre = "Postre1" });
            _repo.AgregarUnPostre(new Postre { Id = "ID000002", Nombre = "Postre2" });
            _repo.AgregarUnPostre(new Postre { Id = "ID000003", Nombre = "Postre3" });
            _repo.AgregarUnPostre(new Postre { Id = "ID000004", Nombre = "Postre4" });


        }

      
    }
}
