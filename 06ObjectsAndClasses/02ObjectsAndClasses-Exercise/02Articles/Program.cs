using System;
using System.Linq;

namespace _02Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(',').Select(x => x.Trim()).ToArray();
            string title = data[0];
            string content = data[1];
            string author = data[2];
            Article article = new Article(title, content, author);

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                data = Console.ReadLine().Split(':').Select(x => x.Trim()).ToArray();
                string command = data[0];

                if (command == "Edit")
                {
                    string newContent = data[1];
                    article.Edit(newContent);
                }
                else if (command == "ChangeAuthor")
                {
                    string newAuthor = data[1];
                    article.ChangeAuthor(newAuthor);

                }
                else if (command == "Rename")
                {
                    string newTitle = data[1];
                    article.Rename(newTitle);
                }
            }

            Console.WriteLine(article.ToString());
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

        public void Edit(string newContent)
        {
            this.Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            this.Title = newTitle;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}
