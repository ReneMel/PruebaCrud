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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            refreshdata();
            

        }

        private void refreshdata()
        {

            clientDataGridView.ReadOnly = true;
            clientDataGridView.DataSource = BClient.ListClients();

        }

        private void ClientDataGridView_Load(object sender, EventArgs e)
        {
            refreshdata();
        }

        private void createbtn_Click(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
             
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
