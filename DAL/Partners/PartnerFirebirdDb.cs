using SK2EVERYONE.Model;

namespace SK2EVERYONE.DAL.Partners
{
    public class PartnerFirebirdDb : FirebirdDbBase<Partner>
    {
        const string sql = "insert into partner(name, City, Street, ZipCode, IDNumber, VATNumber, VATNumberWithoutSK, PayerOfVAT, AccountNumber, Bank, Phone, Fax, MobilePhone, Email, WWW, CommunicationId, CommunicationCode, GroupType, Subscriber, Supplier) " +
            "values (@name, @City, @Street, @ZipCode, @IDNumber, @VATNumber, @VATNumberWithoutSK, @PayerOfVAT, @AccountNumber, @Bank, @Phone, @Fax, @MobilePhone, @Email, @WWW, @CommunicationId, @CommunicationCode, @GroupType, @Subscriber, @Supplier)";
        public PartnerFirebirdDb(IFirebirdConnectionProvider firebirdConnectionProvider) : base(sql, firebirdConnectionProvider)
        {
        }
    }
}
