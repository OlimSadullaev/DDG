using Mock_interview.Enum;

namespace Mock_interview.Entities
{
    public class Payment
    {
        public int PaymentId { get; set; }

        public long PaymentNumber { get; set; }

        public int ReceiverId { get; set; }
        public User Receiver { get; set; }
        public bool PaymentStatus { get; set; }

        public PaymentType PaymentTypes { get; set; }

        public decimal Price { get; set; }

    }
}
