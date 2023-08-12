using Postres.Core.CasosDeUso;
using System;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Windows.Forms;

namespace Postres.Desktop.Forms
{
    public partial class PostresLista : Form
    {
        Contenedor _padre;
        private readonly RepositorioDePostres _repositorioDePostres;
        public PostresLista(Contenedor padre, RepositorioDePostres repositorioDePostres)
        {
            _padre = padre;
            _repositorioDePostres = repositorioDePostres;   
            InitializeComponent();
            
            ActualizarDataGrid();
        }

        private void AtrasBtn_Click(object sender, EventArgs e)
        {
            _padre.CargarFormulario(new CrearPostre(_padre, _repositorioDePostres));
        }

        private void verDetalles(object sender, EventArgs e)
        { 

        }


        private void ActualizarDataGrid()
        {
            var postres = _repositorioDePostres.ObtenerListaDePostres();
            if (postres != null)
            {
                var DetallesDataSource = postres.ToList().Select(
                        i => new
                        {
                            Nombre = i.Nombre,
                            Estado = i.EstaEnAlta,
                            

                        }).ToList();
                
                DataGridPostres.DataSource = DetallesDataSource;

                var botonDetalle = new DataGridViewButtonColumn()
                {
                    HeaderText = "Ver",
                    Text = "ver detalles",
                    UseColumnTextForButtonValue = true
                };
                if(DataGridPostres.Columns.Count == 2)
                DataGridPostres.Columns.Add(botonDetalle);
               

            }
          
          

        }

        private void DataGridPostres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            var postre = _repositorioDePostres.ObtenerListaDePostres()[indice];

            if (e.ColumnIndex == 2)
            {
                postre.EstaEnAlta = postre.EstaEnAlta ? false : true;
                ActualizarDataGrid();
            }
            if (e.ColumnIndex == 0)
            {
                _padre.CargarFormulario(new DetallesPostre(_padre, _repositorioDePostres, postre));
                
            }
          



        }
    }
}
