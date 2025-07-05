namespace Model
{
    public enum ApplicationStatus
    {
        InProgress = 0, // В работе
        Completed = 1, // Завершена
        Cancelled = 2 // Отменена
    }
    /// <summary>
    /// Общие данные о заявке
    /// - Идентификатор заявки
    /// - Дата создания
    /// - Дата дедлайна
    /// - Статус заявки
    /// - Связанные сущности
    /// - Автор заявки
    /// - Исполнитель
    /// - Клиент
    /// - Объект оценки
    /// </summary>
    public class AppllicationsModel
    {
        public int AppllicationId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime Deadline { get; set; }
        public ApplicationStatus Status { get; set; }

        /// <summary>
        /// Связанные сущности
        /// - Автор заявки
        /// - Исполнитель
        /// - Клиент
        /// - Объект
        /// </summary>
        public EmployeesModel AssgreeId { get; set; } = new EmployeesModel(); // Автор заявки
        public EmployeesModel EmployeeId { get; set; } = new EmployeesModel(); // Исполнитель заявки
        public ClientsModel ClientId { get; set; } = new ClientsModel(); // Клиент заявки
        public ValuationObjectModel ValuationObjectId { get; set; } = new ValuationObjectModel();
    }
}
