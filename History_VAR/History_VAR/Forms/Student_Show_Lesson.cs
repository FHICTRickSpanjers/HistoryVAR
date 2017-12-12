﻿using History_VAR.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace History_VAR.Forms
{
    public partial class Student_Show_Lesson : Form
    {
        private string Lesson_name;
        private string current_user;

        public Student_Show_Lesson(string lesson_name, string username)
        {
            InitializeComponent();
            this.Lesson_name = lesson_name;
            this.current_user = username;
            SetLessonData();
        }


        public void SetLessonData()
        {
            LBL_Lesson_Title.Text = Lesson_name;
            DBRepository DB = DBRepository.GetInstance();
            var Lessons = DB.Get_Lessons_Data();

            foreach(var single_lesson in Lessons)
            {
                if (single_lesson.GetLessonName() == Lesson_name)
                {
                    TB_Lesson_Desc.Text = single_lesson.GetLessonDesc();
                    LBL_Lesson_Subject.Text = single_lesson.GetLessonSubject();
                }
            }

        }


        private void Download_OBJ_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Sscreen = new Student_Screen(current_user);
            Sscreen.Closed += (s, args) => this.Close();
            Sscreen.Show();
        }
    }
}