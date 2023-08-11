using Postres.Core.CasosDeUso;
using Postres.Core.Dominio;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
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

            ArregloDeObjetos<Postre> postres = new ArregloDeObjetos<Postre>();

            postres.Agregar(new Postre{
                Id = "ID00001",
                Nombre = "PostreMock1"
            });
            postres.Agregar(new Postre
            {
                Id = "ID00002",
                Nombre = "PostreMock2"
            });
            postres.Agregar(new Postre
            {
                Id = "ID00003",
                Nombre = "PostreMock3"
            });


            foreach(Postre p in postres)
            {
                Console.WriteLine(p.Nombre);
               
            }


            Postre pos = postres.Obtener(2);
            Console.WriteLine(postres.Obtener(pos).Nombre);

            postres.Eliminar(pos);
            postres.Eliminar(1);

            foreach (Postre p in postres)
            {
                Console.WriteLine(p.Nombre);

            }

            Console.ReadLine();
        }
    }
}
