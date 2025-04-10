


using Maple.MonoGameAssistant.AndroidModel.ExceptionData;
using Maple.MonoGameAssistant.AndroidWebApi;

var json1 = AndroidWebApiJsonExtensions.Json4Object<AndroidSessionInfoDTO>(new AndroidSessionInfoDTO()
{ 
    
    ObjectId = "ObjectId",
    Status = true,
    ApiVer = "app",
    DisplayDesc = "desc",
    DisplayImage = "image",
    DisplayName = "name",
    QQ = "qq",
    Address = "Address",

});

Console.WriteLine(json1);
var json2 = AndroidWebApiJsonExtensions.Json4Object<AndroidWebApiNotifyDTO>(new AndroidWebApiNotifyDTO()
{

    Path = "123"

});
Console.WriteLine(json2);

Console.ReadLine();