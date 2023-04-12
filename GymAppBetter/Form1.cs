using GymAppBetter;

namespace GymAppBetter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        Boolean b = true;
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (b == true)
            {
                menuStrip2.Dock = DockStyle.Left;
                b = false;
                toolStripMenuItem1.Image = Image.FromFile(@"C:\Users\David\OneDrive\Desktop\Arrow images\img1.jpg");

            }
            else
            {
                menuStrip2.Dock = DockStyle.Top;
                b = true;
                toolStripMenuItem1.Image = Image.FromFile(@"C:\Users\David\OneDrive\Desktop\Arrow images\img2.jpg");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripMenuItem1.Image = Image.FromFile(@"C:\Users\David\OneDrive\Desktop\Arrow images\img2.jpg");
        }

        private void newMemberToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            NewMember nm = new NewMember();
            nm.Show();
        }

        private void newStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Staff ns = new New_Staff();
            ns.Show();
        }

        private void equipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkoutPlan workoutPlan = new WorkoutPlan();
            workoutPlan.Show();
        }

        private void searchMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchMember searchMember = new SearchMember();
            searchMember.Show();
        }

        private void deleteMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteMember dm = new DeleteMember();
            dm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will close your application. Confirm?", "CLOSE", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Welcome Back", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Log OUT !! Confirm?","LOG OUT",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
                Login lg = new Login();
                lg.Show();
            }
        }
    }
}