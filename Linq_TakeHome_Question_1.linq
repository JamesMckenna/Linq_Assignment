<Query Kind="Expression">
  <Connection>
    <ID>7f9718f8-14d6-4fa3-99e2-4a999221d277</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WorkSchedule</Database>
  </Connection>
</Query>

//Show all skills requiring a ticket and which employees have those skills. 

from Skill in Skills
where Skill.RequiresTicket == true
orderby Skill.Description
select new 
{
	Description = Skill.Description,
	Employees = from Info in EmployeeSkills
				where Info.SkillID == Skill.SkillID
				orderby Info.YearsOfExperience descending
				select new 
				{
					Name = Info.Employee.FirstName + " " + Info.Employee.LastName,
					Level = Info.Level,
					YearsExperience = Info.YearsOfExperience
				}				
}


