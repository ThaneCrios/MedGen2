using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Proj.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BirthPlace = table.Column<string>(nullable: true),
                    CityAdress = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Fio = table.Column<string>(nullable: true),
                    Nationality = table.Column<string>(nullable: true),
                    Sex = table.Column<string>(nullable: true),
                    StreetAdress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CardCode = table.Column<string>(nullable: true),
                    ManId = table.Column<int>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    OurNotOur = table.Column<string>(nullable: true),
                    TypeOfInheritance = table.Column<string>(nullable: true),
                    diagnosis = table.Column<string>(nullable: true),
                    disability = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patients_People_ManId",
                        column: x => x.ManId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patients_ManId",
                table: "Patients",
                column: "ManId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
