using Maple.MonoGameAssistant.AndroidWebApi;
using Microsoft.AspNetCore.Hosting;

var web = AndroidWebApiServiceExtensions.AsRunWebApiService(p => { }, p => { });
web.Run();