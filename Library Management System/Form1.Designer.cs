namespace Library_Management_System
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(418, 317);
            button1.Name = "button1";
            button1.Size = new Size(101, 36);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(185, 197);
            label1.Name = "label1";
            label1.Size = new Size(121, 23);
            label1.TabIndex = 1;
            label1.Text = "User Name :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(185, 260);
            label2.Name = "label2";
            label2.Size = new Size(109, 23);
            label2.TabIndex = 2;
            label2.Text = "Password :";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(344, 197);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 31);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(344, 252);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(175, 31);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.OIP;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(738, 531);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}