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
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnViewTeacher_Click(object sender, EventArgs e)
        {
            teacherData1.Visible = true;
            studentData1.Visible = false;
            adminData1.Visible = false;
            allUsers1.Visible = false;
        }

        private void btnViewStudent_Click(object sender, EventArgs e)
        {
            studentData1.Visible = true;
            teacherData1.Visible = false;
            adminData1.Visible = false;
            allUsers1.Visible = false;
        }

        private void btnViewAdmin_Click(object sender, EventArgs e)
        {
            adminData1.Visible = true;
            teacherData1.Visible = false;
            studentData1.Visible = false;
            allUsers1.Visible = false;
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            allUsers1.Visible = true;
            teacherData1.Visible = false;
            studentData1.Visible = false;
            adminData1.Visible = false;
        }
    }
}
