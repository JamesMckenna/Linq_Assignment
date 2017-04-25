<Query Kind="Expression">
  <Connection>
    <ID>7f9718f8-14d6-4fa3-99e2-4a999221d277</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WorkSchedule</Database>
  </Connection>
</Query>

//List all skills, alphabetically, showing only the description of the skill.

from desc in Skills
orderby desc.Description ascending
select desc.Description 