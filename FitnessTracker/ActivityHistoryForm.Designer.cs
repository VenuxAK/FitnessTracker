namespace FitnessTracker
{
    partial class ActivityHistoryForm
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
            dgvActivities = new DataGridView();
            ActivityName = new DataGridViewTextBoxColumn();
            MET = new DataGridViewTextBoxColumn();
            Weight = new DataGridViewTextBoxColumn();
            Duration = new DataGridViewTextBoxColumn();
            CaloriesBurned = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvActivities).BeginInit();
            SuspendLayout();
            // 
            // dgvActivities
            // 
            dgvActivities.BackgroundColor = SystemColors.Window;
            dgvActivities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActivities.Columns.AddRange(new DataGridViewColumn[] { ActivityName, MET, Weight, Duration, CaloriesBurned, Date });
            dgvActivities.Location = new Point(99, 81);
            dgvActivities.Name = "dgvActivities";
            dgvActivities.RowHeadersWidth = 51;
            dgvActivities.ShowEditingIcon = false;
            dgvActivities.Size = new Size(803, 325);
            dgvActivities.TabIndex = 0;
            // 
            // ActivityName
            // 
            ActivityName.HeaderText = "Activity";
            ActivityName.MinimumWidth = 6;
            ActivityName.Name = "ActivityName";
            ActivityName.Width = 125;
            // 
            // MET
            // 
            MET.HeaderText = "MET";
            MET.MinimumWidth = 6;
            MET.Name = "MET";
            MET.Width = 125;
            // 
            // Weight
            // 
            Weight.HeaderText = "Weight (kg)";
            Weight.MinimumWidth = 6;
            Weight.Name = "Weight";
            Weight.Width = 125;
            // 
            // Duration
            // 
            Duration.HeaderText = "Duration (hrs)";
            Duration.MinimumWidth = 6;
            Duration.Name = "Duration";
            Duration.Width = 125;
            // 
            // CaloriesBurned
            // 
            CaloriesBurned.HeaderText = "Calories Burned";
            CaloriesBurned.MinimumWidth = 6;
            CaloriesBurned.Name = "CaloriesBurned";
            CaloriesBurned.Width = 125;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(99, 25);
            label1.Name = "label1";
            label1.Size = new Size(125, 28);
            label1.TabIndex = 1;
            label1.Text = "Your History";
            // 
            // ActivityHistoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 479);
            Controls.Add(label1);
            Controls.Add(dgvActivities);
            Name = "ActivityHistoryForm";
            Text = "Fitness Tracker - Activity History";
            Load += ActivityHistoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvActivities).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvActivities;
        private DataGridViewTextBoxColumn ActivityName;
        private DataGridViewTextBoxColumn MET;
        private DataGridViewTextBoxColumn Weight;
        private DataGridViewTextBoxColumn Duration;
        private DataGridViewTextBoxColumn CaloriesBurned;
        private DataGridViewTextBoxColumn Date;
        private Label label1;
    }
}