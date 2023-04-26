using Microsoft.Extensions.Configuration;

namespace SK2EVERYONE.BLL
{
#if false
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
#endif
}
