namespace FitnessTracker
{
    partial class SettingGoalForm
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
            label1 = new Label();
            btnCancelSetGoal = new Button();
            btnSetGoal = new Button();
            numGoal = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numGoal).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 55);
            label1.Name = "label1";
            label1.Size = new Size(157, 23);
            label1.TabIndex = 0;
            label1.Text = "Set Goal (calories): ";
            // 
            // btnCancelSetGoal
            // 
            btnCancelSetGoal.Location = new Point(148, 112);
            btnCancelSetGoal.Name = "btnCancelSetGoal";
            btnCancelSetGoal.Size = new Size(108, 40);
            btnCancelSetGoal.TabIndex = 2;
            btnCancelSetGoal.Text = "Cancel";
            btnCancelSetGoal.UseVisualStyleBackColor = true;
            // 
            // btnSetGoal
            // 
            btnSetGoal.Location = new Point(262, 112);
            btnSetGoal.Name = "btnSetGoal";
            btnSetGoal.Size = new Size(108, 40);
            btnSetGoal.TabIndex = 3;
            btnSetGoal.Text = "Set Goal";
            btnSetGoal.UseVisualStyleBackColor = true;
            btnSetGoal.Click += btnSetGoal_Click;
            // 
            // numGoal
            // 
            numGoal.Increment = new decimal(new int[] { 50, 0, 0, 0 });
            numGoal.Location = new Point(220, 55);
            numGoal.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numGoal.Name = "numGoal";
            numGoal.Size = new Size(150, 27);
            numGoal.TabIndex = 4;
            numGoal.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // SettingGoalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 281);
            Controls.Add(numGoal);
            Controls.Add(btnSetGoal);
            Controls.Add(btnCancelSetGoal);
            Controls.Add(label1);
            Name = "SettingGoalForm";
            Text = "Fitness Tracker - Set Goal";
            Load += SettingGoalForm_Load;
            ((System.ComponentModel.ISupportInitialize)numGoal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCancelSetGoal;
        private Button btnSetGoal;
        private NumericUpDown numGoal;
    }
}