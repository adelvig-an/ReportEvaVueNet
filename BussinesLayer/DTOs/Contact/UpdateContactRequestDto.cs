namespace BussinesLayer.DTOs.Contact
{
    public class UpdateContactRequestDto
    {
        public string Name { get; set; } = string.Empty;
        public string Ptronymic { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = new DateTime();
    }
}
