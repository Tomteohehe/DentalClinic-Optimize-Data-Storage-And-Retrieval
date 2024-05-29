namespace csdlnc
{
    partial class adminPanel
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button6 = new Button();
            label1 = new Label();
            label2 = new Label();
            button5 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(102, 644);
            button1.Name = "button1";
            button1.Size = new Size(452, 114);
            button1.TabIndex = 0;
            button1.Text = "Tao Lich Hen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(102, 284);
            button2.Name = "button2";
            button2.Size = new Size(452, 114);
            button2.TabIndex = 1;
            button2.Text = "Benh Nhan";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(102, 404);
            button3.Name = "button3";
            button3.Size = new Size(452, 114);
            button3.TabIndex = 2;
            button3.Text = "Bac si";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(102, 764);
            button4.Name = "button4";
            button4.Size = new Size(452, 114);
            button4.TabIndex = 3;
            button4.Text = "Dieu tri";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button6
            // 
            button6.Location = new Point(102, 524);
            button6.Name = "button6";
            button6.Size = new Size(452, 114);
            button6.TabIndex = 5;
            button6.Text = "Nhan vien";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(275, 149);
            label1.Name = "label1";
            label1.Size = new Size(120, 50);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(259, 73);
            label2.Name = "label2";
            label2.Size = new Size(150, 32);
            label2.TabIndex = 7;
            label2.Text = "Logged in as";
            // 
            // button5
            // 
            button5.Location = new Point(518, 12);
            button5.Name = "button5";
            button5.Size = new Size(124, 44);
            button5.TabIndex = 8;
            button5.Text = "logout";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // button7
            // 
            button7.Location = new Point(102, 884);
            button7.Name = "button7";
            button7.Size = new Size(452, 114);
            button7.TabIndex = 9;
            button7.Text = "Thuoc";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // adminPanel
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 1050);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "adminPanel";
            Text = "receptionistPanel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button6;
        private Label label1;
        private Label label2;
        private Button button5;
        private Button button7;
    }
}