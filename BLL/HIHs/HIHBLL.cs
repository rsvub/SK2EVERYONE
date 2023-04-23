using SK2EVERYONE.DAL.HIHs;
using SK2EVERYONE.Model.HIHs;

namespace SK2EVERYONE.BLL.HIHs
{
    public class HIHBLL
    {
        public List<HIH> GetAllHIH()
        {
            List<HIH> hihList =  new HIHSrcDb().GetAllHIH();
            List<HIH> checkHIHList = new List<HIH>();

            foreach (HIH h in hihList)
            {
                if (h.Id != "")
                {
                    checkHIHList.Add(new HIH
                    {
                        Id = h.Id,
                        Name = h.Name,
                        Region = h.Region,
                        IdWithoutRegion = h.IdWithoutRegion,
                    });
                }
            }
            return checkHIHList;
        }
    }
}
