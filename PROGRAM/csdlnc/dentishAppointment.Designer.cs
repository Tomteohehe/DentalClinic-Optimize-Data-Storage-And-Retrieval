namespace csdlnc
{
    partial class dentishAppointment
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
            button2 = new Button();
            button1 = new Button();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(831, 101);
            button3.Name = "button3";
            button3.Size = new Size(166, 66);
            button3.TabIndex = 94;
            button3.Text = "Tao lich";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1175, 101);
            button2.Name = "button2";
            button2.Size = new Size(166, 66);
            button2.TabIndex = 93;
            button2.Text = "Xoa lich";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1003, 101);
            button1.Name = "button1";
            button1.Size = new Size(166, 66);
            button1.TabIndex = 92;
            button1.Text = "Sua lich";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(709, 43);
            label6.Name = "label6";
            label6.Size = new Size(116, 32);
            label6.TabIndex = 91;
            label6.Text = "Thoi Gian";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(831, 43);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(510, 39);
            dateTimePicker1.TabIndex = 85;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(669, 290);
            dataGridView1.TabIndex = 84;
            // 
            // dentishAppointment
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1352, 377);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Name = "dentishAppointment";
            Text = "dentishAppointment";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
    }
}