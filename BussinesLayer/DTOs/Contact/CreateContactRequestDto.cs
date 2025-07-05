using Model;

namespace BussinesLayer.DTOs.Contact
{
    public class CreateContactRequestDto
    {
        public string Name { get; set; } = string.Empty;
        public string Ptronymic { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public ContactRole ContactType { get; set; }
        public DateTime CreatedAt { get; set; } = new DateTime();
    }
}
