namespace Estimate
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
            this.num1 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.dollar = new System.Windows.Forms.Button();
            this.pound = new System.Windows.Forms.Button();
            this.euro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.AutoSize = true;
            this.num1.Location = new System.Drawing.Point(35, 52);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(33, 13);
            this.num1.TabIndex = 0;
            this.num1.Text = "num1";
            // 
            // num2
            // 
            this.num2.AutoSize = true;
            this.num2.Location = new System.Drawing.Point(36, 96);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(33, 13);
            this.num2.TabIndex = 1;
            this.num2.Text = "num2";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(40, 257);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(32, 13);
            this.result.TabIndex = 2;
            this.result.Text = "result";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(420, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(80, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(418, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(80, 257);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(418, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(145, 139);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(53, 27);
            this.add.TabIndex = 6;
            this.add.Text = "add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(214, 139);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(49, 27);
            this.sub.TabIndex = 7;
            this.sub.Text = "sub";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // mul
            // 
            this.mul.Location = new System.Drawing.Point(279, 139);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(49, 27);
            this.mul.TabIndex = 8;
            this.mul.Text = "mul";
            this.mul.UseVisualStyleBackColor = true;
            this.mul.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(348, 139);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(50, 27);
            this.div.TabIndex = 9;
            this.div.Text = "div";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // dollar
            // 
            this.dollar.Location = new System.Drawing.Point(188, 200);
            this.dollar.Name = "dollar";
            this.dollar.Size = new System.Drawing.Size(52, 27);
            this.dollar.TabIndex = 10;
            this.dollar.Text = "dollar";
            this.dollar.UseVisualStyleBackColor = true;
            this.dollar.Click += new System.EventHandler(this.dollar_Click);
            // 
            // pound
            // 
            this.pound.Location = new System.Drawing.Point(259, 200);
            this.pound.Name = "pound";
            this.pound.Size = new System.Drawing.Size(47, 28);
            this.pound.TabIndex = 11;
            this.pound.Text = "pound";
            this.pound.UseVisualStyleBackColor = true;
            this.pound.Click += new System.EventHandler(this.button1_Click_4);
            // 
            // euro
            // 
            this.euro.Location = new System.Drawing.Point(321, 200);
            this.euro.Name = "euro";
            this.euro.Size = new System.Drawing.Size(51, 28);
            this.euro.TabIndex = 12;
            this.euro.Text = "euro";
            this.euro.UseVisualStyleBackColor = true;
            this.euro.Click += new System.EventHandler(this.button1_Click_5);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Calculations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Conversion( curr to pkr)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 316);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.euro);
            this.Controls.Add(this.pound);
            this.Controls.Add(this.dollar);
            this.Controls.Add(this.div);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.add);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button dollar;
        private System.Windows.Forms.Button pound;
        private System.Windows.Forms.Button euro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

