namespace Model
{
    public enum ClientType
    {
        Individual = 0, // Физическое лицо
        LegalEntity = 1 // Юридическое лицо
    }

    /// <summary>
    /// Данные клиента
    /// - Сохранение типа клиента
    /// </summary>
    public class ClientsModel
    {
        public int ClientId { get; set; }
        /// <summary>
        /// Сохранение типа клиента
        /// - Физическое лицо
        /// - Юрридическое лицо
        /// </summary>
        public ClientType ClientType { get; set; }

        /// <summary>
        /// Детали клиента
        /// - Паспортные данные
        /// - Данные организации
        /// - Почтовый адрес
        /// и т.д.
        /// </summary>
    }
}
