using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_project_sad_shit
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }
        /*private void viewAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open ViewAccountDetailsForm in a new window
            TaskAssignmentForm viewAccount = new TaskAssignmentForm();
            viewAccount.Show(); // Opens the form as a separate window
        }

        private void updateProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open UpdateProfileForm in a new window
            RequestVolunteersForm updateProfile = new RequestVolunteersForm();
            updateProfile.Show(); // Opens the form as a separate window
        }

        private void changePrivacySettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open PrivacySettingsForm in a new window
            RequestDonation privacySettings = new RequestDonation();
            privacySettings.Show(); // Opens the form as a separate window
        }*/


        private void button1_Click(object sender, EventArgs e)
        {
            // Open ViewAccountDetailsForm in a new window
            TaskAssignmentForm viewAccount = new TaskAssignmentForm();
            viewAccount.Show(); // Opens the form as a separate window
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Open PrivacySettingsForm in a new window
            RequestDonation privacySettings = new RequestDonation();
            privacySettings.Show(); // Opens the form as a separate window
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Open UpdateProfileForm in a new window
            RequestVolunteersForm updateProfile = new RequestVolunteersForm();
            updateProfile.Show(); // Opens the form as a separate window
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Open PrivacySettingsForm in a new window
            CreateProject createProject = new CreateProject();
            createProject.Show(); // Opens the form as a separate window
        }
    }
}
