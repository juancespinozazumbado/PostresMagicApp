using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Postres.Desktop
{
    public partial class Postres : Form
    {
        Contenedor _padre;
        public Postres(Contenedor padre)
        {
            _padre = padre;
            InitializeComponent();
        }

        private void AtrasBtn_Click(object sender, EventArgs e)
        {
            _padre.CargarFormulario(new CrearPostre());
        }
    }
}
