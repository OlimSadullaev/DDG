using Mock_interview.Enum;

namespace Mock_interview.Entities
{
    public class Payment
    {
        public int PaymentId { get; set; }

        public long PaymentNumber { get; set; }

        public int ReceiverId { get; set; }
        public User Receiver { get; set; }
<<<<<<< HEAD
=======

>>>>>>> 269c5f9e41f1c988b025c644190f7fca8be2d7f2
        public bool PaymentStatus { get; set; }

        public PaymentType PaymentTypes { get; set; }

        public decimal Price { get; set; }

    }
}
