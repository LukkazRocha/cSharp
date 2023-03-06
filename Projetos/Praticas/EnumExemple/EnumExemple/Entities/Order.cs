using EnumExemple.Entities.Enum;

namespace EnumExemple.Entities
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
    }
}
