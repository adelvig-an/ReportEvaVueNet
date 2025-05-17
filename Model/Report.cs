using System;

namespace Model
{
    //Данный класс содержит поля для хранения информации о созданных отчетах и экспертизах, в том числе судебных экспертизах
    public class Report
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public DateTime CreationDate { get; set; }
        //public virtual ExpertTask ExpertTask { get; set; }
    }
}