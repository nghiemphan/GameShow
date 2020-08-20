namespace mc
{
    partial class chatmc
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
            this.lvchat = new System.Windows.Forms.ListView();
            this.txtinput = new System.Windows.Forms.TextBox();
            this.btnsend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvchat
            // 
            this.lvchat.HideSelection = false;
            this.lvchat.Location = new System.Drawing.Point(0, 0);
            this.lvchat.Name = "lvchat";
            this.lvchat.Size = new System.Drawing.Size(282, 203);
            this.lvchat.TabIndex = 0;
            this.lvchat.UseCompatibleStateImageBehavior = false;
            // 
            // txtinput
            // 
            this.txtinput.Location = new System.Drawing.Point(0, 209);
            this.txtinput.Multiline = true;
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(229, 40);
            this.txtinput.TabIndex = 1;
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(236, 210);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(46, 39);
            this.btnsend.TabIndex = 2;
            this.btnsend.Text = "SEND";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // chatmc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.txtinput);
            this.Controls.Add(this.lvchat);
            this.Name = "chatmc";
            this.Text = " chat";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.chatmc_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvchat;
        private System.Windows.Forms.TextBox txtinput;
        private System.Windows.Forms.Button btnsend;
    }
}