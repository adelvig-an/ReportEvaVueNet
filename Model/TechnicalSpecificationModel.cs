using System.ComponentModel;

namespace Model
{
    public class TechnicalSpecificationModel //Задание на оценку (Техническое задание)
    {
        public int Id { get; set; }
        public int? ContactId { get; set; }
        public ContactModel? Contact { get; set; }
        public ValueType ValueType { get; set; }
        public ResearchObjects ResearchObjects { get; set; }

    }

    public enum ValueType
    {
        [Description("Рыночная стоимость")]
        MarketValue = 0,
        [Description("Рыночная и ликвидационная стоимость")]
        MarketAndLiquidationValue = 1,
        [Description("Ликвидационная стоимость")]
        LiquidationValue = 2,
        [Description("Инвестиционная стоимость")]
        InvestmentValue = 3
    }

    public enum ResearchObjects
    {
        [Description("Недвижимое имущество")]
        RealEstate = 0,
        [Description("Движимое имущество")]
        MovableProperty = 1,
        [Description("Бизнес")]
        Business = 2
        //[Description("Жилое помещение (квартира)")]
        //ResidentialPremises = 0,
        //[Description("Нежилое помещение")]
        //NonResidentialPremises = 1,
        //[Description("Жилое здание")]
        //ResidentialBuilding = 2,
        //[Description("Жилое здание с земельным участком")]
        //ResidentialBuildingWithLandPlot = 3,
        //[Description("Нежилое здание")]
        //NonResidentialBuilding = 4,
        //[Description("Нежилое здание с земельным участком")]
        //NonResidentialBuildingWithLandPlot = 5,
        //[Description("Земельный участок")]
        //LandPlot = 6,
        //[Description("Транспортное средство")]
        //Vehicle = 7,
        //[Description("Спецтехника")]
        //SpecialEquipment = 8,
        //[Description("Внутренняя отделка жилого помещения")]
        //ResidentialInteriorFinishing = 9,
        //[Description("Мебель")]
        //Furniture = 10,
        //[Description("Прочее движимое имущество")]
        //OtherMoveableProperty = 11,
        //[Description("Бизнес")]
        //Business = 12,
        //[Description("Доля в бизнесе")]
        //ShareInBusiness = 13,
        //[Description("Акции")]
        //Shares = 14
    }
}
