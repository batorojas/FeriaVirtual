using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using Clases;

namespace FeriaApp
{
    public partial class vInicio : UserControl
    {
        public vInicio()
        {
            InitializeComponent();
        }

        public string NombreSesionStartPage
        {
            get { return metroLabel1.Text; }
            set { metroLabel1.Text = value; }
        }


        private void vInicio_Load(object sender, EventArgs e)
        {
            
        }
    }
}
