using System.ComponentModel;

namespace Model
{
    public class CounterpartyModel
    {
        public int Id { get; set; }

        public CounterpartyType CounterpartyType { get; set; }

        //Данные для юридического лица
        public string FullOpf { get; set; } = string.Empty; //Полное наименование ОПФ
        public string ShortOpf { get; set; } = string.Empty; //Сокращенное наименование ОПФ
        public string NameFullOpf { get; set; } = string.Empty; //Полное наименование с ОПФ
        public string NameShortOpf { get; set; } = string.Empty; //Сокращенное наименование с ОПФ
        public string NameFull { get; set; } = string.Empty; //Полное наименование без ОПФ
        public string NameShort { get; set; } = string.Empty; //Сокращенное наименование без ОПФ
        public string INN { get; set; } = string.Empty; //ИНН
        public string KPP { get; set; } = string.Empty; //КПП
        public string OGRN { get; set; } = string.Empty; //ОГРН
        public DateTime? DateOGRN { get; set; } //Дата регистрации
        
        public ManagementModel? Management { get; set; } //Даные руководителя или физ. лица

        //Данные физического лица
        public string Serial { get; set; } = string.Empty; //Серия документа
        public string Number { get; set; } = string.Empty; //Номер документа
        public string Division { get; set; } = string.Empty; //Кем выдан документ
        public string DivisionCode { get; set; } = string.Empty; //Код подразделения
        public DateTime DateIssue { get; set; } //Дата выдачи

        //Контакты
        public string PhoneNumber { get; set; } = string.Empty; //Номер телефона
        public string Email { get; set; } = string.Empty; //Эл. почта
        public string Site { get; set; } = string.Empty; //Сайт

        //Данные банковских реквизитов
        public string Bank { get; set; } = string.Empty; //Название банка
        public string Bik { get; set; } = string.Empty; //БИК Банка
        public string PayAccount { get; set; } = string.Empty; //Расчетный счет
        public string CorrAccount { get; set; } = string.Empty; //Корреспондентский счет

        //Адреса регистрации и фактический
        public int? AddressRegistrationId { get; set; }
        public AddressModel? AddressRegistration { get; set; }
        public int? AddressActualId { get; set; }
        public AddressModel? AddressActual { get; set; }

    }

    public enum CounterpartyType
    {
        [Description("Юридическое лицо")]
        Organization = 0,
        [Description("Индивидуальный предприниматель")]
        IndividualEntrepreneur = 1,
        [Description("Физическое лицо")]
        PrivatePerson = 2,
        [Description("Частнопрактикующий оценщик")]
        PrivatePractitioner = 3
    }
}
