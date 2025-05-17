using System.ComponentModel;

namespace Model
{
    public class SROrganizationModel : CounterpartyModel
    {
        public SROrganizationType SROrganizationType { get; set; }
        public string PathImage { get; set; } = string.Empty; //Путь к изображениям сертификата и выписки в JSON
    }

    public enum SROrganizationType
    {
        [Description("Саморегулируемая организация оценщиков")]
        Appraiser = 0,
        [Description("Саморегулируемая организация экспертов")]
        Expert = 1,
        [Description("Саморегулируемая организация экспертных организаций")]
        ExpertOrganization = 2
    }
}
