using Microsoft.EntityFrameworkCore.Migrations;

namespace TraBlockchain.Migrations
{
    public partial class SeedUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name" },
                new object[,]
                {
                    { 1, "pouya1pournasir@gmail.com", "PouyaAdmin" },
                    { 2, "Mohammad.zanjanchi@gmail.com", "MohammadAdmin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
