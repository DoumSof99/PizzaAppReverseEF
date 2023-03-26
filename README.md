# PizzaAppReverseEF
Console App .Net 7.0 with Reverse Entity Freamework

Create a new Console App, then in the PMC run the command:
Simple: 
Scaffold-DbContext "ConnectionString" Microsoft.EntityFrameworkCore.SqlServer -ContextDir Data -OutputDir Models
With annotations:
Scaffold-DbContext "ConnectionString" Microsoft.EntityFrameworkCore.SqlServer -ContextDir Data -OutputDir Models -DataAnnotation
To seperate the genrated Models and work with them with another logic use the command:
Scaffold-DbContext "ConnectionString" Microsoft.EntityFrameworkCore.SqlServer -ContextDir Data -OutputDir Models/Generated -ContextNamespace PizzaAppReverseEF.Data -Namespace PizzaAppReverseEF.Models

These commands allows to work with an existing DB
