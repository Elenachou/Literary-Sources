namespace veiw
{
    partial class BookControl
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
            this.authorLabel = new System.Windows.Forms.Label();
            this.titleAuthor = new System.Windows.Forms.Label();
            this.statementOfResponsibilityLabel = new System.Windows.Forms.Label();
            this.yearOfManufactureLabel = new System.Windows.Forms.Label();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.statementOfResponsibilityTextBox = new System.Windows.Forms.TextBox();
            this.yearOfManufactureTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(17, 21);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(38, 13);
            this.authorLabel.TabIndex = 0;
            this.authorLabel.Text = "Author";
            // 
            // titleAuthor
            // 
            this.titleAuthor.AutoSize = true;
            this.titleAuthor.Location = new System.Drawing.Point(17, 58);
            this.titleAuthor.Name = "titleAuthor";
            this.titleAuthor.Size = new System.Drawing.Size(27, 13);
            this.titleAuthor.TabIndex = 1;
            this.titleAuthor.Text = "Title";
            // 
            // statementOfResponsibilityLabel
            // 
            this.statementOfResponsibilityLabel.AutoSize = true;
            this.statementOfResponsibilityLabel.Location = new System.Drawing.Point(17, 92);
            this.statementOfResponsibilityLabel.Name = "statementOfResponsibilityLabel";
            this.statementOfResponsibilityLabel.Size = new System.Drawing.Size(129, 13);
            this.statementOfResponsibilityLabel.TabIndex = 2;
            this.statementOfResponsibilityLabel.Text = "Statement of responsibility";
            // 
            // yearOfManufactureLabel
            // 
            this.yearOfManufactureLabel.AutoSize = true;
            this.yearOfManufactureLabel.Location = new System.Drawing.Point(20, 128);
            this.yearOfManufactureLabel.Name = "yearOfManufactureLabel";
            this.yearOfManufactureLabel.Size = new System.Drawing.Size(103, 13);
            this.yearOfManufactureLabel.TabIndex = 3;
            this.yearOfManufactureLabel.Text = "Year of manufacture";
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(158, 21);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(190, 20);
            this.authorTextBox.TabIndex = 4;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(158, 58);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(364, 20);
            this.titleTextBox.TabIndex = 5;
            // 
            // statementOfResponsibilityTextBox
            // 
            this.statementOfResponsibilityTextBox.Location = new System.Drawing.Point(158, 92);
            this.statementOfResponsibilityTextBox.Name = "statementOfResponsibilityTextBox";
            this.statementOfResponsibilityTextBox.Size = new System.Drawing.Size(190, 20);
            this.statementOfResponsibilityTextBox.TabIndex = 6;
            // 
            // yearOfManufactureTextBox
            // 
            this.yearOfManufactureTextBox.Location = new System.Drawing.Point(158, 128);
            this.yearOfManufactureTextBox.Name = "yearOfManufactureTextBox";
            this.yearOfManufactureTextBox.Size = new System.Drawing.Size(71, 20);
            this.yearOfManufactureTextBox.TabIndex = 7;
            // 
            // BookControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.yearOfManufactureTextBox);
            this.Controls.Add(this.statementOfResponsibilityTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.yearOfManufactureLabel);
            this.Controls.Add(this.statementOfResponsibilityLabel);
            this.Controls.Add(this.titleAuthor);
            this.Controls.Add(this.authorLabel);
            this.Name = "BookControl";
            this.Size = new System.Drawing.Size(536, 280);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label titleAuthor;
        private System.Windows.Forms.Label statementOfResponsibilityLabel;
        private System.Windows.Forms.Label yearOfManufactureLabel;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox statementOfResponsibilityTextBox;
        private System.Windows.Forms.TextBox yearOfManufactureTextBox;
    }
}
