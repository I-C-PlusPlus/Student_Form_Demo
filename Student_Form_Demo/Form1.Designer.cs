namespace Student_Form_Demo
{
    partial class frmStudentInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txbStudentID = new System.Windows.Forms.TextBox();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.txBLastName = new System.Windows.Forms.TextBox();
            this.gbMajor = new System.Windows.Forms.GroupBox();
            this.rbProgramming = new System.Windows.Forms.RadioButton();
            this.rbWebDesign = new System.Windows.Forms.RadioButton();
            this.rbIT = new System.Windows.Forms.RadioButton();
            this.lblCourses = new System.Windows.Forms.Label();
            this.lblScores = new System.Windows.Forms.Label();
            this.cbxCIS101 = new System.Windows.Forms.CheckBox();
            this.cbxCIS102 = new System.Windows.Forms.CheckBox();
            this.cbxCIS103 = new System.Windows.Forms.CheckBox();
            this.txbScore1 = new System.Windows.Forms.TextBox();
            this.txbScore2 = new System.Windows.Forms.TextBox();
            this.txbScore3 = new System.Windows.Forms.TextBox();
            this.cbxCIS104 = new System.Windows.Forms.CheckBox();
            this.txbScore4 = new System.Windows.Forms.TextBox();
            this.txbResults = new System.Windows.Forms.TextBox();
            this.llCengage = new System.Windows.Forms.LinkLabel();
            this.pbSubmitButton = new System.Windows.Forms.PictureBox();
            this.cbxCampus = new System.Windows.Forms.ComboBox();
            this.lblCampus = new System.Windows.Forms.Label();
            this.gbMajor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubmitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(60, 64);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(68, 16);
            this.lblStudentID.TabIndex = 0;
            this.lblStudentID.Text = "Student ID";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(60, 94);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(72, 16);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(60, 125);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(72, 16);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // txbStudentID
            // 
            this.txbStudentID.Location = new System.Drawing.Point(189, 64);
            this.txbStudentID.Name = "txbStudentID";
            this.txbStudentID.Size = new System.Drawing.Size(229, 22);
            this.txbStudentID.TabIndex = 3;
            // 
            // txbFirstName
            // 
            this.txbFirstName.Location = new System.Drawing.Point(189, 94);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(229, 22);
            this.txbFirstName.TabIndex = 4;
            // 
            // txBLastName
            // 
            this.txBLastName.Location = new System.Drawing.Point(189, 125);
            this.txBLastName.Name = "txBLastName";
            this.txBLastName.Size = new System.Drawing.Size(229, 22);
            this.txBLastName.TabIndex = 5;
            // 
            // gbMajor
            // 
            this.gbMajor.Controls.Add(this.rbIT);
            this.gbMajor.Controls.Add(this.rbWebDesign);
            this.gbMajor.Controls.Add(this.rbProgramming);
            this.gbMajor.Location = new System.Drawing.Point(212, 153);
            this.gbMajor.Name = "gbMajor";
            this.gbMajor.Size = new System.Drawing.Size(150, 110);
            this.gbMajor.TabIndex = 6;
            this.gbMajor.TabStop = false;
            this.gbMajor.Text = "Major";
            // 
            // rbProgramming
            // 
            this.rbProgramming.AutoSize = true;
            this.rbProgramming.Location = new System.Drawing.Point(7, 22);
            this.rbProgramming.Name = "rbProgramming";
            this.rbProgramming.Size = new System.Drawing.Size(109, 20);
            this.rbProgramming.TabIndex = 0;
            this.rbProgramming.TabStop = true;
            this.rbProgramming.Text = "Programming";
            this.rbProgramming.UseVisualStyleBackColor = true;
            // 
            // rbWebDesign
            // 
            this.rbWebDesign.AutoSize = true;
            this.rbWebDesign.Location = new System.Drawing.Point(7, 49);
            this.rbWebDesign.Name = "rbWebDesign";
            this.rbWebDesign.Size = new System.Drawing.Size(103, 20);
            this.rbWebDesign.TabIndex = 1;
            this.rbWebDesign.TabStop = true;
            this.rbWebDesign.Text = "Web Design";
            this.rbWebDesign.UseVisualStyleBackColor = true;
            // 
            // rbIT
            // 
            this.rbIT.AutoSize = true;
            this.rbIT.Location = new System.Drawing.Point(7, 76);
            this.rbIT.Name = "rbIT";
            this.rbIT.Size = new System.Drawing.Size(40, 20);
            this.rbIT.TabIndex = 2;
            this.rbIT.TabStop = true;
            this.rbIT.Text = "IT";
            this.rbIT.UseVisualStyleBackColor = true;
            // 
            // lblCourses
            // 
            this.lblCourses.AutoSize = true;
            this.lblCourses.Location = new System.Drawing.Point(149, 322);
            this.lblCourses.Name = "lblCourses";
            this.lblCourses.Size = new System.Drawing.Size(57, 16);
            this.lblCourses.TabIndex = 7;
            this.lblCourses.Text = "Courses";
            // 
            // lblScores
            // 
            this.lblScores.AutoSize = true;
            this.lblScores.Location = new System.Drawing.Point(393, 322);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(50, 16);
            this.lblScores.TabIndex = 8;
            this.lblScores.Text = "Scores";
            // 
            // cbxCIS101
            // 
            this.cbxCIS101.AutoSize = true;
            this.cbxCIS101.Location = new System.Drawing.Point(149, 352);
            this.cbxCIS101.Name = "cbxCIS101";
            this.cbxCIS101.Size = new System.Drawing.Size(71, 20);
            this.cbxCIS101.TabIndex = 9;
            this.cbxCIS101.Text = "CIS101";
            this.cbxCIS101.UseVisualStyleBackColor = true;
            // 
            // cbxCIS102
            // 
            this.cbxCIS102.AutoSize = true;
            this.cbxCIS102.Location = new System.Drawing.Point(149, 379);
            this.cbxCIS102.Name = "cbxCIS102";
            this.cbxCIS102.Size = new System.Drawing.Size(71, 20);
            this.cbxCIS102.TabIndex = 10;
            this.cbxCIS102.Text = "CIS102";
            this.cbxCIS102.UseVisualStyleBackColor = true;
            // 
            // cbxCIS103
            // 
            this.cbxCIS103.AutoSize = true;
            this.cbxCIS103.Location = new System.Drawing.Point(149, 406);
            this.cbxCIS103.Name = "cbxCIS103";
            this.cbxCIS103.Size = new System.Drawing.Size(71, 20);
            this.cbxCIS103.TabIndex = 11;
            this.cbxCIS103.Text = "CIS103";
            this.cbxCIS103.UseVisualStyleBackColor = true;
            // 
            // txbScore1
            // 
            this.txbScore1.Location = new System.Drawing.Point(343, 350);
            this.txbScore1.Name = "txbScore1";
            this.txbScore1.Size = new System.Drawing.Size(100, 22);
            this.txbScore1.TabIndex = 12;
            // 
            // txbScore2
            // 
            this.txbScore2.Location = new System.Drawing.Point(343, 377);
            this.txbScore2.Name = "txbScore2";
            this.txbScore2.Size = new System.Drawing.Size(100, 22);
            this.txbScore2.TabIndex = 13;
            // 
            // txbScore3
            // 
            this.txbScore3.Location = new System.Drawing.Point(343, 406);
            this.txbScore3.Name = "txbScore3";
            this.txbScore3.Size = new System.Drawing.Size(100, 22);
            this.txbScore3.TabIndex = 14;
            // 
            // cbxCIS104
            // 
            this.cbxCIS104.AutoSize = true;
            this.cbxCIS104.Location = new System.Drawing.Point(149, 433);
            this.cbxCIS104.Name = "cbxCIS104";
            this.cbxCIS104.Size = new System.Drawing.Size(71, 20);
            this.cbxCIS104.TabIndex = 15;
            this.cbxCIS104.Text = "CIS104";
            this.cbxCIS104.UseVisualStyleBackColor = true;
            // 
            // txbScore4
            // 
            this.txbScore4.Location = new System.Drawing.Point(343, 435);
            this.txbScore4.Name = "txbScore4";
            this.txbScore4.Size = new System.Drawing.Size(100, 22);
            this.txbScore4.TabIndex = 16;
            // 
            // txbResults
            // 
            this.txbResults.Location = new System.Drawing.Point(110, 538);
            this.txbResults.Multiline = true;
            this.txbResults.Name = "txbResults";
            this.txbResults.ReadOnly = true;
            this.txbResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbResults.Size = new System.Drawing.Size(354, 102);
            this.txbResults.TabIndex = 18;
            // 
            // llCengage
            // 
            this.llCengage.AutoSize = true;
            this.llCengage.Location = new System.Drawing.Point(225, 647);
            this.llCengage.Name = "llCengage";
            this.llCengage.Size = new System.Drawing.Size(91, 16);
            this.llCengage.TabIndex = 19;
            this.llCengage.TabStop = true;
            this.llCengage.Text = "Visit Cengage";
            this.llCengage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llCengage_LinkClicked);
            // 
            // pbSubmitButton
            // 
            this.pbSubmitButton.Image = global::Student_Form_Demo.Properties.Resources.SubmitButton;
            this.pbSubmitButton.Location = new System.Drawing.Point(177, 464);
            this.pbSubmitButton.Name = "pbSubmitButton";
            this.pbSubmitButton.Size = new System.Drawing.Size(207, 68);
            this.pbSubmitButton.TabIndex = 20;
            this.pbSubmitButton.TabStop = false;
            this.pbSubmitButton.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cbxCampus
            // 
            this.cbxCampus.FormattingEnabled = true;
            this.cbxCampus.Items.AddRange(new object[] {
            "Main",
            "Montoya",
            "Rio Rancho"});
            this.cbxCampus.Location = new System.Drawing.Point(212, 276);
            this.cbxCampus.Name = "cbxCampus";
            this.cbxCampus.Size = new System.Drawing.Size(217, 24);
            this.cbxCampus.TabIndex = 21;
            this.cbxCampus.Text = "Please select a campus.";
            // 
            // lblCampus
            // 
            this.lblCampus.AutoSize = true;
            this.lblCampus.Location = new System.Drawing.Point(149, 276);
            this.lblCampus.Name = "lblCampus";
            this.lblCampus.Size = new System.Drawing.Size(57, 16);
            this.lblCampus.TabIndex = 22;
            this.lblCampus.Text = "Campus";
            // 
            // frmStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 758);
            this.Controls.Add(this.lblCampus);
            this.Controls.Add(this.cbxCampus);
            this.Controls.Add(this.pbSubmitButton);
            this.Controls.Add(this.llCengage);
            this.Controls.Add(this.txbResults);
            this.Controls.Add(this.txbScore4);
            this.Controls.Add(this.cbxCIS104);
            this.Controls.Add(this.txbScore3);
            this.Controls.Add(this.txbScore2);
            this.Controls.Add(this.txbScore1);
            this.Controls.Add(this.cbxCIS103);
            this.Controls.Add(this.cbxCIS102);
            this.Controls.Add(this.cbxCIS101);
            this.Controls.Add(this.lblScores);
            this.Controls.Add(this.lblCourses);
            this.Controls.Add(this.gbMajor);
            this.Controls.Add(this.txBLastName);
            this.Controls.Add(this.txbFirstName);
            this.Controls.Add(this.txbStudentID);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblStudentID);
            this.Name = "frmStudentInfo";
            this.Text = "Student Info";
            this.gbMajor.ResumeLayout(false);
            this.gbMajor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubmitButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txbStudentID;
        private System.Windows.Forms.TextBox txbFirstName;
        private System.Windows.Forms.TextBox txBLastName;
        private System.Windows.Forms.GroupBox gbMajor;
        private System.Windows.Forms.RadioButton rbIT;
        private System.Windows.Forms.RadioButton rbWebDesign;
        private System.Windows.Forms.RadioButton rbProgramming;
        private System.Windows.Forms.Label lblCourses;
        private System.Windows.Forms.Label lblScores;
        private System.Windows.Forms.CheckBox cbxCIS101;
        private System.Windows.Forms.CheckBox cbxCIS102;
        private System.Windows.Forms.CheckBox cbxCIS103;
        private System.Windows.Forms.TextBox txbScore1;
        private System.Windows.Forms.TextBox txbScore2;
        private System.Windows.Forms.TextBox txbScore3;
        private System.Windows.Forms.CheckBox cbxCIS104;
        private System.Windows.Forms.TextBox txbScore4;
        private System.Windows.Forms.TextBox txbResults;
        private System.Windows.Forms.LinkLabel llCengage;
        private System.Windows.Forms.PictureBox pbSubmitButton;
        private System.Windows.Forms.ComboBox cbxCampus;
        private System.Windows.Forms.Label lblCampus;
    }
}

