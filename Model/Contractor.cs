using System;

namespace Model
{
    public class Contractor
    {
        public int Id { get; set; }
        public virtual Contact Contact { get; set; }
        
        // Поля Организации
        public string NameFullOpf { get; set; } //Полное наименование с ОПФ
        public string NameShortOpf { get; set; } //Сокращенное наименование с ОПФ
        public string NameFull { get; set; } //полное наименование без ОПФ
        public string NameShort { get; set; } //краткое наименование без ОПФ
        public string FullOpf { get; set; } //Полное название ОПФ
        public string ShortOpf { get; set; } //Сокращенное ОПФ
        public string Ogrn { get; set; } //ОГРН
        public DateTime? OgrnDate { get; set; } //Дата регистрации
        public string Inn { get; set; } //ИНН
        public string Kpp { get; set; } //КПП
        public string Bank { get; set; } //Название банка
        public string Bik { get; set; } //БИК Банка
        public string PayAccount { get; set; } //Расчетный счет
        public string CorrAccount { get; set; } //Корреспондентский счет
        
        // Поля физического лица
        public string Serial { get; set; } //Серия документа
        public string Number { get; set; } //Номер документа
        public string Division { get; set; } //Кем выдан документ
        public string DivisionCode { get; set; } //Код подразделения
        public DateTime? DivisionDate { get; set; } //Дата выдачи
        
        // Поля адреса
        public virtual Address AddressRegistration { get; set; }
        public virtual Address AddressActual { get; set; }
    }
}
