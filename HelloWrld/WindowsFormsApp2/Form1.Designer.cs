﻿namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.폰트설정 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.conFont = new System.Windows.Forms.ComboBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.rdoSoccer = new System.Windows.Forms.RadioButton();
            this.rdoBaseball = new System.Windows.Forms.RadioButton();
            this.rdoBasketball = new System.Windows.Forms.RadioButton();
            this.rdoTkd = new System.Windows.Forms.RadioButton();
            this.lblSports = new System.Windows.Forms.Label();
            this.폰트설정.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // 폰트설정
            // 
            this.폰트설정.Controls.Add(this.txtMessage);
            this.폰트설정.Controls.Add(this.chkItalic);
            this.폰트설정.Controls.Add(this.chkBold);
            this.폰트설정.Controls.Add(this.conFont);
            this.폰트설정.Controls.Add(this.label1);
            this.폰트설정.Location = new System.Drawing.Point(81, 24);
            this.폰트설정.Name = "폰트설정";
            this.폰트설정.Size = new System.Drawing.Size(606, 154);
            this.폰트설정.TabIndex = 0;
            this.폰트설정.TabStop = false;
            this.폰트설정.Text = "폰트설정";
            this.폰트설정.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSports);
            this.groupBox2.Controls.Add(this.rdoTkd);
            this.groupBox2.Controls.Add(this.rdoBasketball);
            this.groupBox2.Controls.Add(this.rdoBaseball);
            this.groupBox2.Controls.Add(this.rdoSoccer);
            this.groupBox2.Location = new System.Drawing.Point(81, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(606, 154);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "좋아하는 스포츠 하나만";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "폰트";
            // 
            // conFont
            // 
            this.conFont.FormattingEnabled = true;
            this.conFont.Location = new System.Drawing.Point(59, 38);
            this.conFont.Name = "conFont";
            this.conFont.Size = new System.Drawing.Size(147, 20);
            this.conFont.TabIndex = 1;
            this.conFont.SelectedIndexChanged += new System.EventHandler(this.conFont_SelectedIndexChanged);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Location = new System.Drawing.Point(222, 41);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(48, 16);
            this.chkBold.TabIndex = 2;
            this.chkBold.Text = "굵게";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Location = new System.Drawing.Point(322, 42);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(72, 16);
            this.chkItalic.TabIndex = 3;
            this.chkItalic.Text = "이탤릭체";
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.chkItalic_CheckedChanged);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(29, 86);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(492, 21);
            this.txtMessage.TabIndex = 4;
            this.txtMessage.Text = "오라클자바커뮤니티";
            // 
            // rdoSoccer
            // 
            this.rdoSoccer.AutoSize = true;
            this.rdoSoccer.Location = new System.Drawing.Point(34, 62);
            this.rdoSoccer.Name = "rdoSoccer";
            this.rdoSoccer.Size = new System.Drawing.Size(47, 16);
            this.rdoSoccer.TabIndex = 0;
            this.rdoSoccer.TabStop = true;
            this.rdoSoccer.Text = "축구";
            this.rdoSoccer.UseVisualStyleBackColor = true;
            this.rdoSoccer.CheckedChanged += new System.EventHandler(this.rdoSoccer_CheckedChanged);
            // 
            // rdoBaseball
            // 
            this.rdoBaseball.AutoSize = true;
            this.rdoBaseball.Location = new System.Drawing.Point(177, 63);
            this.rdoBaseball.Name = "rdoBaseball";
            this.rdoBaseball.Size = new System.Drawing.Size(47, 16);
            this.rdoBaseball.TabIndex = 1;
            this.rdoBaseball.TabStop = true;
            this.rdoBaseball.Text = "야구";
            this.rdoBaseball.UseVisualStyleBackColor = true;
            this.rdoBaseball.CheckedChanged += new System.EventHandler(this.rdoBaseball_CheckedChanged);
            // 
            // rdoBasketball
            // 
            this.rdoBasketball.AutoSize = true;
            this.rdoBasketball.Location = new System.Drawing.Point(322, 62);
            this.rdoBasketball.Name = "rdoBasketball";
            this.rdoBasketball.Size = new System.Drawing.Size(47, 16);
            this.rdoBasketball.TabIndex = 2;
            this.rdoBasketball.TabStop = true;
            this.rdoBasketball.Text = "농구";
            this.rdoBasketball.UseVisualStyleBackColor = true;
            this.rdoBasketball.CheckedChanged += new System.EventHandler(this.rdoBasketball_CheckedChanged);
            // 
            // rdoTkd
            // 
            this.rdoTkd.AutoSize = true;
            this.rdoTkd.Location = new System.Drawing.Point(471, 62);
            this.rdoTkd.Name = "rdoTkd";
            this.rdoTkd.Size = new System.Drawing.Size(59, 16);
            this.rdoTkd.TabIndex = 3;
            this.rdoTkd.TabStop = true;
            this.rdoTkd.Text = "태권도";
            this.rdoTkd.UseVisualStyleBackColor = true;
            this.rdoTkd.CheckedChanged += new System.EventHandler(this.rdoTkd_CheckedChanged);
            // 
            // lblSports
            // 
            this.lblSports.AutoSize = true;
            this.lblSports.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSports.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSports.Location = new System.Drawing.Point(31, 109);
            this.lblSports.Name = "lblSports";
            this.lblSports.Size = new System.Drawing.Size(149, 12);
            this.lblSports.TabIndex = 4;
            this.lblSports.Text = "선택한 스포츠가 없습니다.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.폰트설정);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.폰트설정.ResumeLayout(false);
            this.폰트설정.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox 폰트설정;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.ComboBox conFont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSports;
        private System.Windows.Forms.RadioButton rdoTkd;
        private System.Windows.Forms.RadioButton rdoBasketball;
        private System.Windows.Forms.RadioButton rdoBaseball;
        private System.Windows.Forms.RadioButton rdoSoccer;
    }
}

