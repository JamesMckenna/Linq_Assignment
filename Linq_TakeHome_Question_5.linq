<Query Kind="Statements">
  <Connection>
    <ID>7f9718f8-14d6-4fa3-99e2-4a999221d277</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WorkSchedule</Database>
  </Connection>
</Query>

//List all the employees with the most years of experience.

var mostYears = (from years in EmployeeSkills
select years.YearsOfExperience).Max();

var Names = (from g in EmployeeSkills
		 	orderby g.EmployeeID
		 	where g.EmployeeID == g.Employee.EmployeeID && g.YearsOfExperience == mostYears
		 	select new
		 	{
				Name = g.Employee.FirstName + " " + g.Employee.LastName	
			});
Names.Dump();




