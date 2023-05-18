namespace SK2EVERYONE.Model
{
    public class Partner
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public string IDNumber { get; set; }
        public string VATNumber { get; set; }
        public string VATNumberWithoutSK { get; set; }
        public int PayerOfVAT { get; set; }
        public string AccountNumber { get; set; }
        public string Bank { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string WWW { get; set; }
        public int CommunicationId { get; set; }
        public string CommunicationCode { get; set; }
        public string GroupType { get; set; }
        public int Subscriber { get; set; }
        public int Supplier { get; set; }
    }
}
