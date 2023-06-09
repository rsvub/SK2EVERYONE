﻿namespace SK2EVERYONE.DAL.LoyaltyCards
{
    public class LoyaltyCardFirebirdCreateTable : FirebirdCreateTable
    {
        const string sql = "CREATE TABLE LOYALTYCARD " +
            "(ID INTEGER GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY, " +
            "CARDNUMBER VARCHAR(21), " +
            "CARDBARCODE VARCHAR(21), " +
            "CARDTYPE INTEGER, " +
            "ACTIVE INTEGER, " +
            "OTCPOINT INTEGER, " +
            "RXPOINT INTEGER, " +
            "SEX VARCHAR(1), " +
            "SURNAME VARCHAR(50), " +
            "NAME VARCHAR(50), " +
            "STREET VARCHAR(50), " +
            "CITY VARCHAR(50), " +
            "ZIPCODE VARCHAR(6), " +
            "EMAIL VARCHAR(50), " +
            "PHONE VARCHAR(20), " +
            "EDUCATION VARCHAR(20), " +
            "INDUSTRY VARCHAR(50), " +
            "EMPLOYMENT VARCHAR(50), " +
            "TITLE VARCHAR(50), " +
            "NOTE VARCHAR(50), " +
            "DATEOFBIRTH DATE, " +
            "UNITID INTEGER, " +
            "PHYSICIANID INTEGER)";
#if false
        const string sql = "CREATE TABLE LOYALTYCARD " +
            "(ID INTEGER GENERATED BY DEFAULT AS IDENTITY PRIMARY KEY, " +
            "CARDNUMBER VARCHAR(21), " +
            "CARDBARCODE VARCHAR(21), " +
            "CARDTYPE INTEGER, " +
            "ACTIVE INTEGER, " +
            "OTCPOINT INTEGER, " +
            "RXPOINT INTEGER, " +
            "SEX CHAR(1), " +
            "SURNAME VARCHAR(50), " +
            "NAME VARCHAR(50), " +
            "STREET VARCHAR(50), " +
            "CITY VARCHAR(50), " +
            "ZIPCODE VARCHAR(6), " +
            "EMAIL VARCHAR(50), " +
            "PHONE VARCHAR(20), " +
            "EDUCATION VARCHAR(20), " +
            "INDUSTRY VARCHAR(50), " +
            "EMPLOYMENT VARCHAR(50), " +
            "TITLE VARCHAR(50), " +
            "NOTE VARCHAR(50), " +
            "DATEOFBIRTH DATE, " +
            "UNITID INTEGER, " +
            "PHYSICIANID INTEGER, " +
            "CONSTRAINT FK_LoyaltyCard_TypeLoyaltyCard FOREIGN KEY(CARDTYPE) REFERENCES TYPELOYALTYCARD(ID) ON DELETE NO ACTION ON UPDATE CASCADE, " +
            "CONSTRAINT FK_LoyaltyCard_Unit FOREIGN KEY(UNITID) REFERENCES UNIT(ID) ON DELETE NO ACTION ON UPDATE CASCADE, " +
            "CONSTRAINT FK_LoyaltyCard_PHYSICIAN FOREIGN KEY(PHYSICIANID) REFERENCES PHYSICIAN(ID) ON DELETE NO ACTION ON UPDATE CASCADE)";
#endif
        public LoyaltyCardFirebirdCreateTable(IFirebirdConnectionProvider firebirdConnectionProvider) : base(sql, firebirdConnectionProvider)
        {
        }
    }
}
