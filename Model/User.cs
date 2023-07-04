namespace SK2EVERYONE.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public int IsActive { get; set; }
        public int IsResponsiblePharmacist { get; set; }
        public int IsPharmacist { get; set; }
        public int IsLaboratoryAssistant { get; set; }
    }
}
