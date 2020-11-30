using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PracticaConnection
{
    public partial class FrmPracticaConnection : Form
    {
        public FrmPracticaConnection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection();
        }


        public void Connection()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=PRACTICA;Integrated Security=True";
            SqlConnection _connection = new SqlConnection(connectionString);

            Connect_bd(_connection);

        }

        public void Connect_bd(SqlConnection connection)
        {
            try
            {
                connection.Open();
                MessageBox.Show("La base de datos esta conectada....");
            }
            catch (Exception)
            {
                MessageBox.Show("La base de datos no esta conectada...");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
