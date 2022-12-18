using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.Service.Catalog.Settings
{
    public class DatabaseSettings : IDatabaseSettings
    {
        //public string CourseCollectionName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); } normlade kapatılan şekilde implement ediyor ama ben içini dolduracağım için {}içindekilere gerek yok
        public string CourseCollectionName { get; set; }
        public string CategoryColelctionName { get; set; }
        public string ConnectionStrings { get; set; }
        public string DatabaseName { get; set; }

        //get ettik ama propertyleri set etmedik Benim bunu nerde set etemem gerekicek.Startup tarafında set edeceğim.
    }
}
