using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GymAppBetter
{
    public partial class WorkoutPlan : Form
    {
        public WorkoutPlan()
        {
            InitializeComponent();
        }

        private void Equipment_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String WorkoutPlan = txtWorkoutPlan.Text;
            String Description = txtDescription.Text;
            String MUsed = txtUsed.Text;
            String Date = dateTimePickerStartDate.Text;
            String Cost = txtCost.Text;

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "Server=localhost;Database=gym;uid=root;Pwd=password;Port=3306;";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into workouts (WorkoutName,WDescription,MUsed,SDate,Cost) values ('" + WorkoutPlan + "','" + Description + "','" + MUsed + "','" + Date + "','" + Cost + "')";

            MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data saved.", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnReset_Click_1(object sender, EventArgs e)
        {
            txtWorkoutPlan.Clear();
            txtDescription.Clear();
            txtUsed.Clear();
            txtCost.Clear();
            dateTimePickerStartDate.Value = DateTime.Now;
        }

        private void btnViewWorkout_Click(object sender, EventArgs e)
        {
            ViewWorkout viewWorkout = new ViewWorkout();
            viewWorkout.Show();
        }
    }
}
