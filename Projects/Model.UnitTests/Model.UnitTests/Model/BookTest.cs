using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace Model.UnitTests.Model
{
    [TestFixture]
    public class BookTest
    {

        private int TestLaunchCount = 0;

        [SetUp]
        public void InitSetup()
        {
            TestLaunchCount++;
        }
        [Repeat(3)]
        /// <summary>
        /// Тест на проверку на отрицательное значение страниц.
        /// </summary>
        /// <param name="count">Количество страниц в книге</param>
        [Test]
        [TestCase (1,TestName= "Тестирование Count при присваивании 1.PositiveValue")]
        [TestCase(2, TestName = "Тестирование Count при присваивании 2.PositiveValue")]
        [TestCase(0, TestName = "Тестирование Count при присваивании 0.PositiveValue")]
        [TestCase(5, TestName = "Тестирование Count при присваивании 5.PositiveValue")]
        [TestCase(-1, ExpectedException = typeof(ArgumentException), TestName = "Тестирование Count при присваивании -1.NegativeValue")]
        [TestCase(-2, ExpectedException = typeof(ArgumentException), TestName = "Тестирование Count при присваивании -2.NegativeValue")]
        [TestCase(-6, ExpectedException = typeof(ArgumentException), TestName = "Тестирование Count при присваивании -6.NegativeValue")]
        [TestCase(-7, ExpectedException = typeof(ArgumentException), TestName = "Тестирование Count при присваивании -7.NegativeValue")]
        public void CountOfPagesTest(int count)
        {
            var book = new Book();
            book.CountOfPages = count;
        }

        /// <summary>
        /// Тест на проверку превышение текущей даты.
        /// </summary>
        /// <param name="year">Год издания книги</param>
        [Test]
        [TestCase(2015, TestName = "Тестирование Year при присваивании 2015.PositiveValue")]
        [TestCase(2003, TestName = "Тестирование Year при присваивании 2003.PositiveValue")]
        [TestCase(2020, ExpectedException = typeof(ArgumentException), TestName = "Тестирование Year при присваивании 2020.NegativeValue")]
        [TestCase(2030, ExpectedException = typeof(ArgumentException), TestName = "Тестирование Year при присваивании 2030.NegativeValue")]
        [TestCase(4000, ExpectedException = typeof(ArgumentException), TestName = "Тестирование Year при присваивании 4000.NegativeValue")]
        public void YearOfManufacture(int year)
        {
            var book = new Book();
            book.YearOfManufacture = year;
        }

        /// <summary>
        /// Тест метода GetDescription() для статьи книги.
        /// </summary>
        [Test]
        public void GetDescriptionTest()
        {
            var expected = "Бычкова С.М.Планирование в аудите/С.М. Бычкова, А.В.Газорян,2007.- 263";
            var book = new Book()
            {
            Author = "Бычкова С.М",
            Title = "Планирование в аудите",
            StatementOfResponsibility = "С.М. Бычкова, А.В.Газорян",
            YearOfManufacture = 2007,
            CountOfPages = 263
            };
            var actual = book.GetDescription();
            Assert.AreEqual(expected, actual);
        }
    }
}
