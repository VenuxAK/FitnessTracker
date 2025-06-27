namespace FitnessTracker
{
    partial class AddActivityForm
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
            label2 = new Label();
            txtWeight = new TextBox();
            txtDuration = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnSaveActivity = new Button();
            btnCancelActivity = new Button();
            rdoWalking = new RadioButton();
            rdoSwimming = new RadioButton();
            cmbMET = new ComboBox();
            rdoRunning = new RadioButton();
            rdoCycling = new RadioButton();
            rdoJumpRope = new RadioButton();
            rdoYoga = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(286, 18);
            label1.Name = "label1";
            label1.Size = new Size(178, 28);
            label1.TabIndex = 0;
            label1.Text = "Add Your Activity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(189, 67);
            label2.Name = "label2";
            label2.Size = new Size(129, 23);
            label2.TabIndex = 1;
            label2.Text = "Choose Activity";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(313, 190);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(172, 27);
            txtWeight.TabIndex = 3;
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(313, 252);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(172, 27);
            txtDuration.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(189, 191);
            label3.Name = "label3";
            label3.Size = new Size(101, 23);
            label3.TabIndex = 6;
            label3.Text = "Weight (kg)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(189, 256);
            label4.Name = "label4";
            label4.Size = new Size(121, 23);
            label4.TabIndex = 7;
            label4.Text = "Duration Hour";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(189, 329);
            label5.Name = "label5";
            label5.Size = new Size(91, 23);
            label5.TabIndex = 8;
            label5.Text = "MET Value";
            // 
            // btnSaveActivity
            // 
            btnSaveActivity.Location = new Point(372, 390);
            btnSaveActivity.Name = "btnSaveActivity";
            btnSaveActivity.Size = new Size(113, 47);
            btnSaveActivity.TabIndex = 9;
            btnSaveActivity.Text = "Save";
            btnSaveActivity.UseVisualStyleBackColor = true;
            btnSaveActivity.Click += btnSaveActivity_Click;
            // 
            // btnCancelActivity
            // 
            btnCancelActivity.Location = new Point(242, 390);
            btnCancelActivity.Name = "btnCancelActivity";
            btnCancelActivity.Size = new Size(113, 47);
            btnCancelActivity.TabIndex = 10;
            btnCancelActivity.Text = "Cancel";
            btnCancelActivity.UseVisualStyleBackColor = true;
            btnCancelActivity.Click += btnCancelActivity_Click;
            // 
            // rdoWalking
            // 
            rdoWalking.AutoSize = true;
            rdoWalking.Location = new Point(189, 105);
            rdoWalking.Name = "rdoWalking";
            rdoWalking.Size = new Size(83, 24);
            rdoWalking.TabIndex = 11;
            rdoWalking.TabStop = true;
            rdoWalking.Text = "Walking";
            rdoWalking.UseVisualStyleBackColor = true;
            rdoWalking.CheckedChanged += rdoWalking_CheckedChanged;
            // 
            // rdoSwimming
            // 
            rdoSwimming.AutoSize = true;
            rdoSwimming.Location = new Point(313, 105);
            rdoSwimming.Name = "rdoSwimming";
            rdoSwimming.Size = new Size(100, 24);
            rdoSwimming.TabIndex = 12;
            rdoSwimming.TabStop = true;
            rdoSwimming.Text = "Swimming";
            rdoSwimming.UseVisualStyleBackColor = true;
            rdoSwimming.CheckedChanged += rdoSwimming_CheckedChanged;
            // 
            // cmbMET
            // 
            cmbMET.FormattingEnabled = true;
            cmbMET.Location = new Point(313, 324);
            cmbMET.Name = "cmbMET";
            cmbMET.Size = new Size(172, 28);
            cmbMET.TabIndex = 13;
            // 
            // rdoRunning
            // 
            rdoRunning.AutoSize = true;
            rdoRunning.Location = new Point(470, 105);
            rdoRunning.Name = "rdoRunning";
            rdoRunning.Size = new Size(84, 24);
            rdoRunning.TabIndex = 14;
            rdoRunning.TabStop = true;
            rdoRunning.Text = "Running";
            rdoRunning.UseVisualStyleBackColor = true;
            rdoRunning.CheckedChanged += rdoRunning_CheckedChanged;
            // 
            // rdoCycling
            // 
            rdoCycling.AutoSize = true;
            rdoCycling.Location = new Point(187, 138);
            rdoCycling.Name = "rdoCycling";
            rdoCycling.Size = new Size(78, 24);
            rdoCycling.TabIndex = 15;
            rdoCycling.TabStop = true;
            rdoCycling.Text = "Cycling";
            rdoCycling.UseVisualStyleBackColor = true;
            rdoCycling.CheckedChanged += rdoCycling_CheckedChanged;
            // 
            // rdoJumpRope
            // 
            rdoJumpRope.AutoSize = true;
            rdoJumpRope.Location = new Point(313, 138);
            rdoJumpRope.Name = "rdoJumpRope";
            rdoJumpRope.Size = new Size(104, 24);
            rdoJumpRope.TabIndex = 16;
            rdoJumpRope.TabStop = true;
            rdoJumpRope.Text = "Jump Rope";
            rdoJumpRope.UseVisualStyleBackColor = true;
            rdoJumpRope.CheckedChanged += rdoJumpRope_CheckedChanged;
            // 
            // rdoYoga
            // 
            rdoYoga.AutoSize = true;
            rdoYoga.Location = new Point(470, 138);
            rdoYoga.Name = "rdoYoga";
            rdoYoga.Size = new Size(63, 24);
            rdoYoga.TabIndex = 17;
            rdoYoga.TabStop = true;
            rdoYoga.Text = "Yoga";
            rdoYoga.UseVisualStyleBackColor = true;
            rdoYoga.CheckedChanged += rdoYoga_CheckedChanged;
            // 
            // AddActivityForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 486);
            Controls.Add(rdoYoga);
            Controls.Add(rdoJumpRope);
            Controls.Add(rdoCycling);
            Controls.Add(rdoRunning);
            Controls.Add(cmbMET);
            Controls.Add(rdoSwimming);
            Controls.Add(rdoWalking);
            Controls.Add(btnCancelActivity);
            Controls.Add(btnSaveActivity);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtDuration);
            Controls.Add(txtWeight);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddActivityForm";
            Text = "Fitness Tracler - Add Activity";
            Load += AddActivityForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtWeight;
        private TextBox txtDuration;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnSaveActivity;
        private Button btnCancelActivity;
        private RadioButton rdoWalking;
        private RadioButton rdoSwimming;
        private ComboBox cmbMET;
        private RadioButton rdoRunning;
        private RadioButton rdoCycling;
        private RadioButton rdoJumpRope;
        private RadioButton rdoYoga;
    }
}