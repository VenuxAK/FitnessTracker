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
    public partial class ProgressSummaryForm : Form
    {
        private readonly User currentUser;
        public ProgressSummaryForm(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void ProgressSummaryForm_Load(object sender, EventArgs e)
        {
            double goal = currentUser.CalorieGoal;
            double totalBurnedCalories = currentUser.GetTotalCaloriesBurned();

            lblGoal.Text = $"{goal} kcal";
            lblTotalBurned.Text = $"{totalBurnedCalories:F2} kcal";

            if (goal > 0)
            {
                int progressPercent = (int)Math.Min((totalBurnedCalories / goal) * 100, 100);
                progressBar.Value = progressPercent;
            }
            
            if(totalBurnedCalories >= goal)
            {
                lblStatus.Text = "✅ Goal Achieved!";
                lblStatus.ForeColor = Color.Green;
                
            } else
            {
                lblStatus.Text = "❌ Goal Not Reached Yet";
                lblStatus.ForeColor = Color.Black;
            }

            if (totalBurnedCalories == 0 || totalBurnedCalories == 0.00)
            {
                lblStatus.Text = "Start your activity to view status";
                lblStatus.ForeColor = Color.Black;
            }
        }

    }
}
