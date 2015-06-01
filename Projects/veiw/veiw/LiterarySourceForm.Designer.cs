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
            this.LiterarySorceGroupBox = new System.Windows.Forms.GroupBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.RemoveLiterarySourceButton = new System.Windows.Forms.Button();
            this.AddLiterarySourceButton = new System.Windows.Forms.Button();
            this.DescriptionSourceDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.failToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.literarySourceControl1 = new view.LiterarySourceControl();
            this.LiterarySorceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionSourceDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LiterarySorceGroupBox
            // 
            this.LiterarySorceGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LiterarySorceGroupBox.Controls.Add(this.CloseButton);
            this.LiterarySorceGroupBox.Controls.Add(this.RemoveLiterarySourceButton);
            this.LiterarySorceGroupBox.Controls.Add(this.AddLiterarySourceButton);
            this.LiterarySorceGroupBox.Controls.Add(this.DescriptionSourceDataGridView);
            this.LiterarySorceGroupBox.Controls.Add(this.menuStrip1);
            this.LiterarySorceGroupBox.Location = new System.Drawing.Point(5, 5);
            this.LiterarySorceGroupBox.Name = "LiterarySorceGroupBox";
            this.LiterarySorceGroupBox.Size = new System.Drawing.Size(529, 323);
            this.LiterarySorceGroupBox.TabIndex = 0;
            this.LiterarySorceGroupBox.TabStop = false;
            this.LiterarySorceGroupBox.Text = "LiterarySource";
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Location = new System.Drawing.Point(416, 269);
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
            this.RemoveLiterarySourceButton.Location = new System.Drawing.Point(213, 269);
            this.RemoveLiterarySourceButton.Name = "RemoveLiterarySourceButton";
            this.RemoveLiterarySourceButton.Size = new System.Drawing.Size(99, 48);
            this.RemoveLiterarySourceButton.TabIndex = 2;
            this.RemoveLiterarySourceButton.Text = "Remove Literary Source";
            this.RemoveLiterarySourceButton.UseVisualStyleBackColor = true;
            this.RemoveLiterarySourceButton.Click += new System.EventHandler(this.RemoveLiterarySourceButton_Click);
            // 
            // AddLiterarySourceButton
            // 
            this.AddLiterarySourceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddLiterarySourceButton.Location = new System.Drawing.Point(0, 269);
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
            this.DescriptionSourceDataGridView.Location = new System.Drawing.Point(3, 43);
            this.DescriptionSourceDataGridView.Name = "DescriptionSourceDataGridView";
            this.DescriptionSourceDataGridView.Size = new System.Drawing.Size(516, 214);
            this.DescriptionSourceDataGridView.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.failToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 16);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(523, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // failToolStripMenuItem
            // 
            this.failToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.downloadToolStripMenuItem,
            this.newListToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.failToolStripMenuItem.Name = "failToolStripMenuItem";
            this.failToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.failToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // downloadToolStripMenuItem
            // 
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            this.downloadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.downloadToolStripMenuItem.Text = "Download";
            // 
            // newListToolStripMenuItem
            // 
            this.newListToolStripMenuItem.Name = "newListToolStripMenuItem";
            this.newListToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newListToolStripMenuItem.Text = "New List";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // literarySourceControl1
            // 
            this.literarySourceControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.literarySourceControl1.LiterarySource = null;
            this.literarySourceControl1.Location = new System.Drawing.Point(530, 5);
            this.literarySourceControl1.Name = "literarySourceControl1";
            this.literarySourceControl1.Size = new System.Drawing.Size(605, 281);
            this.literarySourceControl1.TabIndex = 0;
            // 
            // LiterarySourceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1130, 340);
            this.Controls.Add(this.literarySourceControl1);
            this.Controls.Add(this.LiterarySorceGroupBox);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LiterarySourceForm";
            this.Text = "LiterarySourceForm";
            this.LiterarySorceGroupBox.ResumeLayout(false);
            this.LiterarySorceGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionSourceDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void addLiterarySourceButton_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.GroupBox LiterarySorceGroupBox;
        private System.Windows.Forms.DataGridView DescriptionSourceDataGridView;
        private System.Windows.Forms.Button RemoveLiterarySourceButton;
        private System.Windows.Forms.Button AddLiterarySourceButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem failToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private LiterarySourceControl literarySourceControl1;
    }
}

