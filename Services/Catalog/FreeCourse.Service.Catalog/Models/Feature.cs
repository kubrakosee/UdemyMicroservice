using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.Service.Catalog.Models
{
    //Not:Dikkat ederseniz bunun herhangi bir Id si yok.Çünkü ben bunu nerde tutuyorum direk olarak 
    
    public class Feature
    {
        //burda sadece kursun süresini tutacağız
        public int Duration { get; set; }
        //Not şuan biz birebir ilişkiyi göstermek için bu şekilde yapıyoruz.
    }
}
