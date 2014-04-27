using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DMIS_WPF.Views
{
	/// <summary>
	/// Interaction logic for MainView.xaml
	/// <para>*****************************</para>
	/// <para>Caliburn Micro expects a particular naming convention so it can hook up the view to the appropriate view model. </para>
	/// <para>View names should end with “View” and start with the same name you used for the view model</para>
	/// </summary>
	public partial class MainView : Window
	{
		public MainView()
		{
			InitializeComponent();
		}
	}
}
