using Microsoft.EntityFrameworkCore.Migrations;

namespace AppointmentDoctor.Migrations
{
    public partial class IsDoctorApproved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsApproved",
                table: "Appointments",
                newName: "IsDoctorApproved");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsDoctorApproved",
                table: "Appointments",
                newName: "IsApproved");
        }
    }
}
