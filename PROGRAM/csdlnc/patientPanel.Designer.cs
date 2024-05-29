namespace csdlnc
{
    partial class patientPanel
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
            button5 = new Button();
            label2 = new Label();
            label1 = new Label();
            button6 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Location = new Point(340, 6);
            button5.Name = "button5";
            button5.Size = new Size(124, 44);
            button5.TabIndex = 23;
            button5.Text = "logout";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 18);
            label2.Name = "label2";
            label2.Size = new Size(150, 32);
            label2.TabIndex = 22;
            label2.Text = "Logged in as";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 64);
            label1.Name = "label1";
            label1.Size = new Size(120, 50);
            label1.TabIndex = 21;
            label1.Text = "label1";
            // 
            // button6
            // 
            button6.Location = new Point(12, 187);
            button6.Name = "button6";
            button6.Size = new Size(452, 114);
            button6.TabIndex = 20;
            button6.Text = "Lich hen";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 427);
            button4.Name = "button4";
            button4.Size = new Size(452, 114);
            button4.TabIndex = 19;
            button4.Text = "Chi tiet thanh toan";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 550);
            button2.Name = "button2";
            button2.Size = new Size(452, 114);
            button2.TabIndex = 18;
            button2.Text = "Ke hoach dieu tri";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 307);
            button1.Name = "button1";
            button1.Size = new Size(452, 114);
            button1.TabIndex = 17;
            button1.Text = "Xem ho so";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // patientPanel
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 792);
            Controls.Add(button5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "patientPanel";
            Text = "patientPanel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private Label label2;
        private Label label1;
        private Button button6;
        private Button button4;
        private Button button2;
        private Button button1;
    }
}