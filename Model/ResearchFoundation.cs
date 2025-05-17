using System;

namespace Model
{
    public class ResearchFoundation
    {
        public int Id { get; set; }
        public int Number { get; set; } // Номер
        public DateTime Date { get; set; } // Дата
        public virtual Contractor Contractor { get; set; } // Контрагент
        public virtual int Expert { get; set; } // Эксперт
        public virtual int Performer { get; set; } // Исполнитель
    }
}