using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio002.Entities
{
    internal class Post
    {
        public DateTime Moment { get; set; }
        public String Title { get; set; }
        public String Content { get; set; }
        public int Likes { get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post() { }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment) { // Quandoio há uma relação de um para muitos (Quando criamos a lista como objeto) por padrão atribuimos o Add e Remove. 
            Comments.Add (comment);
        }

        public void RemoveComment(Comment comment) { 
            Comments.Remove (comment); 
        }

        public override string ToString()// Gerando o ToStrng de uma forma mais eficiente utilizando a classe StringBuilder. Faz parte do System.Text.
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");
            foreach (Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }

            return sb.ToString();
        }
    }
}
