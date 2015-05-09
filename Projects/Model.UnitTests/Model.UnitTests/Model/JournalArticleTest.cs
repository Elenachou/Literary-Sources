using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Model.UnitTests.Model
{
    [TestFixture]
    class JournalArticleTest
    {
        /// <summary>
        /// Тест на отрицательное значение номера журнала.
        /// </summary>
        /// <param name="number">Номер</param>
        [Test]
        [TestCase(1, TestName = "Тестирование Number при присваивании 1.")]
        [TestCase(2, TestName = "Тестирование Number при присваивании 2.")]
        [TestCase(0, TestName = "Тестирование Number при присваивании 0.")]
        [TestCase(9, TestName = "Тестирование Number при присваивании 9.")]
        [TestCase(-1, ExpectedException = typeof(ArgumentException), TestName = "Тестирование Number при присваивании -1.")]
        [TestCase(-2, ExpectedException = typeof(ArgumentException), TestName = "Тестирование Number при присваивании -2.")]
        [TestCase(-6, ExpectedException = typeof(ArgumentException), TestName = "Тестирование Number при присваивании -6.")]
        [TestCase(-7, ExpectedException = typeof(ArgumentException), TestName = "Тестирование Number при присваивании -7.")]
        public void IssueNumberTest(int number)
        {
            var journalArticle = new JournalArticle();
            journalArticle.IssueNumber = number;
        }

        /// <summary>
        /// Год издания журнала.
        /// </summary>
        /// <param name="year">Год издания статьи из журнала</param>
        [Test]
        [TestCase(2015, TestName = "Тестирование Year при присваивании 2015")]
        [TestCase(2003, TestName = "Тестирование Year при присваивании 2003")]
        [TestCase(2020, ExpectedException = typeof(ArgumentException), TestName = "Тестирование Year при присваивании 2020")]
        [TestCase(2030, ExpectedException = typeof(ArgumentException), TestName = "Тестирование Year при присваивании 2030")]
        [TestCase(4000, ExpectedException = typeof(ArgumentException), TestName = "Тестирование Year при присваивании 4000")]
        public void YearOfManufacture(int year)
        {
            var journalArticle = new JournalArticle();
            journalArticle.YearOfManufacture = year;
        }

        /// <summary>
        /// Тест проверки на неотрицательные значения начальной и конечно страницы журнала, и на сравнения начальной и конечной страницы.
        /// </summary>
        /// <param name="startPage">Начальная страница статьи</param>
        /// <param name="endPage">Конечная страница статьи</param>
        [Test]
        [TestCase(2,4, TestName = "Тестирование SetStartAndEndPage присвоив EndPage значение 4,а StartPage 2.")]
        [TestCase(-2,4, ExpectedException = typeof(ArgumentException), TestName = "Тестирование SetStartAndEndPage StartPage присвоив -2.")]
        [TestCase(4,2, ExpectedException = typeof(ArgumentException), TestName = "Тестирование SetStartAndEndPage,начальная страница больше конечной.")]
        [TestCase(2,-4, ExpectedException = typeof(ArgumentException), TestName = "Тестирование SetStartAndEndPage,присвоив EndPage значение-1.")]
        [TestCase(-2, -4, ExpectedException = typeof(ArgumentException), TestName = "Тестирование SetStartAndEndPage ,StartPage присвоив -2,EndPage значение-1.")]
        public void SetStartAndEndPage(int startPage,int endPage)
        {
            var journalArticle = new JournalArticle();
            journalArticle.SetStartAndEndPage(startPage, endPage);

        }

        /// <summary>
        /// Тест метода GetDescription() для статьи из журнала.
        /// </summary>
        [Test]
        public void GetDescriptionTest()
        {
            var expected = "Тарасова, Н.Г.Смена парадигм в развитии теории и практики градостроительства/Н.Г. Тарасова//Архитектура и строительство России.- 2007.- 4.- 2 - 4";
            var journalArticle = new JournalArticle()
            {
                Author = "Тарасова, Н.Г",
                Title = "Смена парадигм в развитии теории и практики градостроительства",
                StatementOfResponsibility = "Н.Г. Тарасова",
                YearOfManufacture = 2007,
                NameJournal = "Архитектура и строительство России",
                IssueNumber = 4
            };
            journalArticle.SetStartAndEndPage(2, 4);
            var actual = journalArticle.GetDescription();
            Assert.AreEqual(expected, actual);
        }
    }
}
