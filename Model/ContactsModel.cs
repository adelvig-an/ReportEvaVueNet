namespace Model
{
    /// <summary>
    /// Общие данные человека
    /// - Имя
    /// - Отчество
    /// - Фамилия
    /// - Email
    /// - Телефон
    /// - Дата создания
    /// - Ссылка на адрес
    /// </summary>
    public class ContactsModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Ptronymic { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = new DateTime();

        /// <summary>
        /// Ссылка на адрес
        /// </summary>
        public virtual AddressModel Address { get; set; } = new AddressModel();

    }
}
