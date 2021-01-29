using System;
using System.Collections.Generic;
using System.Text;

namespace Week_3_Exercises
{
    class Team
    {
        public List<TeamMember> TeamMembers { get; set; } = new List<TeamMember>();

        public void AddTeamMember(TeamMember teamMember)
        {
            TeamMembers.Add(teamMember);
        }
    }
}
