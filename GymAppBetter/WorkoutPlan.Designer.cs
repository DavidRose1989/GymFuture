namespace GymAppBetter
{
    partial class WorkoutPlan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkoutPlan));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtWorkoutPlan = new TextBox();
            txtUsed = new TextBox();
            txtCost = new TextBox();
            txtDescription = new RichTextBox();
            dateTimePickerStartDate = new DateTimePicker();
            btnSave = new Button();
            btnReset = new Button();
            btnViewWorkout = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(357, 186);
            label1.Name = "label1";
            label1.Size = new Size(141, 28);
            label1.TabIndex = 0;
            label1.Text = "Workout Plan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(357, 252);
            label2.Name = "label2";
            label2.Size = new Size(121, 28);
            label2.TabIndex = 1;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(357, 440);
            label3.Name = "label3";
            label3.Size = new Size(140, 28);
            label3.TabIndex = 2;
            label3.Text = "Muscles Used";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(357, 546);
            label4.Name = "label4";
            label4.Size = new Size(110, 28);
            label4.TabIndex = 3;
            label4.Text = "Start Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(357, 675);
            label5.Name = "label5";
            label5.Size = new Size(53, 28);
            label5.TabIndex = 4;
            label5.Text = "Cost";
            // 
            // txtWorkoutPlan
            // 
            txtWorkoutPlan.Location = new Point(536, 196);
            txtWorkoutPlan.Name = "txtWorkoutPlan";
            txtWorkoutPlan.Size = new Size(316, 31);
            txtWorkoutPlan.TabIndex = 5;
            // 
            // txtUsed
            // 
            txtUsed.Location = new Point(536, 437);
            txtUsed.Name = "txtUsed";
            txtUsed.Size = new Size(316, 31);
            txtUsed.TabIndex = 8;
            // 
            // txtCost
            // 
            txtCost.Location = new Point(536, 669);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(224, 31);
            txtCost.TabIndex = 9;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(536, 252);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(316, 144);
            txtDescription.TabIndex = 10;
            txtDescription.Text = "";
            // 
            // dateTimePickerStartDate
            // 
            dateTimePickerStartDate.Format = DateTimePickerFormat.Short;
            dateTimePickerStartDate.Location = new Point(536, 546);
            dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            dateTimePickerStartDate.Size = new Size(150, 31);
            dateTimePickerStartDate.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(355, 793);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.Location = new Point(559, 793);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(112, 34);
            btnReset.TabIndex = 13;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click_1;
            // 
            // btnViewWorkout
            // 
            btnViewWorkout.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewWorkout.Location = new Point(778, 793);
            btnViewWorkout.Name = "btnViewWorkout";
            btnViewWorkout.Size = new Size(169, 34);
            btnViewWorkout.TabIndex = 14;
            btnViewWorkout.Text = "View Workout";
            btnViewWorkout.UseVisualStyleBackColor = true;
            btnViewWorkout.Click += btnViewWorkout_Click;
            // 
            // WorkoutPlan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1231, 919);
            Controls.Add(btnViewWorkout);
            Controls.Add(btnReset);
            Controls.Add(btnSave);
            Controls.Add(dateTimePickerStartDate);
            Controls.Add(txtDescription);
            Controls.Add(txtCost);
            Controls.Add(txtUsed);
            Controls.Add(txtWorkoutPlan);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "WorkoutPlan";
            Text = "Equipment";
            Load += Equipment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtWorkoutPlan;
        private TextBox txtUsed;
        private TextBox txtCost;
        private RichTextBox txtDescription;
        private DateTimePicker dateTimePickerStartDate;
        private Button btnSave;
        private Button btnReset;
        private Button btnViewWorkout;
    }
}