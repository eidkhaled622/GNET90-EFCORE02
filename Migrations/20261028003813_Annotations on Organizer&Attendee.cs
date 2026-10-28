using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GNET90_EFCORE02.Migrations
{
    /// <inheritdoc />
    public partial class AnnotationsonOrganizerAttendee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Organizers_OrganizerID",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_organizerProfiles_Organizers_OrganizerID",
                table: "organizerProfiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Organizers",
                table: "Organizers");

            migrationBuilder.RenameTable(
                name: "Organizers",
                newName: "EventOrganizers");

            migrationBuilder.RenameColumn(
                name: "Address_ZipCode",
                table: "Attenders",
                newName: "ZIPCode");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventOrganizers",
                table: "EventOrganizers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_EventOrganizers_OrganizerID",
                table: "Events",
                column: "OrganizerID",
                principalTable: "EventOrganizers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_organizerProfiles_EventOrganizers_OrganizerID",
                table: "organizerProfiles",
                column: "OrganizerID",
                principalTable: "EventOrganizers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_EventOrganizers_OrganizerID",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_organizerProfiles_EventOrganizers_OrganizerID",
                table: "organizerProfiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EventOrganizers",
                table: "EventOrganizers");

            migrationBuilder.RenameTable(
                name: "EventOrganizers",
                newName: "Organizers");

            migrationBuilder.RenameColumn(
                name: "ZIPCode",
                table: "Attenders",
                newName: "Address_ZipCode");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Organizers",
                table: "Organizers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Organizers_OrganizerID",
                table: "Events",
                column: "OrganizerID",
                principalTable: "Organizers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_organizerProfiles_Organizers_OrganizerID",
                table: "organizerProfiles",
                column: "OrganizerID",
                principalTable: "Organizers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
