using DataAccessLayer.Abstraction;
using DataAccessLayer.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Extensions
{
	public static class DataAccessLayerDIExtensions
	{
		public static IServiceCollection AddDataAccessLayerDI(this IServiceCollection services)
		{
			services.AddScoped<IPostRepository, PostRepository>();
			return services;
		}
	}
}
