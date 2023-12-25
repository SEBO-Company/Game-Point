using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisunessLayer.Abstract
{
   public interface IOyunlarBl:IGenericBl<Oyunlar>
    {
        List<Oyunlar> TGetListwithCategoryPlatform();
        List<Oyunlar> TGetListwithCategoryPlatformbyFilter(int id);
        List<Oyunlar> TGetSearchListByFilter(string p);
    }
}
