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
    public partial class SettingGoalForm : Form
    {
        private readonly User currentUser;

        public SettingGoalForm(User _currentUser)
        {
            InitializeComponent();
            currentUser = _currentUser;
        }

        private void btnSetGoal_Click(object sender, EventArgs e)
        {
            double goal = (double)numGoal.Value;

            if (goal > 0)
            {
                currentUser.CalorieGoal = goal;
                MessageBox.Show("Goal saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a number greater than 100.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnCancelSetGoal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
