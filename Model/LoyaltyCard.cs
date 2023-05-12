
namespace SK2EVERYONE.Model
{
    public class LoyaltyCard
    {
        public string CardNumber { get; set; }
        public string CardBarCode { get; set; }
        public int CardType { get; set; }
        public int Active { get; set; }
        public float OtcPoint { get; set; }
        public float RxPoint { get; set;}
        public char Sex { get; set;}
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Education { get; set; }
        public string Industry { get; set; }
        public string Employment { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public int UnitId { get; set; }
        public int PhysicianId { get; set; }
    }
}
