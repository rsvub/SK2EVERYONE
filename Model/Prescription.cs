namespace SK2EVERYONE.Model
{
    public class Prescription
    {
        public int Id { get; set; }
        public int DocumentId { get; set; }
        public string NationalIdentificationNumber { get; set; }
        public string IdEPresrciption { get; set; }
        public int HIHIdWithoutRegion { get; set; }
    }
}
