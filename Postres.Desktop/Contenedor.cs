using System;
using System.Windows.Forms;

namespace Postres.Desktop
{
    public partial class Contenedor : Form
    {
        public Contenedor()
        {
            InitializeComponent();
        }

      
        private void PostresButtom_Click(object sender, EventArgs e)
        {
            Postres postresView = new Postres(this);
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
