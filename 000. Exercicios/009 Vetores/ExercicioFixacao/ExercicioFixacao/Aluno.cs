using System.Runtime.CompilerServices;

namespace ExercicioFixacao {
    internal class Aluno {

        public string Name { get; set; }
        public string Email { get; set; }

        public Aluno(string name, string email) {
            Name = name;
            Email = email;
        }

        public override string ToString() {
            return Name + ", " + Email;
        }

    }
}
