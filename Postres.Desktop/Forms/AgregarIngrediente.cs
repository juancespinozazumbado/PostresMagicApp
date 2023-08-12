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

namespace Postres.Desktop.Forms
{
    public partial class AgregarIngrediente : Form
    {
        private Contenedor _contenedor;
        private readonly RepositorioDePostres _repositorioDePostres;
        private Postre _postre;
        public AgregarIngrediente(Contenedor contenedor, RepositorioDePostres repositorio, Postre postre)
        {
            InitializeComponent();
            _contenedor = contenedor;  
            _repositorioDePostres = repositorio;   
            _postre = postre;
            cargarDatos();
        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                AgregarElIngrediente();
                _postre = _repositorioDePostres.ObtenerUnPostrePorId(_postre.Id);

                _contenedor.CargarFormulario(new DetallesPostre(_contenedor, _repositorioDePostres, _postre));
            }
        }


        void cargarDatos()
        {
            this.PostreIdTxtLabel.Text = _postre.Id;
            this.PostreNameTxtLbl.Text = _postre.Nombre;

        }

        private void  AgregarElIngrediente()
        {
           
            
                int num = new Random().Next(1, 100);
                _repositorioDePostres.AgregarUnIngrediente(
                    _postre.Id,
                    new Ingrediente
                    {
                        Id = $"IG000{num}",
                        Nombre = NombreTxt.Text,
                        Cantidad = int.Parse(Cantidadtxt.Text)
                    });
            
        }
        bool ValidarCampos()
        {
            if (NombreTxt.Text.Equals(""))
            {
                MessageBox.Show("El campo Nombre debe llenarse!");
                return false;

            }

            if (double.TryParse(NombreTxt.Text, out _) && !NombreTxt.Text.Equals(""))
            {
                MessageBox.Show("El campo Nombre debe contener caracteres alfabeticos. No puede ser un numero");
                return false;
            }


            if (NombreTxt.Text.Any(Char.IsDigit))
            {
                MessageBox.Show("El campo Nombre debe contener caracteres alfabeticos. No puede ser un numero");
                return false;
            }

            // Para la parte numerica 

            if (Cantidadtxt.Text.Equals(""))
            {
                MessageBox.Show("El campo Cantidad debe llenarse!");
                return false;

            }

          
            if (!Cantidadtxt.Text.All(Char.IsDigit))
            {
                MessageBox.Show("El campo debe contener solo numeros. No puede ser un caracter alfanumerico. No debe contenr letras ni pountos o comas");
                return false;
            }

            if (int.Parse(Cantidadtxt.Text) <= 0)
            {
                MessageBox.Show("La cantidad debe ser un entero mayor a 0");
                return false;
            }



            return true;
        }
    }


    
}
