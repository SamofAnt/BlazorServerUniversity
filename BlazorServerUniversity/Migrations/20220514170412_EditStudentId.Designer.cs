// <auto-generated />
using System;
using BlazorServerUniversity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorServerUniversity.Migrations
{
    [DbContext(typeof(UniversityContext))]
    [Migration("20220514170412_EditStudentId")]
    partial class EditStudentId
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.4");

            modelBuilder.Entity("BlazorServerUniversity.Department", b =>
                {
                    b.Property<long>("IdDepartment")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("FacultyId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("IdDepartment");

                    b.HasIndex("FacultyId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("BlazorServerUniversity.Discipline", b =>
                {
                    b.Property<long>("IdDiscipline")
                        .HasColumnType("INTEGER");

                    b.Property<long>("DepartmentId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("DisciplineTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("LectureHours")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PracticeHours")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("ProfessorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdDiscipline");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("DisciplineTypeId");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Disciplines");
                });

            modelBuilder.Entity("BlazorServerUniversity.DisciplineType", b =>
                {
                    b.Property<long>("IdDisciplineType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("IdDisciplineType");

                    b.ToTable("DisciplineTypes");
                });

            modelBuilder.Entity("BlazorServerUniversity.Faculty", b =>
                {
                    b.Property<long>("IdFaculty")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("IdFaculty");

                    b.ToTable("Faculties");
                });

            modelBuilder.Entity("BlazorServerUniversity.Group", b =>
                {
                    b.Property<long>("IdGroup")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("SpecialityId")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdGroup");

                    b.HasIndex("SpecialityId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("BlazorServerUniversity.GroupDiscipline", b =>
                {
                    b.Property<long>("IdGroupDiscipline")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DateEnd")
                        .HasColumnType("TEXT")
                        .HasColumnName("dateEnd");

                    b.Property<string>("DateStart")
                        .HasColumnType("TEXT")
                        .HasColumnName("dateStart");

                    b.Property<long>("DisciplineId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("GroupId")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdGroupDiscipline");

                    b.HasIndex("DisciplineId");

                    b.HasIndex("GroupId");

                    b.ToTable("GroupDiscipline", (string)null);
                });

            modelBuilder.Entity("BlazorServerUniversity.ListExamsForEachGroup", b =>
                {
                    b.Property<string>("Discipline")
                        .HasColumnType("TEXT");

                    b.Property<string>("DisciplineType")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("FullName")
                        .HasColumnType("BLOB")
                        .HasColumnName("FullName");

                    b.Property<string>("Group")
                        .HasColumnType("TEXT");

                    b.ToView("ListExamsForEachGroup");
                });

            modelBuilder.Entity("BlazorServerUniversity.ListOfAdmittedStudent", b =>
                {
                    b.Property<string>("Discipline")
                        .HasColumnType("TEXT");

                    b.Property<string>("DisciplineType")
                        .HasColumnType("TEXT")
                        .HasColumnName("Discipline Type");

                    b.Property<byte[]>("FullName")
                        .HasColumnType("BLOB")
                        .HasColumnName("Full Name");

                    b.Property<string>("Group")
                        .HasColumnType("TEXT");

                    b.ToView("ListOfAdmittedStudents");
                });

            modelBuilder.Entity("BlazorServerUniversity.ListOfDisciplinesForEachProfessor", b =>
                {
                    b.Property<string>("Discipline")
                        .HasColumnType("TEXT");

                    b.Property<string>("DisciplineType")
                        .HasColumnType("TEXT")
                        .HasColumnName("DisciplineType");

                    b.Property<string>("Group")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProfessorName")
                        .HasColumnType("TEXT");

                    b.ToView("ListOfDisciplinesForEachProfessors");
                });

            modelBuilder.Entity("BlazorServerUniversity.PersonalDatum", b =>
                {
                    b.Property<long>("IdPersonalData")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long?>("ProfessorId")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("StudentId")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdPersonalData");

                    b.HasIndex("ProfessorId");

                    b.HasIndex("StudentId");

                    b.ToTable("PersonalData");
                });

            modelBuilder.Entity("BlazorServerUniversity.Professor", b =>
                {
                    b.Property<long>("IdProfessor")
                        .HasColumnType("INTEGER");

                    b.Property<long>("DepartmentId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("PersonalDataId")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdProfessor");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("PersonalDataId");

                    b.ToTable("Professors");
                });

            modelBuilder.Entity("BlazorServerUniversity.Speciality", b =>
                {
                    b.Property<long>("IdSpeciality")
                        .HasColumnType("INTEGER");

                    b.Property<long>("DepartmentId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("IdSpeciality");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Speciality", (string)null);
                });

            modelBuilder.Entity("BlazorServerUniversity.Student", b =>
                {
                    b.Property<long>("IdStudent")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("Course")
                        .HasColumnType("INTEGER");

                    b.Property<long>("GroupId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("IsStudy")
                        .HasColumnType("INTEGER");

                    b.Property<long>("PersonalDataId")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdStudent");

                    b.HasIndex("GroupId");

                    b.HasIndex("PersonalDataId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("BlazorServerUniversity.StudentDiscipline", b =>
                {
                    b.Property<long>("IdStudentDiscipline")
                        .HasColumnType("INTEGER");

                    b.Property<long>("DisciplineId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Grade")
                        .HasColumnType("INTEGER");

                    b.Property<long>("IsPay")
                        .HasColumnType("INTEGER")
                        .HasColumnName("isPay");

                    b.Property<long>("StudentId")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdStudentDiscipline");

                    b.HasIndex("DisciplineId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentDiscipline", (string)null);
                });

            modelBuilder.Entity("BlazorServerUniversity.StudentsWhoPayPass", b =>
                {
                    b.Property<string>("Discipline")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("FullName")
                        .HasColumnType("BLOB")
                        .HasColumnName("Full Name");

                    b.Property<long?>("Grade")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Group")
                        .HasColumnType("TEXT");

                    b.ToView("StudentsWhoPayPass");
                });

            modelBuilder.Entity("BlazorServerUniversity.Department", b =>
                {
                    b.HasOne("BlazorServerUniversity.Faculty", "Faculty")
                        .WithMany("Departments")
                        .HasForeignKey("FacultyId")
                        .IsRequired();

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("BlazorServerUniversity.Discipline", b =>
                {
                    b.HasOne("BlazorServerUniversity.Department", "Department")
                        .WithMany("Disciplines")
                        .HasForeignKey("DepartmentId")
                        .IsRequired();

                    b.HasOne("BlazorServerUniversity.DisciplineType", "DisciplineType")
                        .WithMany("Disciplines")
                        .HasForeignKey("DisciplineTypeId")
                        .IsRequired();

                    b.HasOne("BlazorServerUniversity.Professor", "Professor")
                        .WithMany("Disciplines")
                        .HasForeignKey("ProfessorId")
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("DisciplineType");

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("BlazorServerUniversity.Group", b =>
                {
                    b.HasOne("BlazorServerUniversity.Speciality", "Speciality")
                        .WithMany("Groups")
                        .HasForeignKey("SpecialityId")
                        .IsRequired();

                    b.Navigation("Speciality");
                });

            modelBuilder.Entity("BlazorServerUniversity.GroupDiscipline", b =>
                {
                    b.HasOne("BlazorServerUniversity.Discipline", "Discipline")
                        .WithMany("GroupDisciplines")
                        .HasForeignKey("DisciplineId")
                        .IsRequired();

                    b.HasOne("BlazorServerUniversity.Group", "Group")
                        .WithMany("GroupDisciplines")
                        .HasForeignKey("GroupId")
                        .IsRequired();

                    b.Navigation("Discipline");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("BlazorServerUniversity.PersonalDatum", b =>
                {
                    b.HasOne("BlazorServerUniversity.Professor", "Professor")
                        .WithMany("PersonalData")
                        .HasForeignKey("ProfessorId");

                    b.HasOne("BlazorServerUniversity.Student", "Student")
                        .WithMany("PersonalData")
                        .HasForeignKey("StudentId");

                    b.Navigation("Professor");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("BlazorServerUniversity.Professor", b =>
                {
                    b.HasOne("BlazorServerUniversity.Department", "Department")
                        .WithMany("Professors")
                        .HasForeignKey("DepartmentId")
                        .IsRequired();

                    b.HasOne("BlazorServerUniversity.PersonalDatum", "PersonalDataNavigation")
                        .WithMany("Professors")
                        .HasForeignKey("PersonalDataId")
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("PersonalDataNavigation");
                });

            modelBuilder.Entity("BlazorServerUniversity.Speciality", b =>
                {
                    b.HasOne("BlazorServerUniversity.Department", "Department")
                        .WithMany("Specialities")
                        .HasForeignKey("DepartmentId")
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("BlazorServerUniversity.Student", b =>
                {
                    b.HasOne("BlazorServerUniversity.Group", "Group")
                        .WithMany("Students")
                        .HasForeignKey("GroupId")
                        .IsRequired();

                    b.HasOne("BlazorServerUniversity.PersonalDatum", "PersonalDataNavigation")
                        .WithMany("Students")
                        .HasForeignKey("PersonalDataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("PersonalDataNavigation");
                });

            modelBuilder.Entity("BlazorServerUniversity.StudentDiscipline", b =>
                {
                    b.HasOne("BlazorServerUniversity.Discipline", "Discipline")
                        .WithMany("StudentDisciplines")
                        .HasForeignKey("DisciplineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorServerUniversity.Student", "Student")
                        .WithMany("StudentDisciplines")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Discipline");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("BlazorServerUniversity.Department", b =>
                {
                    b.Navigation("Disciplines");

                    b.Navigation("Professors");

                    b.Navigation("Specialities");
                });

            modelBuilder.Entity("BlazorServerUniversity.Discipline", b =>
                {
                    b.Navigation("GroupDisciplines");

                    b.Navigation("StudentDisciplines");
                });

            modelBuilder.Entity("BlazorServerUniversity.DisciplineType", b =>
                {
                    b.Navigation("Disciplines");
                });

            modelBuilder.Entity("BlazorServerUniversity.Faculty", b =>
                {
                    b.Navigation("Departments");
                });

            modelBuilder.Entity("BlazorServerUniversity.Group", b =>
                {
                    b.Navigation("GroupDisciplines");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("BlazorServerUniversity.PersonalDatum", b =>
                {
                    b.Navigation("Professors");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("BlazorServerUniversity.Professor", b =>
                {
                    b.Navigation("Disciplines");

                    b.Navigation("PersonalData");
                });

            modelBuilder.Entity("BlazorServerUniversity.Speciality", b =>
                {
                    b.Navigation("Groups");
                });

            modelBuilder.Entity("BlazorServerUniversity.Student", b =>
                {
                    b.Navigation("PersonalData");

                    b.Navigation("StudentDisciplines");
                });
#pragma warning restore 612, 618
        }
    }
}
