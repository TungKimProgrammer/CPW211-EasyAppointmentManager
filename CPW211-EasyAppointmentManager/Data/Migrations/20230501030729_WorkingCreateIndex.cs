using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CPW211_EasyAppointmentManager.Data.Migrations
{
    public partial class WorkingCreateIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TimeSlot_Doctor_DoctorId",
                table: "TimeSlot");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TimeSlotDate",
                table: "TimeSlot",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DoctorId",
                table: "TimeSlot",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TimeSlot_Doctor_DoctorId",
                table: "TimeSlot",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "DoctorId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TimeSlot_Doctor_DoctorId",
                table: "TimeSlot");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TimeSlotDate",
                table: "TimeSlot",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "DoctorId",
                table: "TimeSlot",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeSlot_Doctor_DoctorId",
                table: "TimeSlot",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "DoctorId");
        }
    }
}
