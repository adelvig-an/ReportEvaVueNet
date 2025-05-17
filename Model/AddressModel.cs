using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class AddressModel
    {
        public int Id { get; set; }
        public string AddressFull { get; set; } = string.Empty; //Адрес полностью
        public string Index { get; set; } = string.Empty; //Индекс
        public string Country { get; set; } = string.Empty; //Страна
        public string FederalDistrict { get; set; } = string.Empty; //Федеральный округ
        public string RegionKladrId { get; set; } = string.Empty; //КЛАДР-код региона
        public string RegionWthType { get; set; } = string.Empty; //Регион с типом
        public string RegionType { get; set; } = string.Empty; //Тип региона (сокращенный)
        public string RegionTypeFull { get; set; } = string.Empty; //Тип региона
        public string Region { get; set; } = string.Empty; //Регион
        public string AreaKladrId { get; set; } = string.Empty; //КЛАДР-код района
        public string AreaWithType { get; set; } = string.Empty; //Район в регионе с типом
        public string AreaType { get; set; } = string.Empty; //Тип района в регионе (сокращенный)
        public string AreaTypeFull { get; set; } = string.Empty; //Тип района в регионе
        public string Area { get; set; } = string.Empty; //Район в регионе
        public string CityKladrId { get; set; } = string.Empty; //КЛАДР-код города
        public string CityWithType { get; set; } = string.Empty; //Город с типом
        public string CityType { get; set; } = string.Empty; //Тип города (сокращенный)
        public string CityTypeFull { get; set; } = string.Empty; //Тип города
        public string City { get; set; } = string.Empty; //Город
        public string CityDistrictWithType { get; set; } = string.Empty; //Район города с типом
        public string CityDistrictType { get; set; } = string.Empty; //Тип района города (сокращенный)
        public string CityDistrictTypeFull { get; set; } = string.Empty; //Тип района города
        public string CityDistrict { get; set; } = string.Empty; //Район города
        public string SettlementKladrId { get; set; } = string.Empty; //КЛАДР-код населенного пункта
        public string SettlemenWithType { get; set; } = string.Empty; //Населенный пункт с типом
        public string SettlemenType { get; set; } = string.Empty; //Тип населенного пункта (сокращенный)
        public string SettlemenTypeFull { get; set; } = string.Empty; //Тип населенного пункта
        public string Settlemen { get; set; } = string.Empty; //Населенный пункт
        public string StreetKladrId { get; set; } = string.Empty; //КЛАДР-код улицы
        public string StreetWithType { get; set; } = string.Empty; //Улица с типом
        public string StreetType { get; set; } = string.Empty; //Тип улицы (сокращенный)
        public string StreetTypeFull { get; set; } = string.Empty; //Тип улицы
        public string Street { get; set; } = string.Empty; //Улица
        public string HouseKladrId { get; set; } = string.Empty; //КЛАДР-код дома
        public string HouseType { get; set; } = string.Empty; //Тип дома (сокращенный)
        public string HouseTypeFull { get; set; } = string.Empty; //Тип дома
        public string House { get; set; } = string.Empty; //Номер дома
        public string BlockType { get; set; } = string.Empty; //Тип корпуса/строения (сокращенный)
        public string BloctTypeFull { get; set; } = string.Empty; //Тип корпуса/строения
        public string Block { get; set; } = string.Empty; //Номер корпуса/строения
        public string Entrance { get; set; } = string.Empty; //Подъезд
        public string Floor { get; set; } = string.Empty; //Этаж
        public string FlatType { get; set; } = string.Empty; //Тип квартиры (сокращенный)
        public string FlatTypeFull { get; set; } = string.Empty; //Тип квартиры
        public string Flat { get; set; } = string.Empty; //Квартиры

        //[InverseProperty("AddressRegistration")]
        //public virtual ICollection<Counterparty> AddressRegistration { get; set; }
        //[InverseProperty("AddressActual")]
        //public virtual ICollection<Counterparty> AddressActual { get; set; }
    }
}
