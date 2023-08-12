using Postres.Core.CasosDeUso;
using Postres.Desktop.Forms;
using System;
using System.Windows.Forms;

namespace Postres.Desktop
{
    public partial class Contenedor : Form
    {
        private readonly RepositorioDePostres _repositorioDePostres;
        public Contenedor( RepositorioDePostres repositorioDePostres)
        {
            InitializeComponent();
            _repositorioDePostres = repositorioDePostres;
        }

      
        private void PostresButtom_Click(object sender, EventArgs e)
        {
            PostresLista postresView = new PostresLista(this, _repositorioDePostres);
            CargarFormulario(postresView);
        }

        // para cambiar entre las vistas del Layout
        public void CargarFormulario(Form form)
        {
            if(this.PrincipalPanel.Controls.Count > 0)
            {
                PrincipalPanel.Controls.RemoveAt(0);
                Form parcial = form as Form;
                parcial.TopLevel = false;
                parcial.Dock = DockStyle.Fill;  
                PrincipalPanel.Controls.Add(parcial);   
                PrincipalPanel.Tag = parcial;
                parcial.Show();

            }
            
        }
    }
}
