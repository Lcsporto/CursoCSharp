
namespace Course.Entities.Exceptions
{
    internal class DomainException : ApplicationException // Ela é uma subclasse da Application, que é personalizável. 
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
