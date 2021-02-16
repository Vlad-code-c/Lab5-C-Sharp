using System;
using System.Windows.Forms;

namespace lab5
{
    public partial class PushNotification : Form
    {


        public static int CurrentFormCount = 0;
        public static int MaxFormCount = 5;
        
        public PushNotification()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setError(string text)
        {
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            this.label1.Text = text;

            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))));

        }

        public void setSucces(string text)
        {
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (255)))), ((int) (((byte) (192)))));
            this.label1.Text = text;

            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (255)))), ((int) (((byte) (192)))));

        }


        public void showPushNotification()
        {
            
            Timer timer = new Timer();
            timer.Interval = 3000;
            timer.Tick += new EventHandler(closePushNotification);


            if (CurrentFormCount <= MaxFormCount)
            {
                this.Show();
                CurrentFormCount++;
            }
            timer.Start();
        }

        public void closePushNotification(object sender, EventArgs e)
        {
            CurrentFormCount--;
            this.Close();
        }
    }
}