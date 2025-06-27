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
    public partial class ActivityHistoryForm : Form
    {
        private User currentUser;
        public ActivityHistoryForm(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void ActivityHistoryForm_Load(object sender, EventArgs e)
        {
            foreach (Activity activity in currentUser.Activities)
            {
                dgvActivities.Rows.Add(
                    activity.Name,
                    activity.MET,
                    activity.Weight,
                    activity.DurationHours,
                    activity.CalculateCalories().ToString("F2"),
                    activity.Date.ToString("g")
                );
            }
        }
    }
}
