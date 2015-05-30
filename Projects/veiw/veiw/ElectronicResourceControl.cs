using System;
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
    public partial class ElectronicResourceControl : UserControl
    {
        public ElectronicResourceControl()
        {
            InitializeComponent();
        }
        public ElectronicResource GetElectronicResource()
        {
            return new ElectronicResource()
            {
                Author = authorTextBox.Text,
                Title = titleTextBox.Text,
                StatementOfResponsibility = statementOfResponsibilityTextBox.Text,
                YearOfManufacture = Convert.ToInt32(yearOfManufactureTextBox.Text),
                TypeOfResource = typeOfResourceTextBox.Text,
                PlaceOfPublication = placeOfPublicationTextBox.Text,
                PublishingHouse = publishingHouseTextBox.Text,
                Series = seriesTextBox.Text
            };

        }
    }
}