using System;
using System.Drawing;

namespace Organizer.Model
{
    /// <summary>
    /// Описывает простую текстовую заметку
    /// </summary>
    public class Note
    {
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Note()
        { }
        
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="priority">Приоритет</param>
        /// <param name="name">Название</param>
        /// <param name="content">Содержание</param>
        /// <param name="timeOfChange">Время изменения</param>
        /// <param name="color">Цвет фона заметки</param>
        public Note(byte priority, string name, string content, DateTime timeOfChange, Color color)
        {
            Priority = priority;
            Name = name;
            Content = content;
            TimeOfChange = timeOfChange;
            Color = color;
        }

        /// <summary>
        /// Уникальный ключ
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Приоритет
        /// </summary>
        public byte Priority { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Содержание
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Цвет фона заметки
        /// </summary>
        public Color Color { get; set; }

        /// <summary>
        /// Время изменения
        /// </summary>
        public DateTime TimeOfChange { get; set; }

        public override bool Equals(object obj)
        {
            return (obj as Note)?.Id == Id;
        }

        public override int GetHashCode()
        {
            return Id * Priority * 365 - 15 / 2;
        }
    }
}
