namespace IWSK_Project
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            button1 = new Button();
            label5 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            label7 = new Label();
            richTextBox1 = new RichTextBox();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 16);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 0;
            label1.Text = "Port:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 40);
            label2.Name = "label2";
            label2.Size = new Size(151, 15);
            label2.TabIndex = 1;
            label2.Text = "Szybkość transmisji [bit/s]]:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 68);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 2;
            label3.Text = "Format znaku:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 97);
            label4.Name = "label4";
            label4.Size = new Size(112, 15);
            label4.TabIndex = 3;
            label4.Text = "Kontrola przepływu:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(160, 14);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(154, 23);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(160, 65);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(154, 23);
            comboBox2.TabIndex = 5;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(160, 91);
            comboBox3.Margin = new Padding(3, 2, 3, 2);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(154, 23);
            comboBox3.TabIndex = 6;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(160, 40);
            comboBox4.Margin = new Padding(3, 2, 3, 2);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(154, 23);
            comboBox4.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(5, 212);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(109, 34);
            button1.TabIndex = 8;
            button1.Text = "Połącz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 126);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 9;
            label5.Text = "Terminator:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(160, 118);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(154, 23);
            textBox1.TabIndex = 10;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 150);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 11;
            label6.Text = "Wiadomość:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(160, 142);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(154, 23);
            textBox2.TabIndex = 12;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.GrayText;
            button2.Location = new Point(120, 212);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(99, 34);
            button2.TabIndex = 13;
            button2.TabStop = false;
            button2.Text = "Rozłącz";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(224, 212);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(89, 34);
            button3.TabIndex = 14;
            button3.Text = "Ping";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(326, 16);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 15;
            label7.Text = "Terminal:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(326, 34);
            richTextBox1.Margin = new Padding(3, 2, 3, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(364, 214);
            richTextBox1.TabIndex = 16;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // button4
            // 
            button4.Location = new Point(5, 174);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(309, 34);
            button4.TabIndex = 17;
            button4.Text = "Wyślij";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 263);
            Controls.Add(button4);
            Controls.Add(richTextBox1);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new Size(716, 302);
            MinimumSize = new Size(716, 302);
            Name = "Form1";
            Text = "IWSK Projekt Sekcja 4 KTW";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Button button1;
        private Label label5;
        private TextBox textBox1;
        private Label label6;
        private TextBox textBox2;
        private Button button2;
        private Button button3;
        private Label label7;
        private RichTextBox richTextBox1;
        private Button button4;
    }
}
