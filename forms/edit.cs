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
    public partial class edit : Form
    {
        public edit()
        {
            InitializeComponent();
            getInfo(dataGridView);
            getCat(categoryBox);
        }

        void getInfo(DataGridView grid)
        {
            string query = "select";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                if(rd.HasRows)
                {
                    while(rd.Read())
                    {
                        dataGridView.Rows.Add(rd.GetString(0), rd.GetString(1));
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dstsGriView_Click(object sender, EventArgs e)
        {
            IDbox.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            titleBox.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            categoryBox.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            authorBox.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            articleBox.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
            date.Text = dataGridView.CurrentRow.Cells[5].Value.ToString();
            tagBox.Text = dataGridView.CurrentRow.Cells[6].Value.ToString();
        }

        private void update_Click(object sender, EventArgs e)
        {
            string query = "update table set name='" + titleBox.Text + "'; ";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader(); 
                conn.Close();
                MessageBox.Show("article updates");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void getCat(ComboBox box)
        {
            string query = "select * from category";
            MySqlConnection conn = DBUtils.GetDbConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            MySqlDataReader rd;
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                rd = cmDB.ExecuteReader();
                if(rd.HasRows)
                {
                    while(rd.Read())
                    {
                        string row = rd.GetString(0);
                        box.Items.Add(row);
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
