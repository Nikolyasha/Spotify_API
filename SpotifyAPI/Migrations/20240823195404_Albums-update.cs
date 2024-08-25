using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpotifyAPI.Migrations
{
    /// <inheritdoc />
    public partial class Albumsupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Release_Artists_ArtistId",
                table: "Release");

            migrationBuilder.DropForeignKey(
                name: "FK_Song_Release_ReleaseId",
                table: "Song");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Song",
                table: "Song");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Release",
                table: "Release");

            migrationBuilder.RenameTable(
                name: "Song",
                newName: "Songs");

            migrationBuilder.RenameTable(
                name: "Release",
                newName: "Releases");

            migrationBuilder.RenameIndex(
                name: "IX_Song_ReleaseId",
                table: "Songs",
                newName: "IX_Songs_ReleaseId");

            migrationBuilder.RenameIndex(
                name: "IX_Release_ArtistId",
                table: "Releases",
                newName: "IX_Releases_ArtistId");

            migrationBuilder.AddColumn<string>(
                name: "ReleasePreview",
                table: "Releases",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Songs",
                table: "Songs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Releases",
                table: "Releases",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Releases_Artists_ArtistId",
                table: "Releases",
                column: "ArtistId",
                principalTable: "Artists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Releases_ReleaseId",
                table: "Songs",
                column: "ReleaseId",
                principalTable: "Releases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Releases_Artists_ArtistId",
                table: "Releases");

            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Releases_ReleaseId",
                table: "Songs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Songs",
                table: "Songs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Releases",
                table: "Releases");

            migrationBuilder.DropColumn(
                name: "ReleasePreview",
                table: "Releases");

            migrationBuilder.RenameTable(
                name: "Songs",
                newName: "Song");

            migrationBuilder.RenameTable(
                name: "Releases",
                newName: "Release");

            migrationBuilder.RenameIndex(
                name: "IX_Songs_ReleaseId",
                table: "Song",
                newName: "IX_Song_ReleaseId");

            migrationBuilder.RenameIndex(
                name: "IX_Releases_ArtistId",
                table: "Release",
                newName: "IX_Release_ArtistId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Song",
                table: "Song",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Release",
                table: "Release",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Release_Artists_ArtistId",
                table: "Release",
                column: "ArtistId",
                principalTable: "Artists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Song_Release_ReleaseId",
                table: "Song",
                column: "ReleaseId",
                principalTable: "Release",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
