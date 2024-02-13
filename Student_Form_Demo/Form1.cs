using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using StudentForm;


namespace Student_Form_Demo
{
    public partial class frmStudentInfo : Form
    {
        public frmStudentInfo()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //get major from form
            string major = "TBD";
            if (rbIT.Checked) major = rbIT.Text;
            else if(rbProgramming.Checked) major = rbProgramming.Text;
            else if(rbWebDesign.Checked) major = rbWebDesign.Text;

            //Instantiate a student
            Student st = new Student(txbStudentID.Text, txbFirstName.Text, txBLastName.Text, major);

            //Set Student properties from form
            if(cbxCampus.SelectedItem != null) st.Campus = cbxCampus.SelectedItem.ToString();


            int count = 0;
            if (cbxCIS101.Checked) count++;
            if (cbxCIS102.Checked) count++;
            if (cbxCIS103.Checked) count++;
            if (cbxCIS104.Checked) count++;

            string[] courses = new string[count];
            int[] scores = new int[count];

            int index = 0;
            if (cbxCIS101.Checked)
            {
                courses[index] = cbxCIS101.Text;
                int.TryParse(txbScore1.Text, out scores[index++]);
            }
            if (cbxCIS102.Checked)
            {
                courses[index] = cbxCIS102.Text;
                int.TryParse(txbScore2.Text, out scores[index++]);
            }
            if (cbxCIS103.Checked)
            {
                courses[index] = cbxCIS103.Text;
                int.TryParse(txbScore3.Text, out scores[index++]);
            }
            if (cbxCIS104.Checked)
            {
                courses[index] = cbxCIS104.Text;
                int.TryParse(txbScore4.Text, out scores[index++]);
            }

            //Set new arrays into student object
           
            st.Courses = courses;
            st.Scores = scores;


            //Display to string in result textbox
            txbResults.Text = st.ToString();
        }

        private void llCengage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore", "http://www.course.com");
            llCengage.LinkVisited=true;

        }
    }
}
