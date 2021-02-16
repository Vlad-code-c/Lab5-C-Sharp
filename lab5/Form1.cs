using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            Student.deserializeAll();
            refreshList();
            
        }

        #region ClickEvents
        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student(name.Text, Convert.ToInt32(varstaNumericUpDown1.Text), Convert.ToInt32(anComboBox1.Text), 
                new int[]{
                    Convert.ToInt32(nota1.Text == "" ? "1" : nota1.Text), 
                    Convert.ToInt32(nota2.Text == "" ? "1" : nota2.Text), 
                    Convert.ToInt32(nota3.Text == "" ? "1" : nota3.Text), 
                    Convert.ToInt32(nota4.Text == "" ? "1" : nota4.Text), 
                    Convert.ToInt32(nota5.Text == "" ? "1" : nota5.Text)});

            listBox1.Items.Add(student.ToString());
            
            
            new Thread(() =>
            {
                Student.serializeAll();
            }).Start();
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student.bubleSortByName();
            Student.Students.Reverse();
            
            refreshList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Student.bubleSortByMedie();
            Student.Students.Reverse();
            
            refreshList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (anSearch.Text == "")
            {
                anSearch.Text = "1";
            }
            
            int year = Convert.ToInt32(anSearch.Text);
            customRefreshList(Student.getStudentsFromYear(year));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string name = nameSearch.Text;
            customRefreshList(Student.getStudentsByName(name));
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;
            Student.deleteBySelectedIndex(selectedIndex);
            
            
            refreshList();
        }
        
        
        private void editButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                EditStudentForm esf = new EditStudentForm();
                esf.init((Student.customStudents != null ? Student.customStudents[listBox1.SelectedIndex] : Student.Students[listBox1.SelectedIndex]), listBox1.SelectedIndex);
                esf.Closing += (o, args) => refreshList();
                esf.ShowDialog();
            }
        }
        
        #endregion


        #region EditStudent
        public static void saveStudent(Student student, int index)
        {
            Student.updateStudent(student, index);
        }

        
        #endregion

        #region Refresh
        public void refreshList()
        {
            Student.customStudents = null;
            
            listBox1.Items.Clear();

            
            foreach (Student student in Student.Students)
            {
                listBox1.Items.Add(student);
            }
        }

        public void customRefreshList(List<Student> students)
        {
            Student.customStudents = students;
            
            listBox1.Items.Clear();

            
            foreach (Student student in students)
            {
                listBox1.Items.Add(student);
            }
        }
        #endregion

       
    }
}