namespace LP3_WinForms
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;

        
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button9 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button10 = new Button();
            CPUTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SpringGreen;
            label1.Location = new Point(38, 9);
            label1.Name = "label1";
            label1.Size = new Size(214, 45);
            label1.TabIndex = 0;
            label1.Text = "Player Wins: ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(475, 9);
            label2.Name = "label2";
            label2.Size = new Size(175, 45);
            label2.TabIndex = 1;
            label2.Text = "CPU Wins:";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(38, 109);
            button1.Name = "button1";
            button1.Size = new Size(200, 200);
            button1.TabIndex = 2;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(244, 109);
            button2.Name = "button2";
            button2.Size = new Size(200, 200);
            button2.TabIndex = 3;
            button2.Text = "?";
            button2.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.Location = new Point(450, 521);
            button9.Name = "button9";
            button9.Size = new Size(200, 200);
            button9.TabIndex = 10;
            button9.Text = "?";
            button9.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(450, 109);
            button3.Name = "button3";
            button3.Size = new Size(200, 200);
            button3.TabIndex = 13;
            button3.Text = "?";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(38, 315);
            button4.Name = "button4";
            button4.Size = new Size(200, 200);
            button4.TabIndex = 12;
            button4.Text = "?";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(244, 315);
            button5.Name = "button5";
            button5.Size = new Size(200, 200);
            button5.TabIndex = 11;
            button5.Text = "?";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(450, 315);
            button6.Name = "button6";
            button6.Size = new Size(200, 200);
            button6.TabIndex = 16;
            button6.Text = "?";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(38, 521);
            button7.Name = "button7";
            button7.Size = new Size(200, 200);
            button7.TabIndex = 15;
            button7.Text = "?";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.Location = new Point(244, 521);
            button8.Name = "button8";
            button8.Size = new Size(200, 200);
            button8.TabIndex = 14;
            button8.Text = "?";
            button8.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.ForeColor = Color.Blue;
            button10.Location = new Point(244, 751);
            button10.Name = "button10";
            button10.Size = new Size(200, 67);
            button10.TabIndex = 17;
            button10.Text = "Restart";
            button10.UseVisualStyleBackColor = true;
            // 
            // CPUTimer
            // 
            CPUTimer.Interval = 1000;
            CPUTimer.Tick += CPUmove;
            // 
            // Form1
            // 
            AccessibleName = "Tic Tac Toe";
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 844);
            Controls.Add(button10);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button9);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button9;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button10;
        private System.Windows.Forms.Timer CPUTimer;
    }
}
