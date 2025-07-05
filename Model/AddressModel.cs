using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    /// <summary>
    /// Данные адреса из Dadata.ru
    /// - Адрес полностью
    /// - Индекс
    /// - Страна
    /// - Федеральный округ
    /// - Регион (с типом и полным типом)
    /// - Район (с типом и полным типом)
    /// - Город (с типом и полным типом)
    /// - Городской округ (с типом и полным типом)
    /// - Населенный пункт (с типом и полным типом)
    /// - Улица (с типом и полным типом)
    /// - Дом (с типом и полным типом)
    /// - Корпус (с типом и полным типом)
    /// - Квартира (с типом и полным типом)
    /// </summary>
    public class AddressModel
    {
        public int Id { get; set; }
        public string AddressFull { get; set; } = string.Empty;
        public string Index { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string FederalDistrict { get; set; } = string.Empty;
        public string RegionKladrId { get; set; } = string.Empty;
        public string RegionWthType { get; set; } = string.Empty;
        public string RegionType { get; set; } = string.Empty;
        public string RegionTypeFull { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public string AreaKladrId { get; set; } = string.Empty;
        public string AreaWithType { get; set; } = string.Empty;
        public string AreaType { get; set; } = string.Empty;
        public string AreaTypeFull { get; set; } = string.Empty;
        public string Area { get; set; } = string.Empty;
        public string CityKladrId { get; set; } = string.Empty;
        public string CityWithType { get; set; } = string.Empty;
        public string CityType { get; set; } = string.Empty;
        public string CityTypeFull { get; set; }    
        public string City { get; set; } = string.Empty;
        public string CityDistrictWithType { get; set; } = string.Empty;
        public string CityDistrictType { get; set; } = string.Empty;
        public string CityDistrictTypeFull { get; set; } = string.Empty;
        public string CityDistrict { get; set; } = string.Empty;
        public string SettlementKladrId { get; set; } = string.Empty;
        public string SettlemenWithType { get; set; } = string.Empty;
        public string SettlemenType { get; set; } = string.Empty;
        public string SettlemenTypeFull { get; set; } = string.Empty;
        public string Settlemen { get; set; } = string.Empty;
        public string StreetKladrId { get; set; } = string.Empty;
        public string StreetWithType { get; set; } = string.Empty;
        public string StreetType { get; set; } = string.Empty;
        public string StreetTypeFull { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public string HouseKladrId { get; set; } = string.Empty;
        public string HouseType { get; set; } = string.Empty;
        public string HouseTypeFull { get; set; } = string.Empty;
        public string House { get; set; } = string.Empty;
        public string BlockType { get; set; } = string.Empty;
        public string BloctTypeFull { get; set; } = string.Empty;
        public string Block { get; set; } = string.Empty;
        public string FlatType { get; set; } = string.Empty;
        public string FlatTypeFull { get; set; } = string.Empty;
        public string Flat { get; set; } = string.Empty;
    }
}