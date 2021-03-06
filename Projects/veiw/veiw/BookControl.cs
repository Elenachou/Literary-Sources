﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace view
{
    public partial class BookControl : UserControl
    {
        public BookControl()
        {
            InitializeComponent();
        }

        public Book GetBook()
        {
            return new Book()
            {
                Author = authorTextBox.Text,
                Title = titleTextBox.Text,
                StatementOfResponsibility = statementOfResponsibilityTextBox.Text,
                YearOfManufacture = Convert.ToInt32(yearOfManufactureTextBox.Text),
                CountOfPages = Convert.ToInt32(countOfPagesTextBox.Text)
            };

        }
    }
}
