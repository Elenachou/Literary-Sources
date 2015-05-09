using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Model.UnitTests.Model
{
    class ElectronisResourceTest
    {
        /// <summary>
        /// Год издания.
        /// </summary>
        /// <param name="year">Год издания электронного ресурса</param>
        [Test]
        [TestCase(2015, TestName = "Тестирование Year при присваивании 2015")]
        [TestCase(2000, TestName = "Тестирование Year при присваивании 2000")]
        [TestCase(2020, ExpectedException = typeof(ArgumentException), TestName = "Тестирование Year при присваивании 2020")]
        [TestCase(2034, ExpectedException = typeof(ArgumentException), TestName = "Тестирование Year при присваивании 2034")]
        [TestCase(8000, ExpectedException = typeof(ArgumentException), TestName = "Тестирование Year при присваивании 8000")]
        public void YearOfManufacture(int year)
        {
            var electronicResource = new ElectronicResource();
            electronicResource.YearOfManufacture = year;
        }

        /// <summary>
        /// Тест метода GetDescription() для Электронного ресурса.
        /// </summary>
        [Test]
        public void GetDescriptionTest()
        {
            var expected =
                "Родников, А.Р.Логистика [Электронный ресурс]: терминологический словарь .-/А.Р. Родников.-Электронные данные.-Москва:ИНФРА-М,2000.-1 эл. опт. диск  (CD- ROM)";
            var electronicResource = new ElectronicResource()
            {
                Author = "Родников, А.Р",
                Title = "Логистика [Электронный ресурс]: терминологический словарь ",
                StatementOfResponsibility = "А.Р. Родников",
                YearOfManufacture = 2000,
                TypeOfResource = "Электронные данные",
                PlaceOfPublication = "Москва",
                PublishingHouse = "ИНФРА-М",
                Series = "1 эл. опт. диск  (CD- ROM)"
            };
            var actual = electronicResource.GetDescription();
            Assert.AreEqual(expected, actual);
        }
    }
}
