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

        
    }
}
