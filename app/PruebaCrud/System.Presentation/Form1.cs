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

        private void DgvLoansFormat()
        {
            clientDataGridView.Columns[0].HeaderText = "Apellidos";
            clientDataGridView.Columns[1].HeaderText = "Nombre";
            clientDataGridView.Columns[2].HeaderText = "Dui";
            clientDataGridView.Columns[3].HeaderText = "Fecha de cumpleaños";

            for (int i = 1; i < 4; i++)
            {
                clientDataGridView.Columns[i].Width = 230;
            }
        }
        private void refreshdata()
        {

            try
            {
                clientDataGridView.ReadOnly = true;
                DataTable data = new DataTable();
                data = BClient.ListClients();
                clientDataGridView.DataSource = data;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
            }


        }

        private void ClientDataGridView_Load(object sender, EventArgs e)
        {
            refreshdata();
        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            refreshdata();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
             
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
