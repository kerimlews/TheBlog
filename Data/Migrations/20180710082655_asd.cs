using Microsoft.EntityFrameworkCore.Migrations;

namespace blog.Migrations
{
    public partial class asd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Tag",
                table: "TagList",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Tag",
                table: "TagList",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
