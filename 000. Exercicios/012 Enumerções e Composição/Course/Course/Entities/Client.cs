using System.Text;

namespace Course.Entities
{
    internal class Client
    {
        public String Name { get; set; }
        public String Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client(string name, string email, string birthDate) // Verificar se ele entra aqui como data mesmo ou se entra como String e depois transformamos ele 
        {
            Name = name;
            Email = email;
            BirthDate = DateTime.Parse(birthDate);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Client: {Name} (" + BirthDate.ToString("dd/MM/yyyy") + $") - {Email}");

            return sb.ToString();
        }
    }
}
