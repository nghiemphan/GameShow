namespace SV
{
    partial class ServerMain
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
            this.lvlistclient = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvlistclient
            // 
            this.lvlistclient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvlistclient.HideSelection = false;
            this.lvlistclient.Location = new System.Drawing.Point(0, 0);
            this.lvlistclient.Name = "lvlistclient";
            this.lvlistclient.Size = new System.Drawing.Size(690, 398);
            this.lvlistclient.TabIndex = 0;
            this.lvlistclient.UseCompatibleStateImageBehavior = false;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 398);
            this.Controls.Add(this.lvlistclient);
            this.Name = "Server";
            this.Text = "Server";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvlistclient;
    }
}

