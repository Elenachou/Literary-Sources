namespace veiw
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
            this.closeButton = new System.Windows.Forms.Button();
            this.removeLiterarySourceButton = new System.Windows.Forms.Button();
            this.addLiterarySourceButton = new System.Windows.Forms.Button();
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
            this.literarySorceGroupBox.Controls.Add(this.closeButton);
            this.literarySorceGroupBox.Controls.Add(this.removeLiterarySourceButton);
            this.literarySorceGroupBox.Controls.Add(this.addLiterarySourceButton);
            this.literarySorceGroupBox.Controls.Add(this.DescriptionSourceDataGridView);
            this.literarySorceGroupBox.Location = new System.Drawing.Point(5, 5);
            this.literarySorceGroupBox.Name = "literarySorceGroupBox";
            this.literarySorceGroupBox.Size = new System.Drawing.Size(536, 323);
            this.literarySorceGroupBox.TabIndex = 0;
            this.literarySorceGroupBox.TabStop = false;
            this.literarySorceGroupBox.Text = "LiterarySource";
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(423, 246);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(103, 48);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.Close_Click);
            // 
            // removeLiterarySourceButton
            // 
            this.removeLiterarySourceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeLiterarySourceButton.Location = new System.Drawing.Point(219, 246);
            this.removeLiterarySourceButton.Name = "removeLiterarySourceButton";
            this.removeLiterarySourceButton.Size = new System.Drawing.Size(99, 48);
            this.removeLiterarySourceButton.TabIndex = 2;
            this.removeLiterarySourceButton.Text = "Remove Literary Source";
            this.removeLiterarySourceButton.UseVisualStyleBackColor = true;
            // 
            // addLiterarySourceButton
            // 
            this.addLiterarySourceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addLiterarySourceButton.Location = new System.Drawing.Point(7, 246);
            this.addLiterarySourceButton.Name = "addLiterarySourceButton";
            this.addLiterarySourceButton.Size = new System.Drawing.Size(104, 48);
            this.addLiterarySourceButton.TabIndex = 1;
            this.addLiterarySourceButton.Text = "Add Literary Source";
            this.addLiterarySourceButton.UseVisualStyleBackColor = true;
            this.addLiterarySourceButton.Click += new System.EventHandler(this.addLiterarySourceButton_Click);
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

        #endregion

        private System.Windows.Forms.GroupBox literarySorceGroupBox;
        private System.Windows.Forms.DataGridView DescriptionSourceDataGridView;
        private System.Windows.Forms.Button removeLiterarySourceButton;
        private System.Windows.Forms.Button addLiterarySourceButton;
        private System.Windows.Forms.Button closeButton;
    }
}

