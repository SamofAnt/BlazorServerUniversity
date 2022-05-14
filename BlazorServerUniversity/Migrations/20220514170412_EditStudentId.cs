using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorServerUniversity.Migrations
{
    public partial class EditStudentId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DisciplineTypes",
                columns: table => new
                {
                    IdDisciplineType = table.Column<long>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisciplineTypes", x => x.IdDisciplineType);
                });

            migrationBuilder.CreateTable(
                name: "Faculties",
                columns: table => new
                {
                    IdFaculty = table.Column<long>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculties", x => x.IdFaculty);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    IdDepartment = table.Column<long>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Code = table.Column<string>(type: "TEXT", nullable: false),
                    FacultyId = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.IdDepartment);
                    table.ForeignKey(
                        name: "FK_Departments_Faculties_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculties",
                        principalColumn: "IdFaculty");
                });

            migrationBuilder.CreateTable(
                name: "Speciality",
                columns: table => new
                {
                    IdSpeciality = table.Column<long>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    DepartmentId = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speciality", x => x.IdSpeciality);
                    table.ForeignKey(
                        name: "FK_Speciality_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "IdDepartment");
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    IdGroup = table.Column<long>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    SpecialityId = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.IdGroup);
                    table.ForeignKey(
                        name: "FK_Groups_Speciality_SpecialityId",
                        column: x => x.SpecialityId,
                        principalTable: "Speciality",
                        principalColumn: "IdSpeciality");
                });

            migrationBuilder.CreateTable(
                name: "Disciplines",
                columns: table => new
                {
                    IdDiscipline = table.Column<long>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    LectureHours = table.Column<long>(type: "INTEGER", nullable: false),
                    PracticeHours = table.Column<string>(type: "TEXT", nullable: false),
                    DisciplineTypeId = table.Column<long>(type: "INTEGER", nullable: false),
                    ProfessorId = table.Column<long>(type: "INTEGER", nullable: false),
                    DepartmentId = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplines", x => x.IdDiscipline);
                    table.ForeignKey(
                        name: "FK_Disciplines_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "IdDepartment");
                    table.ForeignKey(
                        name: "FK_Disciplines_DisciplineTypes_DisciplineTypeId",
                        column: x => x.DisciplineTypeId,
                        principalTable: "DisciplineTypes",
                        principalColumn: "IdDisciplineType");
                });

            migrationBuilder.CreateTable(
                name: "GroupDiscipline",
                columns: table => new
                {
                    IdGroupDiscipline = table.Column<long>(type: "INTEGER", nullable: false),
                    dateStart = table.Column<string>(type: "TEXT", nullable: true),
                    dateEnd = table.Column<string>(type: "TEXT", nullable: true),
                    GroupId = table.Column<long>(type: "INTEGER", nullable: false),
                    DisciplineId = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupDiscipline", x => x.IdGroupDiscipline);
                    table.ForeignKey(
                        name: "FK_GroupDiscipline_Disciplines_DisciplineId",
                        column: x => x.DisciplineId,
                        principalTable: "Disciplines",
                        principalColumn: "IdDiscipline");
                    table.ForeignKey(
                        name: "FK_GroupDiscipline_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "IdGroup");
                });

            migrationBuilder.CreateTable(
                name: "PersonalData",
                columns: table => new
                {
                    IdPersonalData = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Age = table.Column<long>(type: "INTEGER", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    StudentId = table.Column<long>(type: "INTEGER", nullable: true),
                    ProfessorId = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalData", x => x.IdPersonalData);
                });

            migrationBuilder.CreateTable(
                name: "Professors",
                columns: table => new
                {
                    IdProfessor = table.Column<long>(type: "INTEGER", nullable: false),
                    DepartmentId = table.Column<long>(type: "INTEGER", nullable: false),
                    PersonalDataId = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professors", x => x.IdProfessor);
                    table.ForeignKey(
                        name: "FK_Professors_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "IdDepartment");
                    table.ForeignKey(
                        name: "FK_Professors_PersonalData_PersonalDataId",
                        column: x => x.PersonalDataId,
                        principalTable: "PersonalData",
                        principalColumn: "IdPersonalData");
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    IdStudent = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Course = table.Column<long>(type: "INTEGER", nullable: false),
                    IsStudy = table.Column<long>(type: "INTEGER", nullable: false),
                    GroupId = table.Column<long>(type: "INTEGER", nullable: false),
                    PersonalDataId = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.IdStudent);
                    table.ForeignKey(
                        name: "FK_Students_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "IdGroup");
                    table.ForeignKey(
                        name: "FK_Students_PersonalData_PersonalDataId",
                        column: x => x.PersonalDataId,
                        principalTable: "PersonalData",
                        principalColumn: "IdPersonalData",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentDiscipline",
                columns: table => new
                {
                    IdStudentDiscipline = table.Column<long>(type: "INTEGER", nullable: false),
                    StudentId = table.Column<long>(type: "INTEGER", nullable: false),
                    DisciplineId = table.Column<long>(type: "INTEGER", nullable: false),
                    isPay = table.Column<long>(type: "INTEGER", nullable: false),
                    Grade = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentDiscipline", x => x.IdStudentDiscipline);
                    table.ForeignKey(
                        name: "FK_StudentDiscipline_Disciplines_DisciplineId",
                        column: x => x.DisciplineId,
                        principalTable: "Disciplines",
                        principalColumn: "IdDiscipline",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentDiscipline_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "IdStudent",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departments_FacultyId",
                table: "Departments",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplines_DepartmentId",
                table: "Disciplines",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplines_DisciplineTypeId",
                table: "Disciplines",
                column: "DisciplineTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplines_ProfessorId",
                table: "Disciplines",
                column: "ProfessorId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupDiscipline_DisciplineId",
                table: "GroupDiscipline",
                column: "DisciplineId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupDiscipline_GroupId",
                table: "GroupDiscipline",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_SpecialityId",
                table: "Groups",
                column: "SpecialityId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalData_ProfessorId",
                table: "PersonalData",
                column: "ProfessorId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalData_StudentId",
                table: "PersonalData",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Professors_DepartmentId",
                table: "Professors",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Professors_PersonalDataId",
                table: "Professors",
                column: "PersonalDataId");

            migrationBuilder.CreateIndex(
                name: "IX_Speciality_DepartmentId",
                table: "Speciality",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentDiscipline_DisciplineId",
                table: "StudentDiscipline",
                column: "DisciplineId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentDiscipline_StudentId",
                table: "StudentDiscipline",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_GroupId",
                table: "Students",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_PersonalDataId",
                table: "Students",
                column: "PersonalDataId");

            migrationBuilder.AddForeignKey(
                name: "FK_Disciplines_Professors_ProfessorId",
                table: "Disciplines",
                column: "ProfessorId",
                principalTable: "Professors",
                principalColumn: "IdProfessor");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalData_Professors_ProfessorId",
                table: "PersonalData",
                column: "ProfessorId",
                principalTable: "Professors",
                principalColumn: "IdProfessor");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalData_Students_StudentId",
                table: "PersonalData",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "IdStudent");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Faculties_FacultyId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Professors_Departments_DepartmentId",
                table: "Professors");

            migrationBuilder.DropForeignKey(
                name: "FK_Speciality_Departments_DepartmentId",
                table: "Speciality");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonalData_Professors_ProfessorId",
                table: "PersonalData");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Groups_GroupId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonalData_Students_StudentId",
                table: "PersonalData");

            migrationBuilder.DropTable(
                name: "GroupDiscipline");

            migrationBuilder.DropTable(
                name: "StudentDiscipline");

            migrationBuilder.DropTable(
                name: "Disciplines");

            migrationBuilder.DropTable(
                name: "DisciplineTypes");

            migrationBuilder.DropTable(
                name: "Faculties");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Professors");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Speciality");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "PersonalData");
        }
    }
}
