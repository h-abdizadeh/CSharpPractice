using SqliteApp.Data;
using SqliteApp.Models;
using static System.Console;

//test app steps 
//step 1 : 
//tools > Nuget package manager > package manager console
//step 2 : 
//PM> update-database

DatabaseContext database = new DatabaseContext();

////////////////////////////////////////////////////
//1 show all data
//var persons = database.Persons.ToList();
//foreach (var item in persons)
//    WriteLine($"{item.Id}\t{item.Fname}\t{item.Lname}\t{item.Age}");

/////////////////////////////////////////////////////
//2 insert new data
//var person = new Person()
//{
//    Fname = "reza",
//    Lname = "amiri",
//    Age = 32
//};

//database.Persons.Add(person);
//database.SaveChanges();

/////////////////////////////////////////////////
//3 search data
//var search = "asad";
//WriteLine($"search result : {search}");
//var result = 
//    database.Persons.Where(p => p.Lname.Contains(search)).ToList();
//foreach (var item in result)
//    WriteLine($"{item.Id}\t{item.Fname}\t{item.Lname}\t{item.Age}");

////////////////////////////////////////////////////
//4 Delete Data
//var id = 1;
//var person = database.Persons.Find(id);
//if (person is not null)//!=
//{
//    database.Persons.Remove(person);
//    database.SaveChanges();
//}

///////////////////////////////////////////////////
//5 update Data
//var id = 2;
//var person = database.Persons.FirstOrDefault(p => p.Id == id);
//if (person is not null)
//{

//    person.Age = 32;
//    person.Fname = "arad";

//    database.Persons.Update(person);
//    //database.Update(person);
//    //database.Update(person).CurrentValues.SetValues(person);
//    database.SaveChanges();
//}
