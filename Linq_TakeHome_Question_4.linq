<Query Kind="Statements">
  <Connection>
    <ID>7f9718f8-14d6-4fa3-99e2-4a999221d277</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WorkSchedule</Database>
  </Connection>
</Query>

//From the shifts scheduled for NAIT's placement contract, show the number of employees needed for each day (ordered by day-of-week). 
//Bonus: display the name of the day of week (first day being Monday
	

from shift in Shifts
orderby shift.DayOfWeek ascending
where shift.PlacementContract.Location.Name.Contains("NAIT")
group shift by shift.DayOfWeek into holder
select new 
	{
		Day = holder.Key,
		EmployeesNeeded = holder.Sum(s => s.NumberOfEmployees)
	}