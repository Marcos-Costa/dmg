﻿// <auto-generated />
namespace InspectionServer.Migrations

open System
open Microsoft.EntityFrameworkCore
open Microsoft.EntityFrameworkCore.Infrastructure
open Microsoft.EntityFrameworkCore.Metadata
open Microsoft.EntityFrameworkCore.Migrations
open Microsoft.EntityFrameworkCore.Storage.ValueConversion

[<DbContext(typeof<InspectionModel.InspectionsContext>)>]
[<Migration("20210516014128_inspection_to_sneakcase")>]
type inspection_to_sneakcase() =
    inherit Migration()

    override this.Up(migrationBuilder: MigrationBuilder) =
        migrationBuilder.RenameColumn(name = "Retail", table = "Inspections", newName = "retail")
        |> ignore

        migrationBuilder.RenameColumn(name = "SnowRate", table = "Inspections", newName = "snow_rate")
        |> ignore

        migrationBuilder.RenameColumn(name = "RooftopRate", table = "Inspections", newName = "rooftop_rate")
        |> ignore

        migrationBuilder.RenameColumn(name = "LightingRate", table = "Inspections", newName = "lighting_rate")
        |> ignore


    override this.Down(migrationBuilder: MigrationBuilder) =
        migrationBuilder.RenameColumn(name = "retail", table = "Inspections", newName = "Retail")
        |> ignore

        migrationBuilder.RenameColumn(name = "snow_rate", table = "Inspections", newName = "SnowRate")
        |> ignore

        migrationBuilder.RenameColumn(name = "rooftop_rate", table = "Inspections", newName = "RooftopRate")
        |> ignore

        migrationBuilder.RenameColumn(name = "lighting_rate", table = "Inspections", newName = "LightingRate")
        |> ignore


    override this.BuildTargetModel(modelBuilder: ModelBuilder) =
        modelBuilder

            .UseIdentityByDefaultColumns()
            .HasAnnotation("Relational:MaxIdentifierLength", 63)
            .HasAnnotation("ProductVersion", "5.0.6")
        |> ignore

        modelBuilder.Entity(
            "InspectionModel+inspections",
            (fun b ->

                b.Property<string>("retail").HasColumnType("text")
                |> ignore

                b
                    .Property<int>("lighting_rate")
                    .IsRequired()
                    .HasColumnType("integer")
                |> ignore

                b
                    .Property<int>("rooftop_rate")
                    .IsRequired()
                    .HasColumnType("integer")
                |> ignore

                b
                    .Property<int>("snow_rate")
                    .IsRequired()
                    .HasColumnType("integer")
                |> ignore

                b.HasKey("retail") |> ignore

                b.ToTable("Inspections") |> ignore

                )
        )
        |> ignore