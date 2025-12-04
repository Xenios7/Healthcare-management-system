using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EHRNurse.Data.Migrations
{
    /// <inheritdoc />
    public partial class SyncGhostTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /*
            migrationBuilder.AlterColumn<Guid>(
                name: "user_id",
                table: "shifts",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");
                */
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "user_id",
                table: "shifts",
                type: "integer",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid");
        }
    }
}
