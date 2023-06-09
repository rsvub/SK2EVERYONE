﻿namespace SK2EVERYONE.DAL.Stock
{
    public class DegressiveMarginFirebirdCreateTable : FirebirdCreateTable
    {
        const string sql = "CREATE TABLE DEGRESSIVEMARGIN (ID BIGINT NOT NULL PRIMARY KEY, VALUEFROM DOUBLE PRECISION, DISTRIBUTORAMOUNT DOUBLE PRECISION, DISTRIBUTORPERCENTAGE DOUBLE PRECISION, PHARMACYAMOUNT DOUBLE PRECISION, PHARMACYPERCENTAGE DOUBLE PRECISION)";
        public DegressiveMarginFirebirdCreateTable(IFirebirdConnectionProvider firebirdConnectionProvider) : base(sql, firebirdConnectionProvider)
        {
        }
    }
}
