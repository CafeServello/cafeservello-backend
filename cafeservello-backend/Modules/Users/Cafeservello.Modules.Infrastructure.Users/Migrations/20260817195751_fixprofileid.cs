using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cafeservello.Modules.Infrastructure.Users.Migrations
{
    /// <inheritdoc />
    public partial class fixprofileid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Profile",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    ProfileType = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "char(36)", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "char(36)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profile", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "char(36)", nullable: false),
                    ID_PROFILE = table.Column<Guid>(type: "char(36)", nullable: false),
                    CITY = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    COMPLEMENT = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    COUNTRY = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    NEIGHBORHOOD = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    NUMBER = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    STATE = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: true),
                    STREET = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true),
                    ZIPCODE = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true),
                    CELL_PHONE = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    LANDLINE = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    PRIMARY_EMAIL = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    SECONDADARY_EMAIL = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    CPF = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    DATE_OF_BIRTH = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    GENDER = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    LAST_NAME = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    PASSWORD = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    USER_NAME = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    THEME = table.Column<int>(type: "int", nullable: true),
                    CREATED_BY = table.Column<Guid>(type: "char(36)", nullable: false),
                    UPDATED_BY = table.Column<Guid>(type: "char(36)", nullable: false),
                    CREATED_AT = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UPDATED_AT = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IS_ACTIVE = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    NAME = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    DESCRIPTION = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                    table.ForeignKey(
                        name: "FK_USER_PROFILE",
                        column: x => x.ID_PROFILE,
                        principalTable: "Profile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_User_ID_PROFILE",
                table: "User",
                column: "ID_PROFILE");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Profile");
        }
    }
}
