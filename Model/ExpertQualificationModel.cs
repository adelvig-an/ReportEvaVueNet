using System.ComponentModel;

namespace Model
{
    public class ExpertQualificationModel
    {
        public int Id { get; set; }
        public QualificationType QualificationType { get; set; }
        public string Name { get; set; } = string.Empty; //Название кваливицирующего органа
        public string DirectionQualification { get; set; } = string.Empty; //Направление квалификации
        public string Serial { get; set; } = string.Empty; //Серия квалификационного документа
        public string Number { get; set; } = string.Empty; //Номер квалификационного документа
        public DateTime IssueDate { get; set; } //Дата выдачи
        public DateTime ExpirationDate { get; set; } //Дата истечения срока действия
        public SpecialityType SpecialityType { get; set; }
        public string PathImage { get; set; } = string.Empty; //Путь к изображениям квалификационных документов в JSON
    }

    public enum QualificationType
    {
        [Description("Диплом о высшем образовании")]
        HigherEducationDiploma,
        [Description("Диплом о профессиональной квалификации")]
        ProfessionalQualificationDiploma,
        [Description("Повышение квалификации")]
        AdvancedTrainingCertificate,
        [Description("Квалификационный аттестат")]
        QualificationCertificate,
        [Description("Сертификат соответствия")]
        ConformityCertificate
    }

    public enum SpecialityType
    {
        [Description("Оценка недвижимости")]
        EstateAppraisal = 0,
        [Description("Оценка движимого имущества")]
        ValuationOfMovableProperty = 1,
        [Description("Оценка бизнеса")]
        BusinessValuation = 2
    }
}
