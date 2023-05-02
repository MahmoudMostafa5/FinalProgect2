using Microsoft.EntityFrameworkCore.Migrations;

namespace Schools.DataBase.Migrations
{
    public partial class u2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "JobDegreeId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DepartmentLocation",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Departmentbuilding",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "JobDegree",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobDegree", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_JobDegreeId",
                table: "Employees",
                column: "JobDegreeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_JobDegree_JobDegreeId",
                table: "Employees",
                column: "JobDegreeId",
                principalTable: "JobDegree",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_JobDegree_JobDegreeId",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "JobDegree");

            migrationBuilder.DropIndex(
                name: "IX_Employees_JobDegreeId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "JobDegreeId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DepartmentLocation",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "Departmentbuilding",
                table: "Departments");
        }
    }
}
