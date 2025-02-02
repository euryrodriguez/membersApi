https://medium.com/@akila.ishan101/using-entity-framework-with-database-first-approach-a-step-by-step-guide-c6c72a659f86

Add this to Program.cs

builder.Services.AddDbContext<DbContext, MemberAPIContext>();
