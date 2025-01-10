using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Mango.Services.AuthAPI.Models; // Ensure this namespace contains JwtOptions

namespace Mango.Services.AuthAPI.Extensions
{
	public static class WebApplicationBuilderExtensions
	{
		public static WebApplicationBuilder AddAppAuthentication(this WebApplicationBuilder builder)
		{
			// Retrieve JWT options from configuration
			var jwtOptions = builder.Configuration.GetSection("ApiSettings:JwtOptions").Get<JwtOptions>();

			if (jwtOptions == null || string.IsNullOrEmpty(jwtOptions.Secret))
			{
				throw new ArgumentNullException(nameof(jwtOptions), "JWT Options are not properly configured in appsettings.json.");
			}

			var key = Encoding.ASCII.GetBytes(jwtOptions.Secret);

			builder.Services.AddAuthentication(options =>
			{
				options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
				options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
			})
			.AddJwtBearer(options =>
			{
				options.TokenValidationParameters = new TokenValidationParameters
				{
					ValidateIssuerSigningKey = true,
					IssuerSigningKey = new SymmetricSecurityKey(key),
					ValidateIssuer = true,
					ValidIssuer = jwtOptions.Issuer,
					ValidateAudience = true,
					ValidAudience = jwtOptions.Audience,
					ValidateLifetime = true,
					ClockSkew = TimeSpan.Zero // Optional: Adjust as needed
				};
			});

			return builder;
		}
	}
}
