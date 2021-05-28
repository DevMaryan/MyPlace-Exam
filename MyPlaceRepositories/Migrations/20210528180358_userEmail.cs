using Microsoft.EntityFrameworkCore.Migrations;

namespace MyPlaceRepositories.Migrations
{
    public partial class userEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Posts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Posts");
        }
    }
}
