namespace csdlnc
{
    partial class thuocDT
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
            textBox5 = new TextBox();
            button3 = new Button();
            label12 = new Label();
            label11 = new Label();
            comboBox7 = new ComboBox();
            label10 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // textBox5
            // 
            textBox5.Location = new Point(460, 81);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(426, 44);
            textBox5.TabIndex = 80;
            // 
            // button3
            // 
            button3.Location = new Point(199, 432);
            button3.Name = "button3";
            button3.Size = new Size(687, 46);
            button3.TabIndex = 79;
            button3.Text = "Tao";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(208, 301);
            label12.Name = "label12";
            label12.Size = new Size(115, 32);
            label12.TabIndex = 78;
            label12.Text = "So Luong";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(208, 193);
            label11.Name = "label11";
            label11.Size = new Size(110, 32);
            label11.TabIndex = 76;
            label11.Text = "ID Thuoc";
            // 
            // comboBox7
            // 
            comboBox7.FormattingEnabled = true;
            comboBox7.Location = new Point(460, 193);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(426, 40);
            comboBox7.TabIndex = 75;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(208, 81);
            label10.Name = "label10";
            label10.Size = new Size(141, 32);
            label10.TabIndex = 74;
            label10.Text = "ID ke hoach";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(460, 298);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(426, 44);
            textBox1.TabIndex = 81;
            // 
            // thuocKH
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 572);
            Controls.Add(textBox1);
            Controls.Add(textBox5);
            Controls.Add(button3);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(comboBox7);
            Controls.Add(label10);
            Name = "thuocKH";
            Text = "thuocKH";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox5;
        private Button button3;
        private Label label12;
        private Label label11;
        private ComboBox comboBox7;
        private Label label10;
        private TextBox textBox1;
    }
}