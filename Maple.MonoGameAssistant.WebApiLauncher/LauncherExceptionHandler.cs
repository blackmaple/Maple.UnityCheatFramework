using Maple.MonoGameAssistant.Model;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Maple.MonoGameAssistant.WebApiLauncher
{
    public class LauncherExceptionHandler(ILogger<LauncherExceptionHandler> logger) : IExceptionHandler
    {
        ILogger Logger { get; } = logger;

        public virtual async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            Logger.LogError("{ex}", exception);
            httpContext.Response.StatusCode = StatusCodes.Status200OK;
            if (exception is MonoCommonException ex)
            {
                  await httpContext.Response.WriteAsJsonAsync(MonoResultDTO.GetBizError(ex), MonoJsonContext.Default.MonoResultDTO, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            else
            {
                  await httpContext.Response.WriteAsJsonAsync(MonoResultDTO.GetSystemError($"{exception.GetType().Name}‌:{DateTime.Now:yyyy-MM-dd HH:mm:ss}"), MonoJsonContext.Default.MonoResultDTO, cancellationToken: cancellationToken).ConfigureAwait(false);
            }

            return true;
        }

        public virtual async ValueTask TryStatusCodeAsync(HttpContext httpContext)
        {
            var statusCode = httpContext.Response.StatusCode;
            if (statusCode >= StatusCodes.Status200OK && statusCode < StatusCodes.Status300MultipleChoices)
            {
                return;
            }
            Logger.LogError("{url}:{code}", httpContext.Request.Path.Value, statusCode);

            httpContext.Response.StatusCode = StatusCodes.Status200OK;
            switch (statusCode)
            {

                case StatusCodes.Status401Unauthorized:
                case StatusCodes.Status403Forbidden:
                    {
                        await httpContext.Response.WriteAsJsonAsync(MonoResultDTO.GetSystemUnauthorized($"SystemUnauthorized:{DateTime.Now:yyyy-MM-dd HH:mm:ss}"), MonoJsonContext.Default.MonoResultDTO).ConfigureAwait(false);
                        break;
                    }
                case StatusCodes.Status404NotFound:
                    {
                        await httpContext.Response.WriteAsJsonAsync(MonoResultDTO.GetSystemError($"{nameof(StatusCodes.Status404NotFound)}:{DateTime.Now:yyyy-MM-dd HH:mm:ss}"), MonoJsonContext.Default.MonoResultDTO).ConfigureAwait(false);
                        break;
                    }
                case StatusCodes.Status400BadRequest:
                default:
                    {
                        await httpContext.Response.WriteAsJsonAsync(MonoResultDTO.GetSystemError($"{nameof(StatusCodes)}Error({statusCode}):{DateTime.Now:yyyy-MM-dd HH:mm:ss}"), MonoJsonContext.Default.MonoResultDTO).ConfigureAwait(false);
                        break;
                    }
            }
        }

    }

}
