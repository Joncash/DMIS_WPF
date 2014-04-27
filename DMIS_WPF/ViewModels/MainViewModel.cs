using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMIS_WPF.ViewModels
{
	/// <summary>
	/// Caliburn Micro expects a particular naming convention so it can hook up the view model to the appropriate view. 
	/// <para>*********************</para>
	/// <para>The class name of a view model should end with “ViewModel”. What you put in front of “ViewModel” is up to you. </para>
	/// <para>The other thing to notice here is that this class extends the PropertyChangedBase. </para>
	/// <para>This is provided by Caliburn Micro and makes it easy to raise property change notifications without needing to implement INotifyPropertyChanged in all your view models.</para>
	/// </summary>
	public class MainViewModel : PropertyChangedBase
	{
		public MainViewModel()
		{
			WindowTitle = "藥單";
		}
		public string WindowTitle { get; set; }
	}
}
