namespace calculator
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Add = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            res = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.HotTrack;
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(168, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 31);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.HotTrack;
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(382, 103);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 31);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Add
            // 
            Add.BackColor = SystemColors.ActiveCaptionText;
            Add.ForeColor = SystemColors.ButtonHighlight;
            Add.Location = new Point(199, 170);
            Add.Name = "Add";
            Add.Size = new Size(79, 40);
            Add.TabIndex = 2;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(284, 170);
            button2.Name = "button2";
            button2.Size = new Size(79, 40);
            button2.TabIndex = 3;
            button2.Text = "SUB";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(382, 170);
            button3.Name = "button3";
            button3.Size = new Size(79, 40);
            button3.TabIndex = 4;
            button3.Text = "MUl";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaptionText;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(484, 170);
            button4.Name = "button4";
            button4.Size = new Size(79, 40);
            button4.TabIndex = 5;
            button4.Text = "DIV";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(127, 18);
            label1.Name = "label1";
            label1.Size = new Size(553, 44);
            label1.TabIndex = 6;
            label1.Text = "simple Calculator with c#";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(304, 292);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 7;
            // 
            // res
            // 
            res.AutoSize = true;
            res.Location = new Point(349, 261);
            res.Name = "res";
            res.Size = new Size(0, 25);
            res.TabIndex = 8;
            res.Click += label3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(207, 249);
            label3.Name = "label3";
            label3.Size = new Size(142, 33);
            label3.TabIndex = 9;
            label3.Text = "result :";
            label3.Click += label3_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Elephant", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(349, 245);
            label4.Name = "label4";
            label4.Size = new Size(0, 37);
            label4.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(res);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Add);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button Add;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
        private Label res;
        private Label label3;
        private Label label4;
    }
}
