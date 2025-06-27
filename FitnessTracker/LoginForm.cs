using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessTracker
{
    public partial class LoginForm : Form
    {
        private FitnessTracker tracker;
        private bool isRegistrationMode = false;
        private int loginAttempts = 0;
        private int maxAttempts = 3;

        public LoginForm(FitnessTracker fitnessTracker)
        {
            InitializeComponent();
            tracker = fitnessTracker;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            isRegistrationMode = false;
            txtPassword.UseSystemPasswordChar = true;

            if (isRegistrationMode)
            {
                lblLoginHeader.Text = "Register new account";
            }
            else
            {
                lblLoginHeader.Text = "Login to your account";
            }

        }

        private void lnkToggleMode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.ToggleMode();
        }

        private void ToggleMode()
        {
            isRegistrationMode = !isRegistrationMode;
            lblStatus.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            cbHideShow.Checked = false;

            // Update button and link text
            btnAction.Text = isRegistrationMode ? "Register" : "Login";
            lnkToggleMode.Text = isRegistrationMode ? "Already have an account?" : "Create new account";
            lblLoginHeader.Text = isRegistrationMode ? "Register new account" : "Login to your account";


        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (isRegistrationMode)
            {
                HandleRegister();
            }
            else
            {
                HandleLogin();
            }
        }

        private void HandleLogin()
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                this.ShowStatus("Please enter both username and password");
                return;
            }

            if (tracker.Login(username, password))
            {
                MainForm mainForm = new MainForm(tracker.CurrentUser);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                loginAttempts++;
                ShowStatus($"Invalid credentials. Attempts remaining: {maxAttempts - loginAttempts}");

                if (loginAttempts >= maxAttempts)
                {
                    MessageBox.Show("Too many failed attempts.", "Security Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();
                }

                return;
            }

        }

        private void HandleRegister()
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                this.ShowStatus("Please enter both username and password");
                return;
            }

            if (!Validator.ValidateUsername(username))
            {
                ShowStatus("Username must contain only letters and numbers");
                return;
            }

            if (!Validator.ValidatePassword(password))
            {
                ShowStatus("Password must be 12 chars with at least 1 uppercase 1 lowercase");
                return;
            }

            if (tracker.Register(username, password))
            {
                //ShowStatus("Registration successful!");
                //ToggleMode(); // Switch back to login mode
                MainForm mainForm = new MainForm(tracker.CurrentUser);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                ShowStatus("Username already in used.");
            }

        }


        private void ShowStatus(string message)
        {
            lblStatus.Text = message;
            lblStatus.ForeColor = Color.Red;
        }

        private void cbHideShow_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !cbHideShow.Checked;
        }
    }
}
