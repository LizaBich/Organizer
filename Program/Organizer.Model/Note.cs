using System;

namespace Organizer.Model
{
    /// <summary>
    /// Описывает простую текстовую заметку
    /// </summary>
    public class Note
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="priority">Приоритет</param>
        /// <param name="name">Название</param>
        /// <param name="content">Содержание</param>
        /// <param name="timeOfChange">Время изменения</param>
        public Note(sbyte priority, string name, string content, DateTime timeOfChange)
        {
            Priority = priority;
            Name = name;
            Content = content;
            TimeOfChange = timeOfChange;
        }

        /// <summary>
        /// Уникальный ключ
        /// </summary>
        public uint Id { get; set; }

        /// <summary>
        /// Приоритет
        /// </summary>
        public sbyte Priority { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Содержание
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Время изменения
        /// </summary>
        public DateTime TimeOfChange { get; set; }

        //public Brush Color { get; set; }
    }
}
