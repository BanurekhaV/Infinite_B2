
namespace WindowsRemotingClient
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
            this.lblnum1 = new System.Windows.Forms.Label();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.btnHighest = new System.Windows.Forms.Button();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Location = new System.Drawing.Point(60, 65);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(81, 13);
            this.lblnum1.TabIndex = 0;
            this.lblnum1.Text = "Enter Number 1";
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.Location = new System.Drawing.Point(60, 144);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(81, 13);
            this.lblnum2.TabIndex = 1;
            this.lblnum2.Text = "Enter Number 2";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(223, 65);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 2;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(223, 141);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 3;
            // 
            // btnHighest
            // 
            this.btnHighest.Location = new System.Drawing.Point(175, 220);
            this.btnHighest.Name = "btnHighest";
            this.btnHighest.Size = new System.Drawing.Size(167, 23);
            this.btnHighest.TabIndex = 4;
            this.btnHighest.Text = "Highest Number";
            this.btnHighest.UseVisualStyleBackColor = true;
            this.btnHighest.Click += new System.EventHandler(this.btnHighest_Click);
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(460, 127);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(167, 20);
            this.txtresult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.btnHighest);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.lblnum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button btnHighest;
        private System.Windows.Forms.TextBox txtresult;
    }
}

