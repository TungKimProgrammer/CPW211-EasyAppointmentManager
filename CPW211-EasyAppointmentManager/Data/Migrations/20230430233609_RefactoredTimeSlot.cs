using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CPW211_EasyAppointmentManager.Data.Migrations
{
    public partial class RefactoredTimeSlot : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Service_ServiceId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_ClinicService_Service_ServicesServiceId",
                table: "ClinicService");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_TimeSlot_TimeSlotId",
                table: "Doctor");

            migrationBuilder.DropForeignKey(
                name: "FK_DoctorService_Service_ServicesServiceId",
                table: "DoctorService");

            migrationBuilder.DropIndex(
                name: "IX_Doctor_TimeSlotId",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "TimeSlotId",
                table: "Doctor");

            migrationBuilder.RenameColumn(
                name: "ServiceId",
                table: "Service",
                newName: "DoctorId");

            migrationBuilder.RenameColumn(
                name: "ServicesServiceId",
                table: "DoctorService",
                newName: "ServicesDoctorId");

            migrationBuilder.RenameIndex(
                name: "IX_DoctorService_ServicesServiceId",
                table: "DoctorService",
                newName: "IX_DoctorService_ServicesDoctorId");

            migrationBuilder.RenameColumn(
                name: "ServicesServiceId",
                table: "ClinicService",
                newName: "ServicesDoctorId");

            migrationBuilder.RenameIndex(
                name: "IX_ClinicService_ServicesServiceId",
                table: "ClinicService",
                newName: "IX_ClinicService_ServicesDoctorId");

            migrationBuilder.RenameColumn(
                name: "ServiceId",
                table: "Appointment",
                newName: "ServiceDoctorId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_ServiceId",
                table: "Appointment",
                newName: "IX_Appointment_ServiceDoctorId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "TimeSlot",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "TimeSlot",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "TimeSlot",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TimeSlot_DoctorId",
                table: "TimeSlot",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Service_ServiceDoctorId",
                table: "Appointment",
                column: "ServiceDoctorId",
                principalTable: "Service",
                principalColumn: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClinicService_Service_ServicesDoctorId",
                table: "ClinicService",
                column: "ServicesDoctorId",
                principalTable: "Service",
                principalColumn: "DoctorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorService_Service_ServicesDoctorId",
                table: "DoctorService",
                column: "ServicesDoctorId",
                principalTable: "Service",
                principalColumn: "DoctorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TimeSlot_Doctor_DoctorId",
                table: "TimeSlot",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "DoctorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Service_ServiceDoctorId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_ClinicService_Service_ServicesDoctorId",
                table: "ClinicService");

            migrationBuilder.DropForeignKey(
                name: "FK_DoctorService_Service_ServicesDoctorId",
                table: "DoctorService");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeSlot_Doctor_DoctorId",
                table: "TimeSlot");

            migrationBuilder.DropIndex(
                name: "IX_TimeSlot_DoctorId",
                table: "TimeSlot");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "TimeSlot");

            migrationBuilder.RenameColumn(
                name: "DoctorId",
                table: "Service",
                newName: "ServiceId");

            migrationBuilder.RenameColumn(
                name: "ServicesDoctorId",
                table: "DoctorService",
                newName: "ServicesServiceId");

            migrationBuilder.RenameIndex(
                name: "IX_DoctorService_ServicesDoctorId",
                table: "DoctorService",
                newName: "IX_DoctorService_ServicesServiceId");

            migrationBuilder.RenameColumn(
                name: "ServicesDoctorId",
                table: "ClinicService",
                newName: "ServicesServiceId");

            migrationBuilder.RenameIndex(
                name: "IX_ClinicService_ServicesDoctorId",
                table: "ClinicService",
                newName: "IX_ClinicService_ServicesServiceId");

            migrationBuilder.RenameColumn(
                name: "ServiceDoctorId",
                table: "Appointment",
                newName: "ServiceId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_ServiceDoctorId",
                table: "Appointment",
                newName: "IX_Appointment_ServiceId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "TimeSlot",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "TimeSlot",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "TimeSlotId",
                table: "Doctor",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_TimeSlotId",
                table: "Doctor",
                column: "TimeSlotId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Service_ServiceId",
                table: "Appointment",
                column: "ServiceId",
                principalTable: "Service",
                principalColumn: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClinicService_Service_ServicesServiceId",
                table: "ClinicService",
                column: "ServicesServiceId",
                principalTable: "Service",
                principalColumn: "ServiceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_TimeSlot_TimeSlotId",
                table: "Doctor",
                column: "TimeSlotId",
                principalTable: "TimeSlot",
                principalColumn: "TimeSlotId");

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorService_Service_ServicesServiceId",
                table: "DoctorService",
                column: "ServicesServiceId",
                principalTable: "Service",
                principalColumn: "ServiceId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
