using SPOJ.ConsoleApp;

Console.Title = "Sphere online judge - SPOJ";
Console.ForegroundColor = ConsoleColor.Green;

Action[] solvedProblemsFunctions = new[]
{
	Basics.BasicsProblems,
	Tutorial.TutorialProblems,
	Classical.ClassicalProblems,
	Challenge.ChallengeProblems,
	Partial.PartialProblems,
	Riddle.RiddleProblems,
};

MainSPOJ.DoWork(solvedProblemsFunctions);