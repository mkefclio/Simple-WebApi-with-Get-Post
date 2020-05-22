# Simple-WebApi-with-Get-Post

Writer : Manos Kefalas
Date : 22/5/2020

Title : Simple_WebApi_with_Get-Post

Subject: This is a simple web api with two methods.
The first is a post method (/api/values/save/) ,
and receives a JSON object 
e.g.
  {
	Id:1,
	Name:"Manos"
}
that is saved in the root of the project.
The JSON object is saved in a txt file with the name : customer.txt.

The second is a get method (/api/values/get/),
that reads the customer.txt file
and returns a JSON object.

The particular project has been developed with Microsoft Visual Studio Community 2019
and .NET Framework 4.8 .
