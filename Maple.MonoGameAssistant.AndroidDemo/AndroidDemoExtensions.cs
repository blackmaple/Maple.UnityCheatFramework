


using Maple.MonoGameAssistant.AndroidModel.ExceptionData;
using Maple.MonoGameAssistant.AndroidWebApi;
using Microsoft.AspNetCore.Hosting;

var webhost = AndroidWebApiServiceExtensions.AsRunWebApiService(new Maple.MonoGameAssistant.Model.MonoGameSettings() { Http = true }, services => { });
webhost.Run();