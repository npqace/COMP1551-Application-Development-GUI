using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMP1551_Coursework.Forms.User_Control;

namespace COMP1551_Coursework
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            // Subscribe to the PersonAdded event
            adminData1.PersonAdded += AdminData1_PersonAdded;
            studentData1.PersonAdded += StudentData1_PersonAdded;
            teacherData1.PersonAdded += TeacherData1_PersonAdded;

            // Subscribe to the PersonUpdate even
            adminData1.PersonUpdated += AdminData1_PersonUpdated;
            studentData1.PersonUpdated += StudentData1_PersonUpdated;
            teacherData1.PersonUpdated += TeacherData1_PersonUpdated;

            // Subscribe to the PersonDeleted event
            adminData1.PersonDeleted += AdminData1_PersonDeleted;
            studentData1.PersonDeleted += StudentData1_PersonDeleted;
            teacherData1.PersonDeleted += TeacherData1_PersonDeleted;

            // Initially hide all user controls
            HideAllUserControls();
            allUsers1.Visible = true; // Show the AllUsers user control by default when running the application   
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            // When click on the View All button, show the AllUsers user control
            HideAllUserControls();
            allUsers1.Visible = true;
        }

        private void btnViewAdmin_Click(object sender, EventArgs e)
        {
            // When click on the View Admin button, show the AdminData user control
            HideAllUserControls();
            adminData1.Visible = true;
        }

        private void btnViewTeacher_Click(object sender, EventArgs e)
        {
            // When click on the View Teacher button, show the TeacherData user control
            HideAllUserControls();
            teacherData1.Visible = true;
        }

        private void btnViewStudent_Click(object sender, EventArgs e)
        {
            // When click on the View Student button, show the StudentData user control
            HideAllUserControls();
            studentData1.Visible = true;
        }

        private void HideAllUserControls()
        {
            // Hide all user controls
            adminData1.Visible = false;
            studentData1.Visible = false;
            teacherData1.Visible = false;
            allUsers1.Visible = false;
        }

        private void AdminData1_PersonAdded(object sender, EventArgs e)
        {
            // Refresh the AllUsers user control
            allUsers1.RefreshData();
        }

        private void AdminData1_PersonUpdated(object sender, EventArgs e)
        {
            // Refresh the AllUsers user control
            allUsers1.RefreshData();
        }

        private void AdminData1_PersonDeleted(object sender, EventArgs e)
        {
            // Refresh the AllUsers user control
            allUsers1.RefreshData();
        }

        private void StudentData1_PersonAdded(object sender, EventArgs e)
        {
            // Refresh the AllUsers user control
            allUsers1.RefreshData();
        }

        private void StudentData1_PersonUpdated(object sender, EventArgs e)
        {
            // Refresh the AllUsers user control
            allUsers1.RefreshData();
        }

        private void StudentData1_PersonDeleted(object sender, EventArgs e)
        {
            // Refresh the AllUsers user control
            allUsers1.RefreshData();
        }

        private void TeacherData1_PersonAdded(object sender, EventArgs e)
        {
            // Refresh the AllUsers user control
            allUsers1.RefreshData();
        }

        private void TeacherData1_PersonUpdated(object sender, EventArgs e)
        {
            // Refresh the AllUsers user control
            allUsers1.RefreshData();
        }

        private void TeacherData1_PersonDeleted(object sender, EventArgs e)
        {
            // Refresh the AllUsers user control
            allUsers1.RefreshData();
        }        
    }
}
