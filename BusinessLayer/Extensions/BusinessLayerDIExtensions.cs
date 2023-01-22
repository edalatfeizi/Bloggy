using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Extensions
{
	public static class BusinessLayerDIExtensions
	{
		public static IServiceCollection AddBusinessLayerDI(this IServiceCollection services)
		{
			services.AddScoped<IPostService, PostService>();

			return services;
		}
	}
}
