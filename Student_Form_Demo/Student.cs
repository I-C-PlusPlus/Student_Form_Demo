﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentForm
{
    class Student
    {
        //-------------------------------------
        //Private Fields
        //-------------------------------------
        private int[] scores = new int[0];
        private string[] courses = new string[0];

        //-------------------------------------
        //Constructors
        //-------------------------------------

        //default constructor
        public Student()
            : this("Number Pending", "TBD", "TBD", "Undeclared")
        {
        }

        //single parameter constructor
        public Student(string sID)
            : this(sID, "TBD", "TBD", "Undeclared")
        {
        }

        //constructor when we have student ID information and major
        public Student(string sID, string firstName, string lastName, string maj)
        {
            
            StudentNumber = sID;
            FirstName = firstName;
            LastName = lastName;
            Major = maj;
        }

        //constructor when we have student information and score information
        public Student(string sID, string firstName, string lastName,
            int [] scores, string maj)
            : this(sID, firstName, lastName, maj)
        {
            this.scores = scores; 
            CalcAverage();
        }

        //-------------------------------------
        //Properties
        //-------------------------------------
        public string Major { get; set; }

        public int [] Scores
        {
            get
            {
                return scores;
            }
            set
            {
                scores = value;
                CalcAverage();
            }
        }

        public string[] Courses
        {
            get { return courses; }
            set { courses = value; }
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentNumber { get; set; }
        public double Average { get; private set; }
        public string Campus {  get; set; }

        //-------------------------------------
        //Instance Methods
        //------------------------------------
        private void CalcAverage()
        {
            int scoreTotal = 0;
            foreach (int score in scores)
            {
                scoreTotal += score;
            }
            if (scores.GetLength(0) != 0)
            {
                Average = scoreTotal / scores.GetLength(0);
            }
            else
            {
                Average = 0;
            }
        }

        public override string ToString()
        {
            string summary = 
                "Student's Major is " + Major +
                "\r\nStudent's First Name is " + FirstName +
                "\r\nStudent's Last Name is " + LastName +
                "\r\nStudent's Campus is " + Campus +
                "\r\nStudent's Average is " + Average +
                "\r\nCourses: ";
            foreach (string course in courses)
            {
                summary += "\r\n"+course;
            }
            return summary;
        }
    }
}
