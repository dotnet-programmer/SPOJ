using SPOJ.Lib;
using System.Reflection;
using System.Windows;

namespace SPOJ.WPF;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	private static readonly Action[] _basics = typeof(Basics).GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Instance)
		.Select(x => x.CreateDelegate<Action>())
		.ToArray();

	private static readonly Action[] _tutorial = typeof(Tutorial).GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Instance)
		.Select(x => x.CreateDelegate<Action>())
		.ToArray();

	private static readonly Action[] _classical = typeof(Classical).GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Instance)
		.Select(x => x.CreateDelegate<Action>())
		.ToArray();

	private static readonly Action[] _challenge = typeof(Challenge).GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Instance)
		.Select(x => x.CreateDelegate<Action>())
		.ToArray();

	private static readonly Action[] _partial = typeof(Partial).GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Instance)
		.Select(x => x.CreateDelegate<Action>())
		.ToArray();

	private static readonly Action[] _riddle = typeof(Riddle).GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Instance)
		.Select(x => x.CreateDelegate<Action>())
		.ToArray();

	public MainWindow()
	{
		InitializeComponent();
	}
}
