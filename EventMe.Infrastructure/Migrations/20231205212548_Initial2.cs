using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventMe.Infrastructure.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterTable(
                name: "Events",
                comment: "Събитие",
                oldComment: "Event");

            migrationBuilder.AlterColumn<int>(
                name: "PlaceId",
                table: "Events",
                type: "int",
                nullable: false,
                comment: "Идентификатор на мястото",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Идетдификатор на мястото");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Events",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                comment: "Име на събитието",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "Име на събитие");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Events",
                type: "int",
                nullable: false,
                comment: "Идентификатор на събитието",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Идендификатор на събитие")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Events",
                type: "datetime2",
                nullable: true,
                comment: "Дата на изтриване");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Events");

            migrationBuilder.AlterTable(
                name: "Events",
                comment: "Event",
                oldComment: "Събитие");

            migrationBuilder.AlterColumn<int>(
                name: "PlaceId",
                table: "Events",
                type: "int",
                nullable: false,
                comment: "Идетдификатор на мястото",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Идентификатор на мястото");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Events",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                comment: "Име на събитие",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "Име на събитието");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Events",
                type: "int",
                nullable: false,
                comment: "Идендификатор на събитие",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Идентификатор на събитието")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }
    }
}
