using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.Service.Catalog.Settings
{
    /// <summary>
    /// Benim burda appsetting.json da karşılık gelen propertyleri oluşturacağım 
    /// </summary>
    interface IDatabaseSettings
    {
        public string CourseCollectionName { get; set; }
        public string CategoryColelctionName { get; set; }

        public string ConnectionStrings { get; set; }
        public string DatabaseName { get; set; }

        //şimdi buraya birde implement eden bir tane classımız olsun 
    }
}
