namespace FreeCourse.Service.Catalog.Dtos
{
    public class CourseUpdateDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string UserId { get; set; }
        public FeatureDto Feature { get; set; }
        public string CategoryId { get; set; }

        //update esnasında resimi de alalım 
        public string Picture { get; set; }

        //NOT:CourseDto daki gibi öteki entitylerinde bu şekilde yapabilirsiniz.
    }
}
