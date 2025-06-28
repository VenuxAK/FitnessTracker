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
        // Instance of FitnessTracker to manage users and activities
        private FitnessTracker tracker;
        // Currently logged-in user
        private User currentUser;

        public MainForm(User user)
        {
            InitializeComponent();
            tracker = new FitnessTracker();
            currentUser = user;
        }

        // Handles form load event, checks user login and updates UI
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (currentUser == null)
            {
                // If no user, show login form and hide main form
                LoginForm loginForm = new LoginForm(tracker);
                loginForm.Show();
                this.Close();
                return;
            }

            // Update UI with user information
            RefreshUserStatus();
        }

        /// Updates all status labels on the main screen.
        private void RefreshUserStatus()
        {
            lblWelcomeUser.Text = $"Welcome, {currentUser.Username}";
            lblUserGoal.Text = $"Your Goal: {currentUser.CalorieGoal} kcal";
            lblUserBurnedCal.Text = $"Calories Burned: {currentUser.GetTotalCaloriesBurned():F2} kcal";
            lblUserGoalStatus.Text = currentUser.CalorieGoal > 0 ? $"Goal Status: {currentUser.GoalStatus()}" : "";
        }


        // Open the goal setting form and updates goal info after closing
        private void btnNavigateToSetGoal_Click(object sender, EventArgs e)
        {
            SettingGoalForm settingGoalForm = new SettingGoalForm(currentUser);
            settingGoalForm.ShowDialog();
            RefreshUserStatus();
        }

        // open the add activity form and updates calories burned after closing
        private void btnNavigateToAddActivity_Click(object sender, EventArgs e)
        {
            AddActivityForm addActivityForm = new AddActivityForm(currentUser);
            addActivityForm.ShowDialog();
            RefreshUserStatus();
        }

        // Open the progress summary form
        private void btnNavigateToViewProgressSummary_Click(object sender, EventArgs e)
        {
            ProgressSummaryForm progressSummaryForm = new ProgressSummaryForm(currentUser);
            progressSummaryForm.ShowDialog();
        }

        // Open the activity history form
        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            ActivityHistoryForm activityHistoryForm = new ActivityHistoryForm(currentUser);
            activityHistoryForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result.ToString() == "Yes")
            {
                tracker.Logout();
                this.Close();
                LoginForm loginForm = new LoginForm(tracker);
                loginForm.Show();
            }
        }
    }
}
