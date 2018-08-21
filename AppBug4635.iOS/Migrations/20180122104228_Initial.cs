using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AppBug4635.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BuggedNotNullableEntities",
                columns: table => new
                {
                    Key = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NotNullable1 = table.Column<bool>(nullable: false),
                    NotNullable10 = table.Column<bool>(nullable: false),
                    NotNullable11 = table.Column<bool>(nullable: false),
                    NotNullable12 = table.Column<bool>(nullable: false),
                    NotNullable13 = table.Column<bool>(nullable: false),
                    NotNullable14 = table.Column<bool>(nullable: false),
                    NotNullable2 = table.Column<bool>(nullable: false),
                    NotNullable3 = table.Column<bool>(nullable: false),
                    NotNullable4 = table.Column<bool>(nullable: false),
                    NotNullable5 = table.Column<bool>(nullable: false),
                    NotNullable6 = table.Column<bool>(nullable: false),
                    NotNullable7 = table.Column<bool>(nullable: false),
                    NotNullable8 = table.Column<bool>(nullable: false),
                    NotNullable9 = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuggedNotNullableEntities", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "BuggedNullableEntities",
                columns: table => new
                {
                    Key = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nullable1 = table.Column<long>(nullable: true),
                    Nullable2 = table.Column<long>(nullable: true),
                    Nullable3 = table.Column<long>(nullable: true),
                    Nullable4 = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuggedNullableEntities", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "OkNotNullableEntities",
                columns: table => new
                {
                    Key = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NotNullable1 = table.Column<bool>(nullable: false),
                    NotNullable10 = table.Column<bool>(nullable: false),
                    NotNullable11 = table.Column<bool>(nullable: false),
                    NotNullable12 = table.Column<bool>(nullable: false),
                    NotNullable13 = table.Column<bool>(nullable: false),
                    NotNullable2 = table.Column<bool>(nullable: false),
                    NotNullable3 = table.Column<bool>(nullable: false),
                    NotNullable4 = table.Column<bool>(nullable: false),
                    NotNullable5 = table.Column<bool>(nullable: false),
                    NotNullable6 = table.Column<bool>(nullable: false),
                    NotNullable7 = table.Column<bool>(nullable: false),
                    NotNullable8 = table.Column<bool>(nullable: false),
                    NotNullable9 = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OkNotNullableEntities", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "OkNullableEntities",
                columns: table => new
                {
                    Key = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nullable1 = table.Column<long>(nullable: true),
                    Nullable2 = table.Column<long>(nullable: true),
                    Nullable3 = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OkNullableEntities", x => x.Key);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BuggedNotNullableEntities");

            migrationBuilder.DropTable(
                name: "BuggedNullableEntities");

            migrationBuilder.DropTable(
                name: "OkNotNullableEntities");

            migrationBuilder.DropTable(
                name: "OkNullableEntities");
        }
    }
}
