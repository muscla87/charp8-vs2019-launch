using System;

namespace NullableReferenceTypes
{
	class Program
	{
		static void Main(string[] args)
		{
			//DON'T FORGET TO ADD <NullableContextOptions>enable</NullableContextOptions> to .csproj
			// <SnippetAddQuestions>
			var surveyRun = new SurveyRun();
			surveyRun.AddQuestion(QuestionType.YesNo, "Has your code ever thrown a NullReferenceException?");
			surveyRun.AddQuestion(new SurveyQuestion(QuestionType.Number, "How many times (to the nearest 100) has that happened?"));
			surveyRun.AddQuestion(QuestionType.Text, "What is your favorite color?");
#nullable disable
			string question = null;
			surveyRun.AddQuestion(QuestionType.Text, question);
#nullable restore

			// </SnippetAddQuestions>

			// <SnippetRunSurvey>
			surveyRun.PerformSurvey(50);
			// </SnippetRunSurvey>

			// <SnippetWriteAnswers>
			foreach (var participant in surveyRun.AllParticipants)
			{
				Console.WriteLine($"Participant: {participant.Id}:");
				if (participant.AnsweredSurvey)
				{
					for (int i = 0; i < surveyRun.Questions.Count; i++)
					{
						var answer = participant.Answer(i);
						Console.WriteLine($"\t{surveyRun.GetQuestion(i)} : {answer}");
					}
				}
				else
					Console.WriteLine("\tNo responses");
			}
			// </SnippetWriteAnswers>
		}
	}
}
