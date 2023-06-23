namespace SK2EVERYONE.Model
{
    public class DeliveryCode
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Code { get; set; }
        public int PartnerId { get; set; }
        public int IsActive { get; set; }
    }
}
