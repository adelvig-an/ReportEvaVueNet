using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    /// <summary>
    /// Данные адреса из Dadata.ru
    /// </summary>
    public class AddressModel
    {
        public string source { get; set; } = string.Empty;
        public string result { get; set; } = string.Empty;

        public string postal_code { get; set; } = string.Empty;
        public string country { get; set; } = string.Empty;
        public string country_iso_code { get; set; } = string.Empty;
        public string federal_district { get; set; } = string.Empty;

        public string region_fias_id { get; set; } = string.Empty;
        public string region_kladr_id { get; set; } = string.Empty;
        public string region_iso_code { get; set; } = string.Empty;
        public string region_with_type { get; set; } = string.Empty;
        public string region_type { get; set; } = string.Empty;
        public string region_type_full { get; set; } = string.Empty;
        public string region { get; set; } = string.Empty;

        public string area_fias_id { get; set; } = string.Empty;
        public string area_kladr_id { get; set; } = string.Empty;
        public string area_with_type { get; set; } = string.Empty;
        public string area_type { get; set; } = string.Empty;
        public string area_type_full { get; set; } = string.Empty;
        public string area { get; set; } = string.Empty;

        public string sub_area_fias_id { get; set; } = string.Empty;
        public string sub_area_kladr_id { get; set; } = string.Empty;
        public string sub_area_with_type { get; set; } = string.Empty;
        public string sub_area_type { get; set; } = string.Empty;
        public string sub_area_type_full { get; set; } = string.Empty;
        public string sub_area { get; set; } = string.Empty;
            
        public string city_fias_id { get; set; } = string.Empty;
        public string city_kladr_id { get; set; } = string.Empty;
        public string city_with_type { get; set; } = string.Empty;
        public string city_type { get; set; } = string.Empty;
        public string city_type_full { get; set; } = string.Empty;
        public string city { get; set; } = string.Empty;

        public string city_area { get; set; } = string.Empty;

        public string city_district_fias_id { get; set; } = string.Empty;
        public string city_district_kladr_id { get; set; } = string.Empty;
        public string city_district_with_type { get; set; } = string.Empty;
        public string city_district_type { get; set; } = string.Empty;
        public string city_district_type_full { get; set; } = string.Empty;
        public string city_district { get; set; } = string.Empty;

        public string settlement_fias_id { get; set; } = string.Empty;
        public string settlement_kladr_id { get; set; } = string.Empty;
        public string settlement_with_type { get; set; } = string.Empty;
        public string settlement_type { get; set; } = string.Empty;
        public string settlement_type_full { get; set; } = string.Empty;
        public string settlement { get; set; } = string.Empty;

        public string street_fias_id { get; set; } = string.Empty;
        public string street_kladr_id { get; set; } = string.Empty;
        public string street_with_type { get; set; } = string.Empty;
        public string street_type { get; set; } = string.Empty;
        public string street_type_full { get; set; } = string.Empty;
        public string street { get; set; } = string.Empty;

        public string house_fias_id { get; set; } = string.Empty;
        public string house_kladr_id { get; set; } = string.Empty;
        public string house_cadnum { get; set; } = string.Empty;
        public string house_flat_count { get; set; } = string.Empty;
        public string house_with_type { get; set; } = string.Empty;
        public string house_type { get; set; } = string.Empty;
        public string house_type_full { get; set; } = string.Empty;
        public string house { get; set; } = string.Empty;

        public string block_type { get; set; } = string.Empty;
        public string block_type_full { get; set; } = string.Empty;
        public string block { get; set; } = string.Empty;

        public string entrance { get; set; } = string.Empty;
        public string floor { get; set; } = string.Empty;

        public string flat_fias_id { get; set; } = string.Empty;
        public string flat_cadnum { get; set; } = string.Empty;
        public string flat_type { get; set; } = string.Empty;
        public string flat_type_full { get; set; } = string.Empty;
        public string flat { get; set; } = string.Empty;

        public string room_fias_id { get; set; } = string.Empty;
        public string room_cadnum { get; set; } = string.Empty;
        public string room_type { get; set; } = string.Empty;
        public string room_type_full { get; set; } = string.Empty;
        public string room { get; set; } = string.Empty;

        public string stead_fias_id { get; set; } = string.Empty;
        public string stead_kladr_id { get; set; } = string.Empty;
        public string stead_type { get; set; } = string.Empty;
        public string stead_type_full { get; set; } = string.Empty;
        public string stead { get; set; } = string.Empty;

        public string flat_area { get; set; } = string.Empty;
        public string square_meter_price { get; set; } = string.Empty;
        public string flat_price { get; set; } = string.Empty;

        public string postal_box { get; set; } = string.Empty;
        public string fias_id { get; set; } = string.Empty;
        public string fias_code { get; set; } = string.Empty;
        public string fias_level { get; set; } = string.Empty;
        public string fias_actuality_state { get; set; } = string.Empty;
        public string kladr_id { get; set; } = string.Empty;
        public string geoname_id { get; set; } = string.Empty;
        public string capital_marker { get; set; } = string.Empty;

        public string okato { get; set; } = string.Empty;
        public string oktmo { get; set; } = string.Empty;
        public string tax_office { get; set; } = string.Empty;
        public string tax_office_legal { get; set; } = string.Empty;
        public string timezone { get; set; } = string.Empty;

        public string geo_lat { get; set; } = string.Empty;
        public string geo_lon { get; set; } = string.Empty;
        public string beltway_hit { get; set; } = string.Empty;
        public string beltway_distance { get; set; } = string.Empty;

        public string qc_geo { get; set; } = string.Empty;
        public string qc_complete { get; set; } = string.Empty;
        public string qc_house { get; set; } = string.Empty;
        public string qc { get; set; } = string.Empty;

        public string unparsed_parts { get; set; } = string.Empty;

        public List<string> history_values { get; set; } = new List<string>();
        public List<AddressMetro> metro { get; set; } = new List<AddressMetro>();
        public AddressDivisions divisions { get; set; } = new AddressDivisions();

        public override string ToString()
        {
            return string.Format(
                "[AddressData: source={0}, postal_code={1}, result={2}, qc={3}]",
                source, postal_code, result, qc
            );
        }
    }

    public class AddressMetro
    {
        public string name { get; set; } = string.Empty;
        public string line { get; set; } = string.Empty;
        public decimal distance { get; set; }
    }

    public class AddressDivisions
    {
        public AddressAdministrative administrative { get; set; } = new AddressAdministrative();
        public AddressMunicipal municipal { get; set; } = new AddressMunicipal();
    }

    public class AddressAdministrative
    {
        public AddressPart area { get; set; } = new AddressPart();
        public AddressPart city { get; set; } = new AddressPart();
        public AddressPart city_district { get; set; } = new AddressPart();
        public AddressPart settlement { get; set; } = new AddressPart();
        public AddressPart planning_structure { get; set; } = new AddressPart();
    }

    public class AddressMunicipal
    {
        public AddressPart area { get; set; } = new AddressPart();
        public AddressPart sub_area { get; set; } = new AddressPart();
        public AddressPart city { get; set; } = new AddressPart();
        public AddressPart settlement { get; set; } = new AddressPart();
        public AddressPart planning_structure { get; set; } = new AddressPart();
    }

    public class AddressPart
    {
        public string fias_id { get; set; } = string.Empty;
        public string kladr_id { get; set; } = string.Empty;
        public string type { get; set; } = string.Empty;
        public string type_full { get; set; } = string.Empty;
        public string name { get; set; } = string.Empty;
        public string name_with_type { get; set; } = string.Empty;
    }
}