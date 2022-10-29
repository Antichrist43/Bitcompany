using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SQLite;
using MySql.Data.MySqlClient;
using System.Net;

namespace Bitcompany_Core
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buyABicompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 myNewForm = new Form6();
            myNewForm.Visible = true;
        }

        private void createPorfolioToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Form2 myNewForm = new Form2();
            myNewForm.Visible = true;
        }

        private void myPortfolioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 myNewForm = new Form3();
            myNewForm.Visible = true;
        }

        private void createBitcompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
      
        }

        private void sendBitcompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 myNewForm = new Form8();
            myNewForm.Visible = true;
        }

        private void receiveBitcompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 myNewForm = new Form9();
            myNewForm.Visible = true;
        }

        private void versionV0001ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 myNewForm = new Form7();
            myNewForm.Visible = true;
        }

        private void fAQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 myNewForm = new Form10();
            myNewForm.Visible = true;
        }

        private void exitToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string cs1 = @"server=148.66.138.124;userid=chrisclarker99;password=Seadragon#1234;database=DBbitcompany";


            var con1 = new MySqlConnection(cs1);
            con1.Open();
        }

        private void bitcompanyChainToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mitLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 myNewForm = new Form4();
            myNewForm.Visible = true;
        }
    }
}
