

namespace FreeCourse.Service.Catalog.Models
{
    //Not:Kod da gereksiz attributeleri silmek için sağ tıkla Remote and Sort Using diyoruz
    public class Category//public yerine internal da diyebiliriz
    {
        /*ID'yi integer olarak değil string olarak tutacaz.ID nin üretim işini MongoDb ye bırakacağız.Kendisi otomatik benim için ID üretecek*/
        /*Şimdi benim bunu MongoDb ye haberdar etmem lazım.Id ne için tutulacak Name ne için tutulacak bunu haberdar etmemiz gerekir Mongo Db ye*/
        /*Id Mongo db tarafından gerçekten bir Id olduğunu algılaması için BsonId attribute ile beraber işaretliyorum.birde tipinide işaretlemem lazım çünkü ıd nin mongo db tarafındaki tipi de farklı bir şekilde temsil ediliyor bir object(obj) ıd tipinden temsil ediliyor.Burda da BsonRepresentation böyle bir attribute m var tipide objectId olucak diyorum*/
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        /*Name ile ilgili herhangi birşey belirtmeme gerek yok*/
        public string Name { get; set; }
    }
}
