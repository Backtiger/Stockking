﻿namespace DartApI
{
    partial class frmDataSetting
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbDataset = new System.Windows.Forms.GroupBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.LBoxPath = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.rdPL = new System.Windows.Forms.RadioButton();
            this.rdCE = new System.Windows.Forms.RadioButton();
            this.rdCF = new System.Windows.Forms.RadioButton();
            this.rdBS = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gbDataset.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbDataset);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // gbDataset
            // 
            this.gbDataset.AutoSize = true;
            this.gbDataset.Controls.Add(this.label1);
            this.gbDataset.Controls.Add(this.rdBS);
            this.gbDataset.Controls.Add(this.rdCF);
            this.gbDataset.Controls.Add(this.rdCE);
            this.gbDataset.Controls.Add(this.rdPL);
            this.gbDataset.Controls.Add(this.btnPath);
            this.gbDataset.Controls.Add(this.LBoxPath);
            this.gbDataset.Controls.Add(this.label2);
            this.gbDataset.Controls.Add(this.btnOK);
            this.gbDataset.Location = new System.Drawing.Point(12, 12);
            this.gbDataset.Name = "gbDataset";
            this.gbDataset.Size = new System.Drawing.Size(762, 400);
            this.gbDataset.TabIndex = 0;
            this.gbDataset.TabStop = false;
            this.gbDataset.Text = "데이터 세팅";
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(101, 355);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(75, 23);
            this.btnPath.TabIndex = 4;
            this.btnPath.Text = "파일선택";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // LBoxPath
            // 
            this.LBoxPath.FormattingEnabled = true;
            this.LBoxPath.ItemHeight = 12;
            this.LBoxPath.Location = new System.Drawing.Point(101, 38);
            this.LBoxPath.Name = "LBoxPath";
            this.LBoxPath.Size = new System.Drawing.Size(199, 304);
            this.LBoxPath.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "파일경로";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(225, 355);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "확인";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // rdPL
            // 
            this.rdPL.AutoSize = true;
            this.rdPL.Location = new System.Drawing.Point(379, 74);
            this.rdPL.Name = "rdPL";
            this.rdPL.Size = new System.Drawing.Size(83, 16);
            this.rdPL.TabIndex = 5;
            this.rdPL.TabStop = true;
            this.rdPL.Text = "손익계산서";
            this.rdPL.UseVisualStyleBackColor = true;
            // 
            // rdCE
            // 
            this.rdCE.AutoSize = true;
            this.rdCE.Location = new System.Drawing.Point(379, 96);
            this.rdCE.Name = "rdCE";
            this.rdCE.Size = new System.Drawing.Size(83, 16);
            this.rdCE.TabIndex = 6;
            this.rdCE.TabStop = true;
            this.rdCE.Text = "재무상태표";
            this.rdCE.UseVisualStyleBackColor = true;
            // 
            // rdCF
            // 
            this.rdCF.AutoSize = true;
            this.rdCF.Location = new System.Drawing.Point(379, 118);
            this.rdCF.Name = "rdCF";
            this.rdCF.Size = new System.Drawing.Size(83, 16);
            this.rdCF.TabIndex = 7;
            this.rdCF.TabStop = true;
            this.rdCF.Text = "현금흐름표";
            this.rdCF.UseVisualStyleBackColor = true;
            // 
            // rdBS
            // 
            this.rdBS.AutoSize = true;
            this.rdBS.Location = new System.Drawing.Point(379, 140);
            this.rdBS.Name = "rdBS";
            this.rdBS.Size = new System.Drawing.Size(83, 16);
            this.rdBS.TabIndex = 8;
            this.rdBS.TabStop = true;
            this.rdBS.Text = "자본변동표";
            this.rdBS.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "데이터 구분";
            // 
            // frmDataSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmDataSetting";
            this.Text = "frmDataSetting";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbDataset.ResumeLayout(false);
            this.gbDataset.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbDataset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ListBox LBoxPath;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdBS;
        private System.Windows.Forms.RadioButton rdCF;
        private System.Windows.Forms.RadioButton rdCE;
        private System.Windows.Forms.RadioButton rdPL;
    }
}