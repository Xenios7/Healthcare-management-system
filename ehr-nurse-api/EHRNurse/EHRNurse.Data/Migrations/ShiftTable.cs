using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EHRNurse.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixShiftTableWithProperCasting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // First, check if the shifts table exists
            migrationBuilder.Sql(@"
                DO $$ 
                BEGIN
                    IF NOT EXISTS (SELECT FROM information_schema.tables WHERE table_name = 'shifts') THEN
                        -- Create the shifts table if it doesn't exist
                        CREATE TABLE shifts (
                            id SERIAL PRIMARY KEY,
                            user_id UUID NOT NULL,
                            clock_in_time TIMESTAMP WITHOUT TIME ZONE NOT NULL,
                            clock_out_time TIMESTAMP WITHOUT TIME ZONE,
                            CONSTRAINT fk_shifts_users FOREIGN KEY (user_id) REFERENCES ""AspNetUsers"" (""Id"") ON DELETE CASCADE
                        );
                        
                        CREATE INDEX ix_shifts_user_id ON shifts (user_id);
                        CREATE INDEX ix_shifts_user_id_clock_in_time ON shifts (user_id, clock_in_time);
                    ELSE
                        -- If table exists and user_id is not UUID, convert it
                        IF EXISTS (
                            SELECT 1 FROM information_schema.columns 
                            WHERE table_name = 'shifts' AND column_name = 'user_id' 
                            AND data_type != 'uuid'
                        ) THEN
                            -- Drop foreign key if it exists
                            ALTER TABLE shifts DROP CONSTRAINT IF EXISTS fk_shifts_users;
                            
                            -- Convert user_id to UUID
                            ALTER TABLE shifts ALTER COLUMN user_id SET DATA TYPE UUID USING user_id::UUID;
                            
                            -- Re-add foreign key
                            ALTER TABLE shifts ADD CONSTRAINT fk_shifts_users FOREIGN KEY (user_id) REFERENCES ""AspNetUsers"" (""Id"") ON DELETE CASCADE;
                        END IF;
                    END IF;
                END
                $$;
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "shifts");
        }
    }
}