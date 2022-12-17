using Mock_interview.Enum;

namespace Mock_interview.Entities
{
    public class Payments
    {
        public int PaymentId { get; set; }

        public long PaymentNumber { get; set; }

        public int ReceivedId { get; set; }

        public User UserId { get; set; }

        public bool PaymentStatus { get; set; }

        public PaymentType PaymentTypes { get; set; }

        public int Price { get; set; }

    }
}
