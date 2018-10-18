namespace AdapterInfo
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
            this.cmbNic = new System.Windows.Forms.ComboBox();
            this.txtIpAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDefaultGW = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSunetMask = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adapter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP Address";
            // 
            // cmbNic
            // 
            this.cmbNic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNic.FormattingEnabled = true;
            this.cmbNic.Location = new System.Drawing.Point(114, 10);
            this.cmbNic.Name = "cmbNic";
            this.cmbNic.Size = new System.Drawing.Size(259, 21);
            this.cmbNic.TabIndex = 2;
            this.cmbNic.SelectedIndexChanged += new System.EventHandler(this.cmbNic_SelectedIndexChanged);
            // 
            // txtIpAddress
            // 
            this.txtIpAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIpAddress.Location = new System.Drawing.Point(114, 37);
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.ReadOnly = true;
            this.txtIpAddress.Size = new System.Drawing.Size(259, 20);
            this.txtIpAddress.TabIndex = 3;
            this.txtIpAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Default GW";
            // 
            // txtDefaultGW
            // 
            this.txtDefaultGW.Location = new System.Drawing.Point(114, 64);
            this.txtDefaultGW.Name = "txtDefaultGW";
            this.txtDefaultGW.ReadOnly = true;
            this.txtDefaultGW.Size = new System.Drawing.Size(259, 20);
            this.txtDefaultGW.TabIndex = 5;
            this.txtDefaultGW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "SubnetMask";
            // 
            // txtSunetMask
            // 
            this.txtSunetMask.Location = new System.Drawing.Point(114, 91);
            this.txtSunetMask.Name = "txtSunetMask";
            this.txtSunetMask.ReadOnly = true;
            this.txtSunetMask.Size = new System.Drawing.Size(259, 20);
            this.txtSunetMask.TabIndex = 7;
            this.txtSunetMask.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(217, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Acerca De..";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 341);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSunetMask);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDefaultGW);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIpAddress);
            this.Controls.Add(this.cmbNic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Network Adapter Information  Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbNic;
        private System.Windows.Forms.TextBox txtIpAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDefaultGW;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSunetMask;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

