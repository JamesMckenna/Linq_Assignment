<Query Kind="Statements">
  <Connection>
    <ID>7f9718f8-14d6-4fa3-99e2-4a999221d277</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WorkSchedule</Database>
  </Connection>
</Query>


//List all the skills for which we do not have any qualfied employees.

from i in Skills
orderby i.SkillID
where i.EmployeeSkills.All(s => s.SkillID != i.SkillID)
select i.Description
