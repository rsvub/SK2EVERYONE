﻿using SK2EVERYONE.BLL.HIHs;
using SK2EVERYONE.DAL.HIHs;
using SK2EVERYONE.Model.HIHs;
using Microsoft.Extensions.Hosting;

using IHost host = Host.CreateDefaultBuilder(args).Build();

if (args[1] == "import")
{
    List<HIH> hihList = new HIHBLL().GetAllHIH();
    hihList.ForEach(hih =>
    {
        Console.WriteLine("RegionIdZP: " + hih.Id + " Name: " + hih.Name + " Region: " + hih.Region + " IdZP: " + hih.IdWithoutRegion);
    });
    HIHFirebirdDb sqlCmd = new HIHFirebirdDb();
    sqlCmd.InsertHIH();
    Console.WriteLine("Import HIH to Firebird OK!");
    Console.ReadKey();
}
if (args[1] == "createdb")
{
    Console.WriteLine("Under construction!");
    Console.ReadKey();
}

