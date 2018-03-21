using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Proj.Migrations
{
    public partial class Places : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_People_ManId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_ManId",
                table: "Patients");

            migrationBuilder.CreateTable(
                name: "LivePlaces",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CityName = table.Column<string>(nullable: true),
                    CityType = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    Population = table.Column<int>(nullable: false),
                    PopulationChildren = table.Column<int>(nullable: false),
                    Republic = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LivePlaces", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LivePlaces");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_ManId",
                table: "Patients",
                column: "ManId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_People_ManId",
                table: "Patients",
                column: "ManId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
