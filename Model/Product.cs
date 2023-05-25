
namespace SK2EVERYONE.Model
{
    public class Product
    {
        public long Id { get; set; }
        public int SalesActive { get; set; }
        public int DeliveriesActive { get; set; }
        public string Name { get; set; }
        public string NameSuplement { get; set; }
        public string Code { get; set; }
        public string Sukl { get; set; }
        public string ATC { get; set; }
        public string EAN { get; set; }
        public string ADC { get; set; }
        public char Composition { get; set; }
        public float AmountOfOpiate { get; set; }
        public string Type { get; set; }
        public string ManufacturerId { get; set; }
        public string ManufacturerName { get; set;}
        public string Country { get; set; }
        public float Vat { get; set; }
        public float Markup { get; set; }
        public string IsDrug { get; set; }
        public char SuklCondition { get; set; }
        public string Category { get; set; }
        public int TypeOfReimbursement { get; set; }
        public string PrescribingRestrictions { get; set; }
        public float MinimumOrder { get; set; }
        public float MinimumStock { get; set; }
        public float OptimumStock { get; set; }
        public int CannotOrder { get; set; }
        public int ConsignmentStock { get; set; }
        public string Unit { get; set; }
        public string CustomsTariff { get; set; }
        public int FMD { get; set; }
        public int PlanningWizard { get; set;}
        public float TaxaLaborum { get; set; }

    }
}
