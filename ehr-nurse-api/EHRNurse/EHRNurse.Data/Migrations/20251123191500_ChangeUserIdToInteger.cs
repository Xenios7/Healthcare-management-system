using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EHRNurse.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangeUserIdToInteger : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
    ALTER TABLE shifts 
    ALTER COLUMN user_id TYPE integer 
    USING user_id::integer;
");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
           migrationBuilder.Sql(@"
                ALTER TABLE shifts 
                ALTER COLUMN user_id TYPE text 
                USING user_id::text;
            ");
        }
    }
}
