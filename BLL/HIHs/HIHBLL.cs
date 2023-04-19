using SK2EVERYONE.DAL.HIHs;
using SK2EVERYONE.Model.HIHs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SK2EVERYONE.BLL.HIHs
{
    public class HIHBLL
    {
        public List<HIH> GetAllHIH()
        {
            return new HIHSrcDb().GetAllHIH();
        }
    }
}
