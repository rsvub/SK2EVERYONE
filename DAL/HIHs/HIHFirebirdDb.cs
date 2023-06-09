﻿using SK2EVERYONE.Model;

namespace SK2EVERYONE.DAL.HIHs
{
    public class HIHFirebirdDb : FirebirdDbBase<HIH>
    {
        const string sql = "insert into hih(id, name, region, idwithoutregion) values (@id, @name, @region, @idwithoutregion)";
        public HIHFirebirdDb(IFirebirdConnectionProvider firebirdConnectionProvider) : base(sql, firebirdConnectionProvider)
        {
        }
    }
}
