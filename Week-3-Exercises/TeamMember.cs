using System;
using System.Collections.Generic;
using System.Text;

namespace Week_3_Exercises
{
    class TeamMember
    {
        public string Name { get; set; }
        public double SkillLevel { get; set; }
        public double CourageFactor { get; set; }
        public static int TeamMemberCount = 0;

        public TeamMember(string name)
        {
            Name = name;
        }

        public void Create()
        {
            Console.Write("Enter this team member's skill level: ");

            try
            {
                SkillLevel = Math.Round(Convert.ToDouble(Console.ReadLine()));
            }
            catch (FormatException)
            {
                Console.Write("ERROR--Enter a number for this team member's skill level: ");
                SkillLevel = Math.Round(Convert.ToDouble(Console.ReadLine()));
            }

            Console.Write("Enter this team member's courage factor: ");

            try
            {
                CourageFactor = Math.Round(Convert.ToDouble(Console.ReadLine()));
            }
            catch (FormatException)
            {
                Console.Write("ERROR--Enter a decimal between 0 and 2 for this team member's courage factor: ");
                CourageFactor = Math.Round(Convert.ToDouble(Console.ReadLine()));
            }

            if (CourageFactor < 0)
            {
                CourageFactor = 0;
            }
            else if (CourageFactor > 2)
            {
                CourageFactor = 2;
            }
        }

        public void Display()
        {
            Console.Write($"\n***Team Member Information***\nTeam Member: {Name}\nSkill Level: {SkillLevel}\nCourage Factor: {CourageFactor}\n");
        }
    }
}
