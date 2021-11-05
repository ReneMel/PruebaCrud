using System;
using System.Business;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System.Presentation
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            if (BClient.createClient(textname.Text, lastnametxt.Text, duitxt.Text, datepicker1.Value)) {
                MessageBox.Show("Usuario insetado correctamente");
            }
        }
    }
}
