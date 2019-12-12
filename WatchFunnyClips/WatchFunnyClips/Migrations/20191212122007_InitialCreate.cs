using Microsoft.EntityFrameworkCore.Migrations;

namespace WatchFunnyClips.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GenreClips",
                columns: table => new
                {
                    GenreClipsId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GenreName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreClips", x => x.GenreClipsId);
                });

            migrationBuilder.CreateTable(
                name: "Clip",
                columns: table => new
                {
                    ClipId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    GenreClipsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clip", x => x.ClipId);
                    table.ForeignKey(
                        name: "FK_Clip_GenreClips_GenreClipsId",
                        column: x => x.GenreClipsId,
                        principalTable: "GenreClips",
                        principalColumn: "GenreClipsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clip_GenreClipsId",
                table: "Clip",
                column: "GenreClipsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clip");

            migrationBuilder.DropTable(
                name: "GenreClips");
        }
    }
}
