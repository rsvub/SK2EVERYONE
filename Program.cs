using SK2EVERYONE.BLL.HIHs;
using SK2EVERYONE.DAL.HIHs;
using SK2EVERYONE.Model.HIHs;

internal class Program
{
    private static void Main(string[] args)
    {
        for(int i = 0; i < args.Length; i++)
        {
            Console.WriteLine(args[i]);
            Console.ReadKey();
        }


        List<HIH> hihList = new HIHBLL().GetAllHIH();

        hihList.ForEach(hih =>
        {
            Console.WriteLine("RegionIdZP: " + hih.Id + " Name: " + hih.Name + " Region: " + hih.Region + " IdZP: " + hih.IdWithoutRegion);
        });

        HIHFirebirdDb sqlCmd = new HIHFirebirdDb();
        sqlCmd.InsertHIH();
        Console.WriteLine("Insert HIH to Firebird OK!");
    }
}