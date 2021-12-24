using System.Collections.Generic;
using ClubManagerBackup.Entities;

namespace ClubManagerBackup.Dtos
{
    public class ClubDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ClubDescription { get; set; }
        public List<User> StudentsClubMembers { get; set; }
        public int ClubBudget{ get; set; }
    }
}