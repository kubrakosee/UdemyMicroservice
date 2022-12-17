using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FreeCourse.Shared.Dtos
{
    //API lardan data dönerken 2 tane yolunuz var.ya başarılı API ya  istek yapıldığında bir endpointte bir istek yapıldığında ya başarılı ya başarısız 2 tane durumumuz var.Başarılı olduğunda Bir dto nesnesi dönebilirsiniz.Başarısız olduğunuz da bir Dto a dönebilirsiniz.Yada başarılı veya başarısız olduğunda ortak bir dto nesnesi dönersiniz.Başarısıysa gelecek olan generic T yi verirsiniz.Başarısız ise  hata kısmını doldurursunuz.Biz burda Tek bir Dto nesnesi dönmesi daha iyi olur. 
    public class ResponseDto<T>//where demiyorum çünkü ben buraya integer da gönderebilirim.Bir class da gönderebilirim.o yüzden where ile herhangi bir kısıtlama yapmıyorum  
    {
        public T Data { get; private set; } //başarılı olduğunda gidecek datam olsun 

        //StatusCode unu tutmak istiyorum.ben bu statusCode u kendi içinde kullanmak istiyorum.Neden jsonIgnore yazdık.Bir API ya bir istek yaptığımızda zaten response da biz dönüş tipini verebiliyoruz.Yani 200 se 200 204 se 204 dönüyor yani ben bir daha responsensın body sinde StausCode göndermeme gerek yok.Ama yazılım içerisinde benim buna ihtiyacım var.Neden ihtiyacım var ben responsensın statusunu belirlerken   dönüş tipini belirlerken ben burdan  faydalanacağım 
        [JsonIgnore]
        public int StatusCode { get; private set; }

        //Başarılı olup olmama durumunu tutalım

        //istersek bunu da jsonIgnore ile de tutabiliriz.Eğer gerek duyurursa jsonIgnore kaldırılır.ben şuan yazılım için kullanacağım için gerek duymuyorum.
        [JsonIgnore]
        public bool IsSuccessfull { get; private set; }

        public List<string> Errors { get; set; }//hatayı list şeklinde dönelim 

        //Ben burda responseDto nesnesine üretmek için static metodlar tanımlayacağım.Static metodlar tanımlanan özellikle nesne oluşturmada bize büyük bir artı sağlıyor.Burda nesne oluşturma da  bir çok dezenpedin var.builderpatern var.Static metodlar direk olarak classın içerisinde tanımlanarak nesne oluşturmaya yardımcı olur.

        //Static Factory Method
        public static ResponseDto<T> Success(T data, int statusCode)//burda t data mı alıcağım birde sttausCodemu alacağım 200 mü 201 mi 204 mü başarınınn da birçok durumu var
        {
            return new ResponseDto<T> { Data = data, StatusCode = statusCode, IsSuccessfull = true };//Burda return new responseDto su dönüyorum.Bu dto nesne içerisine  T ye ben datayı veriyorum arkasında da statusCode u veriyorum.issuccessfull u ben kendim doldurabilirim.Başarılı olduğunu belirtiyoruz.Madem ben nesneleri burdan oluşturuyorum.private a set edebilirim.Dışardan şu ( public T Data { get; private set; }) parantez içindeki arkadaşlar set edilmesin.Artık dışardan bu nesneleri alıp değiştiremiyecekler 
        }
        //başarılı olabilir ama bir data almayabilir.update veya delete işlemlerinde 
        public static ResponseDto<T> Success(int statusCode)
        {
            return new ResponseDto<T> { Data = default(T)/*/artık burdaki t neyse onun default değeri gelsin//*/, StatusCode = statusCode, IsSuccessfull = true };
        }
        //Fail olma durumu var başarılı olduğunda client Data yı alacak .Başarısız olduğunda da hataları alıcak onun için bir property oluşturalım Errors diye yukarda 
        public static ResponseDto<T> Fail(List<string> errors, int statusCode)
        {
            return new ResponseDto<T> { Errors = errors, StatusCode = statusCode, IsSuccessfull = false };
        }
        //Bir tane de hata olabilir.ResponseDto adı aslında Factory metod olarak geçer.
        public static ResponseDto<T> Fail(string errors, int statusCode)
        {
            //var errors=new List
            return new ResponseDto<T> { Errors = new List<string>() { errors }, StatusCode = statusCode, IsSuccessfull = false };
        }
        //Birde arkadaşlar şu T ye başarılı ama herhangi bir data dönmek istemediğim zaman mutlaka bir T geçmem lazım.Burda farklı yollar kullanabiliriz.Nullable oluşturabiliriz.Burdan sonra bir tane class oluşturayım.Onun adı da Nocontent olsun

    }
}

