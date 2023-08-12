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
    public partial class DetallesPostre : Form
    {
        private Contenedor _contenedor;
        private readonly RepositorioDePostres _repositorioDePostres;
        private Postre _postre;
        public DetallesPostre(Contenedor contenedor,RepositorioDePostres repositorio, Postre postre)
        {
            _contenedor = contenedor;  
            _repositorioDePostres = repositorio;
            _postre = postre;



            InitializeComponent();

            cargarDatos();

        }

        private void AgregarIngredieteBtn_Click(object sender, EventArgs e)
        {
            _contenedor.CargarFormulario(new AgregarIngrediente(_contenedor, _repositorioDePostres, _postre)); 
        }

        private void AtrasBtn_Click(object sender, EventArgs e)
        {
            _contenedor.CargarFormulario(new PostresLista(_contenedor, _repositorioDePostres));
        }


        private void cargarDatos()
        {

            this.NombreTxtLabel.Text = _postre.Nombre;
            this.EstadoTxtLbl.Text = _postre.EstaEnAlta ? "Disponible" : "Dado de Baja";

            var ingredientes = _postre.Ingredientes;
            if (ingredientes != null)
            {
                var DetallesDataSource = ingredientes.Select(
                        i => new
                        {
                            Nombre = i.Nombre,
                            Cantidad = i.Cantidad

                        }).ToList();
                this.dataGridView1.DataSource = DetallesDataSource;

                var boton = new DataGridViewButtonColumn()
                {
                    HeaderText = "Eliminar",
                    Text = "Eliminar",
                    UseColumnTextForButtonValue = true
                };

                dataGridView1.Columns.Add(boton);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var ingrediente = _postre.Ingredientes.ElementAt(e.RowIndex);   
            _postre.Ingredientes.Remove(ingrediente);
            cargarDatos();
        }
    }
}
