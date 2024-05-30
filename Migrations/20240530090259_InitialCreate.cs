using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RockMuseumApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Udstillinger",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Navn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Beskrivelse = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Udstillinger", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lydguides",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UdstillingId = table.Column<int>(type: "int", nullable: false),
                    Fil = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lydguides", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lydguides_Udstillinger_UdstillingId",
                        column: x => x.UdstillingId,
                        principalTable: "Udstillinger",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lydguides_UdstillingId",
                table: "Lydguides",
                column: "UdstillingId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lydguides");

            migrationBuilder.DropTable(
                name: "Udstillinger");
        }
    }
}
