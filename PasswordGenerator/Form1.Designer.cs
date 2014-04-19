namespace PasswordGenerator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCombi = new System.Windows.Forms.TextBox();
            this.nudCharCount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSpecial = new System.Windows.Forms.TextBox();
            this.chkSpecial = new System.Windows.Forms.CheckBox();
            this.chkNum = new System.Windows.Forms.CheckBox();
            this.chkLower = new System.Windows.Forms.CheckBox();
            this.chkUpper = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnCalculateCombi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharCount)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCalculateCombi);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.nudCharCount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSpecial);
            this.groupBox1.Controls.Add(this.chkSpecial);
            this.groupBox1.Controls.Add(this.chkNum);
            this.groupBox1.Controls.Add(this.chkLower);
            this.groupBox1.Controls.Add(this.chkUpper);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 285);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Complexity/Constraints";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCombi);
            this.groupBox2.Location = new System.Drawing.Point(15, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 73);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Number of Possible Combinations";
            // 
            // txtCombi
            // 
            this.txtCombi.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCombi.Location = new System.Drawing.Point(6, 31);
            this.txtCombi.Multiline = true;
            this.txtCombi.Name = "txtCombi";
            this.txtCombi.ReadOnly = true;
            this.txtCombi.Size = new System.Drawing.Size(219, 27);
            this.txtCombi.TabIndex = 0;
            this.txtCombi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudCharCount
            // 
            this.nudCharCount.Location = new System.Drawing.Point(164, 131);
            this.nudCharCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCharCount.Name = "nudCharCount";
            this.nudCharCount.Size = new System.Drawing.Size(90, 23);
            this.nudCharCount.TabIndex = 6;
            this.nudCharCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCharCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter number of Characters";
            // 
            // txtSpecial
            // 
            this.txtSpecial.Enabled = false;
            this.txtSpecial.Location = new System.Drawing.Point(175, 95);
            this.txtSpecial.Name = "txtSpecial";
            this.txtSpecial.Size = new System.Drawing.Size(79, 23);
            this.txtSpecial.TabIndex = 4;
            // 
            // chkSpecial
            // 
            this.chkSpecial.AutoSize = true;
            this.chkSpecial.Location = new System.Drawing.Point(6, 97);
            this.chkSpecial.Name = "chkSpecial";
            this.chkSpecial.Size = new System.Drawing.Size(171, 19);
            this.chkSpecial.TabIndex = 3;
            this.chkSpecial.Text = "Special Characters (Specify)";
            this.chkSpecial.UseVisualStyleBackColor = true;
            this.chkSpecial.CheckedChanged += new System.EventHandler(this.chkSpecial_CheckedChanged);
            // 
            // chkNum
            // 
            this.chkNum.AutoSize = true;
            this.chkNum.Location = new System.Drawing.Point(6, 72);
            this.chkNum.Name = "chkNum";
            this.chkNum.Size = new System.Drawing.Size(103, 19);
            this.chkNum.TabIndex = 2;
            this.chkNum.Text = "Numbers (0-9)";
            this.chkNum.UseVisualStyleBackColor = true;
            // 
            // chkLower
            // 
            this.chkLower.AutoSize = true;
            this.chkLower.Location = new System.Drawing.Point(6, 47);
            this.chkLower.Name = "chkLower";
            this.chkLower.Size = new System.Drawing.Size(108, 19);
            this.chkLower.TabIndex = 1;
            this.chkLower.Text = "Lowercase (a-z)";
            this.chkLower.UseVisualStyleBackColor = true;
            // 
            // chkUpper
            // 
            this.chkUpper.AutoSize = true;
            this.chkUpper.Location = new System.Drawing.Point(6, 22);
            this.chkUpper.Name = "chkUpper";
            this.chkUpper.Size = new System.Drawing.Size(112, 19);
            this.chkUpper.TabIndex = 0;
            this.chkUpper.Text = "Uppercase (A-Z)";
            this.chkUpper.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnGenerate);
            this.groupBox3.Controls.Add(this.txtPass);
            this.groupBox3.Location = new System.Drawing.Point(12, 303);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(261, 127);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Your Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "As a security measure, always keep \r\npasswords in a secure location.\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(9, 51);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(245, 23);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate Password";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(9, 22);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(245, 23);
            this.txtPass.TabIndex = 0;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalculateCombi
            // 
            this.btnCalculateCombi.Location = new System.Drawing.Point(21, 252);
            this.btnCalculateCombi.Name = "btnCalculateCombi";
            this.btnCalculateCombi.Size = new System.Drawing.Size(219, 23);
            this.btnCalculateCombi.TabIndex = 8;
            this.btnCalculateCombi.Text = "Calculate Combinations";
            this.btnCalculateCombi.UseVisualStyleBackColor = true;
            this.btnCalculateCombi.Click += new System.EventHandler(this.btnCalculateCombi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 440);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharCount)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSpecial;
        private System.Windows.Forms.CheckBox chkSpecial;
        private System.Windows.Forms.CheckBox chkNum;
        private System.Windows.Forms.CheckBox chkLower;
        private System.Windows.Forms.CheckBox chkUpper;
        private System.Windows.Forms.NumericUpDown nudCharCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCombi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnCalculateCombi;
    }
}

