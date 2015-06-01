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
            this.TypeLiterarySourceGroupBox.Controls.Add(this.JournalArticleRadioButton);
            this.TypeLiterarySourceGroupBox.Controls.Add(this.ElectronicResourceRadioButton);
            this.TypeLiterarySourceGroupBox.Controls.Add(this.BookRadioButton);
            this.TypeLiterarySourceGroupBox.Location = new System.Drawing.Point(6, 6);
            this.TypeLiterarySourceGroupBox.Name = "TypeLiterarySourceGroupBox";
            this.TypeLiterarySourceGroupBox.Size = new System.Drawing.Size(142, 114);
            this.TypeLiterarySourceGroupBox.TabIndex = 0;
            this.TypeLiterarySourceGroupBox.TabStop = false;
            this.TypeLiterarySourceGroupBox.Text = "Literary Source Type";
            // 
            // JournalArticleRadioButton
            // 
            this.JournalArticleRadioButton.AutoSize = true;
            this.JournalArticleRadioButton.Location = new System.Drawing.Point(11, 78);
            this.JournalArticleRadioButton.Name = "JournalArticleRadioButton";
            this.JournalArticleRadioButton.Size = new System.Drawing.Size(91, 17);
            this.JournalArticleRadioButton.TabIndex = 2;
            this.JournalArticleRadioButton.TabStop = true;
            this.JournalArticleRadioButton.Text = "Journal Article";
            this.JournalArticleRadioButton.UseVisualStyleBackColor = true;
            this.JournalArticleRadioButton.CheckedChanged += new System.EventHandler(this.JournalArticleRadioButton_CheckedChanged);
            // 
            // ElectronicResourceRadioButton
            // 
            this.ElectronicResourceRadioButton.AutoSize = true;
            this.ElectronicResourceRadioButton.Location = new System.Drawing.Point(11, 54);
            this.ElectronicResourceRadioButton.Name = "ElectronicResourceRadioButton";
            this.ElectronicResourceRadioButton.Size = new System.Drawing.Size(121, 17);
            this.ElectronicResourceRadioButton.TabIndex = 1;
            this.ElectronicResourceRadioButton.TabStop = true;
            this.ElectronicResourceRadioButton.Text = "Electronic Resource";
            this.ElectronicResourceRadioButton.UseVisualStyleBackColor = true;
            this.ElectronicResourceRadioButton.CheckedChanged += new System.EventHandler(this.ElectronicResourceRadioButton_CheckedChanged);
            // 
            // BookRadioButton
            // 
            this.BookRadioButton.AutoSize = true;
            this.BookRadioButton.Location = new System.Drawing.Point(11, 30);
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
            this.FieldsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FieldsGroupBox.Location = new System.Drawing.Point(155, 6);
            this.FieldsGroupBox.Name = "FieldsGroupBox";
            this.FieldsGroupBox.Size = new System.Drawing.Size(427, 298);
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
            this.Size = new System.Drawing.Size(588, 313);
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
