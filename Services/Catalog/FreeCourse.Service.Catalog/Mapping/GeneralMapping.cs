using AutoMapper;
using FreeCourse.Service.Catalog.Dtos;
using FreeCourse.Service.Catalog.Models;

namespace FreeCourse.Service.Catalog.Mapping
{
    /// <summary>
    /// Bu arakadaş Profile dan referans alacak
    /// </summary>
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            //içine gelip maplerimi oluşturabilirim

            CreateMap<Course, CourseDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Feature, FeatureDto>().ReverseMap();


            CreateMap<Course, CourseCreateDto>().ReverseMap();
            CreateMap<Course, CourseUpdateDto>().ReverseMap();


        }
    }
}
