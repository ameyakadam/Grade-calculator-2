namespace Grade_Calculator
{
    partial class frmCalculateGrade
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
            this.txtGrade = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtNumberGrade = new System.Windows.Forms.TextBox();
            this.txtLetterGrade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Number grade:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtGrade
            // 
            this.txtGrade.AutoSize = true;
            this.txtGrade.Enabled = false;
            this.txtGrade.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrade.Location = new System.Drawing.Point(-2, 147);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(143, 23);
            this.txtGrade.TabIndex = 100;
            this.txtGrade.Text = "Letter grade:";
            this.txtGrade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtGrade.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(32, 234);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCalculate.Size = new System.Drawing.Size(120, 33);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(177, 234);
            this.btnExit.Name = "btnExit";
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnExit.Size = new System.Drawing.Size(134, 33);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNumberGrade
            // 
            this.txtNumberGrade.AcceptsTab = true;
            this.txtNumberGrade.Location = new System.Drawing.Point(158, 64);
            this.txtNumberGrade.Name = "txtNumberGrade";
            this.txtNumberGrade.Size = new System.Drawing.Size(151, 22);
            this.txtNumberGrade.TabIndex = 1;
            // 
            // txtLetterGrade
            // 
            this.txtLetterGrade.Location = new System.Drawing.Point(158, 147);
            this.txtLetterGrade.Name = "txtLetterGrade";
            this.txtLetterGrade.ReadOnly = true;
            this.txtLetterGrade.Size = new System.Drawing.Size(151, 22);
            this.txtLetterGrade.TabIndex = 5;
            this.txtLetterGrade.TabStop = false;
            this.txtLetterGrade.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // frmCalculateGrade
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(347, 305);
            this.Controls.Add(this.txtLetterGrade);
            this.Controls.Add(this.txtNumberGrade);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.label1);
            this.Name = "frmCalculateGrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grade Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtGrade;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtNumberGrade;
        private System.Windows.Forms.TextBox txtLetterGrade;
        private System.Windows.Forms.Button btnCalculate;
    }
}

