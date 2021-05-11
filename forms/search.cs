using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace articles.forms
{
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        void getInfo(DataGridView Grid)
        {
            string query = "select";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        dataGridView1.Rows.Add(rd.GetString(0), rd.GetString(1))
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchBut_Click(object sender, EventArgs e)
        {
            string query = "select mjfnkjngjd where table() like '%" + toSearch.Text + "%';";
            MySqlConnection conn = DBUtils.
        }
    }
}
