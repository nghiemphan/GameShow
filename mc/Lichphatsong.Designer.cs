namespace mc
{
    partial class Lichphatsong
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtCountDown = new System.Windows.Forms.TextBox();
            this.gbAddgameshow = new System.Windows.Forms.GroupBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.dtgend = new System.Windows.Forms.DateTimePicker();
            this.dtgStart = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grvGameShow = new System.Windows.Forms.DataGridView();
            this.gbAddgameshow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvGameShow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnStart.Enabled = false;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(289, 410);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(223, 75);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(629, 305);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(126, 42);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "#Time";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 305);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(143, 42);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "#Name";
            // 
            // txtCountDown
            // 
            this.txtCountDown.BackColor = System.Drawing.SystemColors.Info;
            this.txtCountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountDown.ForeColor = System.Drawing.Color.Red;
            this.txtCountDown.Location = new System.Drawing.Point(29, 360);
            this.txtCountDown.Name = "txtCountDown";
            this.txtCountDown.Size = new System.Drawing.Size(791, 44);
            this.txtCountDown.TabIndex = 6;
            this.txtCountDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbAddgameshow
            // 
            this.gbAddgameshow.Controls.Add(this.btnthoat);
            this.gbAddgameshow.Controls.Add(this.btnadd);
            this.gbAddgameshow.Controls.Add(this.dtgend);
            this.gbAddgameshow.Controls.Add(this.dtgStart);
            this.gbAddgameshow.Controls.Add(this.label4);
            this.gbAddgameshow.Controls.Add(this.label3);
            this.gbAddgameshow.Controls.Add(this.txtname);
            this.gbAddgameshow.Controls.Add(this.label2);
            this.gbAddgameshow.Controls.Add(this.txtid);
            this.gbAddgameshow.Controls.Add(this.label1);
            this.gbAddgameshow.Location = new System.Drawing.Point(271, 80);
            this.gbAddgameshow.Name = "gbAddgameshow";
            this.gbAddgameshow.Size = new System.Drawing.Size(337, 286);
            this.gbAddgameshow.TabIndex = 10;
            this.gbAddgameshow.TabStop = false;
            this.gbAddgameshow.Text = "Thêm Game Show";
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(188, 230);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(93, 27);
            this.btnthoat.TabIndex = 10;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(36, 230);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(93, 27);
            this.btnadd.TabIndex = 9;
            this.btnadd.Text = "Thêm";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dtgend
            // 
            this.dtgend.CustomFormat = "dd/MM/yyyy";
            this.dtgend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgend.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtgend.Location = new System.Drawing.Point(100, 184);
            this.dtgend.Name = "dtgend";
            this.dtgend.Size = new System.Drawing.Size(181, 26);
            this.dtgend.TabIndex = 8;
            // 
            // dtgStart
            // 
            this.dtgStart.CustomFormat = "dd/MM/yyyy";
            this.dtgStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtgStart.Location = new System.Drawing.Point(100, 135);
            this.dtgStart.Name = "dtgStart";
            this.dtgStart.Size = new System.Drawing.Size(181, 26);
            this.dtgStart.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "End";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Start";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(100, 85);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(181, 26);
            this.txtname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(100, 39);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(181, 26);
            this.txtid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // grvGameShow
            // 
            this.grvGameShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvGameShow.Location = new System.Drawing.Point(12, 12);
            this.grvGameShow.Name = "grvGameShow";
            this.grvGameShow.Size = new System.Drawing.Size(811, 276);
            this.grvGameShow.TabIndex = 12;
            // 
            // Lichphatsong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 497);
            this.Controls.Add(this.gbAddgameshow);
            this.Controls.Add(this.grvGameShow);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtCountDown);
            this.Name = "Lichphatsong";
            this.Text = "Lichphatsong";
            this.Load += new System.EventHandler(this.Lichphatsong_Load);
            this.gbAddgameshow.ResumeLayout(false);
            this.gbAddgameshow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvGameShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtCountDown;
        private System.Windows.Forms.GroupBox gbAddgameshow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DateTimePicker dtgend;
        private System.Windows.Forms.DateTimePicker dtgStart;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.DataGridView grvGameShow;
    }
}