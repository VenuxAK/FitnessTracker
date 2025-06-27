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
    public partial class AddActivityForm : Form
    {
        private readonly User currentUser;
        public AddActivityForm(User _currentUser)
        {
            InitializeComponent();
            currentUser = _currentUser;
        }

        private void AddActivityForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelActivity_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveActivity_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtWeight.Text, out double weight) && 
                double.TryParse(txtDuration.Text, out double duration) &&
                double.TryParse(cmbMET.SelectedItem.ToString(), out double met))
            {
                string selectedActivity = GetSelectedActivity();

                Activity activity = new Activity(selectedActivity, weight, duration, met);
                currentUser.Activities.Add(activity);

                //double caloriesBurned = met * weight * duration;
                //currentUser.CalorieBurned = caloriesBurned;
                MessageBox.Show($"Activity recorded!\nCalories Burned: {currentUser.GetTotalCaloriesBurned():F2} kcal", 
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // TODO: Create an Activity object and add to currentUser.Activities

                this.Close();
            } else
            {
                MessageBox.Show("Please enter valid numeric values for all fields.",
                        "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SetMETvalue(params object[] values)
        {
            cmbMET.Items.Clear();
            foreach (var value in values)
            {
                cmbMET.Items.Add(value.ToString());
            }

            if (cmbMET.Items.Count > 0) cmbMET.SelectedIndex = 0;
        }

        private string GetSelectedActivity()
        {
            if (rdoWalking.Checked) return "Walking";
            if (rdoSwimming.Checked) return "Swimming";
            if (rdoRunning.Checked) return "Running";
            if (rdoCycling.Checked) return "Cycling";
            if (rdoJumpRope.Checked) return "Jump Rope";
            if (rdoYoga.Checked) return "Yoga";
            return "Unknown";
        }

        private void rdoWalking_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoWalking.Checked)
            {
                SetMETvalue(2.5, 3.5, 4.3);
            }
        }

        private void rdoSwimming_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoSwimming.Checked)
            {
                SetMETvalue(5.8, 7.0, 8.3);
            }
        }

        private void rdoRunning_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoRunning.Checked)
            {
                SetMETvalue(7.0, 8.0, 9.8);
            }
        }

        private void rdoCycling_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCycling.Checked)
            {
                SetMETvalue(4.0, 6.8, 8.5);
            }
        }

        private void rdoJumpRope_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoJumpRope.Checked)
            {
                SetMETvalue(8.8, 10.0, 12.3);
            }
        }

        private void rdoYoga_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoYoga.Checked)
            {
                SetMETvalue(2.0, 3.0, 3.5);
            }
        }
    }
}
