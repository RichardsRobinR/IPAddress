
namespace IPAddress
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
            this.ipadress_Name = new System.Windows.Forms.Label();
            this.ipaddress_Textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ipadress_Name
            // 
            this.ipadress_Name.AutoSize = true;
            this.ipadress_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipadress_Name.Location = new System.Drawing.Point(40, 41);
            this.ipadress_Name.Name = "ipadress_Name";
            this.ipadress_Name.Size = new System.Drawing.Size(299, 108);
            this.ipadress_Name.TabIndex = 0;
            this.ipadress_Name.Text = "label1";
            // 
            // ipaddress_Textbox
            // 
            this.ipaddress_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipaddress_Textbox.Location = new System.Drawing.Point(45, 200);
            this.ipaddress_Textbox.Name = "ipaddress_Textbox";
            this.ipaddress_Textbox.Size = new System.Drawing.Size(718, 116);
            this.ipaddress_Textbox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ipaddress_Textbox);
            this.Controls.Add(this.ipadress_Name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ipadress_Name;
        private System.Windows.Forms.TextBox ipaddress_Textbox;
    }
}

