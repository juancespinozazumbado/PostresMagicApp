using Postres.Core.CasosDeUso;
using Postres.Core.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Postres.Desktop
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 
        private static  RepositorioDePostres _repositorioDePostres;

        [STAThread]
        static void Main()
        {
            _repositorioDePostres = new RepositorioDePostres(new ArregloDeObjetos<Postre>());
            //addData();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Contenedor(_repositorioDePostres));
        }


        static void addData()
        {
            _repositorioDePostres.AgregarUnPostre(new Postre { Id = "ID000001", Nombre = "Postre1" });
            _repositorioDePostres.AgregarUnPostre(new Postre { Id = "ID000002", Nombre = "Postre2" });
            _repositorioDePostres.AgregarUnPostre(new Postre { Id = "ID000003", Nombre = "Postre3" });
            _repositorioDePostres.AgregarUnPostre(new Postre { Id = "ID000004", Nombre = "Postre4" });


        }
    }
}
