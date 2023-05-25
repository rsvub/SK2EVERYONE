using SK2EVERYONE.Model;

namespace SK2EVERYONE.DAL.Products
{
    public class ProductFirebirdDb : FirebirdDbBase<Product>
    {
        const string sql = "insert into product(Id, SalesActive, DeliveriesActive, Name, NameSuplement, Code, Sukl, ATC, EAN, ADC, Composition, AmountOfOpiate, Type, ManufacturerId, ManufacturerName, Country, Vat, Markup, IsDrug, SuklCondition, Category, TypeOfReimbursement, PrescribingRestrictions, MinimumOrder, MinimumStock, OptimumStock, CannotOrder, ConsignmentStock, Unit, CustomsTariff, FMD, PlanningWizard, TaxaLaborum) " +
            "values (@Id, @SalesActive, @DeliveriesActive, @Name, @NameSuplement, @Code, @Sukl, @ATC, @EAN, @ADC, @Composition, @AmountOfOpiate, @Type, @ManufacturerId, @ManufacturerName, @Country, @Vat, @Markup, @IsDrug, @SuklCondition, @Category, @TypeOfReimbursement, @PrescribingRestrictions, @MinimumOrder, @MinimumStock, @OptimumStock, @CannotOrder, @ConsignmentStock, @Unit, @CustomsTariff, @FMD, @PlanningWizard, @TaxaLaborum)";
        public ProductFirebirdDb(IFirebirdConnectionProvider firebirdConnectionProvider) : base(sql, firebirdConnectionProvider)
        {
        }
    }
}
