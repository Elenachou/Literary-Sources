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
        /// <summary>
        /// Тест на проверку на отрицательное значение страниц.
        /// </summary>
        /// <param name="count">Количество страниц в книге</param>
        [Test]
        [TestCase (1,TestName= "Тестирование Count при присваивании 1.")]
        [TestCase(2, TestName = "Тестирование Count при присваивании 2.")]
        [TestCase(0, TestName = "Тестирование Count при присваивании 0.")]
        [TestCase(5, TestName = "Тестирование Count при присваивании 5.")]
        [TestCase(-1, ExpectedException = typeof(ArgumentException), TestName = "Тестирование Count при присваивании -1.")]
        [TestCase(-2, ExpectedException = typeof(ArgumentException), TestName = "Тестирование Count при присваивании -2.")]
        [TestCase(-6, ExpectedException = typeof(ArgumentException), TestName = "Тестирование Count при присваивании -6.")]
        [TestCase(-7, ExpectedException = typeof(ArgumentException), TestName = "Тестирование Count при присваивании -7.")]
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
        [TestCase(2015, TestName = "Тестирование Year при присваивании 2015")]
        [TestCase(2003, TestName = "Тестирование Year при присваивании 2003")]
        [TestCase(2020, ExpectedException = typeof(ArgumentException), TestName = "Тестирование Year при присваивании 2020")]
        [TestCase(2030, ExpectedException = typeof(ArgumentException), TestName = "Тестирование Year при присваивании 2030")]
        [TestCase(4000, ExpectedException = typeof(ArgumentException), TestName = "Тестирование Year при присваивании 4000")]
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
