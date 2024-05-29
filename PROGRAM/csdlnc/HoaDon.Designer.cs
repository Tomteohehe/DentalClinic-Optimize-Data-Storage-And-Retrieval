namespace csdlnc
{
    partial class HoaDon
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(93, 603);
            label5.Name = "label5";
            label5.Size = new Size(100, 32);
            label5.TabIndex = 29;
            label5.Text = "Don Gia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(93, 497);
            label4.Name = "label4";
            label4.Size = new Size(96, 32);
            label4.TabIndex = 28;
            label4.Text = "Ghi chu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 381);
            label3.Name = "label3";
            label3.Size = new Size(181, 32);
            label3.TabIndex = 27;
            label3.Text = "Loai thanh toan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 271);
            label2.Name = "label2";
            label2.Size = new Size(212, 32);
            label2.TabIndex = 26;
            label2.Text = "Nguoi Thanh Toan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 151);
            label1.Name = "label1";
            label1.Size = new Size(109, 32);
            label1.TabIndex = 25;
            label1.Text = "ID Ho So";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(358, 596);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(392, 39);
            textBox5.TabIndex = 23;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(358, 490);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(392, 39);
            textBox4.TabIndex = 22;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(358, 374);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(392, 39);
            textBox3.TabIndex = 21;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(358, 264);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(392, 39);
            textBox2.TabIndex = 20;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(358, 148);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(392, 39);
            textBox1.TabIndex = 19;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // HoaDon
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 1084);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "HoaDon";
            Text = "HoaDon";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}