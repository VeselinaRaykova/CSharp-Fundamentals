using System;
using System.Collections.Generic;
using System.Linq;

namespace _03Articles2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(',').Select(x => x.Trim()).ToArray();
                string title = data[0];
                string content = data[1];
                string author = data[2];
                Article article = new Article(title, content, author);
                articles.Add(article);
            }

            string criteria = Console.ReadLine();
            List<Article> orderedArticles = new List<Article>();

            switch (criteria)
            {
                case "title":
                    orderedArticles = articles.OrderBy(a => a.Title).ToList();
                    break;
                case "content":
                    orderedArticles = articles.OrderBy(a => a.Content).ToList();
                    break;
                case "author":
                    orderedArticles = articles.OrderBy(a => a.Author).ToList();
                    break;
                default:
                    break;
            }

            foreach (Article article in orderedArticles)
            {
                Console.WriteLine(article.ToString());
            }
        }
    }

    public class Article
    {
        public string Title;
        public string Content;
        public string Author;

        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}
