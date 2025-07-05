namespace Model
{
    public enum EmployeePosition
    {
        Assessor = 0, // Оценщик
        Assistant = 1, // Ассистент
        Secretary = 2 // Секретарь
    }
    /// <summary>
    /// Данные исполнителя (оценщик/эксперт)
    /// - Хэш пароля
    /// - Должность
    /// - Контактные данные
    /// </summary>
    public class EmployeesModel
    {
        public int Id { get; set; }
        public string PasswordHash { get; set; } = string.Empty;
        public EmployeePosition Position { get; set; }
        public ContactsModel ContactId { get; set; } = new ContactsModel();
    }
}
