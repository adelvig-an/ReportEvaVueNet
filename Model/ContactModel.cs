namespace Model
{
    public class ContactModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // Имя контакта
        public string Patronymic { get; set; } = string.Empty; // Отчество контакта
        public string Surname { get; set; } = string.Empty; // Фамилия контакта
    }
}
