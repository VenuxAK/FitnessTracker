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
        private string selectedActivity = "Walking";  // Holds the selected activity name

        // Dictionary mapping activity names to MET values.
        private readonly Dictionary<string, double[]> ActivityMET = new Dictionary<string, double[]>
        {
            { "Walking", new[] { 2.5, 3.5, 4.3 } },
            { "Swimming", new[] { 5.8, 7.0, 8.3 } },
            { "Running", new[] { 7.0, 8.0, 9.8 } },
            { "Cycling", new[] { 4.0, 6.8, 8.5 } },
            { "Jump Rope", new[] { 8.8, 10.0, 12.3 } },
            { "Yoga", new[] { 2.0, 3.0, 3.5 } }
        };

        public AddActivityForm(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void AddActivityForm_Load(object sender, EventArgs e)
        {

        }

        // Saves the selected activity to the user's activity list.
        private void btnSaveActivity_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtWeight.Text, out double weight) &&
                double.TryParse(txtDuration.Text, out double duration) &&
                double.TryParse(cmbMET.SelectedItem?.ToString(), out double met))
            {
                Activity activity = new Activity(selectedActivity, weight, duration, met);
                currentUser.Activities.Add(activity);

                MessageBox.Show($"Activity recorded!\nCalories Burned: {currentUser.GetTotalCaloriesBurned():F2} kcal",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter valid numeric values for all fields.",
                        "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void btnCancelActivity_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Fills the MET ComboBox with MET values for a selected activity
        private void SetMETvalue(params double[] values)
        {
            cmbMET.Items.Clear();
            foreach (var value in values)
            {
                cmbMET.Items.Add(value.ToString());
            }

            if (cmbMET.Items.Count > 0) cmbMET.SelectedIndex = 0;
        }

        // Updates the selectedActivity and sets the corresponding MET values.
        private void HandleActivitySelection(string activity)
        {
            if (ActivityMET.TryGetValue(activity, out double[] values))
            {
                SetMETvalue(values);
                selectedActivity = activity;
            }
        }

        // Each of the following handlers sets MET values using the dictionary
        private void rdoWalking_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoWalking.Checked) HandleActivitySelection("Walking");
        }

        private void rdoSwimming_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSwimming.Checked) HandleActivitySelection("Swimming");
        }

        private void rdoRunning_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoRunning.Checked) HandleActivitySelection("Running");
        }

        private void rdoCycling_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCycling.Checked) HandleActivitySelection("Cycling");
        }

        private void rdoJumpRope_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoJumpRope.Checked) HandleActivitySelection("Jump Rope");
        }

        private void rdoYoga_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoYoga.Checked) HandleActivitySelection("Yoga");
        }
    }
}
