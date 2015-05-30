namespace view
{
    partial class LiterarySourceForm
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
            this.literarySorceGroupBox = new System.Windows.Forms.GroupBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.RemoveLiterarySourceButton = new System.Windows.Forms.Button();
            this.AddLiterarySourceButton = new System.Windows.Forms.Button();
            this.DescriptionSourceDataGridView = new System.Windows.Forms.DataGridView();
            this.literarySorceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionSourceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // literarySorceGroupBox
            // 
            this.literarySorceGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.literarySorceGroupBox.Controls.Add(this.CloseButton);
            this.literarySorceGroupBox.Controls.Add(this.RemoveLiterarySourceButton);
            this.literarySorceGroupBox.Controls.Add(this.AddLiterarySourceButton);
            this.literarySorceGroupBox.Controls.Add(this.DescriptionSourceDataGridView);
            this.literarySorceGroupBox.Location = new System.Drawing.Point(5, 5);
            this.literarySorceGroupBox.Name = "literarySorceGroupBox";
            this.literarySorceGroupBox.Size = new System.Drawing.Size(536, 323);
            this.literarySorceGroupBox.TabIndex = 0;
            this.literarySorceGroupBox.TabStop = false;
            this.literarySorceGroupBox.Text = "LiterarySource";
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Location = new System.Drawing.Point(423, 246);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(103, 48);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.Close_Click);
            // 
            // RemoveLiterarySourceButton
            // 
            this.RemoveLiterarySourceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveLiterarySourceButton.Location = new System.Drawing.Point(219, 246);
            this.RemoveLiterarySourceButton.Name = "RemoveLiterarySourceButton";
            this.RemoveLiterarySourceButton.Size = new System.Drawing.Size(99, 48);
            this.RemoveLiterarySourceButton.TabIndex = 2;
            this.RemoveLiterarySourceButton.Text = "Remove Literary Source";
            this.RemoveLiterarySourceButton.UseVisualStyleBackColor = true;
            // 
            // AddLiterarySourceButton
            // 
            this.AddLiterarySourceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddLiterarySourceButton.Location = new System.Drawing.Point(7, 246);
            this.AddLiterarySourceButton.Name = "AddLiterarySourceButton";
            this.AddLiterarySourceButton.Size = new System.Drawing.Size(104, 48);
            this.AddLiterarySourceButton.TabIndex = 1;
            this.AddLiterarySourceButton.Text = "Add Literary Source";
            this.AddLiterarySourceButton.UseVisualStyleBackColor = true;
            this.AddLiterarySourceButton.Click += new System.EventHandler(this.AddLiterarySourceButton_Click);
            // 
            // DescriptionSourceDataGridView
            // 
            this.DescriptionSourceDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionSourceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DescriptionSourceDataGridView.Location = new System.Drawing.Point(7, 19);
            this.DescriptionSourceDataGridView.Name = "DescriptionSourceDataGridView";
            this.DescriptionSourceDataGridView.Size = new System.Drawing.Size(519, 214);
            this.DescriptionSourceDataGridView.TabIndex = 0;
            // 
            // LiterarySourceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(543, 340);
            this.Controls.Add(this.literarySorceGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LiterarySourceForm";
            this.Text = "LiterarySourceForm";
            this.literarySorceGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionSourceDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        private void addLiterarySourceButton_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.GroupBox literarySorceGroupBox;
        private System.Windows.Forms.DataGridView DescriptionSourceDataGridView;
        private System.Windows.Forms.Button RemoveLiterarySourceButton;
        private System.Windows.Forms.Button AddLiterarySourceButton;
        private System.Windows.Forms.Button CloseButton;
    }
}

