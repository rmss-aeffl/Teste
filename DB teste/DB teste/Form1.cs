using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db_user a = new db_user();

            if (a.validate_user_txt(textBox1.Text, textBox2.Text))
                // abrir outro form
                MessageBox.Show("Ok open new form");

            else
                MessageBox.Show("Erro pass ou user nao validos");
        }
    }
}
