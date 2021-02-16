using System;
using System.Windows.Forms;

namespace lab5
{
    public partial class EditStudentForm : Form
    {

        private int index;
        
        public EditStudentForm()
        {
            InitializeComponent();
        }


        public void init(Student student, int index)
        {
            this.name.Text = student.Nume;
            this.varstaNumericUpDown1.Text = student.Varsta.ToString();
            this.anComboBox1.Text = student.An.ToString();

            if (student.Note.Length != 5)
            {
                return;
            }

            nota1.Text = student.Note[0].ToString();
            nota2.Text = student.Note[1].ToString();
            nota3.Text = student.Note[2].ToString();
            nota4.Text = student.Note[3].ToString();
            nota5.Text = student.Note[4].ToString();


            this.index = index;
        }
        
        //Cancel
        private void button2_Click(object sender, EventArgs e)
        {
         this.Close();   
        }

        //Save
        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student(name.Text, 
                Convert.ToInt32(varstaNumericUpDown1.Text == "" ? "1" : varstaNumericUpDown1.Text), 
                Convert.ToInt32(anComboBox1.Text == "" ? "1" : anComboBox1.Text), 
                new []{Convert.ToInt32(nota1.Text == "" ? "1" : nota1.Text), 
                            Convert.ToInt32(nota2.Text == "" ? "1" : nota2.Text),
                            Convert.ToInt32(nota3.Text == "" ? "1" : nota3.Text),
                            Convert.ToInt32(nota4.Text == "" ? "1" : nota4.Text),
                            Convert.ToInt32(nota5.Text == "" ? "1" : nota5.Text)
                });
            
            
            Form1.saveStudent(student, index);
            this.Close();
        }
    }
}