using System;

namespace TextFilesAdvanced
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FirstNameBox1 = new System.Windows.Forms.TextBox();
            this.LastNameBox2 = new System.Windows.Forms.TextBox();
            this.AliveBox1 = new System.Windows.Forms.CheckBox();
            this.yearsNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.yearsNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Is Alive:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(35, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(340, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add User";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(35, 464);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(340, 54);
            this.button2.TabIndex = 5;
            this.button2.Text = "Save User";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(479, 45);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(413, 436);
            this.listBox1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(333, 39);
            this.label5.TabIndex = 7;
            this.label5.Text = "Text File Challenge";
            // 
            // FirstNameBox1
            // 
            this.FirstNameBox1.Location = new System.Drawing.Point(189, 113);
            this.FirstNameBox1.Name = "FirstNameBox1";
            this.FirstNameBox1.Size = new System.Drawing.Size(258, 22);
            this.FirstNameBox1.TabIndex = 8;
            this.FirstNameBox1.TextChanged += new System.EventHandler(this.FirstNameBox1_TextChanged);
            // 
            // LastNameBox2
            // 
            this.LastNameBox2.Location = new System.Drawing.Point(189, 174);
            this.LastNameBox2.Name = "LastNameBox2";
            this.LastNameBox2.Size = new System.Drawing.Size(258, 22);
            this.LastNameBox2.TabIndex = 9;
            // 
            // AliveBox1
            // 
            this.AliveBox1.AutoSize = true;
            this.AliveBox1.Location = new System.Drawing.Point(189, 340);
            this.AliveBox1.Name = "AliveBox1";
            this.AliveBox1.Size = new System.Drawing.Size(18, 17);
            this.AliveBox1.TabIndex = 10;
            this.AliveBox1.UseVisualStyleBackColor = true;
            // 
            // yearsNumeric
            // 
            this.yearsNumeric.Location = new System.Drawing.Point(189, 281);
            this.yearsNumeric.Name = "yearsNumeric";
            this.yearsNumeric.Size = new System.Drawing.Size(75, 22);
            this.yearsNumeric.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 530);
            this.Controls.Add(this.yearsNumeric);
            this.Controls.Add(this.AliveBox1);
            this.Controls.Add(this.LastNameBox2);
            this.Controls.Add(this.FirstNameBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "firstName";
            ((System.ComponentModel.ISupportInitialize)(this.yearsNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FirstNameBox1;
        private System.Windows.Forms.TextBox LastNameBox2;
        private System.Windows.Forms.CheckBox AliveBox1;
        private System.Windows.Forms.NumericUpDown yearsNumeric;
    }
}

