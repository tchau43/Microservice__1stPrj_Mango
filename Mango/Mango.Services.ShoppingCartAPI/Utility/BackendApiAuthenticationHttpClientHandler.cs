using Microsoft.AspNetCore.Authentication;
using System.Net.Http.Headers;

namespace Mango.Services.ShoppingCartAPI.Utility
{
	public class BackendApiAuthenticationHttpClientHandler : DelegatingHandler
	{
		private readonly IHttpContextAccessor _accessor;

		public BackendApiAuthenticationHttpClientHandler(IHttpContextAccessor accessor)
		{
			_accessor = accessor;
		}

		protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			var accessToken = await _accessor.HttpContext.GetTokenAsync("access_token");
			//if (!string.IsNullOrEmpty(accessToken))
			//{
			//	request.SetBearerToken(accessToken);
			//}

			request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

			return await base.SendAsync(request, cancellationToken);
		}
	}
}
