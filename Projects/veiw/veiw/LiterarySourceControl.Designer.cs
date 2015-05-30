namespace view
{
    partial class LiterarySourceControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TypeLiterarySourceGroupBox = new System.Windows.Forms.GroupBox();
            this.JournalArticleRadioButton = new System.Windows.Forms.RadioButton();
            this.ElectronicResourceRadioButton = new System.Windows.Forms.RadioButton();
            this.BookRadioButton = new System.Windows.Forms.RadioButton();
            this.FieldsGroupBox = new System.Windows.Forms.GroupBox();
            this.TypeLiterarySourceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TypeLiterarySourceGroupBox
            // 
            this.TypeLiterarySourceGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeLiterarySourceGroupBox.Controls.Add(this.JournalArticleRadioButton);
            this.TypeLiterarySourceGroupBox.Controls.Add(this.ElectronicResourceRadioButton);
            this.TypeLiterarySourceGroupBox.Controls.Add(this.BookRadioButton);
            this.TypeLiterarySourceGroupBox.Location = new System.Drawing.Point(13, 6);
            this.TypeLiterarySourceGroupBox.Name = "TypeLiterarySourceGroupBox";
            this.TypeLiterarySourceGroupBox.Size = new System.Drawing.Size(219, 203);
            this.TypeLiterarySourceGroupBox.TabIndex = 0;
            this.TypeLiterarySourceGroupBox.TabStop = false;
            this.TypeLiterarySourceGroupBox.Text = "TypeLiterarySource";
            // 
            // JournalArticleRadioButton
            // 
            this.JournalArticleRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.JournalArticleRadioButton.AutoSize = true;
            this.JournalArticleRadioButton.Location = new System.Drawing.Point(17, 110);
            this.JournalArticleRadioButton.Name = "JournalArticleRadioButton";
            this.JournalArticleRadioButton.Size = new System.Drawing.Size(88, 17);
            this.JournalArticleRadioButton.TabIndex = 2;
            this.JournalArticleRadioButton.TabStop = true;
            this.JournalArticleRadioButton.Text = "JournalArticle";
            this.JournalArticleRadioButton.UseVisualStyleBackColor = true;
            this.JournalArticleRadioButton.CheckedChanged += new System.EventHandler(this.JournalArticleRadioButton_CheckedChanged);
            // 
            // ElectronicResourceRadioButton
            // 
            this.ElectronicResourceRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ElectronicResourceRadioButton.AutoSize = true;
            this.ElectronicResourceRadioButton.Location = new System.Drawing.Point(17, 71);
            this.ElectronicResourceRadioButton.Name = "ElectronicResourceRadioButton";
            this.ElectronicResourceRadioButton.Size = new System.Drawing.Size(118, 17);
            this.ElectronicResourceRadioButton.TabIndex = 1;
            this.ElectronicResourceRadioButton.TabStop = true;
            this.ElectronicResourceRadioButton.Text = "ElectronicResource";
            this.ElectronicResourceRadioButton.UseVisualStyleBackColor = true;
            this.ElectronicResourceRadioButton.CheckedChanged += new System.EventHandler(this.ElectronicResourceRadioButton_CheckedChanged);
            // 
            // BookRadioButton
            // 
            this.BookRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BookRadioButton.AutoSize = true;
            this.BookRadioButton.Location = new System.Drawing.Point(17, 30);
            this.BookRadioButton.Name = "BookRadioButton";
            this.BookRadioButton.Size = new System.Drawing.Size(50, 17);
            this.BookRadioButton.TabIndex = 0;
            this.BookRadioButton.TabStop = true;
            this.BookRadioButton.Text = "Book";
            this.BookRadioButton.UseVisualStyleBackColor = true;
            this.BookRadioButton.CheckedChanged += new System.EventHandler(this.BookRadioButton_CheckedChanged);
            // 
            // FieldsGroupBox
            // 
            this.FieldsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FieldsGroupBox.Location = new System.Drawing.Point(248, 6);
            this.FieldsGroupBox.Name = "FieldsGroupBox";
            this.FieldsGroupBox.Size = new System.Drawing.Size(536, 282);
            this.FieldsGroupBox.TabIndex = 1;
            this.FieldsGroupBox.TabStop = false;
            this.FieldsGroupBox.Text = "Fields";
            // 
            // LiterarySourceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FieldsGroupBox);
            this.Controls.Add(this.TypeLiterarySourceGroupBox);
            this.Name = "LiterarySourceControl";
            this.Size = new System.Drawing.Size(800, 288);
            this.TypeLiterarySourceGroupBox.ResumeLayout(false);
            this.TypeLiterarySourceGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TypeLiterarySourceGroupBox;
        private System.Windows.Forms.RadioButton BookRadioButton;
        private System.Windows.Forms.RadioButton ElectronicResourceRadioButton;
        private System.Windows.Forms.RadioButton JournalArticleRadioButton;
        private System.Windows.Forms.GroupBox FieldsGroupBox;
    }
}
