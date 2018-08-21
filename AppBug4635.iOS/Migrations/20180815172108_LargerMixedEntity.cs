using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AppBug4635.Migrations
{
    public partial class LargerMixedEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BuggedLargerNullableEntities",
                columns: table => new
                {
                    Key = table.Column<Guid>(nullable: false),
                    NotNullable1 = table.Column<int>(nullable: false),
                    NotNullable2 = table.Column<DateTime>(nullable: false),
                    NotNullable3 = table.Column<DateTime>(nullable: false),
                    NotNullable4 = table.Column<DateTime>(nullable: false),
                    Nullable1 = table.Column<int>(nullable: true),
                    Nullable2 = table.Column<Guid>(nullable: true),
                    Nullable3 = table.Column<Guid>(nullable: true),
                    Nullable4 = table.Column<Guid>(nullable: true),
                    Nullable5 = table.Column<string>(nullable: true),
                    Nullable6 = table.Column<DateTime>(nullable: true),
                    Nullable7 = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuggedLargerNullableEntities", x => x.Key);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BuggedLargerNullableEntities");
        }
    }
}
