namespace Model
{
    public class ExpertOrganizationModel : CounterpartyModel
    {
        public int? InsurancePolicyId { get; set; }
        public InsurancePolicyModel? InsurancePolicy { get; set; }
        public int? SROrganizationId { get; set; }
        public SROrganizationModel? SROrganization { get; set; }
        public ICollection<ExpertModel>? Experts { get; set; }
    }
}
