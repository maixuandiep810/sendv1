using System.Collections.Generic;

namespace Send
{
    partial class Form_Send
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnFileName = new System.Windows.Forms.Button();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnValExpress = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.lbContent = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.btnReadTextBox = new System.Windows.Forms.Button();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.gbInput = new System.Windows.Forms.GroupBox();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.lbProcessName = new System.Windows.Forms.Label();
            this.gbProcess = new System.Windows.Forms.GroupBox();
            this.labelIntro = new System.Windows.Forms.Label();
            this.gbIntro = new System.Windows.Forms.GroupBox();
            this.gbInput.SuspendLayout();
            this.gbProcess.SuspendLayout();
            this.gbIntro.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnFileName
            // 
            this.btnFileName.Location = new System.Drawing.Point(351, 16);
            this.btnFileName.Name = "btnFileName";
            this.btnFileName.Size = new System.Drawing.Size(59, 23);
            this.btnFileName.TabIndex = 2;
            this.btnFileName.Text = "Chọn File";
            this.btnFileName.UseVisualStyleBackColor = true;
            this.btnFileName.Click += new System.EventHandler(this.btnFileName_Click);
            // 
            // tbInput
            // 
            this.tbInput.CausesValidation = false;
            this.tbInput.Location = new System.Drawing.Point(6, 44);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(339, 20);
            this.tbInput.TabIndex = 1;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(148, 394);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(114, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnValExpress
            // 
            this.btnValExpress.Location = new System.Drawing.Point(23, 394);
            this.btnValExpress.Name = "btnValExpress";
            this.btnValExpress.Size = new System.Drawing.Size(123, 23);
            this.btnValExpress.TabIndex = 6;
            this.btnValExpress.Text = "Tính biểu thức";
            this.btnValExpress.UseVisualStyleBackColor = true;
            this.btnValExpress.Click += new System.EventHandler(this.btnValExpress_Click);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(269, 121);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(44, 13);
            this.lbResult.TabIndex = 5;
            this.lbResult.Text = "Kết quả";
            // 
            // lbContent
            // 
            this.lbContent.AutoSize = true;
            this.lbContent.Location = new System.Drawing.Point(20, 121);
            this.lbContent.Name = "lbContent";
            this.lbContent.Size = new System.Drawing.Size(50, 13);
            this.lbContent.TabIndex = 4;
            this.lbContent.Text = "Nội dung";
            // 
            // tbResult
            // 
            this.tbResult.BackColor = System.Drawing.SystemColors.Menu;
            this.tbResult.Location = new System.Drawing.Point(272, 143);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(239, 244);
            this.tbResult.TabIndex = 3;
            this.tbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbFileName
            // 
            this.tbFileName.CausesValidation = false;
            this.tbFileName.Location = new System.Drawing.Point(6, 18);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(339, 20);
            this.tbFileName.TabIndex = 4;
            // 
            // btnReadTextBox
            // 
            this.btnReadTextBox.Location = new System.Drawing.Point(351, 42);
            this.btnReadTextBox.Name = "btnReadTextBox";
            this.btnReadTextBox.Size = new System.Drawing.Size(131, 23);
            this.btnReadTextBox.TabIndex = 3;
            this.btnReadTextBox.Text = "Đọc TextBox";
            this.btnReadTextBox.UseVisualStyleBackColor = true;
            this.btnReadTextBox.Click += new System.EventHandler(this.btnReadTextBox_Click);
            // 
            // tbContent
            // 
            this.tbContent.BackColor = System.Drawing.SystemColors.Menu;
            this.tbContent.Location = new System.Drawing.Point(23, 143);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.ReadOnly = true;
            this.tbContent.Size = new System.Drawing.Size(239, 244);
            this.tbContent.TabIndex = 2;
            this.tbContent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbInput
            // 
            this.gbInput.Controls.Add(this.btnReadFile);
            this.gbInput.Controls.Add(this.tbFileName);
            this.gbInput.Controls.Add(this.btnReadTextBox);
            this.gbInput.Controls.Add(this.btnFileName);
            this.gbInput.Controls.Add(this.tbInput);
            this.gbInput.Location = new System.Drawing.Point(23, 35);
            this.gbInput.Name = "gbInput";
            this.gbInput.Size = new System.Drawing.Size(488, 77);
            this.gbInput.TabIndex = 1;
            this.gbInput.TabStop = false;
            this.gbInput.Text = "Nhập dữ liệu";
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(416, 16);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(66, 23);
            this.btnReadFile.TabIndex = 5;
            this.btnReadFile.Text = "Đọc File";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // lbProcessName
            // 
            this.lbProcessName.AutoSize = true;
            this.lbProcessName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcessName.Location = new System.Drawing.Point(160, 16);
            this.lbProcessName.Name = "lbProcessName";
            this.lbProcessName.Size = new System.Drawing.Size(194, 16);
            this.lbProcessName.TabIndex = 0;
            this.lbProcessName.Text = "TIẾN TRÌNH NGƯỜI DÙNG";
            // 
            // gbProcess
            // 
            this.gbProcess.Controls.Add(this.btnReset);
            this.gbProcess.Controls.Add(this.btnValExpress);
            this.gbProcess.Controls.Add(this.lbResult);
            this.gbProcess.Controls.Add(this.lbContent);
            this.gbProcess.Controls.Add(this.tbResult);
            this.gbProcess.Controls.Add(this.tbContent);
            this.gbProcess.Controls.Add(this.gbInput);
            this.gbProcess.Controls.Add(this.lbProcessName);
            this.gbProcess.Location = new System.Drawing.Point(13, 72);
            this.gbProcess.Name = "gbProcess";
            this.gbProcess.Size = new System.Drawing.Size(531, 433);
            this.gbProcess.TabIndex = 3;
            this.gbProcess.TabStop = false;
            // 
            // labelIntro
            // 
            this.labelIntro.AutoSize = true;
            this.labelIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIntro.Location = new System.Drawing.Point(106, 16);
            this.labelIntro.Name = "labelIntro";
            this.labelIntro.Size = new System.Drawing.Size(327, 24);
            this.labelIntro.TabIndex = 0;
            this.labelIntro.Text = "Interprocess Communication - IPC";
            this.labelIntro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbIntro
            // 
            this.gbIntro.Controls.Add(this.labelIntro);
            this.gbIntro.Location = new System.Drawing.Point(13, 12);
            this.gbIntro.Name = "gbIntro";
            this.gbIntro.Size = new System.Drawing.Size(531, 54);
            this.gbIntro.TabIndex = 2;
            this.gbIntro.TabStop = false;
            // 
            // Form_Send
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 528);
            this.Controls.Add(this.gbProcess);
            this.Controls.Add(this.gbIntro);
            this.Name = "Form_Send";
            this.Text = "IPC using MSMQ v1.0";
            this.gbInput.ResumeLayout(false);
            this.gbInput.PerformLayout();
            this.gbProcess.ResumeLayout(false);
            this.gbProcess.PerformLayout();
            this.gbIntro.ResumeLayout(false);
            this.gbIntro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnFileName;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnValExpress;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label lbContent;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Button btnReadTextBox;
        private System.Windows.Forms.TextBox tbContent;
        private System.Windows.Forms.GroupBox gbInput;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Label lbProcessName;
        private System.Windows.Forms.GroupBox gbProcess;
        private System.Windows.Forms.Label labelIntro;
        private System.Windows.Forms.GroupBox gbIntro;

        private List<string> ExpressionList;
        private List<string> ResultList;
        
        private const string ExpressionMSMQ = @".\private$\ExpressionMSMQ";
        private const string ResultMSMQ = @".\private$\ResultMSMQ";
        private System.ComponentModel.BackgroundWorker bgWorker;
    }
}

