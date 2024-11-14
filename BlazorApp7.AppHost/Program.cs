var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.BlazorApp7>("blazorapp7");

builder.Build().Run();
