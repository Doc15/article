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

namespace articles
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            getInfo(list);
        }

        void getInfo(ListView List)
        {
            string query = "";
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
                        string[] row = { rd.GetString(0), rd.GetString(1) };
                        var listItem = new ListViewItem(row);
                        List.Items.Add(listItem);
                    }
                }
                List.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        
        // update
        private void Refresh_Click(object sender, EventArgs e)
        {
            list.Items.Clear();
            getInfo(list);
        }

        private void delArt_Click(object sender, EventArgs e)
        {
            string query = "delete from table where id= '" + list.Items[list.SelectedIndices[0]].Text + "';";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                conn.Close();
                foreach (ListViewItem item in list.SelectedIndices)
                {
                    list.Items.Remove(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
