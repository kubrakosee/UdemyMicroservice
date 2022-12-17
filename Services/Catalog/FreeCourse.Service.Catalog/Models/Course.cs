using MongoDB.Bson.Serialization.Attributes;
using System;

namespace FreeCourse.Service.Catalog.Models
{
    public class Course
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]//ilgili namespaceleri de yükleyelim
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        /*Benim decimal için de MongoDb de karşılı var.Decimal olarak tutalım*/
        [BsonRepresentation(MongoDB.Bson.BsonType.Decimal128)]
        public decimal Price { get; set; }

        public string Picture { get; set; }//resimleri tutmak için
        [BsonRepresentation(MongoDB.Bson.BsonType.DateTime)]
        public DateTime CreatedTime { get; set; }

        //her bir kurs kullanıcıya ait olması lazım bu yüzden ben birde UserId sini tutayım.String yaptık çünkü ben identity tarafımda identity kütüphanesinin kullanıcı Id sini ben string olarak guid olarak tutucam.Daha doğrusu guid de demeyelim de identity benim için UserId yi otomatik bir şekilde string ve runtime bir değer üretecek.string olarak tutulacağın dolayı da string belirttim.İstersen UserId integer olarak da tutabilirim ama string ve runtime bir şekilde değer tutmak çok daha uygun güvenlik açısından

        public string UserId { get; set; }


        //Burası önemli buraya geliyorum direk olarak direk olarak  bağlayacağım

        public Feature Feature { get; set; }

        //birde Category'e bağlı olması gerekiyor

        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string CategoryId { get; set; }//şimdi burda ObjectId dedik çünkü Category.cs ye gittiğimiz de Id miz ne Object Id olduğu için benim burdaki CategoryId mi de ObjectId demem lazım

        //birde şunu tutalım bu kursun bağlı olduğu bir Category var.Yanlız burası önemli ben bunu kodlama esnasında kullanıcağım yani productları dönerken Categoryleri dönmek istiyorum burdaki Category dolduracağım yanlız bunun MongoDB de bunun karşılığı olmayacak BSONINGNORE diyorum.Yani sen bunu MongoDb deki collectionlara birer satır olarak yansıtırken bunu göz ardı et.bunu ben kendi içimde kullanıyorum demek için.Bir class ı serialize ederken bazı propertyleri serialize edilmesi istemeyebiliriz yine Ignore ederek serialize etmesini engellemiş oluruz.
        [BsonIgnore]
        public Category Category { get; set; }


    }
}
