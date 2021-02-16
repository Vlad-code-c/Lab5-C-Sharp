using System.ComponentModel;

namespace lab5
{
    partial class EditStudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.button1 = new System.Windows.Forms.Button();
            this.nota5 = new System.Windows.Forms.ComboBox();
            this.nota4 = new System.Windows.Forms.ComboBox();
            this.nota3 = new System.Windows.Forms.ComboBox();
            this.nota2 = new System.Windows.Forms.ComboBox();
            this.nota1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.anComboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.varstaNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.varstaNumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.button1.Location = new System.Drawing.Point(29, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 30);
            this.button1.TabIndex = 25;
            this.button1.Text = "Salveaza";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nota5
            // 
            this.nota5.AutoCompleteCustomSource.AddRange(new string[] {"1", "2", "3", "4"});
            this.nota5.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.nota5.FormattingEnabled = true;
            this.nota5.Items.AddRange(new object[] {"2", "3", "4", "5", "6", "7", "8", "9", "10"});
            this.nota5.Location = new System.Drawing.Point(264, 147);
            this.nota5.Name = "nota5";
            this.nota5.Size = new System.Drawing.Size(40, 28);
            this.nota5.TabIndex = 24;
            // 
            // nota4
            // 
            this.nota4.AutoCompleteCustomSource.AddRange(new string[] {"1", "2", "3", "4"});
            this.nota4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.nota4.FormattingEnabled = true;
            this.nota4.Items.AddRange(new object[] {"2", "3", "4", "5", "6", "7", "8", "9", "10"});
            this.nota4.Location = new System.Drawing.Point(218, 147);
            this.nota4.Name = "nota4";
            this.nota4.Size = new System.Drawing.Size(40, 28);
            this.nota4.TabIndex = 23;
            // 
            // nota3
            // 
            this.nota3.AutoCompleteCustomSource.AddRange(new string[] {"1", "2", "3", "4"});
            this.nota3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.nota3.FormattingEnabled = true;
            this.nota3.Items.AddRange(new object[] {"2", "3", "4", "5", "6", "7", "8", "9", "10"});
            this.nota3.Location = new System.Drawing.Point(172, 147);
            this.nota3.Name = "nota3";
            this.nota3.Size = new System.Drawing.Size(40, 28);
            this.nota3.TabIndex = 22;
            // 
            // nota2
            // 
            this.nota2.AutoCompleteCustomSource.AddRange(new string[] {"1", "2", "3", "4"});
            this.nota2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.nota2.FormattingEnabled = true;
            this.nota2.Items.AddRange(new object[] {"2", "3", "4", "5", "6", "7", "8", "9", "10"});
            this.nota2.Location = new System.Drawing.Point(126, 147);
            this.nota2.Name = "nota2";
            this.nota2.Size = new System.Drawing.Size(40, 28);
            this.nota2.TabIndex = 21;
            // 
            // nota1
            // 
            this.nota1.AutoCompleteCustomSource.AddRange(new string[] {"1", "2", "3", "4"});
            this.nota1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.nota1.FormattingEnabled = true;
            this.nota1.Items.AddRange(new object[] {"2", "3", "4", "5", "6", "7", "8", "9", "10"});
            this.nota1.Location = new System.Drawing.Point(80, 147);
            this.nota1.Name = "nota1";
            this.nota1.Size = new System.Drawing.Size(40, 28);
            this.nota1.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label4.Location = new System.Drawing.Point(29, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Note";
            // 
            // anComboBox1
            // 
            this.anComboBox1.AutoCompleteCustomSource.AddRange(new string[] {"1", "2", "3", "4"});
            this.anComboBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.anComboBox1.FormattingEnabled = true;
            this.anComboBox1.Items.AddRange(new object[] {"1", "2", "3", "4"});
            this.anComboBox1.Location = new System.Drawing.Point(89, 104);
            this.anComboBox1.Name = "anComboBox1";
            this.anComboBox1.Size = new System.Drawing.Size(100, 28);
            this.anComboBox1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label3.Location = new System.Drawing.Point(29, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "An";
            // 
            // varstaNumericUpDown1
            // 
            this.varstaNumericUpDown1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.varstaNumericUpDown1.Location = new System.Drawing.Point(89, 62);
            this.varstaNumericUpDown1.Name = "varstaNumericUpDown1";
            this.varstaNumericUpDown1.Size = new System.Drawing.Size(100, 26);
            this.varstaNumericUpDown1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label2.Location = new System.Drawing.Point(29, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Varsta";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.name.Location = new System.Drawing.Point(89, 23);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 26);
            this.name.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(29, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.button2.Location = new System.Drawing.Point(218, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 30);
            this.button2.TabIndex = 26;
            this.button2.Text = "Anuleaza";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EditStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 245);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nota5);
            this.Controls.Add(this.nota4);
            this.Controls.Add(this.nota3);
            this.Controls.Add(this.nota2);
            this.Controls.Add(this.nota1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.anComboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.varstaNumericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditStudentForm";
            this.Text = "Edit ";
            ((System.ComponentModel.ISupportInitialize) (this.varstaNumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox anComboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.ComboBox nota1;
        private System.Windows.Forms.ComboBox nota2;
        private System.Windows.Forms.ComboBox nota3;
        private System.Windows.Forms.ComboBox nota4;
        private System.Windows.Forms.ComboBox nota5;
        private System.Windows.Forms.NumericUpDown varstaNumericUpDown1;

        #endregion
    }
}