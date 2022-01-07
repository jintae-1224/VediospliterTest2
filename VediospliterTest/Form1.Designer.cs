
namespace VediospliterTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_fileName = new System.Windows.Forms.TextBox();
            this.btn_SaveFolder = new System.Windows.Forms.Button();
            this.lb_savePath = new System.Windows.Forms.Label();
            this.btn_OpenCSV = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_spliteTime = new System.Windows.Forms.TextBox();
            this.btn_Splite = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lb_progressText = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(41, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "파일명 : ";
            // 
            // txt_fileName
            // 
            this.txt_fileName.Location = new System.Drawing.Point(121, 22);
            this.txt_fileName.Name = "txt_fileName";
            this.txt_fileName.Size = new System.Drawing.Size(458, 25);
            this.txt_fileName.TabIndex = 1;
            // 
            // btn_SaveFolder
            // 
            this.btn_SaveFolder.Location = new System.Drawing.Point(611, 22);
            this.btn_SaveFolder.Name = "btn_SaveFolder";
            this.btn_SaveFolder.Size = new System.Drawing.Size(89, 26);
            this.btn_SaveFolder.TabIndex = 2;
            this.btn_SaveFolder.Text = "저장경로";
            this.btn_SaveFolder.UseVisualStyleBackColor = true;
            this.btn_SaveFolder.Click += new System.EventHandler(this.btn_SaveFolder_Click);
            // 
            // lb_savePath
            // 
            this.lb_savePath.AutoSize = true;
            this.lb_savePath.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_savePath.Location = new System.Drawing.Point(44, 71);
            this.lb_savePath.Name = "lb_savePath";
            this.lb_savePath.Size = new System.Drawing.Size(0, 17);
            this.lb_savePath.TabIndex = 3;
            // 
            // btn_OpenCSV
            // 
            this.btn_OpenCSV.Location = new System.Drawing.Point(44, 112);
            this.btn_OpenCSV.Name = "btn_OpenCSV";
            this.btn_OpenCSV.Size = new System.Drawing.Size(107, 28);
            this.btn_OpenCSV.TabIndex = 4;
            this.btn_OpenCSV.Text = "OpenCSV";
            this.btn_OpenCSV.UseVisualStyleBackColor = true;
            this.btn_OpenCSV.Click += new System.EventHandler(this.btn_OpenCSV_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(171, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "저장간격 : ";
            // 
            // txt_spliteTime
            // 
            this.txt_spliteTime.Location = new System.Drawing.Point(268, 113);
            this.txt_spliteTime.Name = "txt_spliteTime";
            this.txt_spliteTime.Size = new System.Drawing.Size(100, 25);
            this.txt_spliteTime.TabIndex = 6;
            this.txt_spliteTime.Text = "8";
            // 
            // btn_Splite
            // 
            this.btn_Splite.Location = new System.Drawing.Point(611, 112);
            this.btn_Splite.Name = "btn_Splite";
            this.btn_Splite.Size = new System.Drawing.Size(89, 27);
            this.btn_Splite.TabIndex = 7;
            this.btn_Splite.Text = "Splite";
            this.btn_Splite.UseVisualStyleBackColor = true;
            this.btn_Splite.Click += new System.EventHandler(this.btn_Splite_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(44, 187);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(656, 23);
            this.progressBar.TabIndex = 8;
            // 
            // lb_progressText
            // 
            this.lb_progressText.AutoSize = true;
            this.lb_progressText.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_progressText.Location = new System.Drawing.Point(44, 162);
            this.lb_progressText.Name = "lb_progressText";
            this.lb_progressText.Size = new System.Drawing.Size(0, 21);
            this.lb_progressText.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(477, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(102, 25);
            this.textBox1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(400, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Start : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 229);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_progressText);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btn_Splite);
            this.Controls.Add(this.txt_spliteTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_OpenCSV);
            this.Controls.Add(this.lb_savePath);
            this.Controls.Add(this.btn_SaveFolder);
            this.Controls.Add(this.txt_fileName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_fileName;
        private System.Windows.Forms.Button btn_SaveFolder;
        private System.Windows.Forms.Label lb_savePath;
        private System.Windows.Forms.Button btn_OpenCSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_spliteTime;
        private System.Windows.Forms.Button btn_Splite;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lb_progressText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}

