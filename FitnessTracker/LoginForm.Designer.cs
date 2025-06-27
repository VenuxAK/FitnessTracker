namespace FitnessTracker
{
    partial class LoginForm
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
            lblLoginHeader = new Label();
            label1 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            btnAction = new Button();
            lnkToggleMode = new LinkLabel();
            lblStatus = new Label();
            cbHideShow = new CheckBox();
            SuspendLayout();
            // 
            // lblLoginHeader
            // 
            lblLoginHeader.AutoSize = true;
            lblLoginHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoginHeader.Location = new Point(287, 34);
            lblLoginHeader.Name = "lblLoginHeader";
            lblLoginHeader.Size = new Size(220, 28);
            lblLoginHeader.TabIndex = 0;
            lblLoginHeader.Text = "Login to your account";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(261, 127);
            label1.Name = "label1";
            label1.Size = new Size(186, 25);
            label1.TabIndex = 1;
            label1.Text = "Enter your username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(261, 155);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(278, 27);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(261, 236);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(278, 27);
            txtPassword.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(261, 210);
            label2.Name = "label2";
            label2.Size = new Size(167, 23);
            label2.TabIndex = 4;
            label2.Text = "Enter your password";
            // 
            // btnAction
            // 
            btnAction.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAction.Location = new Point(261, 332);
            btnAction.Name = "btnAction";
            btnAction.Size = new Size(275, 31);
            btnAction.TabIndex = 5;
            btnAction.Text = "Login";
            btnAction.UseVisualStyleBackColor = true;
            btnAction.Click += btnAction_Click;
            // 
            // lnkToggleMode
            // 
            lnkToggleMode.AutoSize = true;
            lnkToggleMode.Location = new Point(261, 291);
            lnkToggleMode.Name = "lnkToggleMode";
            lnkToggleMode.Size = new Size(135, 20);
            lnkToggleMode.TabIndex = 6;
            lnkToggleMode.TabStop = true;
            lnkToggleMode.Text = "Create an account?";
            lnkToggleMode.LinkClicked += lnkToggleMode_LinkClicked;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(261, 89);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 23);
            lblStatus.TabIndex = 7;
            // 
            // cbHideShow
            // 
            cbHideShow.AutoSize = true;
            cbHideShow.Location = new Point(474, 208);
            cbHideShow.Name = "cbHideShow";
            cbHideShow.Size = new Size(67, 24);
            cbHideShow.TabIndex = 8;
            cbHideShow.Text = "Show";
            cbHideShow.UseVisualStyleBackColor = true;
            cbHideShow.CheckedChanged += cbHideShow_CheckedChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 499);
            Controls.Add(cbHideShow);
            Controls.Add(lblStatus);
            Controls.Add(label1);
            Controls.Add(lnkToggleMode);
            Controls.Add(txtUsername);
            Controls.Add(lblLoginHeader);
            Controls.Add(btnAction);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Name = "LoginForm";
            Text = "Fitness Tracker - Login";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLoginHeader;
        private Label label1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label2;
        private Button btnAction;
        private LinkLabel lnkToggleMode;
        private Label lblStatus;
        private CheckBox cbHideShow;
    }
}