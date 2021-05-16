# Division Maintenance Group

DMG Divisions provides a platform to help retailers thrive.
One of the services provides is **inspections**. 

This project is a study case to gRPC + F#, the scenario is, an inspector goes to a retailer and give 3 rates for lighting, snow removal and rooftop maintenance. Those rates range from, BAD, AVERAGE, GOOD.

## Stack
- F#
-- Type Providers
-- Entity Framework
-- Fantomas
- gRPC
- Postgres
- Docker

Originally I was planing to add kafka to the study case but hit the time budget I've set for this project.

## How to run 

from the root of the project
1. `docker-compose up -d database`
2. `dotnet build`
3. `dotnet ef database update`
4. `cd InspectionClient/`
5. Open the `Program.fs` file
6. Edit the example `inspection` object to see how to consume the api.
7. `dotnet run`
8. You'll see on the terminal "the retailer is ...", and a new inspection entry will be added to the database via gRPC.

## Project's Retrospective/Postmortem

### What went well
    - Learned about gRPCs and how to build them
    - Learned about docs limitations of type providers.
    - Praticed Github Actions.
    - Praticed Docker.
    - Learned from real problem how Paket is superior to dotnet raw nuget management.
    - Most of the time were spent on bootstraping stuff. Thus, last time spent on bootstrap work projects.
    - Learn about .NET gRPCs and its limitations like you need a C# project to consume the proto buffers from it.
    - Find out about VSCode Ionide limitation on C#/F# project interop solution.
### What went wrong
    - Most consuming problems were silly problems such as
        - After deleting the old C# gRPC project and creating a new one, I forgot to add the .csproject to the solution, thus, the service wasn't being compiled and matching the protobuffer from the client.
        - Spend too much time figuring out how to manage the DLLs when I had paket to do it like modern package managers do such as pip, npm etc.
    - Didn't had time to add kafka to the project, and it would be really nice to increase my chances on DMG.
    - Most of the time were spent on bootstraping stuff. Thus, last time on business logic.
    - Didn't had time to introduce Computations Expressions at some point to showcase FP skills. (too much simple of project, didn't need anything fancy tbh)
    - Could have added testing to the project, even that fancy lib of algebric auto generated tests. (looks promissing for the next weekend study case)
### Where I got lucky
    - Paket solved all my DLL hell issues.
    - Docs on Entity Framework Core for FSharp, although small, are very precise.
    - gRPC docs on .NET C# still updated.

