using Postres.Core.CasosDeUso;
using Postres.Core.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Postres.Desktop.Forms
{
    public partial class CrearPostre : Form
    {
        private Contenedor _contenedor;
        private RepositorioDePostres _repositorioDePostres;
        public CrearPostre(Contenedor contenedor, RepositorioDePostres repositrio)
        {
            InitializeComponent();
            _contenedor = contenedor;
            _repositorioDePostres = repositrio;
        }

        private void CrearBtn_Click(object sender, EventArgs e)
        {
            if(ValidarCampos())
            {
                int num = new Random().Next(1, 100);
                string nombre = Nombretxt.Text;
                _repositorioDePostres.AgregarUnPostre(new Postre {Id = $"ID0000{num}" , Nombre = nombre});
                _contenedor.CargarFormulario(new PostresLista(_contenedor, _repositorioDePostres));
            }
               
            
            

        }

        bool ValidarCampos()
        {
            if (Nombretxt.Text.Equals(""))
            {
                MessageBox.Show("El campo Nombre debe llenarse!");
                return false;

            }

            if (double.TryParse(Nombretxt.Text, out _) && !Nombretxt.Text.Equals(""))
            {
                MessageBox.Show("El campo debe contener caracteres alfabeticos. No puede ser un numero");
                return false;
            }


            if (Nombretxt.Text.Any(Char.IsDigit))
            {
                MessageBox.Show("El campo debe contener caracteres alfabeticos. No puede ser un numero");
                return false;
            }




            return true;   
        }
    }
}
