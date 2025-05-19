using System.ComponentModel;

namespace Model
{
    /// <summary>
    /// Информация об объекте оценки.
    /// Соответствует пункту 3.1 Задания на оценку.
    /// </summary>
    public class EvaluationObjectInfo
    {
        public int Id { get; set; }
        /// <summary>
        /// Описание объекта оценки, включая количественные и качественные характеристики.
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Права на объект оценки, учитываемые при определении стоимости.
        /// </summary>
        public RightsBeingValued RightsBeingValued { get; set; }

        /// <summary>
        /// Описание ограничений и обременений, связанных с правами на объект оценки.
        /// </summary>
        public List<string>? LimitationsAndEncumbrances { get; set; }
    }

    public enum RightsBeingValued
    {
        [Description("Право собственности")]
        Ownership = 0,
        [Description("Право аренды")]
        Lease = 1,
        [Description("Право залога")]
        Pledge = 2,
        [Description("Право сервитута")] 
        Servitude = 3,
        [Description("Право пользования")] 
        Use = 4
    }
}
