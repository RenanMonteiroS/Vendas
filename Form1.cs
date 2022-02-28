using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testemenubd2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            funcionario Cad = new funcionario();
            Cad.ShowDialog();
           

            this.Close();
           
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            vendas Cad = new vendas();
            Cad.ShowDialog();


            this.Close();

           
            
        }

     
    }
}
