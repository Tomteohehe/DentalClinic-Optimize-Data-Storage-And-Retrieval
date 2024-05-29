namespace csdlnc
{
    partial class ThuocPanel
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
            textBox9 = new TextBox();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox9
            // 
            textBox9.Font = new Font("Segoe UI", 12F);
            textBox9.Location = new Point(44, 58);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(1446, 50);
            textBox9.TabIndex = 3;
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(44, 138);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1446, 986);
            dataGridView1.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1933, 258);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(464, 39);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1933, 374);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(464, 39);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1933, 484);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(464, 39);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(1933, 600);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(464, 39);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(1933, 706);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(464, 39);
            textBox5.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(1933, 816);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(464, 39);
            dateTimePicker1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1740, 261);
            label1.Name = "label1";
            label1.Size = new Size(125, 32);
            label1.TabIndex = 12;
            label1.Text = "Ten Thuoc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1740, 381);
            label2.Name = "label2";
            label2.Size = new Size(87, 32);
            label2.TabIndex = 13;
            label2.Text = "Don Vi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1740, 491);
            label3.Name = "label3";
            label3.Size = new Size(107, 32);
            label3.TabIndex = 14;
            label3.Text = "Chi Dinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1740, 607);
            label4.Name = "label4";
            label4.Size = new Size(153, 32);
            label4.TabIndex = 15;
            label4.Text = "So luong ton";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1740, 713);
            label5.Name = "label5";
            label5.Size = new Size(100, 32);
            label5.TabIndex = 16;
            label5.Text = "Don Gia";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1740, 823);
            label6.Name = "label6";
            label6.Size = new Size(159, 32);
            label6.TabIndex = 17;
            label6.Text = "Ngay het han";
            // 
            // button1
            // 
            button1.Location = new Point(1740, 938);
            button1.Name = "button1";
            button1.Size = new Size(316, 66);
            button1.TabIndex = 18;
            button1.Text = "Cap nhat";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(2091, 938);
            button3.Name = "button3";
            button3.Size = new Size(306, 66);
            button3.TabIndex = 19;
            button3.Text = "Xoa thuoc";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1740, 1042);
            button4.Name = "button4";
            button4.Size = new Size(657, 66);
            button4.TabIndex = 20;
            button4.Text = "Tao moi";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // ThuocPanel
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2564, 1238);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox9);
            Name = "ThuocPanel";
            Text = "Thuoc";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox9;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button3;
        private Button button4;
    }
}