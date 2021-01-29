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
            SkillLevel = Math.Round(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Enter this team member's courage factor: ");
            CourageFactor = Convert.ToDouble(Console.ReadLine());

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
            Console.WriteLine("***Team Member Information***");
            Console.WriteLine($"Team Member: {Name}");
            Console.WriteLine($"Skill Level: {SkillLevel}");
            Console.WriteLine($"Courage Factor: {CourageFactor}");
        }
    }
}
