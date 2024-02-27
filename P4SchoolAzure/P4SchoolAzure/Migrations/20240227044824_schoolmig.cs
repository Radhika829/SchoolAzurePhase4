using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P4SchoolAzure.Migrations
{
    public partial class schoolmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "student",
                columns: table => new
                {
                    student_id = table.Column<int>(type: "int", nullable: false),
                    Fname = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Lname = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    course = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Gender = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_student", x => x.student_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "student");
        }
    }
}
