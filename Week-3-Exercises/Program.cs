using System;

namespace Week_3_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!\n");
            Console.Write("Enter the difficulty level of the bank as as number between 0 and 100: ");
            int bankDifficulty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            var team = new Team();

            var name = "";
            double teamSkillLevel = 0;

            do
            {
                Console.Write("Enter a team member's name: ");
                name = Console.ReadLine();
                if (name == "")
                {
                    break;
                }
                else
                {
                    var teamMember = new TeamMember(name);
                    teamMember.Create();
                    teamSkillLevel += teamMember.SkillLevel;

                    TeamMember.TeamMemberCount++;
                    team.AddTeamMember(teamMember);
                }
            }
            while (name != "");

            Console.WriteLine();
            Console.WriteLine($"You have {TeamMember.TeamMemberCount} team members for this heist.\n");

            foreach (TeamMember teamMember in team.TeamMembers) {
                teamMember.Display();
            }

            Console.Write("How many trial runs do you want to perform? ");
            int trialRuns;

            try
            {
                trialRuns = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.Write("ERROR--Enter a positive integer for the number of trials: ");
                trialRuns = Convert.ToInt32(Console.ReadLine());
            }

            int successfulTrials = 0;
            int failedTrials = 0;

            for (var i = 1; i <= trialRuns; i++)
            {
                Random randomNumber = new Random();
                int luckValue = randomNumber.Next(-10, 10);
                int difficultyAndLuck = bankDifficulty + luckValue;


                Console.WriteLine($"The team's combined skill level is {teamSkillLevel}.");
                Console.WriteLine($"The bank's difficulty level is {difficultyAndLuck}.");

                if (teamSkillLevel >= difficultyAndLuck)
                {
                    Console.WriteLine("Your heist was a success!\n");
                    successfulTrials++;
                }
                else
                {
                    Console.WriteLine("You fail.\n");
                    failedTrials++;
                }
            }

            double successRate = Math.Round(Convert.ToDouble(successfulTrials) / Convert.ToDouble(trialRuns) * 100);
            Console.WriteLine($"You succeeded {successfulTrials} out of {trialRuns} times. That's a {successRate}% success rate.");


        }
    }
}
