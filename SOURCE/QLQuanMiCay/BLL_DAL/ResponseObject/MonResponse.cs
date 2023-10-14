using BLL_DAL.XuLy;
using System.Collections.Generic;

namespace BLL_DAL.ResponseObject
{
    public class MonResponse : Response<Mon>
    {
        public MonResponse(List<Mon> data, int current) : base(data, current)
        {
        }
    }
}
