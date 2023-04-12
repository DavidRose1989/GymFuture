using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymAppBetter
{
    public partial class DeleteMember : Form
    {
        public DeleteMember()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("This will delete your data. Confirm?", "Delete data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {



                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = "Server=localhost;Database=gym;uid=root;Pwd=password;Port=3306;";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "delete from users where MID =  " + textBox1.Text + "";

                MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

               
            }
            else
            {
                this.Activate();
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = "Server=localhost;Database=gym;uid=root;Pwd=password;Port=3306;";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "select * from users";

                MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView1.DataSource = DS.Tables[0];
            }
        }

        private void DeleteMember_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "Server=localhost;Database=gym;uid=root;Pwd=password;Port=3306;";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "select * from users";

            MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView1.DataSource = DS.Tables[0];
        }
    }
}
