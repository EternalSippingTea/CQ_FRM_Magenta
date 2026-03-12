using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikumADO
{
    public partial class Form2 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public Form2()
        {
            InitializeComponent();
        }

        private void Connection()
        {
            conn = new SqlConnection(
               "Data Source=siptea-lt\\FAR;Initial Catalog=DBAkademikADO;Integrated Security=True"
            );
        }

        private void btnCountDosen_Click(object sender, EventArgs e)
        {
            try
            {
                Connection();
                conn.Open();
                string query = "SELECT COUNT(*) FROM Dosen";

                cmd = new SqlCommand(query, conn);
                int jumlah = (int)cmd.ExecuteScalar();

                txtHasil.Text = jumlah.ToString();

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateMk_Click(object sender, EventArgs e)
        {
            try
            {
                Connection();
                conn.Open();
                string query = "UPDATE MataKuliah SET SKS=4 WHERE KodeMK='IF210101'";

                cmd = new SqlCommand(query, conn);
                int hasil = cmd.ExecuteNonQuery();

                MessageBox.Show("Jumlah baris terpengaruh : " + hasil);

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
