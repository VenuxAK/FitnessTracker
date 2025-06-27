namespace FitnessTracker
{
    partial class ProgressSummaryForm
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
            lblGoal = new Label();
            lblTotalBurned = new Label();
            lblStatus = new Label();
            lblProgress = new Label();
            lblProgressSummary = new Label();
            progressBar = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // lblGoal
            // 
            lblGoal.AutoSize = true;
            lblGoal.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGoal.Location = new Point(82, 112);
            lblGoal.Name = "lblGoal";
            lblGoal.Size = new Size(52, 23);
            lblGoal.TabIndex = 0;
            lblGoal.Text = "Value";
            // 
            // lblTotalBurned
            // 
            lblTotalBurned.AutoSize = true;
            lblTotalBurned.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalBurned.Location = new Point(143, 163);
            lblTotalBurned.Name = "lblTotalBurned";
            lblTotalBurned.Size = new Size(52, 23);
            lblTotalBurned.TabIndex = 1;
            lblTotalBurned.Text = "Value";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(92, 207);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(52, 23);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Value";
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProgress.Location = new Point(25, 257);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(84, 23);
            lblProgress.TabIndex = 3;
            lblProgress.Text = "Progress: ";
            // 
            // lblProgressSummary
            // 
            lblProgressSummary.AutoSize = true;
            lblProgressSummary.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProgressSummary.Location = new Point(203, 9);
            lblProgressSummary.Name = "lblProgressSummary";
            lblProgressSummary.Size = new Size(184, 28);
            lblProgressSummary.TabIndex = 4;
            lblProgressSummary.Text = "Progress Summary";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(115, 257);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(125, 23);
            progressBar.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 112);
            label1.Name = "label1";
            label1.Size = new Size(54, 23);
            label1.TabIndex = 6;
            label1.Text = "Goal: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 163);
            label2.Name = "label2";
            label2.Size = new Size(115, 23);
            label2.TabIndex = 7;
            label2.Text = "Total Burned: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 207);
            label3.Name = "label3";
            label3.Size = new Size(66, 23);
            label3.TabIndex = 8;
            label3.Text = "Status: ";
            // 
            // ProgressSummaryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 306);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressBar);
            Controls.Add(lblProgressSummary);
            Controls.Add(lblProgress);
            Controls.Add(lblStatus);
            Controls.Add(lblTotalBurned);
            Controls.Add(lblGoal);
            Name = "ProgressSummaryForm";
            Text = "Fitness Tracker - Progress Summary";
            Load += ProgressSummaryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGoal;
        private Label lblTotalBurned;
        private Label lblStatus;
        private Label lblProgress;
        private Label lblProgressSummary;
        private ProgressBar progressBar;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}