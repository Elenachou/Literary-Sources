namespace veiw
{
    partial class AddLiterarySourceForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.RandomButton = new System.Windows.Forms.Button();
            this.typeLiterarySourceGroupBox = new System.Windows.Forms.GroupBox();
            this.journalArticleRadioButton = new System.Windows.Forms.RadioButton();
            this.electronicResourceRadioButton = new System.Windows.Forms.RadioButton();
            this.bookRadioButton = new System.Windows.Forms.RadioButton();
            this.fieldsGroupBox = new System.Windows.Forms.GroupBox();
            this.statementOfRasponsibilityLabel = new System.Windows.Forms.Label();
            this.typeLiterarySourceGroupBox.SuspendLayout();
            this.fieldsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(283, 290);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(103, 44);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(629, 290);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(102, 44);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // RandomButton
            // 
            this.RandomButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RandomButton.Location = new System.Drawing.Point(454, 290);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(103, 44);
            this.RandomButton.TabIndex = 10;
            this.RandomButton.Text = "Random";
            this.RandomButton.UseVisualStyleBackColor = true;
            this.RandomButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // typeLiterarySourceGroupBox
            // 
            this.typeLiterarySourceGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.typeLiterarySourceGroupBox.Controls.Add(this.journalArticleRadioButton);
            this.typeLiterarySourceGroupBox.Controls.Add(this.electronicResourceRadioButton);
            this.typeLiterarySourceGroupBox.Controls.Add(this.bookRadioButton);
            this.typeLiterarySourceGroupBox.Location = new System.Drawing.Point(12, 4);
            this.typeLiterarySourceGroupBox.Name = "typeLiterarySourceGroupBox";
            this.typeLiterarySourceGroupBox.Size = new System.Drawing.Size(219, 203);
            this.typeLiterarySourceGroupBox.TabIndex = 3;
            this.typeLiterarySourceGroupBox.TabStop = false;
            this.typeLiterarySourceGroupBox.Text = "TypeLiterarySource";
            // 
            // journalArticleRadioButton
            // 
            this.journalArticleRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.journalArticleRadioButton.AutoSize = true;
            this.journalArticleRadioButton.Location = new System.Drawing.Point(17, 110);
            this.journalArticleRadioButton.Name = "journalArticleRadioButton";
            this.journalArticleRadioButton.Size = new System.Drawing.Size(88, 17);
            this.journalArticleRadioButton.TabIndex = 2;
            this.journalArticleRadioButton.TabStop = true;
            this.journalArticleRadioButton.Text = "JournalArticle";
            this.journalArticleRadioButton.UseVisualStyleBackColor = true;
            // 
            // electronicResourceRadioButton
            // 
            this.electronicResourceRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.electronicResourceRadioButton.AutoSize = true;
            this.electronicResourceRadioButton.Location = new System.Drawing.Point(17, 71);
            this.electronicResourceRadioButton.Name = "electronicResourceRadioButton";
            this.electronicResourceRadioButton.Size = new System.Drawing.Size(118, 17);
            this.electronicResourceRadioButton.TabIndex = 1;
            this.electronicResourceRadioButton.TabStop = true;
            this.electronicResourceRadioButton.Text = "ElectronicResource";
            this.electronicResourceRadioButton.UseVisualStyleBackColor = true;
            // 
            // bookRadioButton
            // 
            this.bookRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bookRadioButton.AutoSize = true;
            this.bookRadioButton.Location = new System.Drawing.Point(17, 30);
            this.bookRadioButton.Name = "bookRadioButton";
            this.bookRadioButton.Size = new System.Drawing.Size(50, 17);
            this.bookRadioButton.TabIndex = 0;
            this.bookRadioButton.TabStop = true;
            this.bookRadioButton.Text = "Book";
            this.bookRadioButton.UseVisualStyleBackColor = true;
            this.bookRadioButton.CheckedChanged += new System.EventHandler(this.bookRadioButton_CheckedChanged);
            // 
            // fieldsGroupBox
            // 
            this.fieldsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fieldsGroupBox.Controls.Add(this.statementOfRasponsibilityLabel);
            this.fieldsGroupBox.Location = new System.Drawing.Point(259, 4);
            this.fieldsGroupBox.Name = "fieldsGroupBox";
            this.fieldsGroupBox.Size = new System.Drawing.Size(536, 280);
            this.fieldsGroupBox.TabIndex = 11;
            this.fieldsGroupBox.TabStop = false;
            this.fieldsGroupBox.Text = "Fields";
            this.fieldsGroupBox.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.fieldsGroupBox_ControlAdded);
            // 
            // statementOfRasponsibilityLabel
            // 
            this.statementOfRasponsibilityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.statementOfRasponsibilityLabel.AutoSize = true;
            this.statementOfRasponsibilityLabel.Location = new System.Drawing.Point(46, 110);
            this.statementOfRasponsibilityLabel.Name = "statementOfRasponsibilityLabel";
            this.statementOfRasponsibilityLabel.Size = new System.Drawing.Size(0, 13);
            this.statementOfRasponsibilityLabel.TabIndex = 4;
            // 
            // AddLiterarySourceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 367);
            this.Controls.Add(this.fieldsGroupBox);
            this.Controls.Add(this.RandomButton);
            this.Controls.Add(this.typeLiterarySourceGroupBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Name = "AddLiterarySourceForm";
            this.Text = "AddLiterarySourceForm";
            this.typeLiterarySourceGroupBox.ResumeLayout(false);
            this.typeLiterarySourceGroupBox.PerformLayout();
            this.fieldsGroupBox.ResumeLayout(false);
            this.fieldsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button RandomButton;
        private System.Windows.Forms.GroupBox typeLiterarySourceGroupBox;
        private System.Windows.Forms.RadioButton journalArticleRadioButton;
        private System.Windows.Forms.RadioButton electronicResourceRadioButton;
        private System.Windows.Forms.RadioButton bookRadioButton;
        private System.Windows.Forms.GroupBox fieldsGroupBox;
        private System.Windows.Forms.Label statementOfRasponsibilityLabel;
    }
}