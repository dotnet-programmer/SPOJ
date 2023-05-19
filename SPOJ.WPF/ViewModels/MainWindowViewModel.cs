using SPOJ.Lib;
using SPOJ.WPF.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SPOJ.WPF.ViewModels;
internal class MainWindowViewModel : BaseViewModel
{
    public MainWindowViewModel()
    {
		Basics = typeof(Basics).GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Instance)
			.Select(x => x.CreateDelegate<Action>()).ToList();

		//for (int i = 0; i < Basics.Count; i++)
		//{
		//	MethodInfos[i] = new Model.MethodInfo { Name = Basics[i].Method.Name };
		//}

		GridDoubleClickCommand = new RelayCommand(GridDoubleClick);
	}

	//private List<Action> _basics = typeof(Basics).GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Instance).Select(x => x.CreateDelegate<Action>()).ToList();

	public List<Action> Basics { get; set; }

    public List<SPOJ.WPF.Model.MethodInfo> MethodInfos { get; set; }

	public ICommand GridDoubleClickCommand { get; private set; }

	private void GridDoubleClick(object obj)
	{
		//AddEditEmployeeView addEditEmployeeView = new(obj as EmployeeWrapper);
		//addEditEmployeeView.ShowDialog();
	}
}