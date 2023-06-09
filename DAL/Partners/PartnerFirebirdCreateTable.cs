﻿namespace SK2EVERYONE.DAL.Partners
{
    public class PartnerFirebirdCreateTable : FirebirdCreateTable
    {
        const string sql = "CREATE TABLE PARTNER " +
            "(ID INTEGER NOT NULL PRIMARY KEY, " +
            "NAME VARCHAR(120), " +
            "CITY VARCHAR(50), " +
            "STREET VARCHAR(50), " +
            "ZIPCODE VARCHAR(6), " +
            "IDNUMBER VARCHAR(10), " +
            "VATNUMBER VARCHAR(15), " +
            "VATNUMBERWITHOUTSK VARCHAR(15), " +
            "PAYEROFVAT INTEGER, " +
            "ACCOUNTNUMBER VARCHAR(30), " +
            "BANK VARCHAR(30), " +
            "PHONE VARCHAR(50), " +
            "FAX VARCHAR(50), " +
            "MOBILEPHONE VARCHAR(50), " +
            "EMAIL VARCHAR(100), " +
            "WWW VARCHAR(50), " +
            "COMMUNICATIONID INTEGER, " +
            "COMMUNICATIONCODE VARCHAR(15), " +
            "GROUPTYPE VARCHAR(50), " +
            "SUBSCRIBER INTEGER, " +
            "SUPPLIER INTEGER, " +
            "CONSTRAINT FK_Partner_CommunicationSettings FOREIGN KEY(COMMUNICATIONID) REFERENCES COMMUNICATIONSETTINGS(ID) ON DELETE NO ACTION ON UPDATE CASCADE)";
        public PartnerFirebirdCreateTable(IFirebirdConnectionProvider firebirdConnectionProvider) : base(sql, firebirdConnectionProvider)
        {
        }
    }
}
