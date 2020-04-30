using System;
using Autofac;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	public static class RegisterServices
	{
		public static IContainer Create()
		{
			var containerBuilder = new ContainerBuilder();

			containerBuilder.RegisterModule<MainFormModule>();

			containerBuilder
				.RegisterType<MainForm>()
				.AsSelf()
				.SingleInstance();

			return containerBuilder.Build();
		}
	}
}
