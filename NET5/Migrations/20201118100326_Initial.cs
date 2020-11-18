using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace NET5.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Functions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Delete = table.Column<bool>(type: "boolean", nullable: false),
                    InsertAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Functions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pages",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FunctionId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Area = table.Column<string>(type: "text", nullable: true),
                    Level1 = table.Column<string>(type: "text", nullable: false),
                    Level2 = table.Column<string>(type: "text", nullable: true),
                    Level3 = table.Column<string>(type: "text", nullable: true),
                    Level4 = table.Column<string>(type: "text", nullable: true),
                    LevelView = table.Column<string>(type: "text", nullable: false),
                    RootParam = table.Column<string>(type: "text", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Delete = table.Column<bool>(type: "boolean", nullable: false),
                    InsertAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pages_Functions_FunctionId",
                        column: x => x.FunctionId,
                        principalTable: "Functions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pages_FunctionId",
                table: "Pages",
                column: "FunctionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pages");

            migrationBuilder.DropTable(
                name: "Functions");
        }
    }
}
