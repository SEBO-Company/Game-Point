namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            label1 = new Label();
            button3 = new Button();
            textBox2 = new TextBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(45, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 23);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(102, 79);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Resim Seç";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(87, 108);
            button2.Name = "button2";
            button2.Size = new Size(104, 23);
            button2.TabIndex = 2;
            button2.Text = "Resmi Değiştir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(321, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(640, 420);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 321);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(151, 294);
            button3.Name = "button3";
            button3.Size = new Size(133, 23);
            button3.TabIndex = 5;
            button3.Text = "Seçilen Değeri Getir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(45, 295);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            // 
            // button4
            // 
            button4.Location = new Point(102, 424);
            button4.Name = "button4";
            button4.Size = new Size(119, 43);
            button4.TabIndex = 7;
            button4.Text = "Seçilen Değerin Resmini Yükle";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 543);
            Controls.Add(button4);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private Label label1;
        private Button button3;
        private TextBox textBox2;
        private Button button4;
    }
}
