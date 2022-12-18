using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.Service.Catalog.Dtos
{
    public class CourseDto
    {
        //Create esnasında Id ye gerek yok CreatedTime gerek yok ben bunları kendi içimde de oluşturabilirim bu propertyleri ihtiyaç olmadığı için sağ tıkla CourseCreateDto oluşturuyorum
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Picture { get; set; }
        public DateTime CreatedTime { get; set; }
        public string UserId { get; set; }
        public FeatureDto Feature { get; set; }
        public string CategoryId { get; set; }
        public CategoryDto Category { get; set; }

        
    }
}
