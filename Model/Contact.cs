namespace Model
{
    // Данный класс содержит поля для хранения информации о контактах и судебных определениях. Общее название "Основание" для выполнения работ.
    public class Contact
    {
        public int Id { get; set; }
        public string LastName { get; set; } // Фамилия
        public string FirstName { get; set; } // Имя
        public string Patronymic { get; set; } // Отчество
        public string Phone { get; set; } // Телефон
        public string Email { get; set; } // Электронная почта
    }
}
