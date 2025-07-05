namespace Model
{
    /// <summary>
    /// Данные об оъекте оценки
    /// - Идентификатор объекта оценки
    /// - Название объекта оценки
    /// - Тип объекта оценки
    /// - Описание объекта оценки/исследования
    /// - Дата создания объекта оценки
    /// </summary>
    public class ValuationObjectModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ObjectType { get; set; } = string.Empty;
        /// <summary>
        /// Описание объекта оценки/исследования
        /// </summary>
        public string DescriptionObject { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
    }
}
