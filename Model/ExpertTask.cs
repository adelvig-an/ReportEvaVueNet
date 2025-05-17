using System;

namespace Model
{
    public class ExpertTask
    {
        public int Id {  get; set; } 
        public int Number { get; set; } // Номер
        public DateTime Date { get; set; } // Дата
        public string Task { get; set; } // Задача
        public string ResearchObject { get; set; } // Объект исследования
        public DateTime EvaluationDate { get; set; } // Дата оценки
        public virtual ResearchFoundation ResearchFoundation { get; set; }
    }
}