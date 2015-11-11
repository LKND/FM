namespace FileManager
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReMove = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.myKontrol1 = new FileManager.MyKontrol(this.components);
            this.myKontrol2 = new FileManager.MyKontrol(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 658);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(705, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(3, 3);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(100, 24);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.Text = "Открыть";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnReMove);
            this.panel2.Controls.Add(this.btnCopy);
            this.panel2.Controls.Add(this.btnCreate);
            this.panel2.Controls.Add(this.btnOpenFile);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(705, 61);
            this.panel2.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(425, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReMove
            // 
            this.btnReMove.Location = new System.Drawing.Point(322, 4);
            this.btnReMove.Name = "btnReMove";
            this.btnReMove.Size = new System.Drawing.Size(96, 23);
            this.btnReMove.TabIndex = 4;
            this.btnReMove.Text = "Переместить";
            this.btnReMove.UseVisualStyleBackColor = true;
            this.btnReMove.Click += new System.EventHandler(this.btnReMove_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(215, 4);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(100, 23);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Копировать";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(109, 3);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(99, 23);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Создать";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 61);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.myKontrol1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.myKontrol2);
            this.splitContainer1.Size = new System.Drawing.Size(705, 597);
            this.splitContainer1.SplitterDistance = 350;
            this.splitContainer1.TabIndex = 6;
            // 
            // myKontrol1
            // 
            this.myKontrol1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myKontrol1.Location = new System.Drawing.Point(0, 0);
            this.myKontrol1.Name = "myKontrol1";
            this.myKontrol1.Size = new System.Drawing.Size(350, 597);
            this.myKontrol1.TabIndex = 7;
            // 
            // myKontrol2
            // 
            this.myKontrol2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myKontrol2.Location = new System.Drawing.Point(0, 0);
            this.myKontrol2.Name = "myKontrol2";
            this.myKontrol2.Size = new System.Drawing.Size(351, 597);
            this.myKontrol2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 681);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "FileManager";
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReMove;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MyKontrol myKontrol1;
        private MyKontrol myKontrol2;
    }
}

