using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PerformanceIndicator.Migrations
{
    public partial class UserandRoleTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    CNIC = table.Column<string>(nullable: false),
                    Designation = table.Column<string>(nullable: false),
                    salary = table.Column<float>(nullable: false),
                    Role_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_Role_Id",
                        column: x => x.Role_Id,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Type" },
                values: new object[] { 1, "Employee" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Type" },
                values: new object[] { 2, "Manager" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CNIC", "Designation", "Name", "Role_Id", "salary" },
                values: new object[] { 1, "3740216028296", "Clerk", "Kashif", 1, 50000f });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CNIC", "Designation", "Name", "Role_Id", "salary" },
                values: new object[] { 2, "3740216028298", "Manager", "Atif", 2, 50000f });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Role_Id",
                table: "Users",
                column: "Role_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
