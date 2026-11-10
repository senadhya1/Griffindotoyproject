namespace Griffindotoyproject
{
    partial class Employeemenu
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
            this.lblLeaveManagement = new System.Windows.Forms.Label();
            this.lblLHRLB = new System.Windows.Forms.Label();
            this.lblShowEmployee = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLeaveManagement
            // 
            this.lblLeaveManagement.AutoSize = true;
            this.lblLeaveManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeaveManagement.Location = new System.Drawing.Point(12, 24);
            this.lblLeaveManagement.Name = "lblLeaveManagement";
            this.lblLeaveManagement.Size = new System.Drawing.Size(171, 20);
            this.lblLeaveManagement.TabIndex = 0;
            this.lblLeaveManagement.Text = "Leave Management";
            this.lblLeaveManagement.Click += new System.EventHandler(this.lblLeaveManagement_Click);
            // 
            // lblLHRLB
            // 
            this.lblLHRLB.AutoSize = true;
            this.lblLHRLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLHRLB.Location = new System.Drawing.Point(216, 24);
            this.lblLHRLB.Name = "lblLHRLB";
            this.lblLHRLB.Size = new System.Drawing.Size(386, 20);
            this.lblLHRLB.TabIndex = 1;
            this.lblLHRLB.Text = "Leave History and Remaining Leave Balance";
            // 
            // lblShowEmployee
            // 
            this.lblShowEmployee.AutoSize = true;
            this.lblShowEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowEmployee.Location = new System.Drawing.Point(630, 24);
            this.lblShowEmployee.Name = "lblShowEmployee";
            this.lblShowEmployee.Size = new System.Drawing.Size(141, 20);
            this.lblShowEmployee.TabIndex = 2;
            this.lblShowEmployee.Text = "Show Employee";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(660, 576);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Image = global::Griffindotoyproject.Properties.Resources.Red_Modern_Corporate_New_Employee_Onboarding_Company_Presentation;
            this.pictureBox1.Location = new System.Drawing.Point(2, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(809, 535);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Employeemenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(809, 611);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblShowEmployee);
            this.Controls.Add(this.lblLHRLB);
            this.Controls.Add(this.lblLeaveManagement);
            this.Name = "Employeemenu";
            this.Text = "Employeemenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLeaveManagement;
        private System.Windows.Forms.Label lblLHRLB;
        private System.Windows.Forms.Label lblShowEmployee;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}