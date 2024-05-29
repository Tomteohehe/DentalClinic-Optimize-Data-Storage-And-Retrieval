namespace csdlnc
{
    partial class rangdt
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
            button3 = new Button();
            label12 = new Label();
            comboBox8 = new ComboBox();
            label11 = new Label();
            comboBox7 = new ComboBox();
            label10 = new Label();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(163, 567);
            button3.Name = "button3";
            button3.Size = new Size(687, 46);
            button3.TabIndex = 72;
            button3.Text = "Tao";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(172, 436);
            label12.Name = "label12";
            label12.Size = new Size(111, 32);
            label12.TabIndex = 71;
            label12.Text = "Mat rang";
            // 
            // comboBox8
            // 
            comboBox8.FormattingEnabled = true;
            comboBox8.Location = new Point(424, 436);
            comboBox8.Name = "comboBox8";
            comboBox8.Size = new Size(426, 40);
            comboBox8.TabIndex = 70;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(172, 322);
            label11.Name = "label11";
            label11.Size = new Size(68, 32);
            label11.TabIndex = 69;
            label11.Text = "Rang";
            // 
            // comboBox7
            // 
            comboBox7.FormattingEnabled = true;
            comboBox7.Location = new Point(424, 322);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(426, 40);
            comboBox7.TabIndex = 68;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(172, 216);
            label10.Name = "label10";
            label10.Size = new Size(141, 32);
            label10.TabIndex = 67;
            label10.Text = "ID ke hoach";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(424, 216);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(426, 44);
            textBox5.TabIndex = 73;
      
            // 
            // rangdt
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 858);
            Controls.Add(textBox5);
            Controls.Add(button3);
            Controls.Add(label12);
            Controls.Add(comboBox8);
            Controls.Add(label11);
            Controls.Add(comboBox7);
            Controls.Add(label10);
            Name = "rangdt";
            Text = "rangdt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Label label12;
        private ComboBox comboBox8;
        private Label label11;
        private ComboBox comboBox7;
        private Label label10;
        private TextBox textBox5;
    }
}