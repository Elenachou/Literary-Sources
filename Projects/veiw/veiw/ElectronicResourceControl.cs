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
                Author = AuthorTextBox.Text,
                Title = TitleTextBox.Text,
                StatementOfResponsibility = StatementOfResponsibilityTextBox.Text,
                YearOfManufacture = Convert.ToInt32(YearOfManufactureTextBox.Text),
                TypeOfResource = typeOfResourceTextBox.Text,
                PlaceOfPublication = PlaceOfPublicationTextBox.Text,
                PublishingHouse = PublishingHouseTextBox.Text,
                Series = SeriesTextBox.Text
            };

        }
    }
}