using SPOJ.ConsoleApp;
using SPOJ.Lib;
using System.Reflection;

Console.Title = "Sphere online judge - SPOJ";
Console.ForegroundColor = ConsoleColor.Green;

Action[] _basics = typeof(Basics).GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Instance)
	.Select(x => x.CreateDelegate<Action>())
	.ToArray();

Action[] _tutorial = typeof(Tutorial).GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Instance)
	.Select(x => x.CreateDelegate<Action>())
	.ToArray();

Action[] _classical = typeof(Classical).GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Instance)
	.Select(x => x.CreateDelegate<Action>())
	.ToArray();

Action[] _challenge = typeof(Challenge).GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Instance)
	.Select(x => x.CreateDelegate<Action>())
	.ToArray();

Action[] _partial = typeof(Partial).GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Instance)
	.Select(x => x.CreateDelegate<Action>())
	.ToArray();

Action[] _riddle = typeof(Riddle).GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Instance)
	.Select(x => x.CreateDelegate<Action>())
	.ToArray();

Action[] _polishEasy = typeof(PolishEasy).GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Instance)
	.Select(x => x.CreateDelegate<Action>())
	.ToArray();

Action[] _polishMedium = typeof(PolishMedium).GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Instance)
	.Select(x => x.CreateDelegate<Action>())
	.ToArray();

string[] menuItems = new[] { "Basics", "Tutorial", "Classical", "Challenge", "Partial", "Riddle", "Polish Easy", "Polish Medium" };

while (true)
{
	MainSPOJ.ShowMenuPositions(menuItems);
	Console.Write("Wybierz numer: ");
	char keyChar = Console.ReadKey(true).KeyChar;
	switch (keyChar)
	{
		case '1':
			MainSPOJ.DoWork(_basics);
			break;
		case '2':
			MainSPOJ.DoWork(_tutorial);
			break;
		case '3':
			MainSPOJ.DoWork(_classical);
			break;
		case '4':
			MainSPOJ.DoWork(_challenge);
			break;
		case '5':
			MainSPOJ.DoWork(_partial);
			break;
		case '6':
			MainSPOJ.DoWork(_riddle);
			break;
		case '7':
			MainSPOJ.DoWork(_polishEasy);
			break;
		case '8':
			MainSPOJ.DoWork(_polishMedium);
			break;
		default:
			return;
	}
}