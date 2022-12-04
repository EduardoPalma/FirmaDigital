using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirmaDigital
{
    public partial class Clave : Form
    {
        public Clave()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public void IngresarVariables(string xml, string clave)
        {
            label1.Text = clave;
            richTextBox1.Text = xml;
        }
    }
}
