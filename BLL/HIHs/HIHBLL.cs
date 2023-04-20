using SK2EVERYONE.DAL.HIHs;
using SK2EVERYONE.Model.HIHs;

namespace SK2EVERYONE.BLL.HIHs
{
    public class HIHBLL
    {
        public List<HIH> GetAllHIH()
        {
            var checkHIHList =  new HIHSrcDb().GetAllHIH();

            foreach (HIH h in checkHIHList)
            {
                if (h.Id == null)
                {
                   checkHIHList.Remove(h);
                }
            }


            return checkHIHList;
        }
    }
}
