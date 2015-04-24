using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Library
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int number = 1;
            int n;
            bool choose;

            do
            {
                Console.WriteLine("Что бы узнать о книге нажмите 1");
                Console.WriteLine("Что бы узнать о статье из журнала нажмите 2");
                Console.WriteLine("Что бы узнать об электронном ресурсе нажмите 3");

                do
                {
                    choose = false;
                    Console.WriteLine("Выберите действие");

                    n = Convert.ToInt32(Console.ReadLine());
                    if (n > 0)
                    {
                        choose = true;
                    }
                } while (choose == false);
                try
                {
                    ILiterarySource source;
                    switch (n)
                    {
                        case 1:
                        {
                            var book = new Book()
                            {
                                Author = "Бычкова С.М",
                                Title = "Планирование в аудите",
                                StatementOfResponsibility = "С.М. Бычкова, А.В.Газорян",
                                YearOfManufacture = 2007,
                                CountOfPages = 263
                            };
                            source = book;
                            Console.WriteLine("Aвтор: " + book.Author);
                            Console.WriteLine("Заглавие: " + book.Title);
                            Console.WriteLine("Сведения об ответственном: " + book.StatementOfResponsibility);
                            Console.WriteLine("Год издания:" + book.YearOfManufacture);
                            Console.WriteLine("Объем книги: " + book.CountOfPages);
                            Console.WriteLine("Информация о книге");
                            Console.WriteLine(source.GetDescription());
                            break;
                        }
                        case 2:
                        {
                            var journalArticle = new JournalArticle()
                            {
                                Author = "Тарасова, Н.Г",
                                Title = "Сведения об ответственном: Н.Г. Тарасова",
                                StatementOfResponsibility = "Н.Г. Тарасова",
                                YearOfManufacture = 2007,
                                NameJournal = "Архитектура и строительство России",
                                IssueNumber = 4
                            };
                            journalArticle.SetStartAndEndPage(2, 4);
                            int some = journalArticle.StartPage;
                            source = journalArticle;
                            Console.Write("Введите автора: " + journalArticle.Author);
                            Console.WriteLine("Заглавие: " + journalArticle.Title);
                            Console.WriteLine("Сведения об ответственном: " + journalArticle.StatementOfResponsibility);
                            Console.WriteLine("Название журнала: " + journalArticle.NameJournal);
                            Console.WriteLine("Год издания: " + journalArticle.YearOfManufacture);
                            Console.WriteLine("Номер журнала: " + journalArticle.IssueNumber);
                            Console.WriteLine("Начало статьи на странице: 2" + journalArticle.StartPage);
                            Console.WriteLine("Конец статьи на странице: 4" + journalArticle.EndPage);
                            Console.WriteLine("Информация о статье из журнала");
                            Console.WriteLine(source.GetDescription());
                            break;
                        }
                        case 3:
                        {
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
                            source = electronicResource;
                            Console.Write("Введите автора: " + electronicResource.Author);
                            Console.WriteLine("Заглавие: " + electronicResource.Title);
                            Console.WriteLine("Сведения об ответственном: " +
                                              electronicResource.StatementOfResponsibility);
                            Console.WriteLine("Обозначение вида ресурса: " + electronicResource.TypeOfResource);
                            Console.WriteLine("Год издания: " + electronicResource.YearOfManufacture);
                            Console.WriteLine("Место издания:" + electronicResource.PlaceOfPublication);
                            Console.WriteLine("Издательство: " + electronicResource.PublishingHouse);
                            Console.WriteLine("Серия: " + electronicResource.Series);
                            Console.WriteLine("Информация об электронном ресурсе ");
                            Console.WriteLine(source.GetDescription());
                            break;
                        }
                    }
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("Введен неправильный аргумент! ", e);
                }
                Console.WriteLine("Хотите продолжить?");
                Console.WriteLine("0. НЕТ     1. ДА");
                number = Convert.ToUInt16(Console.ReadLine());

            } while (number != 0);
        }
    }
}

