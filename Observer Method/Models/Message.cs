using Observer_Method.Interfaces;

namespace Observer_Method.Models
{
    public sealed class Message : IModel
    {
        public override string ToString()
        {
            return $"Система сгенерировала сообщение № {Id}: {Text}";
        }
        public int Id { get; set; }
        public string Text {get; set;}
    }
}
