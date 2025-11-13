using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EHRNurse.Data.Migrations
{
    /// <inheritdoc />
    public partial class BuildLocalDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "quest");

            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:PostgresExtension:pg_stat_statements", ",,");

            migrationBuilder.CreateTable(
                name: "allergy_categories",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    table = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_allergy_categories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "appointment_recurrent_type",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_appointment_recurrent_type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "appointment_status_type",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_appointment_status_type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "complication",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_complication", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "definitions",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    area = table.Column<string>(type: "text", nullable: false),
                    field_table = table.Column<string>(type: "text", nullable: false),
                    field_name = table.Column<string>(type: "text", nullable: false),
                    field_description = table.Column<string>(type: "text", nullable: false),
                    field_examples = table.Column<string>(type: "text", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_definitions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "diet_type",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(type: "text", nullable: false),
                    system = table.Column<string>(type: "text", nullable: false),
                    display = table.Column<string>(type: "text", nullable: false),
                    other_display = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_diet_type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "etiology",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_etiology", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "external_doctors_cyma",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user_id = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    surname = table.Column<string>(type: "text", nullable: false),
                    specialty1definition_id = table.Column<int>(type: "integer", nullable: true),
                    specialty2definition_id = table.Column<int>(type: "integer", nullable: true),
                    specialty3definition_id = table.Column<int>(type: "integer", nullable: true),
                    registration_number = table.Column<string>(type: "text", nullable: true),
                    mobile_phone = table.Column<string>(type: "text", nullable: true),
                    land_line_phone = table.Column<string>(type: "text", nullable: true),
                    address1 = table.Column<string>(type: "text", nullable: true),
                    address2 = table.Column<string>(type: "text", nullable: true),
                    postal_code = table.Column<string>(type: "text", nullable: true),
                    city = table.Column<string>(type: "text", nullable: true),
                    country = table.Column<string>(type: "text", nullable: true),
                    status_definition_id = table.Column<int>(type: "integer", nullable: true),
                    account_number = table.Column<string>(type: "text", nullable: true),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false),
                    gesy_number = table.Column<string>(type: "text", nullable: true),
                    social_insurance = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_external_doctors_cyma", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "food_type",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(type: "text", nullable: false),
                    system = table.Column<string>(type: "text", nullable: false),
                    display = table.Column<string>(type: "text", nullable: false),
                    other_display = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_food_type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "glasgow_eye_opening",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    response = table.Column<string>(type: "text", nullable: false),
                    score = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_glasgow_eye_opening", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "glasgow_motor_response",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    response = table.Column<string>(type: "text", nullable: false),
                    score = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_glasgow_motor_response", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "glasgow_verbal_response",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    response = table.Column<string>(type: "text", nullable: false),
                    score = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_glasgow_verbal_response", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "hysteroscopy_anatomical_position",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_hysteroscopy_anatomical_position", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "laboratory",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: true),
                    min_value = table.Column<double>(type: "double precision", nullable: false),
                    max_value = table.Column<double>(type: "double precision", nullable: false),
                    type = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_laboratory", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "laboratory_group",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_laboratory_group", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "locale",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_locale", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "master_categories",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: true),
                    category_code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_master_categories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "master_exam_titles",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_master_exam_titles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "medical_device_actions",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_medical_device_actions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "module",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    icon = table.Column<string>(type: "text", nullable: false),
                    path = table.Column<string>(type: "text", nullable: false),
                    order_by = table.Column<int>(type: "integer", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_module", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "packages",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    licence_number = table.Column<string>(type: "text", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_packages", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pdqv3patients",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    patient_id_extension = table.Column<string>(type: "text", nullable: true),
                    patient_id_root = table.Column<string>(type: "text", nullable: true),
                    given_name = table.Column<string>(type: "text", nullable: true),
                    family_name = table.Column<string>(type: "text", nullable: true),
                    gender_code = table.Column<string>(type: "text", nullable: true),
                    gender_display = table.Column<string>(type: "text", nullable: true),
                    birth_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    street_address = table.Column<string>(type: "text", nullable: true),
                    city = table.Column<string>(type: "text", nullable: true),
                    state = table.Column<string>(type: "text", nullable: true),
                    postal_code = table.Column<string>(type: "text", nullable: true),
                    country = table.Column<string>(type: "text", nullable: true),
                    provider_org_id_root = table.Column<string>(type: "text", nullable: true),
                    provider_org_name = table.Column<string>(type: "text", nullable: true),
                    provider_org_telecom = table.Column<string>(type: "text", nullable: true),
                    match_score = table.Column<int>(type: "integer", nullable: true),
                    source_system_id = table.Column<string>(type: "text", nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_pdqv3patients", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "permissions",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_permissions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pharm_activesubstances",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    active_substance = table.Column<string>(type: "character varying(24)", maxLength: 24, nullable: false),
                    description = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    quantity = table.Column<string>(type: "character varying(12)", maxLength: 12, nullable: false),
                    unit_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_pharm_activesubstances", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pharm_atcs",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    atc = table.Column<string>(type: "character varying(48)", maxLength: 48, nullable: false),
                    description = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_pharm_atcs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pharm_dose_form_mappings",
                columns: table => new
                {
                    df_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    pharm_dose_form = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    mvc_dose_form = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    status = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_pharm_dose_form_mappings", x => x.df_id);
                });

            migrationBuilder.CreateTable(
                name: "pharm_forms",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    description = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    strength = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_pharm_forms", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pharm_packagesizeunits",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    description = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    coding_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_pharm_packagesizeunits", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pharm_products",
                columns: table => new
                {
                    pk = table.Column<string>(type: "character varying(48)", maxLength: 48, nullable: false),
                    drugid = table.Column<string>(type: "character varying(48)", maxLength: 48, nullable: false),
                    packnr = table.Column<string>(type: "character varying(12)", maxLength: 12, nullable: false),
                    barcode = table.Column<string>(type: "character varying(96)", maxLength: 96, nullable: true),
                    product_name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    package_description = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    package_size = table.Column<string>(type: "character varying(24)", maxLength: 24, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_pharm_products", x => x.pk);
                });

            migrationBuilder.CreateTable(
                name: "pharm_quantityunits",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    quantity_unit = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    description = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_pharm_quantityunits", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pharm_routes",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    route = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true),
                    description = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_pharm_routes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "question_types",
                schema: "quest",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_question_types", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "questionnaire_templates",
                schema: "quest",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_questionnaire_templates", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "regions",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_regions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "respiratory_clinical_examination",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_respiratory_clinical_examination", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    order_by = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_roles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "self_report_medication_frequency",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_self_report_medication_frequency", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "self_report_pain_level",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    range = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_self_report_pain_level", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "self_report_symptom_lookup",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_self_report_symptom_lookup", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "self_report_time_of_day_lookup",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_self_report_time_of_day_lookup", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "smart_health_links",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    manifest = table.Column<string>(type: "text", nullable: false),
                    file_name = table.Column<string>(type: "text", nullable: false),
                    data = table.Column<string>(type: "text", nullable: false),
                    label = table.Column<string>(type: "text", nullable: false),
                    passcode = table.Column<string>(type: "text", nullable: false),
                    access_count = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    failed_access_count = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    link = table.Column<string>(type: "text", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    expiration_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    deleted_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_smart_health_links", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "status",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_status", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tenant",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tenant", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tracheostomy_consistency_of_tubes",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    value = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tracheostomy_consistency_of_tubes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tracheostomy_cuff_diameters",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    value = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tracheostomy_cuff_diameters", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tracheostomy_inner_diameters",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    value = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tracheostomy_inner_diameters", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tracheostomy_outer_diameters",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    value = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tracheostomy_outer_diameters", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tracheostomy_tube_inspection",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tracheostomy_tube_inspection", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tracheostomy_tube_lengths",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    value = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tracheostomy_tube_lengths", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tracheostomy_tube_types",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    type = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tracheostomy_tube_types", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "translations",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    default_label = table.Column<string>(type: "text", nullable: false),
                    en = table.Column<string>(type: "text", nullable: false),
                    gr = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_translations", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "translations",
                schema: "quest",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    en = table.Column<string>(type: "text", nullable: false),
                    gr = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_translations", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    username = table.Column<string>(type: "text", nullable: false),
                    first_name = table.Column<string>(type: "text", nullable: false),
                    last_name = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    phone_number = table.Column<string>(type: "text", nullable: true),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    locale = table.Column<string>(type: "text", nullable: false),
                    required_actions = table.Column<bool>(type: "boolean", nullable: true),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "value_set",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_value_set", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "appointment_status",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(type: "text", nullable: false),
                    display = table.Column<string>(type: "text", nullable: false),
                    definition = table.Column<string>(type: "text", nullable: false),
                    appointment_status_type_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_appointment_status", x => x.id);
                    table.ForeignKey(
                        name: "fk_appointment_status_appointment_status_type_appointment_stat",
                        column: x => x.appointment_status_type_id,
                        principalTable: "appointment_status_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hysteroscopy_anatomical_sub_position",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: true),
                    anatomical_position_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_hysteroscopy_anatomical_sub_position", x => x.id);
                    table.ForeignKey(
                        name: "fk_hysteroscopy_anatomical_sub_position_hysteroscopy_anatomica",
                        column: x => x.anatomical_position_id,
                        principalTable: "hysteroscopy_anatomical_position",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "laboratory_group_laboratory",
                columns: table => new
                {
                    laboratory_id = table.Column<int>(type: "integer", nullable: false),
                    laboratory_group_id = table.Column<int>(type: "integer", nullable: false),
                    is_required = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_laboratory_group_laboratory", x => new { x.laboratory_id, x.laboratory_group_id });
                    table.ForeignKey(
                        name: "fk_laboratory_group_laboratory_laboratory_group_laboratory_gro",
                        column: x => x.laboratory_group_id,
                        principalTable: "laboratory_group",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_laboratory_group_laboratory_laboratory_laboratory_id",
                        column: x => x.laboratory_id,
                        principalTable: "laboratory",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "master_category_modalities",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    category_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_master_category_modalities", x => x.id);
                    table.ForeignKey(
                        name: "fk_master_category_modalities_master_categories_category_id",
                        column: x => x.category_id,
                        principalTable: "master_categories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "module_relationships",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    parent_module_id = table.Column<int>(type: "integer", nullable: false),
                    child_module_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_module_relationships", x => x.id);
                    table.ForeignKey(
                        name: "fk_module_relationships_module_child_module_id",
                        column: x => x.child_module_id,
                        principalTable: "module",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_module_relationships_module_parent_module_id",
                        column: x => x.parent_module_id,
                        principalTable: "module",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "package_modules",
                columns: table => new
                {
                    package_id = table.Column<int>(type: "integer", nullable: false),
                    module_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_package_modules", x => new { x.package_id, x.module_id });
                    table.ForeignKey(
                        name: "fk_package_modules_module_module_id",
                        column: x => x.module_id,
                        principalTable: "module",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_package_modules_packages_package_id",
                        column: x => x.package_id,
                        principalTable: "packages",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pdqv3patient_identifiers",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    identifier_root = table.Column<string>(type: "text", nullable: true),
                    identifier_extension = table.Column<string>(type: "text", nullable: true),
                    pdqv3patients_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_pdqv3patient_identifiers", x => x.id);
                    table.ForeignKey(
                        name: "fk_pdqv3patient_identifiers_pdqv3patients_pdqv3patients_id",
                        column: x => x.pdqv3patients_id,
                        principalTable: "pdqv3patients",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "pharm_activesubstancelists",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    drugid = table.Column<string>(type: "character varying(24)", maxLength: 24, nullable: false),
                    pharm_activesubstance_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_pharm_activesubstancelists", x => x.id);
                    table.ForeignKey(
                        name: "fk_pharm_activesubstancelists_pharm_activesubstances_pharm_act",
                        column: x => x.pharm_activesubstance_id,
                        principalTable: "pharm_activesubstances",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pharm_atclists",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    drugid = table.Column<string>(type: "character varying(24)", maxLength: 24, nullable: false),
                    pharm_atc_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_pharm_atclists", x => x.id);
                    table.ForeignKey(
                        name: "fk_pharm_atclists_pharm_atcs_pharm_atc_id",
                        column: x => x.pharm_atc_id,
                        principalTable: "pharm_atcs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pharm_formlists",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    drugid = table.Column<string>(type: "character varying(24)", maxLength: 24, nullable: false),
                    pharm_form_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_pharm_formlists", x => x.id);
                    table.ForeignKey(
                        name: "fk_pharm_formlists_pharm_forms_pharm_form_id",
                        column: x => x.pharm_form_id,
                        principalTable: "pharm_forms",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pharm_packagesizeunitlists",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    drugid = table.Column<string>(type: "character varying(24)", maxLength: 24, nullable: false),
                    pharm_packagesizeunit_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_pharm_packagesizeunitlists", x => x.id);
                    table.ForeignKey(
                        name: "fk_pharm_packagesizeunitlists_pharm_packagesizeunits_pharm_pac",
                        column: x => x.pharm_packagesizeunit_id,
                        principalTable: "pharm_packagesizeunits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pharm_routelists",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    drugid = table.Column<string>(type: "character varying(24)", maxLength: 24, nullable: false),
                    pharm_route_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_pharm_routelists", x => x.id);
                    table.ForeignKey(
                        name: "fk_pharm_routelists_pharm_routes_pharm_route_id",
                        column: x => x.pharm_route_id,
                        principalTable: "pharm_routes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "answer_questionnaires",
                schema: "quest",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    questionnaire_template_id = table.Column<int>(type: "integer", nullable: false),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    created_date_utc = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_time_utc = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_answer_questionnaires", x => x.id);
                    table.ForeignKey(
                        name: "fk_answer_questionnaires_questionnaire_templates_questionnaire",
                        column: x => x.questionnaire_template_id,
                        principalSchema: "quest",
                        principalTable: "questionnaire_templates",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "module_roles",
                columns: table => new
                {
                    role_id = table.Column<Guid>(type: "uuid", nullable: false),
                    module_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_module_roles", x => new { x.role_id, x.module_id });
                    table.ForeignKey(
                        name: "fk_module_roles_module_module_id",
                        column: x => x.module_id,
                        principalTable: "module",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_module_roles_roles_role_id",
                        column: x => x.role_id,
                        principalTable: "roles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "role_permissions",
                columns: table => new
                {
                    role_id = table.Column<Guid>(type: "uuid", nullable: false),
                    permission_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_role_permissions", x => new { x.role_id, x.permission_id });
                    table.ForeignKey(
                        name: "fk_role_permissions_permissions_permission_id",
                        column: x => x.permission_id,
                        principalTable: "permissions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_role_permissions_roles_role_id",
                        column: x => x.role_id,
                        principalTable: "roles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "laboratory_group_tenant",
                columns: table => new
                {
                    laboratory_group_id = table.Column<int>(type: "integer", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_laboratory_group_tenant", x => new { x.laboratory_group_id, x.tenant_id });
                    table.ForeignKey(
                        name: "fk_laboratory_group_tenant_laboratory_group_laboratory_group_id",
                        column: x => x.laboratory_group_id,
                        principalTable: "laboratory_group",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_laboratory_group_tenant_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tenant_packages",
                columns: table => new
                {
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    package_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tenant_packages", x => new { x.tenant_id, x.package_id });
                    table.ForeignKey(
                        name: "fk_tenant_packages_packages_package_id",
                        column: x => x.package_id,
                        principalTable: "packages",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_tenant_packages_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "admission_reasons",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    translation_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_admission_reasons", x => x.id);
                    table.ForeignKey(
                        name: "fk_admission_reasons_translations_translation_id",
                        column: x => x.translation_id,
                        principalTable: "translations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "discharge_situations",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    translation_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_discharge_situations", x => x.id);
                    table.ForeignKey(
                        name: "fk_discharge_situations_translations_translation_id",
                        column: x => x.translation_id,
                        principalTable: "translations",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "discharge_types",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    translation_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_discharge_types", x => x.id);
                    table.ForeignKey(
                        name: "fk_discharge_types_translations_translation_id",
                        column: x => x.translation_id,
                        principalTable: "translations",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "document_types",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    translation_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_document_types", x => x.id);
                    table.ForeignKey(
                        name: "fk_document_types_translations_translation_id",
                        column: x => x.translation_id,
                        principalTable: "translations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "external_doctor_specialties",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(type: "text", nullable: false, defaultValueSql: "''::text"),
                    description = table.Column<string>(type: "text", nullable: false, defaultValueSql: "''::text"),
                    group_head = table.Column<string>(type: "text", nullable: false, defaultValueSql: "''::text"),
                    translation_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_external_doctor_specialties", x => x.id);
                    table.ForeignKey(
                        name: "fk_external_doctor_specialties_translations_translation_id",
                        column: x => x.translation_id,
                        principalTable: "translations",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "patient_closest_relatives",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    translation_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_patient_closest_relatives", x => x.id);
                    table.ForeignKey(
                        name: "fk_patient_closest_relatives_translations_translation_id",
                        column: x => x.translation_id,
                        principalTable: "translations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "patient_education_level",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    translation_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_patient_education_level", x => x.id);
                    table.ForeignKey(
                        name: "fk_patient_education_level_translations_translation_id",
                        column: x => x.translation_id,
                        principalTable: "translations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "patient_family_status",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    translation_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_patient_family_status", x => x.id);
                    table.ForeignKey(
                        name: "fk_patient_family_status_translations_translation_id",
                        column: x => x.translation_id,
                        principalTable: "translations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "patient_file_type",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    translation_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_patient_file_type", x => x.id);
                    table.ForeignKey(
                        name: "fk_patient_file_type_translations_translation_id",
                        column: x => x.translation_id,
                        principalTable: "translations",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "patient_immobility_status",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    translation_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_patient_immobility_status", x => x.id);
                    table.ForeignKey(
                        name: "fk_patient_immobility_status_translations_translation_id",
                        column: x => x.translation_id,
                        principalTable: "translations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "patient_registration_status",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    translation_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_patient_registration_status", x => x.id);
                    table.ForeignKey(
                        name: "fk_patient_registration_status_translations_translation_id",
                        column: x => x.translation_id,
                        principalTable: "translations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "patient_rejection_reasons",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    translation_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_patient_rejection_reasons", x => x.id);
                    table.ForeignKey(
                        name: "fk_patient_rejection_reasons_translations_translation_id",
                        column: x => x.translation_id,
                        principalTable: "translations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "patient_religion",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    translation_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_patient_religion", x => x.id);
                    table.ForeignKey(
                        name: "fk_patient_religion_translations_translation_id",
                        column: x => x.translation_id,
                        principalTable: "translations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "patient_source_of_income",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    translation_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_patient_source_of_income", x => x.id);
                    table.ForeignKey(
                        name: "fk_patient_source_of_income_translations_translation_id",
                        column: x => x.translation_id,
                        principalTable: "translations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "question_pages",
                schema: "quest",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title_translation_id = table.Column<int>(type: "integer", nullable: false),
                    number = table.Column<int>(type: "integer", nullable: false),
                    description = table.Column<string>(type: "text", nullable: true),
                    questionnaire_template_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_question_pages", x => x.id);
                    table.ForeignKey(
                        name: "fk_question_pages_questionnaire_templates_questionnaire_templa",
                        column: x => x.questionnaire_template_id,
                        principalSchema: "quest",
                        principalTable: "questionnaire_templates",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_question_pages_translations_title_translation_id",
                        column: x => x.title_translation_id,
                        principalSchema: "quest",
                        principalTable: "translations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "accommodation_buildings",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    translation_id = table.Column<int>(type: "integer", nullable: true),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_accommodation_buildings", x => x.id);
                    table.ForeignKey(
                        name: "fk_accommodation_buildings_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_accommodation_buildings_translations_translation_id",
                        column: x => x.translation_id,
                        principalTable: "translations",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_accommodation_buildings_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: true),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_departments", x => x.id);
                    table.ForeignKey(
                        name: "fk_departments_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "user_permissions",
                columns: table => new
                {
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    permission_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_user_permissions", x => new { x.user_id, x.permission_id });
                    table.ForeignKey(
                        name: "fk_user_permissions_permissions_permission_id",
                        column: x => x.permission_id,
                        principalTable: "permissions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_user_permissions_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "user_roles",
                columns: table => new
                {
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    role_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_user_roles", x => new { x.user_id, x.role_id });
                    table.ForeignKey(
                        name: "fk_user_roles_roles_role_id",
                        column: x => x.role_id,
                        principalTable: "roles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_user_roles_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_absent_or_unknown_allergy",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_absent_or_unknown_allergy", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_absent_or_unknown_allergy_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_absent_or_unknown_device",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_absent_or_unknown_device", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_absent_or_unknown_device_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_absent_or_unknown_medication",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_absent_or_unknown_medication", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_absent_or_unknown_medication_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_absent_or_unknown_problem",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_absent_or_unknown_problem", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_absent_or_unknown_problem_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_absent_or_unknown_procedure",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_absent_or_unknown_procedure", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_absent_or_unknown_procedure_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_active_ingredient",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_active_ingredient", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_active_ingredient_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_administrative_gender",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false),
                    translation_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_administrative_gender", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_administrative_gender_translations_translation_id",
                        column: x => x.translation_id,
                        principalTable: "translations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_ehdsi_administrative_gender_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_adverse_event_type",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_adverse_event_type", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_adverse_event_type_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_allergen_no_drug",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_allergen_no_drug", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_allergen_no_drug_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_allergies_custom",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    allergy_category_id = table.Column<int>(type: "integer", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_allergies_custom", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_allergies_custom_allergy_categories_allergy_category_",
                        column: x => x.allergy_category_id,
                        principalTable: "allergy_categories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_ehdsi_allergies_custom_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_allergy_certainty",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_allergy_certainty", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_allergy_certainty_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_allergy_status",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_allergy_status", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_allergy_status_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_blood_group",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false),
                    translation_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_blood_group", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_blood_group_translations_translation_id",
                        column: x => x.translation_id,
                        principalTable: "translations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_ehdsi_blood_group_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_blood_pressure",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_blood_pressure", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_blood_pressure_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_certainty",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_certainty", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_certainty_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_code_prob",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_code_prob", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_code_prob_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_confidentiality",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_confidentiality", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_confidentiality_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_country",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_country", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_country_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_criticality",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_criticality", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_criticality_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_current_pregnancy_status",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_current_pregnancy_status", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_current_pregnancy_status_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_display_label",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_display_label", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_display_label_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_document_code",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_document_code", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_document_code_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_dose_form",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_dose_form", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_dose_form_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_healthcare_professional_role",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_healthcare_professional_role", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_healthcare_professional_role_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_hospital_discharge_report_type",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_hospital_discharge_report_type", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_hospital_discharge_report_type_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_illnessand_disorder",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_illnessand_disorder", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_illnessand_disorder_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_laboratory_report_type",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_laboratory_report_type", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_laboratory_report_type_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_language",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_language", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_language_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_medical_device",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_medical_device", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_medical_device_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_medical_images_type",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_medical_images_type", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_medical_images_type_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_medical_imaging_report_type",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_medical_imaging_report_type", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_medical_imaging_report_type_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_null_flavor",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_null_flavor", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_null_flavor_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_outcome_of_pregnancy",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_outcome_of_pregnancy", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_outcome_of_pregnancy_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_package",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_package", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_package_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_personal_relationship",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_personal_relationship", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_personal_relationship_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_pregnancy_information",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_pregnancy_information", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_pregnancy_information_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_procedure",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_procedure", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_procedure_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_quantity_unit",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_quantity_unit", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_quantity_unit_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_rare_disease",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_rare_disease", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_rare_disease_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_reaction_allergy",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_reaction_allergy", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_reaction_allergy_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_resolution_outcome",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_resolution_outcome", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_resolution_outcome_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_role_class",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_role_class", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_role_class_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_routeof_administration",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_routeof_administration", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_routeof_administration_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_section",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_section", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_section_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_severity",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_severity", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_severity_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_social_history",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_social_history", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_social_history_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_status_code",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_status_code", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_status_code_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_substance",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_substance", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_substance_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_substitution_code",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_substitution_code", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_substitution_code_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_telecom_address",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_telecom_address", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_telecom_address_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_timing_event",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_timing_event", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_timing_event_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_unit",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_unit", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_unit_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ehdsi_vaccine",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code_system_id = table.Column<string>(type: "text", nullable: false),
                    code_system_version = table.Column<string>(type: "text", nullable: false),
                    concept_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    value_set_id = table.Column<string>(type: "text", nullable: false),
                    mvc_version = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ehdsi_vaccine", x => x.id);
                    table.ForeignKey(
                        name: "fk_ehdsi_vaccine_value_set_value_set_id",
                        column: x => x.value_set_id,
                        principalTable: "value_set",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "appointment_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    appointment_status_id = table.Column<int>(type: "integer", nullable: false),
                    description = table.Column<string>(type: "text", nullable: true),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    recurrent_type_id = table.Column<int>(type: "integer", nullable: false),
                    recurrence_occurrences = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_appointment_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_appointment_data_appointment_recurrent_type_recurrent_type_",
                        column: x => x.recurrent_type_id,
                        principalTable: "appointment_recurrent_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_appointment_data_appointment_status_appointment_status_id",
                        column: x => x.appointment_status_id,
                        principalTable: "appointment_status",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_appointment_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_appointment_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "admission_reason_tenants",
                columns: table => new
                {
                    admission_reason_id = table.Column<int>(type: "integer", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_admission_reason_tenants", x => new { x.admission_reason_id, x.tenant_id });
                    table.ForeignKey(
                        name: "fk_admission_reason_tenants_admission_reasons_admission_reason",
                        column: x => x.admission_reason_id,
                        principalTable: "admission_reasons",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_admission_reason_tenants_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "patient_rejection_reason_tenant",
                columns: table => new
                {
                    rejection_reason_id = table.Column<int>(type: "integer", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_patient_rejection_reason_tenant", x => new { x.rejection_reason_id, x.tenant_id });
                    table.ForeignKey(
                        name: "fk_patient_rejection_reason_tenant_patient_rejection_reasons_r",
                        column: x => x.rejection_reason_id,
                        principalTable: "patient_rejection_reasons",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_patient_rejection_reason_tenant_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "question_templates",
                schema: "quest",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title_translation_id = table.Column<int>(type: "integer", nullable: false),
                    description_translation_id = table.Column<int>(type: "integer", nullable: true),
                    order = table.Column<int>(type: "integer", nullable: false),
                    questionnaire_template_id = table.Column<int>(type: "integer", nullable: false),
                    question_page_id = table.Column<int>(type: "integer", nullable: false),
                    question_type_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_question_templates", x => x.id);
                    table.ForeignKey(
                        name: "fk_question_templates_question_pages_question_page_id",
                        column: x => x.question_page_id,
                        principalSchema: "quest",
                        principalTable: "question_pages",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_question_templates_question_types_question_type_id",
                        column: x => x.question_type_id,
                        principalSchema: "quest",
                        principalTable: "question_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_question_templates_questionnaire_templates_questionnaire_te",
                        column: x => x.questionnaire_template_id,
                        principalSchema: "quest",
                        principalTable: "questionnaire_templates",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_question_templates_translations_description_translation_id",
                        column: x => x.description_translation_id,
                        principalSchema: "quest",
                        principalTable: "translations",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_question_templates_translations_title_translation_id",
                        column: x => x.title_translation_id,
                        principalSchema: "quest",
                        principalTable: "translations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "accommodation_floors",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    number = table.Column<int>(type: "integer", nullable: false),
                    building_id = table.Column<int>(type: "integer", nullable: false),
                    translation_id = table.Column<int>(type: "integer", nullable: true),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_accommodation_floors", x => x.id);
                    table.ForeignKey(
                        name: "fk_accommodation_floors_accommodation_buildings_building_id",
                        column: x => x.building_id,
                        principalTable: "accommodation_buildings",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_accommodation_floors_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_accommodation_floors_translations_translation_id",
                        column: x => x.translation_id,
                        principalTable: "translations",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_accommodation_floors_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tenant_departments",
                columns: table => new
                {
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    department_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tenant_departments", x => new { x.tenant_id, x.department_id });
                    table.ForeignKey(
                        name: "fk_tenant_departments_departments_department_id",
                        column: x => x.department_id,
                        principalTable: "departments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_tenant_departments_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "address_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    street = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    town = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    post_code = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    district = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    country_id = table.Column<int>(type: "integer", nullable: true),
                    street_number = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    apartment_number = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_address_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_address_data_ehdsi_country_country_id",
                        column: x => x.country_id,
                        principalTable: "ehdsi_country",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "addresses",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    street = table.Column<string>(type: "text", nullable: false),
                    town = table.Column<string>(type: "text", nullable: false),
                    post_code = table.Column<string>(type: "text", nullable: false),
                    district = table.Column<string>(type: "text", nullable: false),
                    country_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_addresses", x => x.id);
                    table.ForeignKey(
                        name: "fk_addresses_ehdsi_country_country_id",
                        column: x => x.country_id,
                        principalTable: "ehdsi_country",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "patient_insurance",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    country_id = table.Column<int>(type: "integer", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_patient_insurance", x => x.id);
                    table.ForeignKey(
                        name: "fk_patient_insurance_ehdsi_country_country_id",
                        column: x => x.country_id,
                        principalTable: "ehdsi_country",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "master_timing_unit",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    description = table.Column<string>(type: "text", nullable: false),
                    unit_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_master_timing_unit", x => x.id);
                    table.ForeignKey(
                        name: "fk_master_timing_unit_ehdsi_unit_unit_id",
                        column: x => x.unit_id,
                        principalTable: "ehdsi_unit",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "appointment_slot_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    slot_status_id = table.Column<int>(type: "integer", nullable: false),
                    start = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    end = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    overbooked = table.Column<bool>(type: "boolean", nullable: false),
                    comment = table.Column<string>(type: "text", nullable: true),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    appointment_data_id = table.Column<int>(type: "integer", nullable: false),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_appointment_slot_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_appointment_slot_data_appointment_data_appointment_data_id",
                        column: x => x.appointment_data_id,
                        principalTable: "appointment_data",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_appointment_slot_data_appointment_status_slot_status_id",
                        column: x => x.slot_status_id,
                        principalTable: "appointment_status",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_appointment_slot_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "answer",
                schema: "quest",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    value = table.Column<string>(type: "text", nullable: true),
                    question_template_id = table.Column<int>(type: "integer", nullable: false),
                    answer_questionnaire_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_answer", x => x.id);
                    table.ForeignKey(
                        name: "fk_answer_answer_questionnaires_answer_questionnaire_id",
                        column: x => x.answer_questionnaire_id,
                        principalSchema: "quest",
                        principalTable: "answer_questionnaires",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_answer_question_templates_question_template_id",
                        column: x => x.question_template_id,
                        principalSchema: "quest",
                        principalTable: "question_templates",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "question_template_values",
                schema: "quest",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    question_template_id = table.Column<int>(type: "integer", nullable: false),
                    translation_id = table.Column<int>(type: "integer", nullable: false),
                    order_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_question_template_values", x => x.id);
                    table.ForeignKey(
                        name: "fk_question_template_values_question_templates_question_templa",
                        column: x => x.question_template_id,
                        principalSchema: "quest",
                        principalTable: "question_templates",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_question_template_values_translations_translation_id",
                        column: x => x.translation_id,
                        principalSchema: "quest",
                        principalTable: "translations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "accommodation_wards",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    floor_id = table.Column<int>(type: "integer", nullable: false),
                    translation_id = table.Column<int>(type: "integer", nullable: true),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_accommodation_wards", x => x.id);
                    table.ForeignKey(
                        name: "fk_accommodation_wards_accommodation_floors_floor_id",
                        column: x => x.floor_id,
                        principalTable: "accommodation_floors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_accommodation_wards_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_accommodation_wards_translations_translation_id",
                        column: x => x.translation_id,
                        principalTable: "translations",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_accommodation_wards_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "external_doctors",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    first_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    last_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    phone_number = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    home_number = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    registration_number = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    email = table.Column<string>(type: "text", nullable: true),
                    address_data_id = table.Column<int>(type: "integer", nullable: true),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_external_doctors", x => x.id);
                    table.ForeignKey(
                        name: "fk_external_doctors_address_data_address_data_id",
                        column: x => x.address_data_id,
                        principalTable: "address_data",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_external_doctors_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "patients",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    first_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    last_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    date_of_birth = table.Column<DateOnly>(type: "date", nullable: false),
                    height = table.Column<double>(type: "double precision", nullable: true),
                    phone = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    email = table.Column<string>(type: "text", nullable: false),
                    gender_id = table.Column<int>(type: "integer", nullable: false),
                    blood_type_id = table.Column<int>(type: "integer", nullable: true),
                    registration_status_id = table.Column<int>(type: "integer", nullable: false),
                    date_of_admission = table.Column<DateOnly>(type: "date", nullable: true),
                    occupation = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    amount_of_income = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    place_of_birth_district = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    place_of_birth_id = table.Column<int>(type: "integer", nullable: true),
                    closest_relatives_id = table.Column<int>(type: "integer", nullable: true),
                    education_level_id = table.Column<int>(type: "integer", nullable: true),
                    family_status_id = table.Column<int>(type: "integer", nullable: true),
                    religion_id = table.Column<int>(type: "integer", nullable: true),
                    closest_relatives_other = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    education_level_other = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    family_status_other = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    religion_other = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    source_of_income_id = table.Column<int>(type: "integer", nullable: true),
                    registration_agent_id = table.Column<Guid>(type: "uuid", nullable: true),
                    moh = table.Column<bool>(type: "boolean", nullable: true),
                    address_data_id = table.Column<int>(type: "integer", nullable: true),
                    picture_path = table.Column<string>(type: "text", nullable: true),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false),
                    immobility_status_id = table.Column<int>(type: "integer", nullable: true),
                    is_imported = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_patients", x => x.id);
                    table.ForeignKey(
                        name: "fk_patients_address_data_address_data_id",
                        column: x => x.address_data_id,
                        principalTable: "address_data",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_patients_ehdsi_administrative_gender_gender_id",
                        column: x => x.gender_id,
                        principalTable: "ehdsi_administrative_gender",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_patients_ehdsi_blood_group_blood_type_id",
                        column: x => x.blood_type_id,
                        principalTable: "ehdsi_blood_group",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_patients_ehdsi_country_place_of_birth_id",
                        column: x => x.place_of_birth_id,
                        principalTable: "ehdsi_country",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_patients_patient_closest_relatives_closest_relatives_id",
                        column: x => x.closest_relatives_id,
                        principalTable: "patient_closest_relatives",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_patients_patient_education_level_education_level_id",
                        column: x => x.education_level_id,
                        principalTable: "patient_education_level",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_patients_patient_family_status_family_status_id",
                        column: x => x.family_status_id,
                        principalTable: "patient_family_status",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_patients_patient_immobility_status_immobility_status_id",
                        column: x => x.immobility_status_id,
                        principalTable: "patient_immobility_status",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_patients_patient_registration_status_registration_status_id",
                        column: x => x.registration_status_id,
                        principalTable: "patient_registration_status",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_patients_patient_religion_religion_id",
                        column: x => x.religion_id,
                        principalTable: "patient_religion",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_patients_patient_source_of_income_source_of_income_id",
                        column: x => x.source_of_income_id,
                        principalTable: "patient_source_of_income",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_patients_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_patients_users_registration_agent_id",
                        column: x => x.registration_agent_id,
                        principalTable: "users",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_patients_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tenant_settings",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    company_name = table.Column<string>(type: "text", nullable: false),
                    company_email = table.Column<string>(type: "text", nullable: true),
                    address_data_id = table.Column<int>(type: "integer", nullable: false),
                    phone = table.Column<string>(type: "text", nullable: true),
                    logo_path = table.Column<string>(type: "text", nullable: true),
                    invoice_logo_path = table.Column<string>(type: "text", nullable: true),
                    fav_icon_path = table.Column<string>(type: "text", nullable: true),
                    is_pilot_study = table.Column<bool>(type: "boolean", nullable: false),
                    include_app_patient = table.Column<bool>(type: "boolean", nullable: false),
                    include_pre_registration = table.Column<bool>(type: "boolean", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    user_id = table.Column<Guid>(type: "uuid", nullable: true),
                    max_user_limit = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tenant_settings", x => x.id);
                    table.ForeignKey(
                        name: "fk_tenant_settings_address_data_address_data_id",
                        column: x => x.address_data_id,
                        principalTable: "address_data",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_tenant_settings_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_tenant_settings_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "accommodation_rooms",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    ward_id = table.Column<int>(type: "integer", nullable: false),
                    translation_id = table.Column<int>(type: "integer", nullable: true),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_accommodation_rooms", x => x.id);
                    table.ForeignKey(
                        name: "fk_accommodation_rooms_accommodation_wards_ward_id",
                        column: x => x.ward_id,
                        principalTable: "accommodation_wards",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_accommodation_rooms_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_accommodation_rooms_translations_translation_id",
                        column: x => x.translation_id,
                        principalTable: "translations",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_accommodation_rooms_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "external_doctors_specialties_link",
                columns: table => new
                {
                    external_doctor_id = table.Column<int>(type: "integer", nullable: false),
                    external_doctor_specialty_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_external_doctors_specialties_link", x => new { x.external_doctor_id, x.external_doctor_specialty_id });
                    table.ForeignKey(
                        name: "fk_external_doctors_specialties_link_external_doctor_specialti",
                        column: x => x.external_doctor_specialty_id,
                        principalTable: "external_doctor_specialties",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_external_doctors_specialties_link_external_doctors_external",
                        column: x => x.external_doctor_id,
                        principalTable: "external_doctors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "appointment_participant_actor_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    reference = table.Column<string>(type: "text", nullable: false),
                    display = table.Column<string>(type: "text", nullable: false),
                    patient_id = table.Column<int>(type: "integer", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_appointment_participant_actor_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_appointment_participant_actor_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_appointment_participant_actor_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "appointment_patient_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    comments = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: true),
                    start_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    is_rejected = table.Column<bool>(type: "boolean", nullable: false),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    doctor_id = table.Column<Guid>(type: "uuid", nullable: true),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    appointment_status_id = table.Column<int>(type: "integer", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_appointment_patient_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_appointment_patient_data_appointment_status_appointment_sta",
                        column: x => x.appointment_status_id,
                        principalTable: "appointment_status",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_appointment_patient_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_appointment_patient_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_appointment_patient_data_users_doctor_id",
                        column: x => x.doctor_id,
                        principalTable: "users",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_appointment_patient_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "episode_cares",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    potential_diagnosis_id = table.Column<int>(type: "integer", nullable: true),
                    status_id = table.Column<int>(type: "integer", nullable: false),
                    is_hospitalized = table.Column<bool>(type: "boolean", nullable: false),
                    activation_date = table.Column<DateOnly>(type: "date", nullable: false),
                    end_date = table.Column<DateOnly>(type: "date", nullable: true),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_episode_cares", x => x.id);
                    table.ForeignKey(
                        name: "fk_episode_cares_ehdsi_illnessand_disorder_potential_diagnosis",
                        column: x => x.potential_diagnosis_id,
                        principalTable: "ehdsi_illnessand_disorder",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_episode_cares_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_episode_cares_status_status_id",
                        column: x => x.status_id,
                        principalTable: "status",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_episode_cares_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_episode_cares_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ips_cda_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    path = table.Column<string>(type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ips_cda_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_ips_cda_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_ips_cda_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_ips_cda_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "patient_doctors",
                columns: table => new
                {
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    doctor_id = table.Column<Guid>(type: "uuid", nullable: false),
                    primary_doctor = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_patient_doctors", x => new { x.patient_id, x.doctor_id });
                    table.ForeignKey(
                        name: "fk_patient_doctors_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_patient_doctors_users_doctor_id",
                        column: x => x.doctor_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "patient_documents_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    document_type_id = table.Column<int>(type: "integer", nullable: false),
                    document_number = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    document_country_issued_id = table.Column<int>(type: "integer", nullable: false),
                    patient_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_patient_documents_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_patient_documents_data_document_types_document_type_id",
                        column: x => x.document_type_id,
                        principalTable: "document_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_patient_documents_data_ehdsi_country_document_country_issue",
                        column: x => x.document_country_issued_id,
                        principalTable: "ehdsi_country",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_patient_documents_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "patient_emergency_contacts_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    document_type_id = table.Column<int>(type: "integer", nullable: true),
                    document_number = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    document_country_issued_id = table.Column<int>(type: "integer", nullable: true),
                    first_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    last_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    occupation = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    phone_number = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    email = table.Column<string>(type: "text", nullable: true),
                    closest_relative_id = table.Column<int>(type: "integer", nullable: true),
                    closest_relative_other = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    address_data_id = table.Column<int>(type: "integer", nullable: true),
                    patient_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_patient_emergency_contacts_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_patient_emergency_contacts_data_address_data_address_data_id",
                        column: x => x.address_data_id,
                        principalTable: "address_data",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_patient_emergency_contacts_data_document_types_document_typ",
                        column: x => x.document_type_id,
                        principalTable: "document_types",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_patient_emergency_contacts_data_ehdsi_country_document_coun",
                        column: x => x.document_country_issued_id,
                        principalTable: "ehdsi_country",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_patient_emergency_contacts_data_patient_closest_relatives_c",
                        column: x => x.closest_relative_id,
                        principalTable: "patient_closest_relatives",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_patient_emergency_contacts_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "patient_external_doctor_data",
                columns: table => new
                {
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    external_doctor_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_patient_external_doctor_data", x => new { x.patient_id, x.external_doctor_id });
                    table.ForeignKey(
                        name: "fk_patient_external_doctor_data_external_doctors_external_doct",
                        column: x => x.external_doctor_id,
                        principalTable: "external_doctors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_patient_external_doctor_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "patient_external_doctors_cyma_data",
                columns: table => new
                {
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    external_doctor_cyma_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_patient_external_doctors_cyma_data", x => new { x.patient_id, x.external_doctor_cyma_id });
                    table.ForeignKey(
                        name: "fk_patient_external_doctors_cyma_data_external_doctors_cyma_ex",
                        column: x => x.external_doctor_cyma_id,
                        principalTable: "external_doctors_cyma",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_patient_external_doctors_cyma_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "patient_files_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    file_type_id = table.Column<int>(type: "integer", nullable: false),
                    file_path = table.Column<string>(type: "text", nullable: false),
                    notes = table.Column<string>(type: "text", nullable: true),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_patient_files_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_patient_files_data_patient_file_type_file_type_id",
                        column: x => x.file_type_id,
                        principalTable: "patient_file_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_patient_files_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_patient_files_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_patient_files_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "patient_insurances_data",
                columns: table => new
                {
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    insurance_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_patient_insurances_data", x => new { x.patient_id, x.insurance_id });
                    table.ForeignKey(
                        name: "fk_patient_insurances_data_patient_insurance_insurance_id",
                        column: x => x.insurance_id,
                        principalTable: "patient_insurance",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_patient_insurances_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "patient_registration_history_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    registration_status_id = table.Column<int>(type: "integer", nullable: false),
                    notes = table.Column<string>(type: "text", nullable: true),
                    rejection_reason_id = table.Column<int>(type: "integer", nullable: true),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_patient_registration_history_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_patient_registration_history_data_patient_registration_stat",
                        column: x => x.registration_status_id,
                        principalTable: "patient_registration_status",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_patient_registration_history_data_patient_rejection_reasons",
                        column: x => x.rejection_reason_id,
                        principalTable: "patient_rejection_reasons",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_patient_registration_history_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_patient_registration_history_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_patient_registration_history_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "self_report_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    pain_level_id = table.Column<int>(type: "integer", nullable: false),
                    medication_frequency_id = table.Column<int>(type: "integer", nullable: false),
                    description = table.Column<string>(type: "text", nullable: true),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_self_report_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_self_report_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_self_report_data_self_report_medication_frequency_medicatio",
                        column: x => x.medication_frequency_id,
                        principalTable: "self_report_medication_frequency",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_self_report_data_self_report_pain_level_pain_level_id",
                        column: x => x.pain_level_id,
                        principalTable: "self_report_pain_level",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_self_report_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "accommodation_beds",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    number = table.Column<int>(type: "integer", nullable: false),
                    order_by = table.Column<int>(type: "integer", nullable: false),
                    is_available = table.Column<bool>(type: "boolean", nullable: false),
                    room_id = table.Column<int>(type: "integer", nullable: false),
                    translation_id = table.Column<int>(type: "integer", nullable: true),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_accommodation_beds", x => x.id);
                    table.ForeignKey(
                        name: "fk_accommodation_beds_accommodation_rooms_room_id",
                        column: x => x.room_id,
                        principalTable: "accommodation_rooms",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_accommodation_beds_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_accommodation_beds_translations_translation_id",
                        column: x => x.translation_id,
                        principalTable: "translations",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_accommodation_beds_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "appointment_participant_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    required = table.Column<bool>(type: "boolean", nullable: false),
                    participant_status_id = table.Column<int>(type: "integer", nullable: false),
                    actor_id = table.Column<int>(type: "integer", nullable: true),
                    appointment_data_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_appointment_participant_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_appointment_participant_data_appointment_data_appointment_d",
                        column: x => x.appointment_data_id,
                        principalTable: "appointment_data",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_appointment_participant_data_appointment_participant_actor_",
                        column: x => x.actor_id,
                        principalTable: "appointment_participant_actor_data",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_appointment_participant_data_appointment_status_participant",
                        column: x => x.participant_status_id,
                        principalTable: "appointment_status",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "discharge_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    discharge_type_id = table.Column<int>(type: "integer", nullable: false),
                    discharge_situation_id = table.Column<int>(type: "integer", nullable: false),
                    discharge_type_notes = table.Column<string>(type: "text", nullable: true),
                    discharge_situation_notes = table.Column<string>(type: "text", nullable: true),
                    episode_care_id = table.Column<int>(type: "integer", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_discharge_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_discharge_data_discharge_situations_discharge_situation_id",
                        column: x => x.discharge_situation_id,
                        principalTable: "discharge_situations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_discharge_data_discharge_types_discharge_type_id",
                        column: x => x.discharge_type_id,
                        principalTable: "discharge_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_discharge_data_episode_cares_episode_care_id",
                        column: x => x.episode_care_id,
                        principalTable: "episode_cares",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_discharge_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_discharge_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "visits",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    visit_date = table.Column<DateOnly>(type: "date", nullable: false),
                    potential_diagnosis_id = table.Column<int>(type: "integer", nullable: true),
                    notes = table.Column<string>(type: "text", nullable: true),
                    doctor_id = table.Column<Guid>(type: "uuid", nullable: false),
                    episode_care_id = table.Column<int>(type: "integer", nullable: false),
                    is_completed = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_visits", x => x.id);
                    table.ForeignKey(
                        name: "fk_visits_ehdsi_illnessand_disorder_potential_diagnosis_id",
                        column: x => x.potential_diagnosis_id,
                        principalTable: "ehdsi_illnessand_disorder",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_visits_episode_cares_episode_care_id",
                        column: x => x.episode_care_id,
                        principalTable: "episode_cares",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_visits_users_doctor_id",
                        column: x => x.doctor_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "self_report_body_part",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    self_report_data_id = table.Column<int>(type: "integer", nullable: false),
                    slug = table.Column<string>(type: "text", nullable: false),
                    area = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_self_report_body_part", x => x.id);
                    table.ForeignKey(
                        name: "fk_self_report_body_part_self_report_data_self_report_data_id",
                        column: x => x.self_report_data_id,
                        principalTable: "self_report_data",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "self_report_symptoms",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    self_report_data_id = table.Column<int>(type: "integer", nullable: false),
                    symptom_lookup_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_self_report_symptoms", x => x.id);
                    table.ForeignKey(
                        name: "fk_self_report_symptoms_self_report_data_self_report_data_id",
                        column: x => x.self_report_data_id,
                        principalTable: "self_report_data",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_self_report_symptoms_self_report_symptom_lookup_symptom_loo",
                        column: x => x.symptom_lookup_id,
                        principalTable: "self_report_symptom_lookup",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "self_report_time_of_day",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    self_report_data_id = table.Column<int>(type: "integer", nullable: false),
                    time_of_day_lookup_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_self_report_time_of_day", x => x.id);
                    table.ForeignKey(
                        name: "fk_self_report_time_of_day_self_report_data_self_report_data_id",
                        column: x => x.self_report_data_id,
                        principalTable: "self_report_data",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_self_report_time_of_day_self_report_time_of_day_lookup_time",
                        column: x => x.time_of_day_lookup_id,
                        principalTable: "self_report_time_of_day_lookup",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "accommodation_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    bed_id = table.Column<int>(type: "integer", nullable: true),
                    registration_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    discharge_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    admission_reason_id = table.Column<int>(type: "integer", nullable: false),
                    admission_notes = table.Column<string>(type: "text", nullable: true),
                    episode_care_id = table.Column<int>(type: "integer", nullable: true),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    move_bed_notes = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_accommodation_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_accommodation_data_accommodation_beds_bed_id",
                        column: x => x.bed_id,
                        principalTable: "accommodation_beds",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_accommodation_data_admission_reasons_admission_reason_id",
                        column: x => x.admission_reason_id,
                        principalTable: "admission_reasons",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_accommodation_data_episode_cares_episode_care_id",
                        column: x => x.episode_care_id,
                        principalTable: "episode_cares",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_accommodation_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_accommodation_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_accommodation_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "allergy_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    allergy_category_id = table.Column<int>(type: "integer", nullable: false),
                    allergy_id = table.Column<int>(type: "integer", nullable: false),
                    event_type_id = table.Column<int>(type: "integer", nullable: true),
                    criticality_id = table.Column<int>(type: "integer", nullable: true),
                    allergy_status_id = table.Column<int>(type: "integer", nullable: true),
                    resolution_date = table.Column<DateOnly>(type: "date", nullable: true),
                    description = table.Column<string>(type: "text", nullable: false),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    visit_id = table.Column<int>(type: "integer", nullable: false),
                    episode_care_id = table.Column<int>(type: "integer", nullable: false),
                    is_submitted = table.Column<bool>(type: "boolean", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_allergy_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_allergy_data_allergy_categories_allergy_category_id",
                        column: x => x.allergy_category_id,
                        principalTable: "allergy_categories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_allergy_data_ehdsi_adverse_event_type_event_type_id",
                        column: x => x.event_type_id,
                        principalTable: "ehdsi_adverse_event_type",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_allergy_data_ehdsi_allergies_custom_allergy_id",
                        column: x => x.allergy_id,
                        principalTable: "ehdsi_allergies_custom",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_allergy_data_ehdsi_allergy_status_allergy_status_id",
                        column: x => x.allergy_status_id,
                        principalTable: "ehdsi_allergy_status",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_allergy_data_ehdsi_criticality_criticality_id",
                        column: x => x.criticality_id,
                        principalTable: "ehdsi_criticality",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_allergy_data_episode_cares_episode_care_id",
                        column: x => x.episode_care_id,
                        principalTable: "episode_cares",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_allergy_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_allergy_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_allergy_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_allergy_data_visits_visit_id",
                        column: x => x.visit_id,
                        principalTable: "visits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "allergy_unknown_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    allergy_id = table.Column<int>(type: "integer", nullable: false),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    visit_id = table.Column<int>(type: "integer", nullable: false),
                    episode_care_id = table.Column<int>(type: "integer", nullable: false),
                    is_submitted = table.Column<bool>(type: "boolean", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_allergy_unknown_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_allergy_unknown_data_ehdsi_absent_or_unknown_allergy_allerg",
                        column: x => x.allergy_id,
                        principalTable: "ehdsi_absent_or_unknown_allergy",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_allergy_unknown_data_episode_cares_episode_care_id",
                        column: x => x.episode_care_id,
                        principalTable: "episode_cares",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_allergy_unknown_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_allergy_unknown_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_allergy_unknown_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_allergy_unknown_data_visits_visit_id",
                        column: x => x.visit_id,
                        principalTable: "visits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "arterial_blood_gas_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    on_set_date_time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ph = table.Column<float>(type: "real", nullable: false),
                    hco3 = table.Column<float>(type: "real", nullable: false),
                    paco2 = table.Column<float>(type: "real", nullable: false),
                    pao2 = table.Column<float>(type: "real", nullable: false),
                    sao2 = table.Column<float>(type: "real", nullable: false),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    visit_id = table.Column<int>(type: "integer", nullable: false),
                    episode_care_id = table.Column<int>(type: "integer", nullable: false),
                    is_submitted = table.Column<bool>(type: "boolean", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_arterial_blood_gas_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_arterial_blood_gas_data_episode_cares_episode_care_id",
                        column: x => x.episode_care_id,
                        principalTable: "episode_cares",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_arterial_blood_gas_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_arterial_blood_gas_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_arterial_blood_gas_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_arterial_blood_gas_data_visits_visit_id",
                        column: x => x.visit_id,
                        principalTable: "visits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "capnography_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    date = table.Column<DateOnly>(type: "date", nullable: false),
                    positive_end_expiratory_pressure = table.Column<double>(type: "double precision", nullable: false),
                    end_tidal = table.Column<double>(type: "double precision", nullable: false),
                    fraction_inhaled_oxygen = table.Column<double>(type: "double precision", nullable: false),
                    tidal_volume = table.Column<double>(type: "double precision", nullable: false),
                    respiratory_rate = table.Column<double>(type: "double precision", nullable: false),
                    pressure_inhaled_oxygen = table.Column<double>(type: "double precision", nullable: false),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    visit_id = table.Column<int>(type: "integer", nullable: false),
                    episode_care_id = table.Column<int>(type: "integer", nullable: false),
                    is_submitted = table.Column<bool>(type: "boolean", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_capnography_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_capnography_data_episode_cares_episode_care_id",
                        column: x => x.episode_care_id,
                        principalTable: "episode_cares",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_capnography_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_capnography_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_capnography_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_capnography_data_visits_visit_id",
                        column: x => x.visit_id,
                        principalTable: "visits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "care_plan_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    description = table.Column<string>(type: "text", nullable: false),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    visit_id = table.Column<int>(type: "integer", nullable: false),
                    episode_care_id = table.Column<int>(type: "integer", nullable: false),
                    is_submitted = table.Column<bool>(type: "boolean", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_care_plan_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_care_plan_data_episode_cares_episode_care_id",
                        column: x => x.episode_care_id,
                        principalTable: "episode_cares",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_care_plan_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_care_plan_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_care_plan_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_care_plan_data_visits_visit_id",
                        column: x => x.visit_id,
                        principalTable: "visits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "comorbidity_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    date = table.Column<DateOnly>(type: "date", nullable: false),
                    iqr = table.Column<double>(type: "double precision", nullable: false),
                    is_respiratory_disease = table.Column<bool>(type: "boolean", nullable: false),
                    is_hypertension = table.Column<bool>(type: "boolean", nullable: false),
                    is_copd = table.Column<bool>(type: "boolean", nullable: false),
                    is_heart_disease = table.Column<bool>(type: "boolean", nullable: false),
                    is_diabetes_mellitus = table.Column<bool>(type: "boolean", nullable: false),
                    is_malignancy = table.Column<bool>(type: "boolean", nullable: false),
                    is_stroke = table.Column<bool>(type: "boolean", nullable: false),
                    is_immunosuppression = table.Column<bool>(type: "boolean", nullable: false),
                    is_no_comorbidities = table.Column<bool>(type: "boolean", nullable: false),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    visit_id = table.Column<int>(type: "integer", nullable: false),
                    episode_care_id = table.Column<int>(type: "integer", nullable: false),
                    is_submitted = table.Column<bool>(type: "boolean", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_comorbidity_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_comorbidity_data_episode_cares_episode_care_id",
                        column: x => x.episode_care_id,
                        principalTable: "episode_cares",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_comorbidity_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_comorbidity_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_comorbidity_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_comorbidity_data_visits_visit_id",
                        column: x => x.visit_id,
                        principalTable: "visits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "complication_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    complication_id = table.Column<int>(type: "integer", nullable: false),
                    is_checked = table.Column<bool>(type: "boolean", nullable: false),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    visit_id = table.Column<int>(type: "integer", nullable: false),
                    episode_care_id = table.Column<int>(type: "integer", nullable: false),
                    is_submitted = table.Column<bool>(type: "boolean", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_complication_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_complication_data_complication_complication_id",
                        column: x => x.complication_id,
                        principalTable: "complication",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_complication_data_episode_cares_episode_care_id",
                        column: x => x.episode_care_id,
                        principalTable: "episode_cares",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_complication_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_complication_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_complication_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_complication_data_visits_visit_id",
                        column: x => x.visit_id,
                        principalTable: "visits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "dietary_habits_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    diet_type_id = table.Column<int>(type: "integer", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    unit_amount = table.Column<int>(type: "integer", nullable: true),
                    custom_timing_unit_id = table.Column<int>(type: "integer", nullable: true),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    visit_id = table.Column<int>(type: "integer", nullable: false),
                    episode_care_id = table.Column<int>(type: "integer", nullable: false),
                    is_submitted = table.Column<bool>(type: "boolean", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_dietary_habits_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_dietary_habits_data_diet_type_diet_type_id",
                        column: x => x.diet_type_id,
                        principalTable: "diet_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_dietary_habits_data_episode_cares_episode_care_id",
                        column: x => x.episode_care_id,
                        principalTable: "episode_cares",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_dietary_habits_data_master_timing_unit_custom_timing_unit_id",
                        column: x => x.custom_timing_unit_id,
                        principalTable: "master_timing_unit",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_dietary_habits_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_dietary_habits_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_dietary_habits_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_dietary_habits_data_visits_visit_id",
                        column: x => x.visit_id,
                        principalTable: "visits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "etiology_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    etiology_id = table.Column<int>(type: "integer", nullable: false),
                    is_checked = table.Column<bool>(type: "boolean", nullable: false),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    visit_id = table.Column<int>(type: "integer", nullable: false),
                    episode_care_id = table.Column<int>(type: "integer", nullable: false),
                    is_submitted = table.Column<bool>(type: "boolean", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_etiology_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_etiology_data_episode_cares_episode_care_id",
                        column: x => x.episode_care_id,
                        principalTable: "episode_cares",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_etiology_data_etiology_etiology_id",
                        column: x => x.etiology_id,
                        principalTable: "etiology",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_etiology_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_etiology_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_etiology_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_etiology_data_visits_visit_id",
                        column: x => x.visit_id,
                        principalTable: "visits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "food_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    on_set_date_time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    food_type_id = table.Column<int>(type: "integer", nullable: false),
                    portion_eaten_percentage = table.Column<int>(type: "integer", nullable: true),
                    portion_size = table.Column<int>(type: "integer", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    visit_id = table.Column<int>(type: "integer", nullable: false),
                    episode_care_id = table.Column<int>(type: "integer", nullable: false),
                    is_submitted = table.Column<bool>(type: "boolean", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_food_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_food_data_episode_cares_episode_care_id",
                        column: x => x.episode_care_id,
                        principalTable: "episode_cares",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_food_data_food_type_food_type_id",
                        column: x => x.food_type_id,
                        principalTable: "food_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_food_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_food_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_food_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_food_data_visits_visit_id",
                        column: x => x.visit_id,
                        principalTable: "visits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "glasgow_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    on_set_date_time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    eye_opening_id = table.Column<int>(type: "integer", nullable: false),
                    motor_response_id = table.Column<int>(type: "integer", nullable: false),
                    verbal_response_id = table.Column<int>(type: "integer", nullable: false),
                    total_score = table.Column<int>(type: "integer", nullable: false),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    visit_id = table.Column<int>(type: "integer", nullable: false),
                    episode_care_id = table.Column<int>(type: "integer", nullable: false),
                    is_submitted = table.Column<bool>(type: "boolean", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_glasgow_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_glasgow_data_episode_cares_episode_care_id",
                        column: x => x.episode_care_id,
                        principalTable: "episode_cares",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_glasgow_data_glasgow_eye_opening_eye_opening_id",
                        column: x => x.eye_opening_id,
                        principalTable: "glasgow_eye_opening",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_glasgow_data_glasgow_motor_response_motor_response_id",
                        column: x => x.motor_response_id,
                        principalTable: "glasgow_motor_response",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_glasgow_data_glasgow_verbal_response_verbal_response_id",
                        column: x => x.verbal_response_id,
                        principalTable: "glasgow_verbal_response",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_glasgow_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_glasgow_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_glasgow_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_glasgow_data_visits_visit_id",
                        column: x => x.visit_id,
                        principalTable: "visits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "glucose_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    glucose_value = table.Column<float>(type: "real", nullable: false),
                    on_set_date_time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    visit_id = table.Column<int>(type: "integer", nullable: false),
                    episode_care_id = table.Column<int>(type: "integer", nullable: false),
                    is_submitted = table.Column<bool>(type: "boolean", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_glucose_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_glucose_data_episode_cares_episode_care_id",
                        column: x => x.episode_care_id,
                        principalTable: "episode_cares",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_glucose_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_glucose_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_glucose_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_glucose_data_visits_visit_id",
                        column: x => x.visit_id,
                        principalTable: "visits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hysteroscopy_file_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    anatomical_position_id = table.Column<int>(type: "integer", nullable: false),
                    date = table.Column<DateOnly>(type: "date", nullable: false),
                    description = table.Column<string>(type: "text", nullable: true),
                    file_type = table.Column<string>(type: "text", nullable: true),
                    path = table.Column<string>(type: "text", nullable: true),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    visit_id = table.Column<int>(type: "integer", nullable: false),
                    episode_care_id = table.Column<int>(type: "integer", nullable: false),
                    is_submitted = table.Column<bool>(type: "boolean", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_hysteroscopy_file_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_hysteroscopy_file_data_episode_cares_episode_care_id",
                        column: x => x.episode_care_id,
                        principalTable: "episode_cares",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_hysteroscopy_file_data_hysteroscopy_anatomical_position_ana",
                        column: x => x.anatomical_position_id,
                        principalTable: "hysteroscopy_anatomical_position",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_hysteroscopy_file_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_hysteroscopy_file_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_hysteroscopy_file_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_hysteroscopy_file_data_visits_visit_id",
                        column: x => x.visit_id,
                        principalTable: "visits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "imaging_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    exam_title = table.Column<string>(type: "text", nullable: false),
                    category_id = table.Column<int>(type: "integer", nullable: false),
                    modality_id = table.Column<int>(type: "integer", nullable: false),
                    date = table.Column<DateOnly>(type: "date", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    report_path = table.Column<string>(type: "text", nullable: true),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    visit_id = table.Column<int>(type: "integer", nullable: false),
                    episode_care_id = table.Column<int>(type: "integer", nullable: false),
                    is_submitted = table.Column<bool>(type: "boolean", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_imaging_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_imaging_data_episode_cares_episode_care_id",
                        column: x => x.episode_care_id,
                        principalTable: "episode_cares",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_imaging_data_master_categories_category_id",
                        column: x => x.category_id,
                        principalTable: "master_categories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_imaging_data_master_category_modalities_modality_id",
                        column: x => x.modality_id,
                        principalTable: "master_category_modalities",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_imaging_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_imaging_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_imaging_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_imaging_data_visits_visit_id",
                        column: x => x.visit_id,
                        principalTable: "visits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "laboratory_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    date = table.Column<DateOnly>(type: "date", nullable: false),
                    laboratory_group_id = table.Column<int>(type: "integer", nullable: false),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    visit_id = table.Column<int>(type: "integer", nullable: false),
                    episode_care_id = table.Column<int>(type: "integer", nullable: false),
                    is_submitted = table.Column<bool>(type: "boolean", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_laboratory_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_laboratory_data_episode_cares_episode_care_id",
                        column: x => x.episode_care_id,
                        principalTable: "episode_cares",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_laboratory_data_laboratory_group_laboratory_group_id",
                        column: x => x.laboratory_group_id,
                        principalTable: "laboratory_group",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_laboratory_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_laboratory_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_laboratory_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_laboratory_data_visits_visit_id",
                        column: x => x.visit_id,
                        principalTable: "visits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "laboratory_files_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    category_id = table.Column<int>(type: "integer", nullable: false),
                    exam_title_id = table.Column<int>(type: "integer", nullable: false),
                    date = table.Column<DateOnly>(type: "date", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    path = table.Column<string>(type: "text", nullable: true),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    visit_id = table.Column<int>(type: "integer", nullable: false),
                    episode_care_id = table.Column<int>(type: "integer", nullable: false),
                    is_submitted = table.Column<bool>(type: "boolean", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_laboratory_files_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_laboratory_files_data_episode_cares_episode_care_id",
                        column: x => x.episode_care_id,
                        principalTable: "episode_cares",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_laboratory_files_data_master_categories_category_id",
                        column: x => x.category_id,
                        principalTable: "master_categories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_laboratory_files_data_master_exam_titles_exam_title_id",
                        column: x => x.exam_title_id,
                        principalTable: "master_exam_titles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_laboratory_files_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_laboratory_files_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_laboratory_files_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_laboratory_files_data_visits_visit_id",
                        column: x => x.visit_id,
                        principalTable: "visits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "medical_alert_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    description = table.Column<string>(type: "text", nullable: false),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    visit_id = table.Column<int>(type: "integer", nullable: false),
                    episode_care_id = table.Column<int>(type: "integer", nullable: false),
                    is_submitted = table.Column<bool>(type: "boolean", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_medical_alert_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_medical_alert_data_episode_cares_episode_care_id",
                        column: x => x.episode_care_id,
                        principalTable: "episode_cares",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_medical_alert_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_medical_alert_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_medical_alert_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_medical_alert_data_visits_visit_id",
                        column: x => x.visit_id,
                        principalTable: "visits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "medical_device_unknown_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    medical_device_id = table.Column<int>(type: "integer", nullable: false),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    visit_id = table.Column<int>(type: "integer", nullable: false),
                    episode_care_id = table.Column<int>(type: "integer", nullable: false),
                    is_submitted = table.Column<bool>(type: "boolean", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_medical_device_unknown_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_medical_device_unknown_data_ehdsi_absent_or_unknown_device_",
                        column: x => x.medical_device_id,
                        principalTable: "ehdsi_absent_or_unknown_device",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_medical_device_unknown_data_episode_cares_episode_care_id",
                        column: x => x.episode_care_id,
                        principalTable: "episode_cares",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_medical_device_unknown_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_medical_device_unknown_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_medical_device_unknown_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_medical_device_unknown_data_visits_visit_id",
                        column: x => x.visit_id,
                        principalTable: "visits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "medical_devices_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    medical_device_action_id = table.Column<int>(type: "integer", nullable: false),
                    medical_device_id = table.Column<int>(type: "integer", nullable: false),
                    on_set_date = table.Column<DateOnly>(type: "date", nullable: false),
                    removal_date = table.Column<DateOnly>(type: "date", nullable: true),
                    description = table.Column<string>(type: "text", nullable: false),
                    visit_id = table.Column<int>(type: "integer", nullable: false),
                    episode_care_id = table.Column<int>(type: "integer", nullable: false),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    is_submitted = table.Column<bool>(type: "boolean", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_medical_devices_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_medical_devices_data_ehdsi_medical_device_medical_device_id",
                        column: x => x.medical_device_id,
                        principalTable: "ehdsi_medical_device",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_medical_devices_data_episode_cares_episode_care_id",
                        column: x => x.episode_care_id,
                        principalTable: "episode_cares",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_medical_devices_data_medical_device_actions_medical_device_",
                        column: x => x.medical_device_action_id,
                        principalTable: "medical_device_actions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_medical_devices_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_medical_devices_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_medical_devices_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_medical_devices_data_visits_visit_id",
                        column: x => x.visit_id,
                        principalTable: "visits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "medical_history_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    description = table.Column<string>(type: "text", nullable: false),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    visit_id = table.Column<int>(type: "integer", nullable: false),
                    episode_care_id = table.Column<int>(type: "integer", nullable: false),
                    is_submitted = table.Column<bool>(type: "boolean", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_medical_history_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_medical_history_data_episode_cares_episode_care_id",
                        column: x => x.episode_care_id,
                        principalTable: "episode_cares",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_medical_history_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_medical_history_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_medical_history_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_medical_history_data_visits_visit_id",
                        column: x => x.visit_id,
                        principalTable: "visits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "medication_unknown_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    medication_id = table.Column<int>(type: "integer", nullable: false),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    visit_id = table.Column<int>(type: "integer", nullable: false),
                    episode_care_id = table.Column<int>(type: "integer", nullable: false),
                    is_submitted = table.Column<bool>(type: "boolean", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_medication_unknown_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_medication_unknown_data_ehdsi_absent_or_unknown_medication_",
                        column: x => x.medication_id,
                        principalTable: "ehdsi_absent_or_unknown_medication",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_medication_unknown_data_episode_cares_episode_care_id",
                        column: x => x.episode_care_id,
                        principalTable: "episode_cares",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_medication_unknown_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_medication_unknown_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_medication_unknown_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_medication_unknown_data_visits_visit_id",
                        column: x => x.visit_id,
                        principalTable: "visits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "neck_size_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    neck_size = table.Column<double>(type: "double precision", nullable: false),
                    description = table.Column<string>(type: "text", nullable: true),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    visit_id = table.Column<int>(type: "integer", nullable: false),
                    episode_care_id = table.Column<int>(type: "integer", nullable: false),
                    is_submitted = table.Column<bool>(type: "boolean", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_neck_size_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_neck_size_data_episode_cares_episode_care_id",
                        column: x => x.episode_care_id,
                        principalTable: "episode_cares",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_neck_size_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_neck_size_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_neck_size_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_neck_size_data_visits_visit_id",
                        column: x => x.visit_id,
                        principalTable: "visits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pregnancy_history_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    outcome_date = table.Column<DateOnly>(type: "date", nullable: false),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    visit_id = table.Column<int>(type: "integer", nullable: false),
                    episode_care_id = table.Column<int>(type: "integer", nullable: false),
                    is_submitted = table.Column<bool>(type: "boolean", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_pregnancy_history_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_pregnancy_history_data_episode_cares_episode_care_id",
                        column: x => x.episode_care_id,
                        principalTable: "episode_cares",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_pregnancy_history_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_pregnancy_history_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_pregnancy_history_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_pregnancy_history_data_visits_visit_id",
                        column: x => x.visit_id,
                        principalTable: "visits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pregnancy_outcome_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    outcome_id = table.Column<int>(type: "integer", nullable: false),
                    number_of_children = table.Column<int>(type: "integer", nullable: false),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    visit_id = table.Column<int>(type: "integer", nullable: false),
                    episode_care_id = table.Column<int>(type: "integer", nullable: false),
                    is_submitted = table.Column<bool>(type: "boolean", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_pregnancy_outcome_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_pregnancy_outcome_data_ehdsi_outcome_of_pregnancy_outcome_id",
                        column: x => x.outcome_id,
                        principalTable: "ehdsi_outcome_of_pregnancy",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_pregnancy_outcome_data_episode_cares_episode_care_id",
                        column: x => x.episode_care_id,
                        principalTable: "episode_cares",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_pregnancy_outcome_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_pregnancy_outcome_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_pregnancy_outcome_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_pregnancy_outcome_data_visits_visit_id",
                        column: x => x.visit_id,
                        principalTable: "visits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pregnancy_status_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    date_of_observation = table.Column<DateOnly>(type: "date", nullable: false),
                    status_id = table.Column<int>(type: "integer", nullable: false),
                    pregnancy_estimated_id = table.Column<int>(type: "integer", nullable: true),
                    estimated_date = table.Column<DateOnly>(type: "date", nullable: true),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    visit_id = table.Column<int>(type: "integer", nullable: false),
                    episode_care_id = table.Column<int>(type: "integer", nullable: false),
                    is_submitted = table.Column<bool>(type: "boolean", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_pregnancy_status_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_pregnancy_status_data_ehdsi_current_pregnancy_status_status",
                        column: x => x.status_id,
                        principalTable: "ehdsi_current_pregnancy_status",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_pregnancy_status_data_ehdsi_pregnancy_information_pregnancy",
                        column: x => x.pregnancy_estimated_id,
                        principalTable: "ehdsi_pregnancy_information",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_pregnancy_status_data_episode_cares_episode_care_id",
                        column: x => x.episode_care_id,
                        principalTable: "episode_cares",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_pregnancy_status_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_pregnancy_status_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_pregnancy_status_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_pregnancy_status_data_visits_visit_id",
                        column: x => x.visit_id,
                        principalTable: "visits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "problem_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    problem_id = table.Column<int>(type: "integer", nullable: false),
                    illness_and_disorder_id = table.Column<int>(type: "integer", nullable: true),
                    rare_disease_id = table.Column<int>(type: "integer", nullable: true),
                    status_code_id = table.Column<int>(type: "integer", nullable: false),
                    on_set_date = table.Column<DateOnly>(type: "date", nullable: false),
                    end_date = table.Column<DateOnly>(type: "date", nullable: true),
                    resolution_circumstances_text = table.Column<string>(type: "text", nullable: true),
                    diagnosis_assertion_id = table.Column<int>(type: "integer", nullable: true),
                    description = table.Column<string>(type: "text", nullable: false),
                    visit_id = table.Column<int>(type: "integer", nullable: false),
                    episode_care_id = table.Column<int>(type: "integer", nullable: false),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    is_submitted = table.Column<bool>(type: "boolean", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false),
                    replacement_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_problem_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_problem_data_ehdsi_certainty_diagnosis_assertion_id",
                        column: x => x.diagnosis_assertion_id,
                        principalTable: "ehdsi_certainty",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_problem_data_ehdsi_code_prob_problem_id",
                        column: x => x.problem_id,
                        principalTable: "ehdsi_code_prob",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_problem_data_ehdsi_illnessand_disorder_illness_and_disorder",
                        column: x => x.illness_and_disorder_id,
                        principalTable: "ehdsi_illnessand_disorder",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_problem_data_ehdsi_rare_disease_rare_disease_id",
                        column: x => x.rare_disease_id,
                        principalTable: "ehdsi_rare_disease",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_problem_data_ehdsi_status_code_status_code_id",
                        column: x => x.status_code_id,
                        principalTable: "ehdsi_status_code",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_problem_data_episode_cares_episode_care_id",
                        column: x => x.episode_care_id,
                        principalTable: "episode_cares",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_problem_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_problem_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_problem_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_problem_data_visits_visit_id",
                        column: x => x.visit_id,
                        principalTable: "visits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "problem_unknown_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    problem_id = table.Column<int>(type: "integer", nullable: false),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    visit_id = table.Column<int>(type: "integer", nullable: false),
                    episode_care_id = table.Column<int>(type: "integer", nullable: false),
                    is_submitted = table.Column<bool>(type: "boolean", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_problem_unknown_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_problem_unknown_data_ehdsi_absent_or_unknown_problem_proble",
                        column: x => x.problem_id,
                        principalTable: "ehdsi_absent_or_unknown_problem",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_problem_unknown_data_episode_cares_episode_care_id",
                        column: x => x.episode_care_id,
                        principalTable: "episode_cares",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_problem_unknown_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_problem_unknown_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_problem_unknown_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_problem_unknown_data_visits_visit_id",
                        column: x => x.visit_id,
                        principalTable: "visits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "procedure_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    procedure_id = table.Column<int>(type: "integer", nullable: false),
                    body_site = table.Column<string>(type: "text", nullable: true),
                    date = table.Column<DateOnly>(type: "date", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    visit_id = table.Column<int>(type: "integer", nullable: false),
                    episode_care_id = table.Column<int>(type: "integer", nullable: false),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    is_submitted = table.Column<bool>(type: "boolean", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_procedure_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_procedure_data_ehdsi_procedure_procedure_id",
                        column: x => x.procedure_id,
                        principalTable: "ehdsi_procedure",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_procedure_data_episode_cares_episode_care_id",
                        column: x => x.episode_care_id,
                        principalTable: "episode_cares",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_procedure_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_procedure_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_procedure_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_procedure_data_visits_visit_id",
                        column: x => x.visit_id,
                        principalTable: "visits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "procedure_unknown_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    procedure_id = table.Column<int>(type: "integer", nullable: false),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    visit_id = table.Column<int>(type: "integer", nullable: false),
                    episode_care_id = table.Column<int>(type: "integer", nullable: false),
                    is_submitted = table.Column<bool>(type: "boolean", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_procedure_unknown_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_procedure_unknown_data_ehdsi_absent_or_unknown_procedure_pr",
                        column: x => x.procedure_id,
                        principalTable: "ehdsi_absent_or_unknown_procedure",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_procedure_unknown_data_episode_cares_episode_care_id",
                        column: x => x.episode_care_id,
                        principalTable: "episode_cares",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_procedure_unknown_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_procedure_unknown_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_procedure_unknown_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_procedure_unknown_data_visits_visit_id",
                        column: x => x.visit_id,
                        principalTable: "visits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "questionnaire_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    answer_id = table.Column<int>(type: "integer", nullable: false),
                    questionnaire_template_id = table.Column<int>(type: "integer", nullable: false),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    visit_id = table.Column<int>(type: "integer", nullable: false),
                    episode_care_id = table.Column<int>(type: "integer", nullable: false),
                    activated = table.Column<bool>(type: "boolean", nullable: false),
                    is_submitted = table.Column<bool>(type: "boolean", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_questionnaire_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_questionnaire_data_episode_cares_episode_care_id",
                        column: x => x.episode_care_id,
                        principalTable: "episode_cares",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_questionnaire_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_questionnaire_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_questionnaire_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_questionnaire_data_visits_visit_id",
                        column: x => x.visit_id,
                        principalTable: "visits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "respiratory_clinical_examination_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    date = table.Column<DateOnly>(type: "date", nullable: false),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    visit_id = table.Column<int>(type: "integer", nullable: false),
                    episode_care_id = table.Column<int>(type: "integer", nullable: false),
                    is_submitted = table.Column<bool>(type: "boolean", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_respiratory_clinical_examination_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_respiratory_clinical_examination_data_episode_cares_episode",
                        column: x => x.episode_care_id,
                        principalTable: "episode_cares",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_respiratory_clinical_examination_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_respiratory_clinical_examination_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_respiratory_clinical_examination_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_respiratory_clinical_examination_data_visits_visit_id",
                        column: x => x.visit_id,
                        principalTable: "visits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "social_history_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    social_history_id = table.Column<int>(type: "integer", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    unit_amount = table.Column<int>(type: "integer", nullable: true),
                    custom_timing_unit_id = table.Column<int>(type: "integer", nullable: true),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    visit_id = table.Column<int>(type: "integer", nullable: false),
                    episode_care_id = table.Column<int>(type: "integer", nullable: false),
                    is_submitted = table.Column<bool>(type: "boolean", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_social_history_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_social_history_data_ehdsi_social_history_social_history_id",
                        column: x => x.social_history_id,
                        principalTable: "ehdsi_social_history",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_social_history_data_episode_cares_episode_care_id",
                        column: x => x.episode_care_id,
                        principalTable: "episode_cares",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_social_history_data_master_timing_unit_custom_timing_unit_id",
                        column: x => x.custom_timing_unit_id,
                        principalTable: "master_timing_unit",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_social_history_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_social_history_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_social_history_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_social_history_data_visits_visit_id",
                        column: x => x.visit_id,
                        principalTable: "visits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tracheostomy_ct_parameters_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    depth_of_trachea = table.Column<double>(type: "double precision", nullable: false),
                    distance_from_skin_to_trachea = table.Column<double>(type: "double precision", nullable: false),
                    distance_from_cricothyroid_to_carina = table.Column<double>(type: "double precision", nullable: false),
                    distance_between_tracheal_cartilages = table.Column<double>(type: "double precision", nullable: false),
                    anatomical_variations = table.Column<string>(type: "text", nullable: false),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    visit_id = table.Column<int>(type: "integer", nullable: false),
                    episode_care_id = table.Column<int>(type: "integer", nullable: false),
                    is_submitted = table.Column<bool>(type: "boolean", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tracheostomy_ct_parameters_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_tracheostomy_ct_parameters_data_episode_cares_episode_care_",
                        column: x => x.episode_care_id,
                        principalTable: "episode_cares",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_tracheostomy_ct_parameters_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_tracheostomy_ct_parameters_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_tracheostomy_ct_parameters_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_tracheostomy_ct_parameters_data_visits_visit_id",
                        column: x => x.visit_id,
                        principalTable: "visits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tracheostomy_tube_characteristics_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    tube_length_id = table.Column<int>(type: "integer", nullable: false),
                    outer_diameter_id = table.Column<int>(type: "integer", nullable: false),
                    inner_diameter_id = table.Column<int>(type: "integer", nullable: false),
                    cuff_diameter_id = table.Column<int>(type: "integer", nullable: false),
                    consistency_of_tube_id = table.Column<int>(type: "integer", nullable: false),
                    tube_type_id = table.Column<int>(type: "integer", nullable: false),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    visit_id = table.Column<int>(type: "integer", nullable: false),
                    episode_care_id = table.Column<int>(type: "integer", nullable: false),
                    is_submitted = table.Column<bool>(type: "boolean", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tracheostomy_tube_characteristics_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_tracheostomy_tube_characteristics_data_episode_cares_episod",
                        column: x => x.episode_care_id,
                        principalTable: "episode_cares",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_tracheostomy_tube_characteristics_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_tracheostomy_tube_characteristics_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_tracheostomy_tube_characteristics_data_tracheostomy_consist",
                        column: x => x.consistency_of_tube_id,
                        principalTable: "tracheostomy_consistency_of_tubes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_tracheostomy_tube_characteristics_data_tracheostomy_cuff_di",
                        column: x => x.cuff_diameter_id,
                        principalTable: "tracheostomy_cuff_diameters",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_tracheostomy_tube_characteristics_data_tracheostomy_inner_d",
                        column: x => x.inner_diameter_id,
                        principalTable: "tracheostomy_inner_diameters",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_tracheostomy_tube_characteristics_data_tracheostomy_outer_d",
                        column: x => x.outer_diameter_id,
                        principalTable: "tracheostomy_outer_diameters",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_tracheostomy_tube_characteristics_data_tracheostomy_tube_le",
                        column: x => x.tube_length_id,
                        principalTable: "tracheostomy_tube_lengths",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_tracheostomy_tube_characteristics_data_tracheostomy_tube_ty",
                        column: x => x.tube_type_id,
                        principalTable: "tracheostomy_tube_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_tracheostomy_tube_characteristics_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_tracheostomy_tube_characteristics_data_visits_visit_id",
                        column: x => x.visit_id,
                        principalTable: "visits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tracheostomy_tube_inspection_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    date = table.Column<DateOnly>(type: "date", nullable: false),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    visit_id = table.Column<int>(type: "integer", nullable: false),
                    episode_care_id = table.Column<int>(type: "integer", nullable: false),
                    is_submitted = table.Column<bool>(type: "boolean", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tracheostomy_tube_inspection_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_tracheostomy_tube_inspection_data_episode_cares_episode_car",
                        column: x => x.episode_care_id,
                        principalTable: "episode_cares",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_tracheostomy_tube_inspection_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_tracheostomy_tube_inspection_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_tracheostomy_tube_inspection_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_tracheostomy_tube_inspection_data_visits_visit_id",
                        column: x => x.visit_id,
                        principalTable: "visits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "travel_history_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    country_id = table.Column<int>(type: "integer", nullable: false),
                    arrival_date = table.Column<DateOnly>(type: "date", nullable: false),
                    departure_date = table.Column<DateOnly>(type: "date", nullable: false),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    visit_id = table.Column<int>(type: "integer", nullable: false),
                    episode_care_id = table.Column<int>(type: "integer", nullable: false),
                    is_submitted = table.Column<bool>(type: "boolean", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_travel_history_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_travel_history_data_ehdsi_country_country_id",
                        column: x => x.country_id,
                        principalTable: "ehdsi_country",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_travel_history_data_episode_cares_episode_care_id",
                        column: x => x.episode_care_id,
                        principalTable: "episode_cares",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_travel_history_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_travel_history_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_travel_history_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_travel_history_data_visits_visit_id",
                        column: x => x.visit_id,
                        principalTable: "visits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "vaccination_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    vaccine_id = table.Column<int>(type: "integer", nullable: false),
                    disease_targeted_id = table.Column<int>(type: "integer", nullable: false),
                    num_series_doses = table.Column<int>(type: "integer", nullable: false),
                    medicinal_product_name = table.Column<string>(type: "text", nullable: true),
                    marketing_authorization_holder = table.Column<string>(type: "text", nullable: true),
                    batch_lot_number = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    next_date = table.Column<DateOnly>(type: "date", nullable: true),
                    country_id = table.Column<int>(type: "integer", nullable: false),
                    doctor_id = table.Column<Guid>(type: "uuid", nullable: false),
                    administering_center_id = table.Column<int>(type: "integer", nullable: false),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    visit_id = table.Column<int>(type: "integer", nullable: false),
                    episode_care_id = table.Column<int>(type: "integer", nullable: false),
                    is_submitted = table.Column<bool>(type: "boolean", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_vaccination_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_vaccination_data_ehdsi_country_country_id",
                        column: x => x.country_id,
                        principalTable: "ehdsi_country",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_vaccination_data_ehdsi_illnessand_disorder_disease_targeted",
                        column: x => x.disease_targeted_id,
                        principalTable: "ehdsi_illnessand_disorder",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_vaccination_data_ehdsi_vaccine_vaccine_id",
                        column: x => x.vaccine_id,
                        principalTable: "ehdsi_vaccine",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_vaccination_data_episode_cares_episode_care_id",
                        column: x => x.episode_care_id,
                        principalTable: "episode_cares",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_vaccination_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_vaccination_data_tenant_settings_administering_center_id",
                        column: x => x.administering_center_id,
                        principalTable: "tenant_settings",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_vaccination_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_vaccination_data_users_doctor_id",
                        column: x => x.doctor_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_vaccination_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_vaccination_data_visits_visit_id",
                        column: x => x.visit_id,
                        principalTable: "visits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "vital_sign_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    on_set_date_time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    temperature = table.Column<float>(type: "real", nullable: false),
                    respiratory_rate = table.Column<float>(type: "real", nullable: false),
                    heart_rate = table.Column<float>(type: "real", nullable: false),
                    systolic_blood_pressure = table.Column<float>(type: "real", nullable: false),
                    diastolic_blood_pressure = table.Column<float>(type: "real", nullable: false),
                    urine_output = table.Column<float>(type: "real", nullable: true),
                    sp_o2 = table.Column<float>(type: "real", nullable: false),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    visit_id = table.Column<int>(type: "integer", nullable: false),
                    episode_care_id = table.Column<int>(type: "integer", nullable: false),
                    is_submitted = table.Column<bool>(type: "boolean", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_vital_sign_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_vital_sign_data_episode_cares_episode_care_id",
                        column: x => x.episode_care_id,
                        principalTable: "episode_cares",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_vital_sign_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_vital_sign_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_vital_sign_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_vital_sign_data_visits_visit_id",
                        column: x => x.visit_id,
                        principalTable: "visits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "weight_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    weight = table.Column<double>(type: "double precision", nullable: true),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    visit_id = table.Column<int>(type: "integer", nullable: true),
                    episode_care_id = table.Column<int>(type: "integer", nullable: true),
                    is_submitted = table.Column<bool>(type: "boolean", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    description = table.Column<string>(type: "text", nullable: true),
                    tenant_id = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_patient_weight_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_patient_weight_data_episode_cares_episode_care_id",
                        column: x => x.episode_care_id,
                        principalTable: "episode_cares",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_patient_weight_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_patient_weight_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_weight_data_visits_visit_id",
                        column: x => x.visit_id,
                        principalTable: "visits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "accommodation_data_history",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    is_historical = table.Column<bool>(type: "boolean", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    accommodation_data_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_accommodation_data_history", x => x.id);
                    table.ForeignKey(
                        name: "fk_accommodation_data_history_accommodation_data_accommodation",
                        column: x => x.accommodation_data_id,
                        principalTable: "accommodation_data",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_accommodation_data_history_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_accommodation_data_history_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_accommodation_data_history_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "allergy_reactions",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    manifestation_id = table.Column<int>(type: "integer", nullable: true),
                    on_set_date = table.Column<DateOnly>(type: "date", nullable: true),
                    end_date = table.Column<DateOnly>(type: "date", nullable: true),
                    severity_id = table.Column<int>(type: "integer", nullable: true),
                    certainty_id = table.Column<int>(type: "integer", nullable: true),
                    description = table.Column<string>(type: "text", nullable: false),
                    allergy_id = table.Column<int>(type: "integer", nullable: false),
                    visit_id = table.Column<int>(type: "integer", nullable: false),
                    episode_care_id = table.Column<int>(type: "integer", nullable: false),
                    is_submitted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_allergy_reactions", x => x.id);
                    table.ForeignKey(
                        name: "fk_allergy_reactions_allergy_data_allergy_id",
                        column: x => x.allergy_id,
                        principalTable: "allergy_data",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_allergy_reactions_ehdsi_allergy_certainty_certainty_id",
                        column: x => x.certainty_id,
                        principalTable: "ehdsi_allergy_certainty",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_allergy_reactions_ehdsi_reaction_allergy_manifestation_id",
                        column: x => x.manifestation_id,
                        principalTable: "ehdsi_reaction_allergy",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_allergy_reactions_ehdsi_severity_severity_id",
                        column: x => x.severity_id,
                        principalTable: "ehdsi_severity",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_allergy_reactions_episode_cares_episode_care_id",
                        column: x => x.episode_care_id,
                        principalTable: "episode_cares",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_allergy_reactions_visits_visit_id",
                        column: x => x.visit_id,
                        principalTable: "visits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "imaging_file_paths",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    path = table.Column<string>(type: "text", nullable: false),
                    imaging_data_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_imaging_file_paths", x => x.id);
                    table.ForeignKey(
                        name: "fk_imaging_file_paths_imaging_data_imaging_data_id",
                        column: x => x.imaging_data_id,
                        principalTable: "imaging_data",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "laboratory_data_items",
                columns: table => new
                {
                    laboratory_data_id = table.Column<int>(type: "integer", nullable: false),
                    laboratory_id = table.Column<int>(type: "integer", nullable: false),
                    value = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_laboratory_data_items", x => new { x.laboratory_data_id, x.laboratory_id });
                    table.ForeignKey(
                        name: "fk_laboratory_data_items_laboratory_data_laboratory_data_id",
                        column: x => x.laboratory_data_id,
                        principalTable: "laboratory_data",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_laboratory_data_items_laboratory_laboratory_id",
                        column: x => x.laboratory_id,
                        principalTable: "laboratory",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "medication_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    problem_id = table.Column<int>(type: "integer", nullable: true),
                    product_id = table.Column<string>(type: "character varying(48)", maxLength: 48, nullable: false),
                    atc_id = table.Column<int>(type: "integer", nullable: false),
                    package_id = table.Column<int>(type: "integer", nullable: false),
                    active_ingredient_id = table.Column<int>(type: "integer", nullable: false),
                    quantity = table.Column<double>(type: "double precision", nullable: false),
                    quantity_unit_id = table.Column<int>(type: "integer", nullable: false),
                    frequency_of_intake_amount = table.Column<double>(type: "double precision", nullable: false),
                    frequency_of_intake_unit_id = table.Column<int>(type: "integer", nullable: false),
                    duration_of_treatment_amount = table.Column<double>(type: "double precision", nullable: false),
                    duration_of_treatment_unit_id = table.Column<int>(type: "integer", nullable: false),
                    on_set_date_time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    end_date_time = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    instruction_patient = table.Column<string>(type: "text", nullable: true),
                    advice_to_dispenser = table.Column<string>(type: "text", nullable: true),
                    route_of_administration_id = table.Column<int>(type: "integer", nullable: true),
                    assigned_doctor_id = table.Column<Guid>(type: "uuid", nullable: true),
                    profession_id = table.Column<int>(type: "integer", nullable: true),
                    patient_id = table.Column<int>(type: "integer", nullable: false),
                    visit_id = table.Column<int>(type: "integer", nullable: false),
                    episode_care_id = table.Column<int>(type: "integer", nullable: false),
                    is_submitted = table.Column<bool>(type: "boolean", nullable: false),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false),
                    replacement_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_medication_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_medication_data_ehdsi_healthcare_professional_role_professi",
                        column: x => x.profession_id,
                        principalTable: "ehdsi_healthcare_professional_role",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_medication_data_episode_cares_episode_care_id",
                        column: x => x.episode_care_id,
                        principalTable: "episode_cares",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_medication_data_master_timing_unit_duration_of_treatment_un",
                        column: x => x.duration_of_treatment_unit_id,
                        principalTable: "master_timing_unit",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_medication_data_master_timing_unit_frequency_of_intake_unit",
                        column: x => x.frequency_of_intake_unit_id,
                        principalTable: "master_timing_unit",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_medication_data_medication_data_replacement_id",
                        column: x => x.replacement_id,
                        principalTable: "medication_data",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_medication_data_patients_patient_id",
                        column: x => x.patient_id,
                        principalTable: "patients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_medication_data_pharm_activesubstances_active_ingredient_id",
                        column: x => x.active_ingredient_id,
                        principalTable: "pharm_activesubstances",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_medication_data_pharm_atcs_atc_id",
                        column: x => x.atc_id,
                        principalTable: "pharm_atcs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_medication_data_pharm_forms_package_id",
                        column: x => x.package_id,
                        principalTable: "pharm_forms",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_medication_data_pharm_packagesizeunits_quantity_unit_id",
                        column: x => x.quantity_unit_id,
                        principalTable: "pharm_packagesizeunits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_medication_data_pharm_products_product_id",
                        column: x => x.product_id,
                        principalTable: "pharm_products",
                        principalColumn: "pk",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_medication_data_pharm_routes_route_of_administration_id",
                        column: x => x.route_of_administration_id,
                        principalTable: "pharm_routes",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_medication_data_problem_data_problem_id",
                        column: x => x.problem_id,
                        principalTable: "problem_data",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_medication_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_medication_data_users_assigned_doctor_id",
                        column: x => x.assigned_doctor_id,
                        principalTable: "users",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_medication_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_medication_data_visits_visit_id",
                        column: x => x.visit_id,
                        principalTable: "visits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "respiratory_clinical_examination_data_items",
                columns: table => new
                {
                    respiratory_clinical_examination_data_id = table.Column<int>(type: "integer", nullable: false),
                    respiratory_clinical_examination_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_respiratory_clinical_examination_data_items", x => new { x.respiratory_clinical_examination_data_id, x.respiratory_clinical_examination_id });
                    table.ForeignKey(
                        name: "fk_respiratory_clinical_examination_data_items_respiratory_cli",
                        column: x => x.respiratory_clinical_examination_data_id,
                        principalTable: "respiratory_clinical_examination_data",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_respiratory_clinical_examination_data_items_respiratory_cli1",
                        column: x => x.respiratory_clinical_examination_id,
                        principalTable: "respiratory_clinical_examination",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tracheostomy_tube_inspection_data_items",
                columns: table => new
                {
                    tracheostomy_tube_inspection_data_id = table.Column<int>(type: "integer", nullable: false),
                    tracheostomy_tube_inspection_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tracheostomy_tube_inspection_data_items", x => new { x.tracheostomy_tube_inspection_data_id, x.tracheostomy_tube_inspection_id });
                    table.ForeignKey(
                        name: "fk_tracheostomy_tube_inspection_data_items_tracheostomy_tube_i",
                        column: x => x.tracheostomy_tube_inspection_data_id,
                        principalTable: "tracheostomy_tube_inspection_data",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_tracheostomy_tube_inspection_data_items_tracheostomy_tube_i1",
                        column: x => x.tracheostomy_tube_inspection_id,
                        principalTable: "tracheostomy_tube_inspection",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "accommodation_data_history_items",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    accommodation_data_history_id = table.Column<int>(type: "integer", nullable: false),
                    registration_status_id = table.Column<int>(type: "integer", nullable: false),
                    notes = table.Column<string>(type: "text", nullable: true),
                    rejection_reason_id = table.Column<int>(type: "integer", nullable: true),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_accommodation_data_history_items", x => x.id);
                    table.ForeignKey(
                        name: "fk_accommodation_data_history_items_accommodation_data_history",
                        column: x => x.accommodation_data_history_id,
                        principalTable: "accommodation_data_history",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_accommodation_data_history_items_patient_registration_statu",
                        column: x => x.registration_status_id,
                        principalTable: "patient_registration_status",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_accommodation_data_history_items_patient_rejection_reasons_",
                        column: x => x.rejection_reason_id,
                        principalTable: "patient_rejection_reasons",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_accommodation_data_history_items_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "imaging_prediction_data",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    imaging_file_id = table.Column<int>(type: "integer", nullable: false),
                    contour_image_path = table.Column<string>(type: "text", nullable: false),
                    processed_image_path = table.Column<string>(type: "text", nullable: false),
                    prediction_image_path = table.Column<string>(type: "text", nullable: false),
                    dimension = table.Column<string>(type: "text", nullable: false),
                    creation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    last_update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_imaging_prediction_data", x => x.id);
                    table.ForeignKey(
                        name: "fk_imaging_prediction_data_imaging_file_paths_imaging_file_id",
                        column: x => x.imaging_file_id,
                        principalTable: "imaging_file_paths",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_imaging_prediction_data_tenant_tenant_id",
                        column: x => x.tenant_id,
                        principalTable: "tenant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_imaging_prediction_data_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_accommodation_beds_room_id",
                table: "accommodation_beds",
                column: "room_id");

            migrationBuilder.CreateIndex(
                name: "ix_accommodation_beds_tenant_id",
                table: "accommodation_beds",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_accommodation_beds_translation_id",
                table: "accommodation_beds",
                column: "translation_id");

            migrationBuilder.CreateIndex(
                name: "ix_accommodation_beds_user_id",
                table: "accommodation_beds",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_accommodation_buildings_tenant_id",
                table: "accommodation_buildings",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_accommodation_buildings_translation_id",
                table: "accommodation_buildings",
                column: "translation_id");

            migrationBuilder.CreateIndex(
                name: "ix_accommodation_buildings_user_id",
                table: "accommodation_buildings",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_accommodation_data_admission_reason_id",
                table: "accommodation_data",
                column: "admission_reason_id");

            migrationBuilder.CreateIndex(
                name: "ix_accommodation_data_bed_id",
                table: "accommodation_data",
                column: "bed_id");

            migrationBuilder.CreateIndex(
                name: "ix_accommodation_data_episode_care_id",
                table: "accommodation_data",
                column: "episode_care_id");

            migrationBuilder.CreateIndex(
                name: "ix_accommodation_data_patient_id",
                table: "accommodation_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_accommodation_data_tenant_id",
                table: "accommodation_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_accommodation_data_user_id",
                table: "accommodation_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_accommodation_data_history_accommodation_data_id",
                table: "accommodation_data_history",
                column: "accommodation_data_id");

            migrationBuilder.CreateIndex(
                name: "ix_accommodation_data_history_patient_id",
                table: "accommodation_data_history",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_accommodation_data_history_tenant_id",
                table: "accommodation_data_history",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_accommodation_data_history_user_id",
                table: "accommodation_data_history",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_accommodation_data_history_items_accommodation_data_history",
                table: "accommodation_data_history_items",
                column: "accommodation_data_history_id");

            migrationBuilder.CreateIndex(
                name: "ix_accommodation_data_history_items_registration_status_id",
                table: "accommodation_data_history_items",
                column: "registration_status_id");

            migrationBuilder.CreateIndex(
                name: "ix_accommodation_data_history_items_rejection_reason_id",
                table: "accommodation_data_history_items",
                column: "rejection_reason_id");

            migrationBuilder.CreateIndex(
                name: "ix_accommodation_data_history_items_user_id",
                table: "accommodation_data_history_items",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_accommodation_floors_building_id",
                table: "accommodation_floors",
                column: "building_id");

            migrationBuilder.CreateIndex(
                name: "ix_accommodation_floors_tenant_id",
                table: "accommodation_floors",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_accommodation_floors_translation_id",
                table: "accommodation_floors",
                column: "translation_id");

            migrationBuilder.CreateIndex(
                name: "ix_accommodation_floors_user_id",
                table: "accommodation_floors",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_accommodation_rooms_tenant_id",
                table: "accommodation_rooms",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_accommodation_rooms_translation_id",
                table: "accommodation_rooms",
                column: "translation_id");

            migrationBuilder.CreateIndex(
                name: "ix_accommodation_rooms_user_id",
                table: "accommodation_rooms",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_accommodation_rooms_ward_id",
                table: "accommodation_rooms",
                column: "ward_id");

            migrationBuilder.CreateIndex(
                name: "ix_accommodation_wards_floor_id",
                table: "accommodation_wards",
                column: "floor_id");

            migrationBuilder.CreateIndex(
                name: "ix_accommodation_wards_tenant_id",
                table: "accommodation_wards",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_accommodation_wards_translation_id",
                table: "accommodation_wards",
                column: "translation_id");

            migrationBuilder.CreateIndex(
                name: "ix_accommodation_wards_user_id",
                table: "accommodation_wards",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_address_data_country_id",
                table: "address_data",
                column: "country_id");

            migrationBuilder.CreateIndex(
                name: "ix_addresses_country_id",
                table: "addresses",
                column: "country_id");

            migrationBuilder.CreateIndex(
                name: "ix_admission_reason_tenants_tenant_id",
                table: "admission_reason_tenants",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_admission_reasons_translation_id",
                table: "admission_reasons",
                column: "translation_id");

            migrationBuilder.CreateIndex(
                name: "ix_allergy_data_allergy_category_id",
                table: "allergy_data",
                column: "allergy_category_id");

            migrationBuilder.CreateIndex(
                name: "ix_allergy_data_allergy_id",
                table: "allergy_data",
                column: "allergy_id");

            migrationBuilder.CreateIndex(
                name: "ix_allergy_data_allergy_status_id",
                table: "allergy_data",
                column: "allergy_status_id");

            migrationBuilder.CreateIndex(
                name: "ix_allergy_data_criticality_id",
                table: "allergy_data",
                column: "criticality_id");

            migrationBuilder.CreateIndex(
                name: "ix_allergy_data_episode_care_id",
                table: "allergy_data",
                column: "episode_care_id");

            migrationBuilder.CreateIndex(
                name: "ix_allergy_data_event_type_id",
                table: "allergy_data",
                column: "event_type_id");

            migrationBuilder.CreateIndex(
                name: "ix_allergy_data_patient_id",
                table: "allergy_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_allergy_data_tenant_id",
                table: "allergy_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_allergy_data_user_id",
                table: "allergy_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_allergy_data_visit_id",
                table: "allergy_data",
                column: "visit_id");

            migrationBuilder.CreateIndex(
                name: "ix_allergy_reactions_allergy_id",
                table: "allergy_reactions",
                column: "allergy_id");

            migrationBuilder.CreateIndex(
                name: "ix_allergy_reactions_certainty_id",
                table: "allergy_reactions",
                column: "certainty_id");

            migrationBuilder.CreateIndex(
                name: "ix_allergy_reactions_episode_care_id",
                table: "allergy_reactions",
                column: "episode_care_id");

            migrationBuilder.CreateIndex(
                name: "ix_allergy_reactions_manifestation_id",
                table: "allergy_reactions",
                column: "manifestation_id");

            migrationBuilder.CreateIndex(
                name: "ix_allergy_reactions_severity_id",
                table: "allergy_reactions",
                column: "severity_id");

            migrationBuilder.CreateIndex(
                name: "ix_allergy_reactions_visit_id",
                table: "allergy_reactions",
                column: "visit_id");

            migrationBuilder.CreateIndex(
                name: "ix_allergy_unknown_data_allergy_id",
                table: "allergy_unknown_data",
                column: "allergy_id");

            migrationBuilder.CreateIndex(
                name: "ix_allergy_unknown_data_episode_care_id",
                table: "allergy_unknown_data",
                column: "episode_care_id");

            migrationBuilder.CreateIndex(
                name: "ix_allergy_unknown_data_patient_id",
                table: "allergy_unknown_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_allergy_unknown_data_tenant_id",
                table: "allergy_unknown_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_allergy_unknown_data_user_id",
                table: "allergy_unknown_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_allergy_unknown_data_visit_id",
                table: "allergy_unknown_data",
                column: "visit_id");

            migrationBuilder.CreateIndex(
                name: "ix_answer_answer_questionnaire_id",
                schema: "quest",
                table: "answer",
                column: "answer_questionnaire_id");

            migrationBuilder.CreateIndex(
                name: "ix_answer_question_template_id",
                schema: "quest",
                table: "answer",
                column: "question_template_id");

            migrationBuilder.CreateIndex(
                name: "ix_answer_questionnaires_questionnaire_template_id",
                schema: "quest",
                table: "answer_questionnaires",
                column: "questionnaire_template_id");

            migrationBuilder.CreateIndex(
                name: "ix_appointment_data_appointment_status_id",
                table: "appointment_data",
                column: "appointment_status_id");

            migrationBuilder.CreateIndex(
                name: "ix_appointment_data_recurrent_type_id",
                table: "appointment_data",
                column: "recurrent_type_id");

            migrationBuilder.CreateIndex(
                name: "ix_appointment_data_tenant_id",
                table: "appointment_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_appointment_data_user_id",
                table: "appointment_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_appointment_participant_actor_data_patient_id",
                table: "appointment_participant_actor_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_appointment_participant_actor_data_user_id",
                table: "appointment_participant_actor_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_appointment_participant_data_actor_id",
                table: "appointment_participant_data",
                column: "actor_id");

            migrationBuilder.CreateIndex(
                name: "ix_appointment_participant_data_appointment_data_id",
                table: "appointment_participant_data",
                column: "appointment_data_id");

            migrationBuilder.CreateIndex(
                name: "ix_appointment_participant_data_participant_status_id",
                table: "appointment_participant_data",
                column: "participant_status_id");

            migrationBuilder.CreateIndex(
                name: "ix_appointment_patient_data_appointment_status_id",
                table: "appointment_patient_data",
                column: "appointment_status_id");

            migrationBuilder.CreateIndex(
                name: "ix_appointment_patient_data_doctor_id",
                table: "appointment_patient_data",
                column: "doctor_id");

            migrationBuilder.CreateIndex(
                name: "ix_appointment_patient_data_patient_id",
                table: "appointment_patient_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_appointment_patient_data_tenant_id",
                table: "appointment_patient_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_appointment_patient_data_user_id",
                table: "appointment_patient_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_appointment_slot_data_appointment_data_id",
                table: "appointment_slot_data",
                column: "appointment_data_id");

            migrationBuilder.CreateIndex(
                name: "ix_appointment_slot_data_slot_status_id",
                table: "appointment_slot_data",
                column: "slot_status_id");

            migrationBuilder.CreateIndex(
                name: "ix_appointment_slot_data_user_id",
                table: "appointment_slot_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_appointment_status_appointment_status_type_id",
                table: "appointment_status",
                column: "appointment_status_type_id");

            migrationBuilder.CreateIndex(
                name: "ix_arterial_blood_gas_data_episode_care_id",
                table: "arterial_blood_gas_data",
                column: "episode_care_id");

            migrationBuilder.CreateIndex(
                name: "ix_arterial_blood_gas_data_patient_id",
                table: "arterial_blood_gas_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_arterial_blood_gas_data_tenant_id",
                table: "arterial_blood_gas_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_arterial_blood_gas_data_user_id",
                table: "arterial_blood_gas_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_arterial_blood_gas_data_visit_id",
                table: "arterial_blood_gas_data",
                column: "visit_id");

            migrationBuilder.CreateIndex(
                name: "ix_capnography_data_episode_care_id",
                table: "capnography_data",
                column: "episode_care_id");

            migrationBuilder.CreateIndex(
                name: "ix_capnography_data_patient_id",
                table: "capnography_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_capnography_data_tenant_id",
                table: "capnography_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_capnography_data_user_id",
                table: "capnography_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_capnography_data_visit_id",
                table: "capnography_data",
                column: "visit_id");

            migrationBuilder.CreateIndex(
                name: "ix_care_plan_data_episode_care_id",
                table: "care_plan_data",
                column: "episode_care_id");

            migrationBuilder.CreateIndex(
                name: "ix_care_plan_data_patient_id",
                table: "care_plan_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_care_plan_data_tenant_id",
                table: "care_plan_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_care_plan_data_user_id",
                table: "care_plan_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_care_plan_data_visit_id",
                table: "care_plan_data",
                column: "visit_id");

            migrationBuilder.CreateIndex(
                name: "ix_comorbidity_data_episode_care_id",
                table: "comorbidity_data",
                column: "episode_care_id");

            migrationBuilder.CreateIndex(
                name: "ix_comorbidity_data_patient_id",
                table: "comorbidity_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_comorbidity_data_tenant_id",
                table: "comorbidity_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_comorbidity_data_user_id",
                table: "comorbidity_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_comorbidity_data_visit_id",
                table: "comorbidity_data",
                column: "visit_id");

            migrationBuilder.CreateIndex(
                name: "ix_complication_data_complication_id",
                table: "complication_data",
                column: "complication_id");

            migrationBuilder.CreateIndex(
                name: "ix_complication_data_episode_care_id",
                table: "complication_data",
                column: "episode_care_id");

            migrationBuilder.CreateIndex(
                name: "ix_complication_data_patient_id",
                table: "complication_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_complication_data_tenant_id",
                table: "complication_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_complication_data_user_id",
                table: "complication_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_complication_data_visit_id",
                table: "complication_data",
                column: "visit_id");

            migrationBuilder.CreateIndex(
                name: "ix_departments_user_id",
                table: "departments",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_dietary_habits_data_custom_timing_unit_id",
                table: "dietary_habits_data",
                column: "custom_timing_unit_id");

            migrationBuilder.CreateIndex(
                name: "ix_dietary_habits_data_diet_type_id",
                table: "dietary_habits_data",
                column: "diet_type_id");

            migrationBuilder.CreateIndex(
                name: "ix_dietary_habits_data_episode_care_id",
                table: "dietary_habits_data",
                column: "episode_care_id");

            migrationBuilder.CreateIndex(
                name: "ix_dietary_habits_data_patient_id",
                table: "dietary_habits_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_dietary_habits_data_tenant_id",
                table: "dietary_habits_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_dietary_habits_data_user_id",
                table: "dietary_habits_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_dietary_habits_data_visit_id",
                table: "dietary_habits_data",
                column: "visit_id");

            migrationBuilder.CreateIndex(
                name: "ix_discharge_data_discharge_situation_id",
                table: "discharge_data",
                column: "discharge_situation_id");

            migrationBuilder.CreateIndex(
                name: "ix_discharge_data_discharge_type_id",
                table: "discharge_data",
                column: "discharge_type_id");

            migrationBuilder.CreateIndex(
                name: "ix_discharge_data_episode_care_id",
                table: "discharge_data",
                column: "episode_care_id");

            migrationBuilder.CreateIndex(
                name: "ix_discharge_data_tenant_id",
                table: "discharge_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_discharge_data_user_id",
                table: "discharge_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_discharge_situations_translation_id",
                table: "discharge_situations",
                column: "translation_id");

            migrationBuilder.CreateIndex(
                name: "ix_discharge_types_translation_id",
                table: "discharge_types",
                column: "translation_id");

            migrationBuilder.CreateIndex(
                name: "ix_document_types_translation_id",
                table: "document_types",
                column: "translation_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_absent_or_unknown_allergy_value_set_id",
                table: "ehdsi_absent_or_unknown_allergy",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_absent_or_unknown_device_value_set_id",
                table: "ehdsi_absent_or_unknown_device",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_absent_or_unknown_medication_value_set_id",
                table: "ehdsi_absent_or_unknown_medication",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_absent_or_unknown_problem_value_set_id",
                table: "ehdsi_absent_or_unknown_problem",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_absent_or_unknown_procedure_value_set_id",
                table: "ehdsi_absent_or_unknown_procedure",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_active_ingredient_value_set_id",
                table: "ehdsi_active_ingredient",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_administrative_gender_translation_id",
                table: "ehdsi_administrative_gender",
                column: "translation_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_administrative_gender_value_set_id",
                table: "ehdsi_administrative_gender",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_adverse_event_type_value_set_id",
                table: "ehdsi_adverse_event_type",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_allergen_no_drug_value_set_id",
                table: "ehdsi_allergen_no_drug",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_allergies_custom_allergy_category_id",
                table: "ehdsi_allergies_custom",
                column: "allergy_category_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_allergies_custom_value_set_id",
                table: "ehdsi_allergies_custom",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_allergy_certainty_value_set_id",
                table: "ehdsi_allergy_certainty",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_allergy_status_value_set_id",
                table: "ehdsi_allergy_status",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_blood_group_translation_id",
                table: "ehdsi_blood_group",
                column: "translation_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_blood_group_value_set_id",
                table: "ehdsi_blood_group",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_blood_pressure_value_set_id",
                table: "ehdsi_blood_pressure",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_certainty_value_set_id",
                table: "ehdsi_certainty",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_code_prob_value_set_id",
                table: "ehdsi_code_prob",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_confidentiality_value_set_id",
                table: "ehdsi_confidentiality",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_country_value_set_id",
                table: "ehdsi_country",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_criticality_value_set_id",
                table: "ehdsi_criticality",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_current_pregnancy_status_value_set_id",
                table: "ehdsi_current_pregnancy_status",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_display_label_value_set_id",
                table: "ehdsi_display_label",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_document_code_value_set_id",
                table: "ehdsi_document_code",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_dose_form_value_set_id",
                table: "ehdsi_dose_form",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_healthcare_professional_role_value_set_id",
                table: "ehdsi_healthcare_professional_role",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_hospital_discharge_report_type_value_set_id",
                table: "ehdsi_hospital_discharge_report_type",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_illnessand_disorder_value_set_id",
                table: "ehdsi_illnessand_disorder",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_laboratory_report_type_value_set_id",
                table: "ehdsi_laboratory_report_type",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_language_value_set_id",
                table: "ehdsi_language",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_medical_device_value_set_id",
                table: "ehdsi_medical_device",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_medical_images_type_value_set_id",
                table: "ehdsi_medical_images_type",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_medical_imaging_report_type_value_set_id",
                table: "ehdsi_medical_imaging_report_type",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_null_flavor_value_set_id",
                table: "ehdsi_null_flavor",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_outcome_of_pregnancy_value_set_id",
                table: "ehdsi_outcome_of_pregnancy",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_package_value_set_id",
                table: "ehdsi_package",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_personal_relationship_value_set_id",
                table: "ehdsi_personal_relationship",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_pregnancy_information_value_set_id",
                table: "ehdsi_pregnancy_information",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_procedure_value_set_id",
                table: "ehdsi_procedure",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_quantity_unit_value_set_id",
                table: "ehdsi_quantity_unit",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_rare_disease_value_set_id",
                table: "ehdsi_rare_disease",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_reaction_allergy_value_set_id",
                table: "ehdsi_reaction_allergy",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_resolution_outcome_value_set_id",
                table: "ehdsi_resolution_outcome",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_role_class_value_set_id",
                table: "ehdsi_role_class",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_routeof_administration_value_set_id",
                table: "ehdsi_routeof_administration",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_section_value_set_id",
                table: "ehdsi_section",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_severity_value_set_id",
                table: "ehdsi_severity",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_social_history_value_set_id",
                table: "ehdsi_social_history",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_status_code_value_set_id",
                table: "ehdsi_status_code",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_substance_value_set_id",
                table: "ehdsi_substance",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_substitution_code_value_set_id",
                table: "ehdsi_substitution_code",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_telecom_address_value_set_id",
                table: "ehdsi_telecom_address",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_timing_event_value_set_id",
                table: "ehdsi_timing_event",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_unit_value_set_id",
                table: "ehdsi_unit",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_ehdsi_vaccine_value_set_id",
                table: "ehdsi_vaccine",
                column: "value_set_id");

            migrationBuilder.CreateIndex(
                name: "ix_episode_cares_patient_id",
                table: "episode_cares",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_episode_cares_potential_diagnosis_id",
                table: "episode_cares",
                column: "potential_diagnosis_id");

            migrationBuilder.CreateIndex(
                name: "ix_episode_cares_status_id",
                table: "episode_cares",
                column: "status_id");

            migrationBuilder.CreateIndex(
                name: "ix_episode_cares_tenant_id",
                table: "episode_cares",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_episode_cares_user_id",
                table: "episode_cares",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_etiology_data_episode_care_id",
                table: "etiology_data",
                column: "episode_care_id");

            migrationBuilder.CreateIndex(
                name: "ix_etiology_data_etiology_id",
                table: "etiology_data",
                column: "etiology_id");

            migrationBuilder.CreateIndex(
                name: "ix_etiology_data_patient_id",
                table: "etiology_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_etiology_data_tenant_id",
                table: "etiology_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_etiology_data_user_id",
                table: "etiology_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_etiology_data_visit_id",
                table: "etiology_data",
                column: "visit_id");

            migrationBuilder.CreateIndex(
                name: "ix_external_doctor_specialties_translation_id",
                table: "external_doctor_specialties",
                column: "translation_id");

            migrationBuilder.CreateIndex(
                name: "ix_external_doctors_address_data_id",
                table: "external_doctors",
                column: "address_data_id");

            migrationBuilder.CreateIndex(
                name: "ix_external_doctors_tenant_id",
                table: "external_doctors",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_external_doctors_specialties_link_external_doctor_specialty",
                table: "external_doctors_specialties_link",
                column: "external_doctor_specialty_id");

            migrationBuilder.CreateIndex(
                name: "ix_food_data_episode_care_id",
                table: "food_data",
                column: "episode_care_id");

            migrationBuilder.CreateIndex(
                name: "ix_food_data_food_type_id",
                table: "food_data",
                column: "food_type_id");

            migrationBuilder.CreateIndex(
                name: "ix_food_data_patient_id",
                table: "food_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_food_data_tenant_id",
                table: "food_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_food_data_user_id",
                table: "food_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_food_data_visit_id",
                table: "food_data",
                column: "visit_id");

            migrationBuilder.CreateIndex(
                name: "ix_glasgow_data_episode_care_id",
                table: "glasgow_data",
                column: "episode_care_id");

            migrationBuilder.CreateIndex(
                name: "ix_glasgow_data_eye_opening_id",
                table: "glasgow_data",
                column: "eye_opening_id");

            migrationBuilder.CreateIndex(
                name: "ix_glasgow_data_motor_response_id",
                table: "glasgow_data",
                column: "motor_response_id");

            migrationBuilder.CreateIndex(
                name: "ix_glasgow_data_patient_id",
                table: "glasgow_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_glasgow_data_tenant_id",
                table: "glasgow_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_glasgow_data_user_id",
                table: "glasgow_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_glasgow_data_verbal_response_id",
                table: "glasgow_data",
                column: "verbal_response_id");

            migrationBuilder.CreateIndex(
                name: "ix_glasgow_data_visit_id",
                table: "glasgow_data",
                column: "visit_id");

            migrationBuilder.CreateIndex(
                name: "ix_glucose_data_episode_care_id",
                table: "glucose_data",
                column: "episode_care_id");

            migrationBuilder.CreateIndex(
                name: "ix_glucose_data_patient_id",
                table: "glucose_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_glucose_data_tenant_id",
                table: "glucose_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_glucose_data_user_id",
                table: "glucose_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_glucose_data_visit_id",
                table: "glucose_data",
                column: "visit_id");

            migrationBuilder.CreateIndex(
                name: "ix_hysteroscopy_anatomical_sub_position_anatomical_position_id",
                table: "hysteroscopy_anatomical_sub_position",
                column: "anatomical_position_id");

            migrationBuilder.CreateIndex(
                name: "ix_hysteroscopy_file_data_anatomical_position_id",
                table: "hysteroscopy_file_data",
                column: "anatomical_position_id");

            migrationBuilder.CreateIndex(
                name: "ix_hysteroscopy_file_data_episode_care_id",
                table: "hysteroscopy_file_data",
                column: "episode_care_id");

            migrationBuilder.CreateIndex(
                name: "ix_hysteroscopy_file_data_patient_id",
                table: "hysteroscopy_file_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_hysteroscopy_file_data_tenant_id",
                table: "hysteroscopy_file_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_hysteroscopy_file_data_user_id",
                table: "hysteroscopy_file_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_hysteroscopy_file_data_visit_id",
                table: "hysteroscopy_file_data",
                column: "visit_id");

            migrationBuilder.CreateIndex(
                name: "ix_imaging_data_category_id",
                table: "imaging_data",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "ix_imaging_data_episode_care_id",
                table: "imaging_data",
                column: "episode_care_id");

            migrationBuilder.CreateIndex(
                name: "ix_imaging_data_modality_id",
                table: "imaging_data",
                column: "modality_id");

            migrationBuilder.CreateIndex(
                name: "ix_imaging_data_patient_id",
                table: "imaging_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_imaging_data_tenant_id",
                table: "imaging_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_imaging_data_user_id",
                table: "imaging_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_imaging_data_visit_id",
                table: "imaging_data",
                column: "visit_id");

            migrationBuilder.CreateIndex(
                name: "ix_imaging_file_paths_imaging_data_id",
                table: "imaging_file_paths",
                column: "imaging_data_id");

            migrationBuilder.CreateIndex(
                name: "ix_imaging_prediction_data_imaging_file_id",
                table: "imaging_prediction_data",
                column: "imaging_file_id");

            migrationBuilder.CreateIndex(
                name: "ix_imaging_prediction_data_tenant_id",
                table: "imaging_prediction_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_imaging_prediction_data_user_id",
                table: "imaging_prediction_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_ips_cda_data_patient_id",
                table: "ips_cda_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_ips_cda_data_tenant_id",
                table: "ips_cda_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_ips_cda_data_user_id",
                table: "ips_cda_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_laboratory_data_episode_care_id",
                table: "laboratory_data",
                column: "episode_care_id");

            migrationBuilder.CreateIndex(
                name: "ix_laboratory_data_laboratory_group_id",
                table: "laboratory_data",
                column: "laboratory_group_id");

            migrationBuilder.CreateIndex(
                name: "ix_laboratory_data_patient_id",
                table: "laboratory_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_laboratory_data_tenant_id",
                table: "laboratory_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_laboratory_data_user_id",
                table: "laboratory_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_laboratory_data_visit_id",
                table: "laboratory_data",
                column: "visit_id");

            migrationBuilder.CreateIndex(
                name: "ix_laboratory_data_items_laboratory_id",
                table: "laboratory_data_items",
                column: "laboratory_id");

            migrationBuilder.CreateIndex(
                name: "ix_laboratory_files_data_category_id",
                table: "laboratory_files_data",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "ix_laboratory_files_data_episode_care_id",
                table: "laboratory_files_data",
                column: "episode_care_id");

            migrationBuilder.CreateIndex(
                name: "ix_laboratory_files_data_exam_title_id",
                table: "laboratory_files_data",
                column: "exam_title_id");

            migrationBuilder.CreateIndex(
                name: "ix_laboratory_files_data_patient_id",
                table: "laboratory_files_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_laboratory_files_data_tenant_id",
                table: "laboratory_files_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_laboratory_files_data_user_id",
                table: "laboratory_files_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_laboratory_files_data_visit_id",
                table: "laboratory_files_data",
                column: "visit_id");

            migrationBuilder.CreateIndex(
                name: "ix_laboratory_group_laboratory_laboratory_group_id",
                table: "laboratory_group_laboratory",
                column: "laboratory_group_id");

            migrationBuilder.CreateIndex(
                name: "ix_laboratory_group_tenant_tenant_id",
                table: "laboratory_group_tenant",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_master_category_modalities_category_id",
                table: "master_category_modalities",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "ix_master_timing_unit_unit_id",
                table: "master_timing_unit",
                column: "unit_id");

            migrationBuilder.CreateIndex(
                name: "ix_medical_alert_data_episode_care_id",
                table: "medical_alert_data",
                column: "episode_care_id");

            migrationBuilder.CreateIndex(
                name: "ix_medical_alert_data_patient_id",
                table: "medical_alert_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_medical_alert_data_tenant_id",
                table: "medical_alert_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_medical_alert_data_user_id",
                table: "medical_alert_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_medical_alert_data_visit_id",
                table: "medical_alert_data",
                column: "visit_id");

            migrationBuilder.CreateIndex(
                name: "ix_medical_device_unknown_data_episode_care_id",
                table: "medical_device_unknown_data",
                column: "episode_care_id");

            migrationBuilder.CreateIndex(
                name: "ix_medical_device_unknown_data_medical_device_id",
                table: "medical_device_unknown_data",
                column: "medical_device_id");

            migrationBuilder.CreateIndex(
                name: "ix_medical_device_unknown_data_patient_id",
                table: "medical_device_unknown_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_medical_device_unknown_data_tenant_id",
                table: "medical_device_unknown_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_medical_device_unknown_data_user_id",
                table: "medical_device_unknown_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_medical_device_unknown_data_visit_id",
                table: "medical_device_unknown_data",
                column: "visit_id");

            migrationBuilder.CreateIndex(
                name: "ix_medical_devices_data_episode_care_id",
                table: "medical_devices_data",
                column: "episode_care_id");

            migrationBuilder.CreateIndex(
                name: "ix_medical_devices_data_medical_device_action_id",
                table: "medical_devices_data",
                column: "medical_device_action_id");

            migrationBuilder.CreateIndex(
                name: "ix_medical_devices_data_medical_device_id",
                table: "medical_devices_data",
                column: "medical_device_id");

            migrationBuilder.CreateIndex(
                name: "ix_medical_devices_data_patient_id",
                table: "medical_devices_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_medical_devices_data_tenant_id",
                table: "medical_devices_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_medical_devices_data_user_id",
                table: "medical_devices_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_medical_devices_data_visit_id",
                table: "medical_devices_data",
                column: "visit_id");

            migrationBuilder.CreateIndex(
                name: "ix_medical_history_data_episode_care_id",
                table: "medical_history_data",
                column: "episode_care_id");

            migrationBuilder.CreateIndex(
                name: "ix_medical_history_data_patient_id",
                table: "medical_history_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_medical_history_data_tenant_id",
                table: "medical_history_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_medical_history_data_user_id",
                table: "medical_history_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_medical_history_data_visit_id",
                table: "medical_history_data",
                column: "visit_id");

            migrationBuilder.CreateIndex(
                name: "ix_medication_data_active_ingredient_id",
                table: "medication_data",
                column: "active_ingredient_id");

            migrationBuilder.CreateIndex(
                name: "ix_medication_data_assigned_doctor_id",
                table: "medication_data",
                column: "assigned_doctor_id");

            migrationBuilder.CreateIndex(
                name: "ix_medication_data_atc_id",
                table: "medication_data",
                column: "atc_id");

            migrationBuilder.CreateIndex(
                name: "ix_medication_data_duration_of_treatment_unit_id",
                table: "medication_data",
                column: "duration_of_treatment_unit_id");

            migrationBuilder.CreateIndex(
                name: "ix_medication_data_episode_care_id",
                table: "medication_data",
                column: "episode_care_id");

            migrationBuilder.CreateIndex(
                name: "ix_medication_data_frequency_of_intake_unit_id",
                table: "medication_data",
                column: "frequency_of_intake_unit_id");

            migrationBuilder.CreateIndex(
                name: "ix_medication_data_package_id",
                table: "medication_data",
                column: "package_id");

            migrationBuilder.CreateIndex(
                name: "ix_medication_data_patient_id",
                table: "medication_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_medication_data_problem_id",
                table: "medication_data",
                column: "problem_id");

            migrationBuilder.CreateIndex(
                name: "ix_medication_data_product_id",
                table: "medication_data",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "ix_medication_data_profession_id",
                table: "medication_data",
                column: "profession_id");

            migrationBuilder.CreateIndex(
                name: "ix_medication_data_quantity_unit_id",
                table: "medication_data",
                column: "quantity_unit_id");

            migrationBuilder.CreateIndex(
                name: "ix_medication_data_replacement_id",
                table: "medication_data",
                column: "replacement_id");

            migrationBuilder.CreateIndex(
                name: "ix_medication_data_route_of_administration_id",
                table: "medication_data",
                column: "route_of_administration_id");

            migrationBuilder.CreateIndex(
                name: "ix_medication_data_tenant_id",
                table: "medication_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_medication_data_user_id",
                table: "medication_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_medication_data_visit_id",
                table: "medication_data",
                column: "visit_id");

            migrationBuilder.CreateIndex(
                name: "ix_medication_unknown_data_episode_care_id",
                table: "medication_unknown_data",
                column: "episode_care_id");

            migrationBuilder.CreateIndex(
                name: "ix_medication_unknown_data_medication_id",
                table: "medication_unknown_data",
                column: "medication_id");

            migrationBuilder.CreateIndex(
                name: "ix_medication_unknown_data_patient_id",
                table: "medication_unknown_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_medication_unknown_data_tenant_id",
                table: "medication_unknown_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_medication_unknown_data_user_id",
                table: "medication_unknown_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_medication_unknown_data_visit_id",
                table: "medication_unknown_data",
                column: "visit_id");

            migrationBuilder.CreateIndex(
                name: "ix_module_relationships_child_module_id",
                table: "module_relationships",
                column: "child_module_id");

            migrationBuilder.CreateIndex(
                name: "ix_module_relationships_parent_module_id",
                table: "module_relationships",
                column: "parent_module_id");

            migrationBuilder.CreateIndex(
                name: "ix_module_roles_module_id",
                table: "module_roles",
                column: "module_id");

            migrationBuilder.CreateIndex(
                name: "ix_neck_size_data_episode_care_id",
                table: "neck_size_data",
                column: "episode_care_id");

            migrationBuilder.CreateIndex(
                name: "ix_neck_size_data_patient_id",
                table: "neck_size_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_neck_size_data_tenant_id",
                table: "neck_size_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_neck_size_data_user_id",
                table: "neck_size_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_neck_size_data_visit_id",
                table: "neck_size_data",
                column: "visit_id");

            migrationBuilder.CreateIndex(
                name: "ix_package_modules_module_id",
                table: "package_modules",
                column: "module_id");

            migrationBuilder.CreateIndex(
                name: "ix_patient_closest_relatives_translation_id",
                table: "patient_closest_relatives",
                column: "translation_id");

            migrationBuilder.CreateIndex(
                name: "ix_patient_doctors_doctor_id",
                table: "patient_doctors",
                column: "doctor_id");

            migrationBuilder.CreateIndex(
                name: "ix_patient_documents_data_document_country_issued_id",
                table: "patient_documents_data",
                column: "document_country_issued_id");

            migrationBuilder.CreateIndex(
                name: "ix_patient_documents_data_document_type_id",
                table: "patient_documents_data",
                column: "document_type_id");

            migrationBuilder.CreateIndex(
                name: "ix_patient_documents_data_patient_id",
                table: "patient_documents_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_patient_education_level_translation_id",
                table: "patient_education_level",
                column: "translation_id");

            migrationBuilder.CreateIndex(
                name: "ix_patient_emergency_contacts_data_address_data_id",
                table: "patient_emergency_contacts_data",
                column: "address_data_id");

            migrationBuilder.CreateIndex(
                name: "ix_patient_emergency_contacts_data_closest_relative_id",
                table: "patient_emergency_contacts_data",
                column: "closest_relative_id");

            migrationBuilder.CreateIndex(
                name: "ix_patient_emergency_contacts_data_document_country_issued_id",
                table: "patient_emergency_contacts_data",
                column: "document_country_issued_id");

            migrationBuilder.CreateIndex(
                name: "ix_patient_emergency_contacts_data_document_type_id",
                table: "patient_emergency_contacts_data",
                column: "document_type_id");

            migrationBuilder.CreateIndex(
                name: "ix_patient_emergency_contacts_data_patient_id",
                table: "patient_emergency_contacts_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_patient_external_doctor_data_external_doctor_id",
                table: "patient_external_doctor_data",
                column: "external_doctor_id");

            migrationBuilder.CreateIndex(
                name: "ix_patient_external_doctors_cyma_data_external_doctor_cyma_id",
                table: "patient_external_doctors_cyma_data",
                column: "external_doctor_cyma_id");

            migrationBuilder.CreateIndex(
                name: "ix_patient_family_status_translation_id",
                table: "patient_family_status",
                column: "translation_id");

            migrationBuilder.CreateIndex(
                name: "ix_patient_file_type_translation_id",
                table: "patient_file_type",
                column: "translation_id");

            migrationBuilder.CreateIndex(
                name: "ix_patient_files_data_file_type_id",
                table: "patient_files_data",
                column: "file_type_id");

            migrationBuilder.CreateIndex(
                name: "ix_patient_files_data_patient_id",
                table: "patient_files_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_patient_files_data_tenant_id",
                table: "patient_files_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_patient_files_data_user_id",
                table: "patient_files_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_patient_immobility_status_translation_id",
                table: "patient_immobility_status",
                column: "translation_id");

            migrationBuilder.CreateIndex(
                name: "ix_patient_insurance_country_id",
                table: "patient_insurance",
                column: "country_id");

            migrationBuilder.CreateIndex(
                name: "ix_patient_insurances_data_insurance_id",
                table: "patient_insurances_data",
                column: "insurance_id");

            migrationBuilder.CreateIndex(
                name: "ix_patient_registration_history_data_patient_id",
                table: "patient_registration_history_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_patient_registration_history_data_registration_status_id",
                table: "patient_registration_history_data",
                column: "registration_status_id");

            migrationBuilder.CreateIndex(
                name: "ix_patient_registration_history_data_rejection_reason_id",
                table: "patient_registration_history_data",
                column: "rejection_reason_id");

            migrationBuilder.CreateIndex(
                name: "ix_patient_registration_history_data_tenant_id",
                table: "patient_registration_history_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_patient_registration_history_data_user_id",
                table: "patient_registration_history_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_patient_registration_status_translation_id",
                table: "patient_registration_status",
                column: "translation_id");

            migrationBuilder.CreateIndex(
                name: "ix_patient_rejection_reason_tenant_tenant_id",
                table: "patient_rejection_reason_tenant",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_patient_rejection_reasons_translation_id",
                table: "patient_rejection_reasons",
                column: "translation_id");

            migrationBuilder.CreateIndex(
                name: "ix_patient_religion_translation_id",
                table: "patient_religion",
                column: "translation_id");

            migrationBuilder.CreateIndex(
                name: "ix_patient_source_of_income_translation_id",
                table: "patient_source_of_income",
                column: "translation_id");

            migrationBuilder.CreateIndex(
                name: "ix_patients_address_data_id",
                table: "patients",
                column: "address_data_id");

            migrationBuilder.CreateIndex(
                name: "ix_patients_blood_type_id",
                table: "patients",
                column: "blood_type_id");

            migrationBuilder.CreateIndex(
                name: "ix_patients_closest_relatives_id",
                table: "patients",
                column: "closest_relatives_id");

            migrationBuilder.CreateIndex(
                name: "ix_patients_education_level_id",
                table: "patients",
                column: "education_level_id");

            migrationBuilder.CreateIndex(
                name: "ix_patients_family_status_id",
                table: "patients",
                column: "family_status_id");

            migrationBuilder.CreateIndex(
                name: "ix_patients_gender_id",
                table: "patients",
                column: "gender_id");

            migrationBuilder.CreateIndex(
                name: "ix_patients_immobility_status_id",
                table: "patients",
                column: "immobility_status_id");

            migrationBuilder.CreateIndex(
                name: "ix_patients_place_of_birth_id",
                table: "patients",
                column: "place_of_birth_id");

            migrationBuilder.CreateIndex(
                name: "ix_patients_registration_agent_id",
                table: "patients",
                column: "registration_agent_id");

            migrationBuilder.CreateIndex(
                name: "ix_patients_registration_status_id",
                table: "patients",
                column: "registration_status_id");

            migrationBuilder.CreateIndex(
                name: "ix_patients_religion_id",
                table: "patients",
                column: "religion_id");

            migrationBuilder.CreateIndex(
                name: "ix_patients_source_of_income_id",
                table: "patients",
                column: "source_of_income_id");

            migrationBuilder.CreateIndex(
                name: "ix_patients_tenant_id",
                table: "patients",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_patients_user_id",
                table: "patients",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_pdqv3patient_identifiers_pdqv3patients_id",
                table: "pdqv3patient_identifiers",
                column: "pdqv3patients_id");

            migrationBuilder.CreateIndex(
                name: "ix_pharm_activesubstancelists_pharm_activesubstance_id",
                table: "pharm_activesubstancelists",
                column: "pharm_activesubstance_id");

            migrationBuilder.CreateIndex(
                name: "ix_pharm_atclists_pharm_atc_id",
                table: "pharm_atclists",
                column: "pharm_atc_id");

            migrationBuilder.CreateIndex(
                name: "ix_pharm_formlists_pharm_form_id",
                table: "pharm_formlists",
                column: "pharm_form_id");

            migrationBuilder.CreateIndex(
                name: "ix_pharm_packagesizeunitlists_pharm_packagesizeunit_id",
                table: "pharm_packagesizeunitlists",
                column: "pharm_packagesizeunit_id");

            migrationBuilder.CreateIndex(
                name: "ix_pharm_routelists_pharm_route_id",
                table: "pharm_routelists",
                column: "pharm_route_id");

            migrationBuilder.CreateIndex(
                name: "ix_pregnancy_history_data_episode_care_id",
                table: "pregnancy_history_data",
                column: "episode_care_id");

            migrationBuilder.CreateIndex(
                name: "ix_pregnancy_history_data_patient_id",
                table: "pregnancy_history_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_pregnancy_history_data_tenant_id",
                table: "pregnancy_history_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_pregnancy_history_data_user_id",
                table: "pregnancy_history_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_pregnancy_history_data_visit_id",
                table: "pregnancy_history_data",
                column: "visit_id");

            migrationBuilder.CreateIndex(
                name: "ix_pregnancy_outcome_data_episode_care_id",
                table: "pregnancy_outcome_data",
                column: "episode_care_id");

            migrationBuilder.CreateIndex(
                name: "ix_pregnancy_outcome_data_outcome_id",
                table: "pregnancy_outcome_data",
                column: "outcome_id");

            migrationBuilder.CreateIndex(
                name: "ix_pregnancy_outcome_data_patient_id",
                table: "pregnancy_outcome_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_pregnancy_outcome_data_tenant_id",
                table: "pregnancy_outcome_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_pregnancy_outcome_data_user_id",
                table: "pregnancy_outcome_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_pregnancy_outcome_data_visit_id",
                table: "pregnancy_outcome_data",
                column: "visit_id");

            migrationBuilder.CreateIndex(
                name: "ix_pregnancy_status_data_episode_care_id",
                table: "pregnancy_status_data",
                column: "episode_care_id");

            migrationBuilder.CreateIndex(
                name: "ix_pregnancy_status_data_patient_id",
                table: "pregnancy_status_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_pregnancy_status_data_pregnancy_estimated_id",
                table: "pregnancy_status_data",
                column: "pregnancy_estimated_id");

            migrationBuilder.CreateIndex(
                name: "ix_pregnancy_status_data_status_id",
                table: "pregnancy_status_data",
                column: "status_id");

            migrationBuilder.CreateIndex(
                name: "ix_pregnancy_status_data_tenant_id",
                table: "pregnancy_status_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_pregnancy_status_data_user_id",
                table: "pregnancy_status_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_pregnancy_status_data_visit_id",
                table: "pregnancy_status_data",
                column: "visit_id");

            migrationBuilder.CreateIndex(
                name: "ix_problem_data_diagnosis_assertion_id",
                table: "problem_data",
                column: "diagnosis_assertion_id");

            migrationBuilder.CreateIndex(
                name: "ix_problem_data_episode_care_id",
                table: "problem_data",
                column: "episode_care_id");

            migrationBuilder.CreateIndex(
                name: "ix_problem_data_illness_and_disorder_id",
                table: "problem_data",
                column: "illness_and_disorder_id");

            migrationBuilder.CreateIndex(
                name: "ix_problem_data_patient_id",
                table: "problem_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_problem_data_problem_id",
                table: "problem_data",
                column: "problem_id");

            migrationBuilder.CreateIndex(
                name: "ix_problem_data_rare_disease_id",
                table: "problem_data",
                column: "rare_disease_id");

            migrationBuilder.CreateIndex(
                name: "ix_problem_data_status_code_id",
                table: "problem_data",
                column: "status_code_id");

            migrationBuilder.CreateIndex(
                name: "ix_problem_data_tenant_id",
                table: "problem_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_problem_data_user_id",
                table: "problem_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_problem_data_visit_id",
                table: "problem_data",
                column: "visit_id");

            migrationBuilder.CreateIndex(
                name: "ix_problem_unknown_data_episode_care_id",
                table: "problem_unknown_data",
                column: "episode_care_id");

            migrationBuilder.CreateIndex(
                name: "ix_problem_unknown_data_patient_id",
                table: "problem_unknown_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_problem_unknown_data_problem_id",
                table: "problem_unknown_data",
                column: "problem_id");

            migrationBuilder.CreateIndex(
                name: "ix_problem_unknown_data_tenant_id",
                table: "problem_unknown_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_problem_unknown_data_user_id",
                table: "problem_unknown_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_problem_unknown_data_visit_id",
                table: "problem_unknown_data",
                column: "visit_id");

            migrationBuilder.CreateIndex(
                name: "ix_procedure_data_episode_care_id",
                table: "procedure_data",
                column: "episode_care_id");

            migrationBuilder.CreateIndex(
                name: "ix_procedure_data_patient_id",
                table: "procedure_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_procedure_data_procedure_id",
                table: "procedure_data",
                column: "procedure_id");

            migrationBuilder.CreateIndex(
                name: "ix_procedure_data_tenant_id",
                table: "procedure_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_procedure_data_user_id",
                table: "procedure_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_procedure_data_visit_id",
                table: "procedure_data",
                column: "visit_id");

            migrationBuilder.CreateIndex(
                name: "ix_procedure_unknown_data_episode_care_id",
                table: "procedure_unknown_data",
                column: "episode_care_id");

            migrationBuilder.CreateIndex(
                name: "ix_procedure_unknown_data_patient_id",
                table: "procedure_unknown_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_procedure_unknown_data_procedure_id",
                table: "procedure_unknown_data",
                column: "procedure_id");

            migrationBuilder.CreateIndex(
                name: "ix_procedure_unknown_data_tenant_id",
                table: "procedure_unknown_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_procedure_unknown_data_user_id",
                table: "procedure_unknown_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_procedure_unknown_data_visit_id",
                table: "procedure_unknown_data",
                column: "visit_id");

            migrationBuilder.CreateIndex(
                name: "ix_question_pages_questionnaire_template_id",
                schema: "quest",
                table: "question_pages",
                column: "questionnaire_template_id");

            migrationBuilder.CreateIndex(
                name: "ix_question_pages_title_translation_id",
                schema: "quest",
                table: "question_pages",
                column: "title_translation_id");

            migrationBuilder.CreateIndex(
                name: "ix_question_template_values_question_template_id",
                schema: "quest",
                table: "question_template_values",
                column: "question_template_id");

            migrationBuilder.CreateIndex(
                name: "ix_question_template_values_translation_id",
                schema: "quest",
                table: "question_template_values",
                column: "translation_id");

            migrationBuilder.CreateIndex(
                name: "ix_question_templates_description_translation_id",
                schema: "quest",
                table: "question_templates",
                column: "description_translation_id");

            migrationBuilder.CreateIndex(
                name: "ix_question_templates_question_page_id",
                schema: "quest",
                table: "question_templates",
                column: "question_page_id");

            migrationBuilder.CreateIndex(
                name: "ix_question_templates_question_type_id",
                schema: "quest",
                table: "question_templates",
                column: "question_type_id");

            migrationBuilder.CreateIndex(
                name: "ix_question_templates_questionnaire_template_id",
                schema: "quest",
                table: "question_templates",
                column: "questionnaire_template_id");

            migrationBuilder.CreateIndex(
                name: "ix_question_templates_title_translation_id",
                schema: "quest",
                table: "question_templates",
                column: "title_translation_id");

            migrationBuilder.CreateIndex(
                name: "ix_questionnaire_data_episode_care_id",
                table: "questionnaire_data",
                column: "episode_care_id");

            migrationBuilder.CreateIndex(
                name: "ix_questionnaire_data_patient_id",
                table: "questionnaire_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_questionnaire_data_tenant_id",
                table: "questionnaire_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_questionnaire_data_user_id",
                table: "questionnaire_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_questionnaire_data_visit_id",
                table: "questionnaire_data",
                column: "visit_id");

            migrationBuilder.CreateIndex(
                name: "ix_respiratory_clinical_examination_data_episode_care_id",
                table: "respiratory_clinical_examination_data",
                column: "episode_care_id");

            migrationBuilder.CreateIndex(
                name: "ix_respiratory_clinical_examination_data_patient_id",
                table: "respiratory_clinical_examination_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_respiratory_clinical_examination_data_tenant_id",
                table: "respiratory_clinical_examination_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_respiratory_clinical_examination_data_user_id",
                table: "respiratory_clinical_examination_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_respiratory_clinical_examination_data_visit_id",
                table: "respiratory_clinical_examination_data",
                column: "visit_id");

            migrationBuilder.CreateIndex(
                name: "ix_respiratory_clinical_examination_data_items_respiratory_cli",
                table: "respiratory_clinical_examination_data_items",
                column: "respiratory_clinical_examination_id");

            migrationBuilder.CreateIndex(
                name: "ix_role_permissions_permission_id",
                table: "role_permissions",
                column: "permission_id");

            migrationBuilder.CreateIndex(
                name: "ix_self_report_body_part_self_report_data_id",
                table: "self_report_body_part",
                column: "self_report_data_id");

            migrationBuilder.CreateIndex(
                name: "ix_self_report_data_medication_frequency_id",
                table: "self_report_data",
                column: "medication_frequency_id");

            migrationBuilder.CreateIndex(
                name: "ix_self_report_data_pain_level_id",
                table: "self_report_data",
                column: "pain_level_id");

            migrationBuilder.CreateIndex(
                name: "ix_self_report_data_patient_id",
                table: "self_report_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_self_report_data_tenant_id",
                table: "self_report_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_self_report_symptoms_self_report_data_id",
                table: "self_report_symptoms",
                column: "self_report_data_id");

            migrationBuilder.CreateIndex(
                name: "ix_self_report_symptoms_symptom_lookup_id",
                table: "self_report_symptoms",
                column: "symptom_lookup_id");

            migrationBuilder.CreateIndex(
                name: "ix_self_report_time_of_day_self_report_data_id",
                table: "self_report_time_of_day",
                column: "self_report_data_id");

            migrationBuilder.CreateIndex(
                name: "ix_self_report_time_of_day_time_of_day_lookup_id",
                table: "self_report_time_of_day",
                column: "time_of_day_lookup_id");

            migrationBuilder.CreateIndex(
                name: "ix_social_history_data_custom_timing_unit_id",
                table: "social_history_data",
                column: "custom_timing_unit_id");

            migrationBuilder.CreateIndex(
                name: "ix_social_history_data_episode_care_id",
                table: "social_history_data",
                column: "episode_care_id");

            migrationBuilder.CreateIndex(
                name: "ix_social_history_data_patient_id",
                table: "social_history_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_social_history_data_social_history_id",
                table: "social_history_data",
                column: "social_history_id");

            migrationBuilder.CreateIndex(
                name: "ix_social_history_data_tenant_id",
                table: "social_history_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_social_history_data_user_id",
                table: "social_history_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_social_history_data_visit_id",
                table: "social_history_data",
                column: "visit_id");

            migrationBuilder.CreateIndex(
                name: "ix_tenant_departments_department_id",
                table: "tenant_departments",
                column: "department_id");

            migrationBuilder.CreateIndex(
                name: "ix_tenant_packages_package_id",
                table: "tenant_packages",
                column: "package_id");

            migrationBuilder.CreateIndex(
                name: "ix_tenant_settings_address_data_id",
                table: "tenant_settings",
                column: "address_data_id");

            migrationBuilder.CreateIndex(
                name: "ix_tenant_settings_tenant_id",
                table: "tenant_settings",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_tenant_settings_user_id",
                table: "tenant_settings",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_tracheostomy_ct_parameters_data_episode_care_id",
                table: "tracheostomy_ct_parameters_data",
                column: "episode_care_id");

            migrationBuilder.CreateIndex(
                name: "ix_tracheostomy_ct_parameters_data_patient_id",
                table: "tracheostomy_ct_parameters_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_tracheostomy_ct_parameters_data_tenant_id",
                table: "tracheostomy_ct_parameters_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_tracheostomy_ct_parameters_data_user_id",
                table: "tracheostomy_ct_parameters_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_tracheostomy_ct_parameters_data_visit_id",
                table: "tracheostomy_ct_parameters_data",
                column: "visit_id");

            migrationBuilder.CreateIndex(
                name: "ix_tracheostomy_tube_characteristics_data_consistency_of_tube_",
                table: "tracheostomy_tube_characteristics_data",
                column: "consistency_of_tube_id");

            migrationBuilder.CreateIndex(
                name: "ix_tracheostomy_tube_characteristics_data_cuff_diameter_id",
                table: "tracheostomy_tube_characteristics_data",
                column: "cuff_diameter_id");

            migrationBuilder.CreateIndex(
                name: "ix_tracheostomy_tube_characteristics_data_episode_care_id",
                table: "tracheostomy_tube_characteristics_data",
                column: "episode_care_id");

            migrationBuilder.CreateIndex(
                name: "ix_tracheostomy_tube_characteristics_data_inner_diameter_id",
                table: "tracheostomy_tube_characteristics_data",
                column: "inner_diameter_id");

            migrationBuilder.CreateIndex(
                name: "ix_tracheostomy_tube_characteristics_data_outer_diameter_id",
                table: "tracheostomy_tube_characteristics_data",
                column: "outer_diameter_id");

            migrationBuilder.CreateIndex(
                name: "ix_tracheostomy_tube_characteristics_data_patient_id",
                table: "tracheostomy_tube_characteristics_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_tracheostomy_tube_characteristics_data_tenant_id",
                table: "tracheostomy_tube_characteristics_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_tracheostomy_tube_characteristics_data_tube_length_id",
                table: "tracheostomy_tube_characteristics_data",
                column: "tube_length_id");

            migrationBuilder.CreateIndex(
                name: "ix_tracheostomy_tube_characteristics_data_tube_type_id",
                table: "tracheostomy_tube_characteristics_data",
                column: "tube_type_id");

            migrationBuilder.CreateIndex(
                name: "ix_tracheostomy_tube_characteristics_data_user_id",
                table: "tracheostomy_tube_characteristics_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_tracheostomy_tube_characteristics_data_visit_id",
                table: "tracheostomy_tube_characteristics_data",
                column: "visit_id");

            migrationBuilder.CreateIndex(
                name: "ix_tracheostomy_tube_inspection_data_episode_care_id",
                table: "tracheostomy_tube_inspection_data",
                column: "episode_care_id");

            migrationBuilder.CreateIndex(
                name: "ix_tracheostomy_tube_inspection_data_patient_id",
                table: "tracheostomy_tube_inspection_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_tracheostomy_tube_inspection_data_tenant_id",
                table: "tracheostomy_tube_inspection_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_tracheostomy_tube_inspection_data_user_id",
                table: "tracheostomy_tube_inspection_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_tracheostomy_tube_inspection_data_visit_id",
                table: "tracheostomy_tube_inspection_data",
                column: "visit_id");

            migrationBuilder.CreateIndex(
                name: "ix_tracheostomy_tube_inspection_data_items_tracheostomy_tube_i",
                table: "tracheostomy_tube_inspection_data_items",
                column: "tracheostomy_tube_inspection_id");

            migrationBuilder.CreateIndex(
                name: "ix_travel_history_data_country_id",
                table: "travel_history_data",
                column: "country_id");

            migrationBuilder.CreateIndex(
                name: "ix_travel_history_data_episode_care_id",
                table: "travel_history_data",
                column: "episode_care_id");

            migrationBuilder.CreateIndex(
                name: "ix_travel_history_data_patient_id",
                table: "travel_history_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_travel_history_data_tenant_id",
                table: "travel_history_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_travel_history_data_user_id",
                table: "travel_history_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_travel_history_data_visit_id",
                table: "travel_history_data",
                column: "visit_id");

            migrationBuilder.CreateIndex(
                name: "ix_user_permissions_permission_id",
                table: "user_permissions",
                column: "permission_id");

            migrationBuilder.CreateIndex(
                name: "ix_user_roles_role_id",
                table: "user_roles",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "ix_vaccination_data_administering_center_id",
                table: "vaccination_data",
                column: "administering_center_id");

            migrationBuilder.CreateIndex(
                name: "ix_vaccination_data_country_id",
                table: "vaccination_data",
                column: "country_id");

            migrationBuilder.CreateIndex(
                name: "ix_vaccination_data_disease_targeted_id",
                table: "vaccination_data",
                column: "disease_targeted_id");

            migrationBuilder.CreateIndex(
                name: "ix_vaccination_data_doctor_id",
                table: "vaccination_data",
                column: "doctor_id");

            migrationBuilder.CreateIndex(
                name: "ix_vaccination_data_episode_care_id",
                table: "vaccination_data",
                column: "episode_care_id");

            migrationBuilder.CreateIndex(
                name: "ix_vaccination_data_patient_id",
                table: "vaccination_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_vaccination_data_tenant_id",
                table: "vaccination_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_vaccination_data_user_id",
                table: "vaccination_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_vaccination_data_vaccine_id",
                table: "vaccination_data",
                column: "vaccine_id");

            migrationBuilder.CreateIndex(
                name: "ix_vaccination_data_visit_id",
                table: "vaccination_data",
                column: "visit_id");

            migrationBuilder.CreateIndex(
                name: "ix_visits_doctor_id",
                table: "visits",
                column: "doctor_id");

            migrationBuilder.CreateIndex(
                name: "ix_visits_episode_care_id",
                table: "visits",
                column: "episode_care_id");

            migrationBuilder.CreateIndex(
                name: "ix_visits_potential_diagnosis_id",
                table: "visits",
                column: "potential_diagnosis_id");

            migrationBuilder.CreateIndex(
                name: "ix_vital_sign_data_episode_care_id",
                table: "vital_sign_data",
                column: "episode_care_id");

            migrationBuilder.CreateIndex(
                name: "ix_vital_sign_data_patient_id",
                table: "vital_sign_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_vital_sign_data_tenant_id",
                table: "vital_sign_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_vital_sign_data_user_id",
                table: "vital_sign_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_vital_sign_data_visit_id",
                table: "vital_sign_data",
                column: "visit_id");

            migrationBuilder.CreateIndex(
                name: "ix_weight_data_episode_care_id",
                table: "weight_data",
                column: "episode_care_id");

            migrationBuilder.CreateIndex(
                name: "ix_weight_data_patient_id",
                table: "weight_data",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "ix_weight_data_tenant_id",
                table: "weight_data",
                column: "tenant_id");

            migrationBuilder.CreateIndex(
                name: "ix_weight_data_user_id",
                table: "weight_data",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_weight_data_visit_id",
                table: "weight_data",
                column: "visit_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "accommodation_data_history_items");

            migrationBuilder.DropTable(
                name: "addresses");

            migrationBuilder.DropTable(
                name: "admission_reason_tenants");

            migrationBuilder.DropTable(
                name: "allergy_reactions");

            migrationBuilder.DropTable(
                name: "allergy_unknown_data");

            migrationBuilder.DropTable(
                name: "answer",
                schema: "quest");

            migrationBuilder.DropTable(
                name: "appointment_participant_data");

            migrationBuilder.DropTable(
                name: "appointment_patient_data");

            migrationBuilder.DropTable(
                name: "appointment_slot_data");

            migrationBuilder.DropTable(
                name: "arterial_blood_gas_data");

            migrationBuilder.DropTable(
                name: "capnography_data");

            migrationBuilder.DropTable(
                name: "care_plan_data");

            migrationBuilder.DropTable(
                name: "comorbidity_data");

            migrationBuilder.DropTable(
                name: "complication_data");

            migrationBuilder.DropTable(
                name: "definitions");

            migrationBuilder.DropTable(
                name: "dietary_habits_data");

            migrationBuilder.DropTable(
                name: "discharge_data");

            migrationBuilder.DropTable(
                name: "ehdsi_active_ingredient");

            migrationBuilder.DropTable(
                name: "ehdsi_allergen_no_drug");

            migrationBuilder.DropTable(
                name: "ehdsi_blood_pressure");

            migrationBuilder.DropTable(
                name: "ehdsi_confidentiality");

            migrationBuilder.DropTable(
                name: "ehdsi_display_label");

            migrationBuilder.DropTable(
                name: "ehdsi_document_code");

            migrationBuilder.DropTable(
                name: "ehdsi_dose_form");

            migrationBuilder.DropTable(
                name: "ehdsi_hospital_discharge_report_type");

            migrationBuilder.DropTable(
                name: "ehdsi_laboratory_report_type");

            migrationBuilder.DropTable(
                name: "ehdsi_language");

            migrationBuilder.DropTable(
                name: "ehdsi_medical_images_type");

            migrationBuilder.DropTable(
                name: "ehdsi_medical_imaging_report_type");

            migrationBuilder.DropTable(
                name: "ehdsi_null_flavor");

            migrationBuilder.DropTable(
                name: "ehdsi_package");

            migrationBuilder.DropTable(
                name: "ehdsi_personal_relationship");

            migrationBuilder.DropTable(
                name: "ehdsi_quantity_unit");

            migrationBuilder.DropTable(
                name: "ehdsi_resolution_outcome");

            migrationBuilder.DropTable(
                name: "ehdsi_role_class");

            migrationBuilder.DropTable(
                name: "ehdsi_routeof_administration");

            migrationBuilder.DropTable(
                name: "ehdsi_section");

            migrationBuilder.DropTable(
                name: "ehdsi_substance");

            migrationBuilder.DropTable(
                name: "ehdsi_substitution_code");

            migrationBuilder.DropTable(
                name: "ehdsi_telecom_address");

            migrationBuilder.DropTable(
                name: "ehdsi_timing_event");

            migrationBuilder.DropTable(
                name: "etiology_data");

            migrationBuilder.DropTable(
                name: "external_doctors_specialties_link");

            migrationBuilder.DropTable(
                name: "food_data");

            migrationBuilder.DropTable(
                name: "glasgow_data");

            migrationBuilder.DropTable(
                name: "glucose_data");

            migrationBuilder.DropTable(
                name: "hysteroscopy_anatomical_sub_position");

            migrationBuilder.DropTable(
                name: "hysteroscopy_file_data");

            migrationBuilder.DropTable(
                name: "imaging_prediction_data");

            migrationBuilder.DropTable(
                name: "ips_cda_data");

            migrationBuilder.DropTable(
                name: "laboratory_data_items");

            migrationBuilder.DropTable(
                name: "laboratory_files_data");

            migrationBuilder.DropTable(
                name: "laboratory_group_laboratory");

            migrationBuilder.DropTable(
                name: "laboratory_group_tenant");

            migrationBuilder.DropTable(
                name: "locale");

            migrationBuilder.DropTable(
                name: "medical_alert_data");

            migrationBuilder.DropTable(
                name: "medical_device_unknown_data");

            migrationBuilder.DropTable(
                name: "medical_devices_data");

            migrationBuilder.DropTable(
                name: "medical_history_data");

            migrationBuilder.DropTable(
                name: "medication_data");

            migrationBuilder.DropTable(
                name: "medication_unknown_data");

            migrationBuilder.DropTable(
                name: "module_relationships");

            migrationBuilder.DropTable(
                name: "module_roles");

            migrationBuilder.DropTable(
                name: "neck_size_data");

            migrationBuilder.DropTable(
                name: "package_modules");

            migrationBuilder.DropTable(
                name: "patient_doctors");

            migrationBuilder.DropTable(
                name: "patient_documents_data");

            migrationBuilder.DropTable(
                name: "patient_emergency_contacts_data");

            migrationBuilder.DropTable(
                name: "patient_external_doctor_data");

            migrationBuilder.DropTable(
                name: "patient_external_doctors_cyma_data");

            migrationBuilder.DropTable(
                name: "patient_files_data");

            migrationBuilder.DropTable(
                name: "patient_insurances_data");

            migrationBuilder.DropTable(
                name: "patient_registration_history_data");

            migrationBuilder.DropTable(
                name: "patient_rejection_reason_tenant");

            migrationBuilder.DropTable(
                name: "pdqv3patient_identifiers");

            migrationBuilder.DropTable(
                name: "pharm_activesubstancelists");

            migrationBuilder.DropTable(
                name: "pharm_atclists");

            migrationBuilder.DropTable(
                name: "pharm_dose_form_mappings");

            migrationBuilder.DropTable(
                name: "pharm_formlists");

            migrationBuilder.DropTable(
                name: "pharm_packagesizeunitlists");

            migrationBuilder.DropTable(
                name: "pharm_quantityunits");

            migrationBuilder.DropTable(
                name: "pharm_routelists");

            migrationBuilder.DropTable(
                name: "pregnancy_history_data");

            migrationBuilder.DropTable(
                name: "pregnancy_outcome_data");

            migrationBuilder.DropTable(
                name: "pregnancy_status_data");

            migrationBuilder.DropTable(
                name: "problem_unknown_data");

            migrationBuilder.DropTable(
                name: "procedure_data");

            migrationBuilder.DropTable(
                name: "procedure_unknown_data");

            migrationBuilder.DropTable(
                name: "question_template_values",
                schema: "quest");

            migrationBuilder.DropTable(
                name: "questionnaire_data");

            migrationBuilder.DropTable(
                name: "regions");

            migrationBuilder.DropTable(
                name: "respiratory_clinical_examination_data_items");

            migrationBuilder.DropTable(
                name: "role_permissions");

            migrationBuilder.DropTable(
                name: "self_report_body_part");

            migrationBuilder.DropTable(
                name: "self_report_symptoms");

            migrationBuilder.DropTable(
                name: "self_report_time_of_day");

            migrationBuilder.DropTable(
                name: "smart_health_links");

            migrationBuilder.DropTable(
                name: "social_history_data");

            migrationBuilder.DropTable(
                name: "tenant_departments");

            migrationBuilder.DropTable(
                name: "tenant_packages");

            migrationBuilder.DropTable(
                name: "tracheostomy_ct_parameters_data");

            migrationBuilder.DropTable(
                name: "tracheostomy_tube_characteristics_data");

            migrationBuilder.DropTable(
                name: "tracheostomy_tube_inspection_data_items");

            migrationBuilder.DropTable(
                name: "travel_history_data");

            migrationBuilder.DropTable(
                name: "user_permissions");

            migrationBuilder.DropTable(
                name: "user_roles");

            migrationBuilder.DropTable(
                name: "vaccination_data");

            migrationBuilder.DropTable(
                name: "vital_sign_data");

            migrationBuilder.DropTable(
                name: "weight_data");

            migrationBuilder.DropTable(
                name: "accommodation_data_history");

            migrationBuilder.DropTable(
                name: "allergy_data");

            migrationBuilder.DropTable(
                name: "ehdsi_allergy_certainty");

            migrationBuilder.DropTable(
                name: "ehdsi_reaction_allergy");

            migrationBuilder.DropTable(
                name: "ehdsi_severity");

            migrationBuilder.DropTable(
                name: "ehdsi_absent_or_unknown_allergy");

            migrationBuilder.DropTable(
                name: "answer_questionnaires",
                schema: "quest");

            migrationBuilder.DropTable(
                name: "appointment_participant_actor_data");

            migrationBuilder.DropTable(
                name: "appointment_data");

            migrationBuilder.DropTable(
                name: "complication");

            migrationBuilder.DropTable(
                name: "diet_type");

            migrationBuilder.DropTable(
                name: "discharge_situations");

            migrationBuilder.DropTable(
                name: "discharge_types");

            migrationBuilder.DropTable(
                name: "etiology");

            migrationBuilder.DropTable(
                name: "external_doctor_specialties");

            migrationBuilder.DropTable(
                name: "food_type");

            migrationBuilder.DropTable(
                name: "glasgow_eye_opening");

            migrationBuilder.DropTable(
                name: "glasgow_motor_response");

            migrationBuilder.DropTable(
                name: "glasgow_verbal_response");

            migrationBuilder.DropTable(
                name: "hysteroscopy_anatomical_position");

            migrationBuilder.DropTable(
                name: "imaging_file_paths");

            migrationBuilder.DropTable(
                name: "laboratory_data");

            migrationBuilder.DropTable(
                name: "master_exam_titles");

            migrationBuilder.DropTable(
                name: "laboratory");

            migrationBuilder.DropTable(
                name: "ehdsi_absent_or_unknown_device");

            migrationBuilder.DropTable(
                name: "ehdsi_medical_device");

            migrationBuilder.DropTable(
                name: "medical_device_actions");

            migrationBuilder.DropTable(
                name: "ehdsi_healthcare_professional_role");

            migrationBuilder.DropTable(
                name: "pharm_products");

            migrationBuilder.DropTable(
                name: "problem_data");

            migrationBuilder.DropTable(
                name: "ehdsi_absent_or_unknown_medication");

            migrationBuilder.DropTable(
                name: "module");

            migrationBuilder.DropTable(
                name: "document_types");

            migrationBuilder.DropTable(
                name: "external_doctors");

            migrationBuilder.DropTable(
                name: "external_doctors_cyma");

            migrationBuilder.DropTable(
                name: "patient_file_type");

            migrationBuilder.DropTable(
                name: "patient_insurance");

            migrationBuilder.DropTable(
                name: "patient_rejection_reasons");

            migrationBuilder.DropTable(
                name: "pdqv3patients");

            migrationBuilder.DropTable(
                name: "pharm_activesubstances");

            migrationBuilder.DropTable(
                name: "pharm_atcs");

            migrationBuilder.DropTable(
                name: "pharm_forms");

            migrationBuilder.DropTable(
                name: "pharm_packagesizeunits");

            migrationBuilder.DropTable(
                name: "pharm_routes");

            migrationBuilder.DropTable(
                name: "ehdsi_outcome_of_pregnancy");

            migrationBuilder.DropTable(
                name: "ehdsi_current_pregnancy_status");

            migrationBuilder.DropTable(
                name: "ehdsi_pregnancy_information");

            migrationBuilder.DropTable(
                name: "ehdsi_absent_or_unknown_problem");

            migrationBuilder.DropTable(
                name: "ehdsi_procedure");

            migrationBuilder.DropTable(
                name: "ehdsi_absent_or_unknown_procedure");

            migrationBuilder.DropTable(
                name: "question_templates",
                schema: "quest");

            migrationBuilder.DropTable(
                name: "respiratory_clinical_examination_data");

            migrationBuilder.DropTable(
                name: "respiratory_clinical_examination");

            migrationBuilder.DropTable(
                name: "self_report_symptom_lookup");

            migrationBuilder.DropTable(
                name: "self_report_data");

            migrationBuilder.DropTable(
                name: "self_report_time_of_day_lookup");

            migrationBuilder.DropTable(
                name: "ehdsi_social_history");

            migrationBuilder.DropTable(
                name: "master_timing_unit");

            migrationBuilder.DropTable(
                name: "departments");

            migrationBuilder.DropTable(
                name: "packages");

            migrationBuilder.DropTable(
                name: "tracheostomy_consistency_of_tubes");

            migrationBuilder.DropTable(
                name: "tracheostomy_cuff_diameters");

            migrationBuilder.DropTable(
                name: "tracheostomy_inner_diameters");

            migrationBuilder.DropTable(
                name: "tracheostomy_outer_diameters");

            migrationBuilder.DropTable(
                name: "tracheostomy_tube_lengths");

            migrationBuilder.DropTable(
                name: "tracheostomy_tube_types");

            migrationBuilder.DropTable(
                name: "tracheostomy_tube_inspection_data");

            migrationBuilder.DropTable(
                name: "tracheostomy_tube_inspection");

            migrationBuilder.DropTable(
                name: "permissions");

            migrationBuilder.DropTable(
                name: "roles");

            migrationBuilder.DropTable(
                name: "ehdsi_vaccine");

            migrationBuilder.DropTable(
                name: "tenant_settings");

            migrationBuilder.DropTable(
                name: "accommodation_data");

            migrationBuilder.DropTable(
                name: "ehdsi_adverse_event_type");

            migrationBuilder.DropTable(
                name: "ehdsi_allergies_custom");

            migrationBuilder.DropTable(
                name: "ehdsi_allergy_status");

            migrationBuilder.DropTable(
                name: "ehdsi_criticality");

            migrationBuilder.DropTable(
                name: "appointment_recurrent_type");

            migrationBuilder.DropTable(
                name: "appointment_status");

            migrationBuilder.DropTable(
                name: "imaging_data");

            migrationBuilder.DropTable(
                name: "laboratory_group");

            migrationBuilder.DropTable(
                name: "ehdsi_certainty");

            migrationBuilder.DropTable(
                name: "ehdsi_code_prob");

            migrationBuilder.DropTable(
                name: "ehdsi_rare_disease");

            migrationBuilder.DropTable(
                name: "ehdsi_status_code");

            migrationBuilder.DropTable(
                name: "question_pages",
                schema: "quest");

            migrationBuilder.DropTable(
                name: "question_types",
                schema: "quest");

            migrationBuilder.DropTable(
                name: "self_report_medication_frequency");

            migrationBuilder.DropTable(
                name: "self_report_pain_level");

            migrationBuilder.DropTable(
                name: "ehdsi_unit");

            migrationBuilder.DropTable(
                name: "accommodation_beds");

            migrationBuilder.DropTable(
                name: "admission_reasons");

            migrationBuilder.DropTable(
                name: "allergy_categories");

            migrationBuilder.DropTable(
                name: "appointment_status_type");

            migrationBuilder.DropTable(
                name: "master_category_modalities");

            migrationBuilder.DropTable(
                name: "visits");

            migrationBuilder.DropTable(
                name: "questionnaire_templates",
                schema: "quest");

            migrationBuilder.DropTable(
                name: "translations",
                schema: "quest");

            migrationBuilder.DropTable(
                name: "accommodation_rooms");

            migrationBuilder.DropTable(
                name: "master_categories");

            migrationBuilder.DropTable(
                name: "episode_cares");

            migrationBuilder.DropTable(
                name: "accommodation_wards");

            migrationBuilder.DropTable(
                name: "ehdsi_illnessand_disorder");

            migrationBuilder.DropTable(
                name: "patients");

            migrationBuilder.DropTable(
                name: "status");

            migrationBuilder.DropTable(
                name: "accommodation_floors");

            migrationBuilder.DropTable(
                name: "address_data");

            migrationBuilder.DropTable(
                name: "ehdsi_administrative_gender");

            migrationBuilder.DropTable(
                name: "ehdsi_blood_group");

            migrationBuilder.DropTable(
                name: "patient_closest_relatives");

            migrationBuilder.DropTable(
                name: "patient_education_level");

            migrationBuilder.DropTable(
                name: "patient_family_status");

            migrationBuilder.DropTable(
                name: "patient_immobility_status");

            migrationBuilder.DropTable(
                name: "patient_registration_status");

            migrationBuilder.DropTable(
                name: "patient_religion");

            migrationBuilder.DropTable(
                name: "patient_source_of_income");

            migrationBuilder.DropTable(
                name: "accommodation_buildings");

            migrationBuilder.DropTable(
                name: "ehdsi_country");

            migrationBuilder.DropTable(
                name: "tenant");

            migrationBuilder.DropTable(
                name: "translations");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "value_set");
        }
    }
}
