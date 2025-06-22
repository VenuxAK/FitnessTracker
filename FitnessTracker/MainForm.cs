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
    public partial class MainForm : Form
    {
        private FitnessTracker tracker;
        private User currentUser;

        public MainForm(FitnessTracker fitnessTracker)
        {
            InitializeComponent();
            this.tracker = fitnessTracker;
            User? currentUserTemp = fitnessTracker.CurrentUser;
            currentUser = currentUserTemp;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //private User CU = tracker.CurrentUser;
            if (tracker.CurrentUser != null)
            {
                lblCU.Text = tracker.CurrentUser.Username;

            } else
            {
                LoginForm loginForm = new LoginForm(tracker);
                loginForm.ShowDialog();
                Hide();
                //this.Hide();
            }

    }
    }
}
