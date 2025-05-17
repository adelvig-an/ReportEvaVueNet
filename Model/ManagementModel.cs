using System.ComponentModel;

namespace Model
{
    public class ManagementModel : ContactModel
    {
        public string Position { get; set; } = string.Empty; //Должность
        public AuthorizationDocuments AuthorizationDocuments { get; set; }
        public string NumberAuthorizationDocument { get; set; } = string.Empty; //Номер документа
        public DateTime DateOn { get; set; } //Дата начала
        public DateTime PowerOff { get; set; } //Дата "действует до"

    }

    public enum AuthorizationDocuments
    {
        [Description("Доверенность")]
        Doverennost = 0,
        [Description("Устав")]
        StatutOrganizatsii = 1,
        [Description("Положения о структурных подразделениях")]
        StructureSubdivisionRegulation = 2,
        [Description("Должностная инструкция")]
        PositionDescription = 3,
        [Description("Другие локальные нормативные акты")]
        OtherLocalRegulatoryActs = 4
    }
}
