using SPOJ;

Console.WriteLine("1. Basics");
Console.WriteLine("2. Tutorial");
Console.WriteLine("3. Classical");
Console.WriteLine("4. Challenge");
Console.WriteLine("5. Partial");
Console.WriteLine("6. Riddle");
Console.Write("Wybierz poziom: ");
int mainMenuNumber = int.Parse(Console.ReadLine());

Console.WriteLine("\nLista rozwiązanych problemów: ");
bool result = mainMenuNumber switch
{
	1 => BasicsProblems(),
	2 => TutorialProblems(),
	3 => ClassicalProblems(),
	4 => ChallengeProblems(),
	5 => PartialProblems(),
	6 => RiddleProblems(),
	_ => false
};

bool BasicsProblems()
{
	Console.WriteLine("1. TESTINT - Test 1");
	Console.WriteLine("2. STRHH - Half of the half");
	Console.WriteLine("3. SMPWOW - Wow");
	Console.WriteLine("4. CPTTRN1 - Character Patterns (Act 1)");
	Console.WriteLine("5. BACTERIA - SPOJ Custom Test");
	Console.WriteLine("6. CPTTRN2 - Character Patterns (Act 2)");
	Console.WriteLine("7. SMPDIV - Divisibility");
	Console.WriteLine("8. BSCXOR - XOR");
	Console.WriteLine("9. SMPSUM - Iterated sums");
	Console.WriteLine("10. CPTTRN3 - Character Patterns (Act 3)");
	Console.WriteLine("11. CHITEST1 - Sum of two numbers");
	Console.WriteLine("12. ALCATRAZ1 - SUM OF DIGITS");
	Console.WriteLine("13. SMPSEQ3 - Fun with Sequences");
	Console.WriteLine("14. SMPSEQ4 - Fun with Sequences (Act 2)");
	Console.WriteLine("15. SMPSEQ5 - Fun with Sequences (Act 3)");
	Console.WriteLine("16. SMPCIRC - Two Circles");
	Console.WriteLine("17. CPTTRN4 - Character Patterns (Act 4)");
	Console.WriteLine("18. HS12MBR - Minimum Bounding Rectangle");
	Console.WriteLine("19. CPTTRN6 - Character Patterns (Act 6)");
	Console.WriteLine("20. CPTTRN6 - Character Patterns (Act 5)");

	Console.Write("Wybierz numer zadania: ");
	int menuNumber = int.Parse(Console.ReadLine());
	_ = menuNumber switch
	{
		1 => Basics.TESTINT_Test_1(),
		2 => Basics.STRHH_Half_of_the_half(),
		3 => Basics.SMPWOW_Wow(),
		4 => Basics.CPTTRN1_Character_Patterns_Act_1(),
		5 => Basics.BACTERIA_SPOJ_Custom_Test(),
		6 => Basics.CPTTRN2_Character_Patterns_Act_2(),
		7 => Basics.SMPDIV_Divisibility(),
		8 => Basics.BSCXOR_XOR(),
		9 => Basics.SMPSUM_Iterated_sums(),
		10 => Basics.CPTTRN3_Character_Pattern_Act_3(),
		11 => Basics.CHITEST1_Sum_of_two_numbers(),
		12 => Basics.ALCATRAZ1_SUM_OF_DIGITS(),
		13 => Basics.SMPSEQ3_Fun_with_Sequences(),
		14 => Basics.SMPSEQ4_Fun_with_Sequences_Act_2(),
		15 => Basics.SMPSEQ5_Fun_with_Sequences_Act_3(),
		16 => Basics.SMPCIR_Two_Circles(),
		17 => Basics.CPTTRN4_Character_Patterns_Act_4(),
		18 => Basics.HS12MBR_Minimum_Bounding_Rectangle(),
		19 => Basics.CPTTRN6_Character_Patterns_Act_6(),
		20 => Basics.CPTTRN5_Character_Patterns_Act_5(),
		_ => false,
	};
	return true;
}

bool TutorialProblems()
{
	Console.WriteLine("1. ");
	Console.Write("Wybierz numer zadania: ");
	int menuNumber = int.Parse(Console.ReadLine());
	_ = menuNumber switch
	{
		_ => false,
	};
	return true;
}

bool ClassicalProblems()
{
	Console.WriteLine("1. TEST - Life, the Universe, and Everything");
	Console.WriteLine("2. ");
	Console.Write("Wybierz numer zadania: ");
	int menuNumber = int.Parse(Console.ReadLine());
	_ = menuNumber switch
	{
		1 => Classical.TEST_Life_the_Universe_and_Everything(),
		_ => false,
	};
	return true;
}

bool ChallengeProblems()
{
	Console.WriteLine("1. ");
	Console.Write("Wybierz numer zadania: ");
	int menuNumber = int.Parse(Console.ReadLine());
	_ = menuNumber switch
	{
		_ => false,
	};
	return true;
}

bool PartialProblems()
{
	Console.WriteLine("1. ");
	Console.Write("Wybierz numer zadania: ");
	int menuNumber = int.Parse(Console.ReadLine());
	_ = menuNumber switch
	{
		_ => false,
	};
	return true;
}

bool RiddleProblems()
{
	Console.WriteLine("1. ");
	Console.Write("Wybierz numer zadania: ");
	int menuNumber = int.Parse(Console.ReadLine());
	_ = menuNumber switch
	{
		_ => false,
	};
	return true;
}