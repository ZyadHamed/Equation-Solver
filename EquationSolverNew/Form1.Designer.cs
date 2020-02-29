namespace EquationSolverNew
{
    partial class frmMain
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
            this.txtTheEquation = new System.Windows.Forms.TextBox();
            this.btnSolve = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSolve2 = new System.Windows.Forms.Button();
            this.txtTheEquation2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter The Equation(First Degree):";
            // 
            // txtTheEquation
            // 
            this.txtTheEquation.Location = new System.Drawing.Point(17, 85);
            this.txtTheEquation.Name = "txtTheEquation";
            this.txtTheEquation.Size = new System.Drawing.Size(434, 31);
            this.txtTheEquation.TabIndex = 1;
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(475, 81);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(152, 38);
            this.btnSolve.TabIndex = 2;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter The Equation(Second Degree):";
            // 
            // btnSolve2
            // 
            this.btnSolve2.Location = new System.Drawing.Point(475, 219);
            this.btnSolve2.Name = "btnSolve2";
            this.btnSolve2.Size = new System.Drawing.Size(152, 38);
            this.btnSolve2.TabIndex = 5;
            this.btnSolve2.Text = "Solve";
            this.btnSolve2.UseVisualStyleBackColor = true;
            this.btnSolve2.Click += new System.EventHandler(this.btnSolve2_Click);
            // 
            // txtTheEquation2
            // 
            this.txtTheEquation2.Location = new System.Drawing.Point(17, 223);
            this.txtTheEquation2.Name = "txtTheEquation2";
            this.txtTheEquation2.Size = new System.Drawing.Size(434, 31);
            this.txtTheEquation2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(490, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Notice that: x squared is symoblized as X(captalized),ie: aX+bx+c = 0";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 352);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSolve2);
            this.Controls.Add(this.txtTheEquation2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.txtTheEquation);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTheEquation;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSolve2;
        private System.Windows.Forms.TextBox txtTheEquation2;
        private System.Windows.Forms.Label label3;
    }
}

