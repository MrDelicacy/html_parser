namespace Parser_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.parserList = new System.Windows.Forms.ListBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonAbort = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // parserList
            // 
            this.parserList.FormattingEnabled = true;
            this.parserList.Location = new System.Drawing.Point(12, 12);
            this.parserList.Name = "parserList";
            this.parserList.Size = new System.Drawing.Size(312, 394);
            this.parserList.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(363, 168);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(120, 27);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonAbort
            // 
            this.buttonAbort.Location = new System.Drawing.Point(363, 201);
            this.buttonAbort.Name = "buttonAbort";
            this.buttonAbort.Size = new System.Drawing.Size(120, 27);
            this.buttonAbort.TabIndex = 6;
            this.buttonAbort.Text = "abort";
            this.buttonAbort.UseVisualStyleBackColor = true;
            this.buttonAbort.Click += new System.EventHandler(this.buttonAbort_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(530, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(172, 394);
            this.treeView1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 450);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.buttonAbort);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.parserList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox parserList;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonAbort;
        private System.Windows.Forms.TreeView treeView1;
    }
}

