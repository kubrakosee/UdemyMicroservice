namespace FreeCourse.Service.Catalog.Dtos
{
    //Not:CourseDto daki propertleri kopyalandı buraya
    public class CourseCreateDto
    {
        //Createler Id sini göndermesine gerek yok o yüzden siliyorum.Category de silebiliriz created ona da gerek yok.
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string UserId { get; set; }
        public string Picture { get; set; }
        public FeatureDto Feature { get; set; }
        public string CategoryId { get; set; }
    }
}
