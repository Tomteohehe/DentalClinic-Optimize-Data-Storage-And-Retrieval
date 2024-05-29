namespace csdlnc
{
    partial class dentisPanel
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
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Location = new Point(507, 98);
            button5.Name = "button5";
            button5.Size = new Size(124, 44);
            button5.TabIndex = 16;
            button5.Text = "logout";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(248, 159);
            label2.Name = "label2";
            label2.Size = new Size(150, 32);
            label2.TabIndex = 15;
            label2.Text = "Logged in as";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(264, 235);
            label1.Name = "label1";
            label1.Size = new Size(120, 50);
            label1.TabIndex = 14;
            label1.Text = "label1";
            // 
            // button4
            // 
            button4.Location = new Point(91, 730);
            button4.Name = "button4";
            button4.Size = new Size(452, 114);
            button4.TabIndex = 12;
            button4.Text = "Dieu tri";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(91, 370);
            button2.Name = "button2";
            button2.Size = new Size(452, 114);
            button2.TabIndex = 10;
            button2.Text = "Benh Nhan";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(91, 610);
            button1.Name = "button1";
            button1.Size = new Size(452, 114);
            button1.TabIndex = 9;
            button1.Text = "Lich Hen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button6
            // 
            button6.Location = new Point(91, 490);
            button6.Name = "button6";
            button6.Size = new Size(452, 114);
            button6.TabIndex = 13;
            button6.Text = "Lich Ca Nhan";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // dentisPanel
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 1062);
            Controls.Add(button5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "dentisPanel";
            Text = "dentisPanel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private Label label2;
        private Label label1;
        private Button button4;
        private Button button2;
        private Button button1;
        private Button button6;
    }
}