namespace mc
{
    partial class frmMC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMC));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.lbinputQs = new System.Windows.Forms.Label();
            this.btnLoadQuestion = new System.Windows.Forms.Button();
            this.btnNewQuestion = new System.Windows.Forms.Button();
            this.btnSendQuestion = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.lbA = new System.Windows.Forms.Label();
            this.lbB = new System.Windows.Forms.Label();
            this.lbC = new System.Windows.Forms.Label();
            this.lbD = new System.Windows.Forms.Label();
            this.lbda = new System.Windows.Forms.Label();
            this.txtDA = new System.Windows.Forms.TextBox();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.lbcount = new System.Windows.Forms.Label();
            this.lbinputda = new System.Windows.Forms.Label();
            this.btnchat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button24 = new System.Windows.Forms.Button();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChonanh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ptImage = new System.Windows.Forms.PictureBox();
            this.ptrImageMc = new System.Windows.Forms.PictureBox();
            this.lbname = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrImageMc)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQuestion
            // 
            this.txtQuestion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtQuestion.CausesValidation = false;
            this.txtQuestion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.ForeColor = System.Drawing.SystemColors.Info;
            this.txtQuestion.Location = new System.Drawing.Point(104, 60);
            this.txtQuestion.MaxLength = 2147483647;
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(421, 103);
            this.txtQuestion.TabIndex = 61;
            // 
            // lbinputQs
            // 
            this.lbinputQs.AutoSize = true;
            this.lbinputQs.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbinputQs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbinputQs.Location = new System.Drawing.Point(104, 41);
            this.lbinputQs.Name = "lbinputQs";
            this.lbinputQs.Size = new System.Drawing.Size(97, 13);
            this.lbinputQs.TabIndex = 62;
            this.lbinputQs.Text = "THÊM CÂU HỎI";
            // 
            // btnLoadQuestion
            // 
            this.btnLoadQuestion.Location = new System.Drawing.Point(108, 169);
            this.btnLoadQuestion.Name = "btnLoadQuestion";
            this.btnLoadQuestion.Size = new System.Drawing.Size(134, 25);
            this.btnLoadQuestion.TabIndex = 63;
            this.btnLoadQuestion.Text = "Đề sẵn";
            this.btnLoadQuestion.UseVisualStyleBackColor = true;
            this.btnLoadQuestion.Click += new System.EventHandler(this.btnLoadQuestion_Click);
            // 
            // btnNewQuestion
            // 
            this.btnNewQuestion.Location = new System.Drawing.Point(248, 169);
            this.btnNewQuestion.Name = "btnNewQuestion";
            this.btnNewQuestion.Size = new System.Drawing.Size(134, 25);
            this.btnNewQuestion.TabIndex = 64;
            this.btnNewQuestion.Text = "Tạo mới";
            this.btnNewQuestion.UseVisualStyleBackColor = true;
            this.btnNewQuestion.Click += new System.EventHandler(this.btnNewQuestion_Click);
            // 
            // btnSendQuestion
            // 
            this.btnSendQuestion.Location = new System.Drawing.Point(238, 410);
            this.btnSendQuestion.Name = "btnSendQuestion";
            this.btnSendQuestion.Size = new System.Drawing.Size(134, 25);
            this.btnSendQuestion.TabIndex = 65;
            this.btnSendQuestion.Text = "Gửi câu hỏi";
            this.btnSendQuestion.UseVisualStyleBackColor = true;
            this.btnSendQuestion.Click += new System.EventHandler(this.btnSendQuestion_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(143, 223);
            this.txtA.Multiline = true;
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(351, 31);
            this.txtA.TabIndex = 66;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(143, 260);
            this.txtB.Multiline = true;
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(351, 31);
            this.txtB.TabIndex = 67;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(143, 297);
            this.txtC.Multiline = true;
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(351, 31);
            this.txtC.TabIndex = 68;
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(143, 334);
            this.txtD.Multiline = true;
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(351, 31);
            this.txtD.TabIndex = 69;
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Location = new System.Drawing.Point(127, 232);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(14, 13);
            this.lbA.TabIndex = 70;
            this.lbA.Text = "A";
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Location = new System.Drawing.Point(127, 269);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(14, 13);
            this.lbB.TabIndex = 71;
            this.lbB.Text = "B";
            // 
            // lbC
            // 
            this.lbC.AutoSize = true;
            this.lbC.Location = new System.Drawing.Point(127, 306);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(14, 13);
            this.lbC.TabIndex = 72;
            this.lbC.Text = "C";
            // 
            // lbD
            // 
            this.lbD.AutoSize = true;
            this.lbD.Location = new System.Drawing.Point(127, 341);
            this.lbD.Name = "lbD";
            this.lbD.Size = new System.Drawing.Size(15, 13);
            this.lbD.TabIndex = 73;
            this.lbD.Text = "D";
            // 
            // lbda
            // 
            this.lbda.AutoSize = true;
            this.lbda.Location = new System.Drawing.Point(105, 375);
            this.lbda.Name = "lbda";
            this.lbda.Size = new System.Drawing.Size(42, 13);
            this.lbda.TabIndex = 74;
            this.lbda.Text = "Đáp án";
            // 
            // txtDA
            // 
            this.txtDA.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDA.Location = new System.Drawing.Point(153, 371);
            this.txtDA.Name = "txtDA";
            this.txtDA.Size = new System.Drawing.Size(100, 20);
            this.txtDA.TabIndex = 75;
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Location = new System.Drawing.Point(391, 169);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(134, 25);
            this.btnNextQuestion.TabIndex = 76;
            this.btnNextQuestion.Text = "Câu hỏi tiếp theo";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // lbcount
            // 
            this.lbcount.AutoSize = true;
            this.lbcount.Location = new System.Drawing.Point(415, 378);
            this.lbcount.Name = "lbcount";
            this.lbcount.Size = new System.Drawing.Size(13, 13);
            this.lbcount.TabIndex = 77;
            this.lbcount.Text = "0";
            // 
            // lbinputda
            // 
            this.lbinputda.AutoSize = true;
            this.lbinputda.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbinputda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbinputda.Location = new System.Drawing.Point(101, 207);
            this.lbinputda.Name = "lbinputda";
            this.lbinputda.Size = new System.Drawing.Size(92, 13);
            this.lbinputda.TabIndex = 78;
            this.lbinputda.Text = "THÊM ĐÁP ÁN";
            // 
            // btnchat
            // 
            this.btnchat.Location = new System.Drawing.Point(484, 410);
            this.btnchat.Name = "btnchat";
            this.btnchat.Size = new System.Drawing.Size(85, 25);
            this.btnchat.TabIndex = 79;
            this.btnchat.Text = "Nhóm chat";
            this.btnchat.UseVisualStyleBackColor = true;
            this.btnchat.Click += new System.EventHandler(this.btnchat_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button24);
            this.panel1.Controls.Add(this.txtIp);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txthoten);
            this.panel1.Controls.Add(this.btnlogin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnChonanh);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ptImage);
            this.panel1.Location = new System.Drawing.Point(38, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 337);
            this.panel1.TabIndex = 80;
            // 
            // button24
            // 
            this.button24.Image = ((System.Drawing.Image)(resources.GetObject("button24.Image")));
            this.button24.Location = new System.Drawing.Point(361, 241);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(93, 39);
            this.button24.TabIndex = 39;
            this.button24.UseVisualStyleBackColor = true;
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(296, 178);
            this.txtIp.Multiline = true;
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(197, 41);
            this.txtIp.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(179, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 59);
            this.label4.TabIndex = 37;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(296, 94);
            this.txthoten.Multiline = true;
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(197, 41);
            this.txthoten.TabIndex = 36;
            // 
            // btnlogin
            // 
            this.btnlogin.Image = ((System.Drawing.Image)(resources.GetObject("btnlogin.Image")));
            this.btnlogin.Location = new System.Drawing.Point(231, 241);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(93, 39);
            this.btnlogin.TabIndex = 35;
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // label3
            // 
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(179, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 59);
            this.label3.TabIndex = 34;
            // 
            // btnChonanh
            // 
            this.btnChonanh.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnChonanh.Location = new System.Drawing.Point(66, 145);
            this.btnChonanh.Name = "btnChonanh";
            this.btnChonanh.Size = new System.Drawing.Size(79, 24);
            this.btnChonanh.TabIndex = 33;
            this.btnChonanh.Text = "Chọn ảnh";
            this.btnChonanh.UseVisualStyleBackColor = false;
            this.btnChonanh.Click += new System.EventHandler(this.btnChonanh_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(174, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 49);
            this.label2.TabIndex = 32;
            this.label2.Text = "Thông tin MC";
            // 
            // ptImage
            // 
            this.ptImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptImage.Image = ((System.Drawing.Image)(resources.GetObject("ptImage.Image")));
            this.ptImage.Location = new System.Drawing.Point(66, 83);
            this.ptImage.Name = "ptImage";
            this.ptImage.Size = new System.Drawing.Size(79, 71);
            this.ptImage.TabIndex = 31;
            this.ptImage.TabStop = false;
            // 
            // ptrImageMc
            // 
            this.ptrImageMc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptrImageMc.Image = ((System.Drawing.Image)(resources.GetObject("ptrImageMc.Image")));
            this.ptrImageMc.Location = new System.Drawing.Point(539, 60);
            this.ptrImageMc.Name = "ptrImageMc";
            this.ptrImageMc.Size = new System.Drawing.Size(79, 71);
            this.ptrImageMc.TabIndex = 81;
            this.ptrImageMc.TabStop = false;
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.Location = new System.Drawing.Point(528, 134);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(97, 13);
            this.lbname.TabIndex = 82;
            this.lbname.Text = "THÊM CÂU HỎI";
            // 
            // frmMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(630, 447);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.ptrImageMc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnchat);
            this.Controls.Add(this.lbinputda);
            this.Controls.Add(this.lbcount);
            this.Controls.Add(this.btnNextQuestion);
            this.Controls.Add(this.txtDA);
            this.Controls.Add(this.lbda);
            this.Controls.Add(this.lbD);
            this.Controls.Add(this.lbC);
            this.Controls.Add(this.lbB);
            this.Controls.Add(this.lbA);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.btnSendQuestion);
            this.Controls.Add(this.btnNewQuestion);
            this.Controls.Add(this.btnLoadQuestion);
            this.Controls.Add(this.lbinputQs);
            this.Controls.Add(this.txtQuestion);
            this.Name = "frmMC";
            this.Text = "MC Chương trình đố vui";
            this.Load += new System.EventHandler(this.frmMC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrImageMc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label lbinputQs;
        private System.Windows.Forms.Button btnLoadQuestion;
        private System.Windows.Forms.Button btnNewQuestion;
        private System.Windows.Forms.Button btnSendQuestion;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.Label lbC;
        private System.Windows.Forms.Label lbD;
        private System.Windows.Forms.Label lbda;
        private System.Windows.Forms.TextBox txtDA;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Label lbcount;
        private System.Windows.Forms.Label lbinputda;
        private System.Windows.Forms.Button btnchat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChonanh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ptImage;
        private System.Windows.Forms.PictureBox ptrImageMc;
        private System.Windows.Forms.Label lbname;
    }
}

