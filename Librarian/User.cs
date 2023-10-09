using Librarian.Model;

namespace Librarian
{
    public class User
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string? Password { get; set; } = null;
        public string Zip { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public bool IsEmployee { get; set; }
        public bool IsStudent { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public string? Citizen { get; set; } = null;
        public string IdCardNumber { get; set; }
        public EIDCardTypes IDCardType { get; set; }
        public bool Enabled { get; set; }
        public DateTime LastLogin {  get; set; }
    }
}
