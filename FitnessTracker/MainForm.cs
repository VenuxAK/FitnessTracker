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

        public MainForm(User user)
        {
            InitializeComponent();
            tracker = new FitnessTracker();
            //this.tracker = fitnessTracker;
            //User? currentUserTemp = fitnessTracker.CurrentUser;
            currentUser = user;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (currentUser == null)
            {
                LoginForm loginForm = new LoginForm(tracker);
                loginForm.ShowDialog();
                this.Hide();
                return;
            }

            lblWelcomeUser.Text = $"Welcome, {currentUser.Username}";
            lblUserGoal.Text = $"Your Goal: {currentUser.CalorieGoal} kcal";
            lblUserBurnedCal.Text = $"Calories Burned: {currentUser.CalorieBurned:F2} kcal";
            lblUserGoalStatus.Text = currentUser.CalorieGoal > 0 ? $"Goal Status: {currentUser.GoalStatus()}" : "";

        }

        private void btnNavigateToSetGoal_Click(object sender, EventArgs e)
        {
            SettingGoalForm settingGoalForm = new SettingGoalForm(currentUser);
            settingGoalForm.ShowDialog();

            lblUserGoal.Text = $"Your Goal: {currentUser.CalorieGoal} kcal";
            lblUserGoalStatus.Text = currentUser.CalorieGoal > 0 ? $"Goal Status: {currentUser.GoalStatus()}" : "";
        }

        private void btnNavigateToAddActivity_Click(object sender, EventArgs e)
        {
            AddActivityForm addActivityForm = new AddActivityForm(currentUser);
            addActivityForm.ShowDialog();

            lblUserBurnedCal.Text = $"Calories Burned: {currentUser.GetTotalCaloriesBurned():F2} kcal";
            lblUserGoalStatus.Text = currentUser.CalorieGoal > 0 ? $"Goal Status: {currentUser.GoalStatus()}" : "";
        }

        private void btnNavigateToViewProgressSummary_Click(object sender, EventArgs e)
        {
            ProgressSummaryForm progressSummaryForm = new ProgressSummaryForm(currentUser);
            progressSummaryForm.ShowDialog();
        }

        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            ActivityHistoryForm activityHistoryForm = new ActivityHistoryForm(currentUser);
            activityHistoryForm.ShowDialog();
        }
    }
}
