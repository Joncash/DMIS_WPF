using Caliburn.Micro;
using DMIS_WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMIS_WPF
{
	/// <summary>
	/// The bootstrapper is the class that configures the framework, telling it what to do and where to start.
	/// <para>set the generic type to be the view model that you want to be used at startup</para>
	/// <para>below is "MainViewModel"</para>
	/// </summary>
	public class AppBootstrapper : Bootstrapper<MainViewModel>
	{
	}
}
