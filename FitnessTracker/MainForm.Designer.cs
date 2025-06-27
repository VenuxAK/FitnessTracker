namespace FitnessTracker
{
    partial class MainForm
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
            lblWelcomeUser = new Label();
            lblUserGoal = new Label();
            lblUserBurnedCal = new Label();
            lblUserGoalStatus = new Label();
            btnNavigateToSetGoal = new Button();
            btnNavigateToAddActivityForm = new Button();
            btnNavigateToViewProgressSummary = new Button();
            btnLogout = new Button();
            btnViewHistory = new Button();
            SuspendLayout();
            // 
            // lblWelcomeUser
            // 
            lblWelcomeUser.AutoSize = true;
            lblWelcomeUser.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeUser.Location = new Point(16, 16);
            lblWelcomeUser.Name = "lblWelcomeUser";
            lblWelcomeUser.Size = new Size(85, 23);
            lblWelcomeUser.TabIndex = 0;
            lblWelcomeUser.Text = "Welcome,";
            // 
            // lblUserGoal
            // 
            lblUserGoal.AutoSize = true;
            lblUserGoal.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserGoal.Location = new Point(16, 46);
            lblUserGoal.Name = "lblUserGoal";
            lblUserGoal.Size = new Size(91, 23);
            lblUserGoal.TabIndex = 1;
            lblUserGoal.Text = "Your goal: ";
            // 
            // lblUserBurnedCal
            // 
            lblUserBurnedCal.AutoSize = true;
            lblUserBurnedCal.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserBurnedCal.Location = new Point(16, 79);
            lblUserBurnedCal.Name = "lblUserBurnedCal";
            lblUserBurnedCal.Size = new Size(149, 23);
            lblUserBurnedCal.TabIndex = 2;
            lblUserBurnedCal.Text = "You have burned: ";
            // 
            // lblUserGoalStatus
            // 
            lblUserGoalStatus.AutoSize = true;
            lblUserGoalStatus.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserGoalStatus.Location = new Point(16, 111);
            lblUserGoalStatus.Name = "lblUserGoalStatus";
            lblUserGoalStatus.Size = new Size(114, 25);
            lblUserGoalStatus.TabIndex = 3;
            lblUserGoalStatus.Text = "Goal status: ";
            // 
            // btnNavigateToSetGoal
            // 
            btnNavigateToSetGoal.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavigateToSetGoal.Location = new Point(16, 193);
            btnNavigateToSetGoal.Name = "btnNavigateToSetGoal";
            btnNavigateToSetGoal.Size = new Size(139, 41);
            btnNavigateToSetGoal.TabIndex = 4;
            btnNavigateToSetGoal.Text = "Set Goal";
            btnNavigateToSetGoal.UseVisualStyleBackColor = true;
            btnNavigateToSetGoal.Click += btnNavigateToSetGoal_Click;
            // 
            // btnNavigateToAddActivityForm
            // 
            btnNavigateToAddActivityForm.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavigateToAddActivityForm.Location = new Point(16, 240);
            btnNavigateToAddActivityForm.Name = "btnNavigateToAddActivityForm";
            btnNavigateToAddActivityForm.Size = new Size(139, 45);
            btnNavigateToAddActivityForm.TabIndex = 5;
            btnNavigateToAddActivityForm.Text = "Add Activity";
            btnNavigateToAddActivityForm.UseVisualStyleBackColor = true;
            btnNavigateToAddActivityForm.Click += btnNavigateToAddActivity_Click;
            // 
            // btnNavigateToViewProgressSummary
            // 
            btnNavigateToViewProgressSummary.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavigateToViewProgressSummary.Location = new Point(16, 291);
            btnNavigateToViewProgressSummary.Name = "btnNavigateToViewProgressSummary";
            btnNavigateToViewProgressSummary.Size = new Size(139, 45);
            btnNavigateToViewProgressSummary.TabIndex = 6;
            btnNavigateToViewProgressSummary.Text = "View Progress";
            btnNavigateToViewProgressSummary.UseVisualStyleBackColor = true;
            btnNavigateToViewProgressSummary.Click += btnNavigateToViewProgressSummary_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(16, 393);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(139, 45);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnViewHistory
            // 
            btnViewHistory.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewHistory.Location = new Point(16, 342);
            btnViewHistory.Name = "btnViewHistory";
            btnViewHistory.Size = new Size(139, 45);
            btnViewHistory.TabIndex = 8;
            btnViewHistory.Text = "View History";
            btnViewHistory.UseVisualStyleBackColor = true;
            btnViewHistory.Click += btnViewHistory_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnViewHistory);
            Controls.Add(btnLogout);
            Controls.Add(btnNavigateToViewProgressSummary);
            Controls.Add(btnNavigateToAddActivityForm);
            Controls.Add(btnNavigateToSetGoal);
            Controls.Add(lblUserGoalStatus);
            Controls.Add(lblUserBurnedCal);
            Controls.Add(lblUserGoal);
            Controls.Add(lblWelcomeUser);
            Name = "MainForm";
            Text = "Fitness Tracker - Home";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcomeUser;
        private Label lblUserGoal;
        private Label lblUserBurnedCal;
        private Label lblUserGoalStatus;
        private Button btnNavigateToSetGoal;
        private Button btnNavigateToAddActivityForm;
        private Button btnNavigateToViewProgressSummary;
        private Button btnLogout;
        private Button btnViewHistory;
    }
}