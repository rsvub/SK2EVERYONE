using SK2EVERYONE.Model;

namespace SK2EVERYONE.DAL.Products
{
    public class ProductCodeFirebirdDb : FirebirdDbBase<ProductCode>
    {
        const string sql = "insert into productcode(id, code, codetypeid, codetypename, codegroupid, codegroupname, isinternal, productname, productid) " +
            "values (@id, @code, @codetypeid, @codetypename, @codegroupid, @codegroupname, @isinternal, @productname, @productid)";
        public ProductCodeFirebirdDb(IFirebirdConnectionProvider firebirdConnectionProvider) : base(sql, firebirdConnectionProvider)
        {
        }
    }
}
