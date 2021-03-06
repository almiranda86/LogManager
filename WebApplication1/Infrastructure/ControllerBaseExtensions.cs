using LogManager.Core;
using LogManager.Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;

namespace LogManagerApplication.Infrastructure
{
    public static class ControllerBaseExtensions
    {
        private static Task<TResponse> HandleApplicationRequest<TRequest, TResponse>(ControllerBase controller, TRequest request, CancellationToken cancellationToken)
                 where TRequest : IRequest<TResponse>
        {

            var requestMediator = ServiceLocator.Current.GetInstance<IRequestHandler<TRequest, TResponse>>();

            var result = requestMediator.Handle(request, cancellationToken);

            return result;
        }

        public static async Task<IActionResult> HandleQueryRequest<TRequest, TResponse>(this ControllerBase controller, TRequest request, CancellationToken cancellationToken)
           where TRequest : IRequest<TResponse>
           where TResponse : ServiceResponse
        {
            var response = await HandleApplicationRequest<TRequest, TResponse>(controller, request, cancellationToken).ConfigureAwait(false);

            if (response != null)
            {
                if (string.IsNullOrEmpty(response.Status))
                    response.SetOk();

                response.StatusDescription = response.StatusDescription ?? $"Response of {typeof(TResponse).Name}";
            }

            return controller.ApiResult(response);
        }
    }
}
