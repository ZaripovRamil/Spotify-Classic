using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class Updated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GenreTrack_Genre_GenresId",
                table: "GenreTrack");

            migrationBuilder.DropForeignKey(
                name: "FK_GenreTrack_Track_TracksId",
                table: "GenreTrack");

            migrationBuilder.DropForeignKey(
                name: "FK_Playlists_Track_TrackId",
                table: "Playlists");

            migrationBuilder.DropForeignKey(
                name: "FK_Track_Playlists_AlbumId",
                table: "Track");

            migrationBuilder.DropForeignKey(
                name: "FK_TrackUser_Track_HistoryId1",
                table: "TrackUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Track",
                table: "Track");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genre",
                table: "Genre");

            migrationBuilder.RenameTable(
                name: "Track",
                newName: "Tracks");

            migrationBuilder.RenameTable(
                name: "Genre",
                newName: "Genres");

            migrationBuilder.RenameIndex(
                name: "IX_Track_AlbumId",
                table: "Tracks",
                newName: "IX_Tracks_AlbumId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tracks",
                table: "Tracks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genres",
                table: "Genres",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Genres_Name",
                table: "Genres",
                column: "Name",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_GenreTrack_Genres_GenresId",
                table: "GenreTrack",
                column: "GenresId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GenreTrack_Tracks_TracksId",
                table: "GenreTrack",
                column: "TracksId",
                principalTable: "Tracks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Playlists_Tracks_TrackId",
                table: "Playlists",
                column: "TrackId",
                principalTable: "Tracks",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Playlists_AlbumId",
                table: "Tracks",
                column: "AlbumId",
                principalTable: "Playlists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrackUser_Tracks_HistoryId1",
                table: "TrackUser",
                column: "HistoryId1",
                principalTable: "Tracks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GenreTrack_Genres_GenresId",
                table: "GenreTrack");

            migrationBuilder.DropForeignKey(
                name: "FK_GenreTrack_Tracks_TracksId",
                table: "GenreTrack");

            migrationBuilder.DropForeignKey(
                name: "FK_Playlists_Tracks_TrackId",
                table: "Playlists");

            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Playlists_AlbumId",
                table: "Tracks");

            migrationBuilder.DropForeignKey(
                name: "FK_TrackUser_Tracks_HistoryId1",
                table: "TrackUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tracks",
                table: "Tracks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genres",
                table: "Genres");

            migrationBuilder.DropIndex(
                name: "IX_Genres_Name",
                table: "Genres");

            migrationBuilder.RenameTable(
                name: "Tracks",
                newName: "Track");

            migrationBuilder.RenameTable(
                name: "Genres",
                newName: "Genre");

            migrationBuilder.RenameIndex(
                name: "IX_Tracks_AlbumId",
                table: "Track",
                newName: "IX_Track_AlbumId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Track",
                table: "Track",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genre",
                table: "Genre",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GenreTrack_Genre_GenresId",
                table: "GenreTrack",
                column: "GenresId",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GenreTrack_Track_TracksId",
                table: "GenreTrack",
                column: "TracksId",
                principalTable: "Track",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Playlists_Track_TrackId",
                table: "Playlists",
                column: "TrackId",
                principalTable: "Track",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Track_Playlists_AlbumId",
                table: "Track",
                column: "AlbumId",
                principalTable: "Playlists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrackUser_Track_HistoryId1",
                table: "TrackUser",
                column: "HistoryId1",
                principalTable: "Track",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
