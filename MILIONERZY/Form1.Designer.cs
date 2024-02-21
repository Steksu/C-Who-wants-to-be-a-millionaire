
namespace MILIONERZY
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
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            button5 = new System.Windows.Forms.Button();
            listBox1 = new System.Windows.Forms.ListBox();
            button6 = new System.Windows.Forms.Button();
            button7 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(143, 299);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(107, 50);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(387, 299);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(97, 50);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(143, 391);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(107, 47);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(387, 391);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(97, 47);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(143, 42);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(78, 32);
            label1.TabIndex = 5;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(679, 102);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(75, 60);
            button5.TabIndex = 7;
            button5.Text = "50/50";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "1000000", "500000", "250000", "125000", "75000", "40000", "20000", "10000", "5000", "2000", "1000", "500" });
            listBox1.Location = new System.Drawing.Point(906, 58);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(159, 364);
            listBox1.TabIndex = 8;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button6
            // 
            button6.Location = new System.Drawing.Point(679, 358);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(110, 44);
            button6.TabIndex = 9;
            button6.Text = "Zakończ grę";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new System.Drawing.Point(679, 179);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(75, 59);
            button7.TabIndex = 10;
            button7.Text = "widownia";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1093, 450);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(listBox1);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

