using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Vomotion.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vomotion.Domain.Entities.FlashCard",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FrontWord = table.Column<string>(type: "text", nullable: false),
                    BackWord = table.Column<string>(type: "text", nullable: false),
                    FrontSentence = table.Column<string>(type: "text", nullable: false),
                    BackSentence = table.Column<string>(type: "text", nullable: false),
                    Severity = table.Column<int>(type: "integer", nullable: false),
                    NoteId = table.Column<int>(type: "integer", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vomotion.Domain.Entities.FlashCard", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vomotion.Domain.Entities.Language",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NameEn = table.Column<string>(type: "text", nullable: false),
                    NameOriginal = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vomotion.Domain.Entities.Language", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vomotion.Domain.Entities.Note",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TitleOriginal = table.Column<string>(type: "text", nullable: false),
                    ContentOriginal = table.Column<string>(type: "text", nullable: false),
                    HighlitedPositionsOriginal = table.Column<int[]>(type: "integer[]", nullable: false),
                    TitleTranslated = table.Column<string>(type: "text", nullable: false),
                    ContentTranslated = table.Column<string>(type: "text", nullable: false),
                    HighlightedPositionsTranslated = table.Column<int[]>(type: "integer[]", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    NotebookId = table.Column<int>(type: "integer", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vomotion.Domain.Entities.Note", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vomotion.Domain.Entities.Notebook",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vomotion.Domain.Entities.Notebook", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vomotion.Domain.Entities.User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<byte[]>(type: "bytea", nullable: false),
                    Username = table.Column<string>(type: "text", nullable: false),
                    NativeLanguageId = table.Column<int>(type: "integer", nullable: false),
                    NotebookId = table.Column<int>(type: "integer", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vomotion.Domain.Entities.User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vomotion.Domain.Entities.User_Vomotion.Domain.Entities.Lang~",
                        column: x => x.NativeLanguageId,
                        principalTable: "Vomotion.Domain.Entities.Language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vomotion.Domain.Entities.User_Vomotion.Domain.Entities.Note~",
                        column: x => x.NotebookId,
                        principalTable: "Vomotion.Domain.Entities.Notebook",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vomotion.Domain.Entities.FlashCard_NoteId",
                table: "Vomotion.Domain.Entities.FlashCard",
                column: "NoteId");

            migrationBuilder.CreateIndex(
                name: "IX_Vomotion.Domain.Entities.Language_UserId",
                table: "Vomotion.Domain.Entities.Language",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Vomotion.Domain.Entities.Note_NotebookId",
                table: "Vomotion.Domain.Entities.Note",
                column: "NotebookId");

            migrationBuilder.CreateIndex(
                name: "IX_Vomotion.Domain.Entities.Note_UserId",
                table: "Vomotion.Domain.Entities.Note",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Vomotion.Domain.Entities.Notebook_UserId",
                table: "Vomotion.Domain.Entities.Notebook",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Vomotion.Domain.Entities.User_NativeLanguageId",
                table: "Vomotion.Domain.Entities.User",
                column: "NativeLanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Vomotion.Domain.Entities.User_NotebookId",
                table: "Vomotion.Domain.Entities.User",
                column: "NotebookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vomotion.Domain.Entities.FlashCard_Vomotion.Domain.Entities~",
                table: "Vomotion.Domain.Entities.FlashCard",
                column: "NoteId",
                principalTable: "Vomotion.Domain.Entities.Note",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vomotion.Domain.Entities.Language_Vomotion.Domain.Entities.~",
                table: "Vomotion.Domain.Entities.Language",
                column: "UserId",
                principalTable: "Vomotion.Domain.Entities.User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vomotion.Domain.Entities.Note_Vomotion.Domain.Entities.Note~",
                table: "Vomotion.Domain.Entities.Note",
                column: "NotebookId",
                principalTable: "Vomotion.Domain.Entities.Notebook",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vomotion.Domain.Entities.Note_Vomotion.Domain.Entities.User~",
                table: "Vomotion.Domain.Entities.Note",
                column: "UserId",
                principalTable: "Vomotion.Domain.Entities.User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vomotion.Domain.Entities.Notebook_Vomotion.Domain.Entities.~",
                table: "Vomotion.Domain.Entities.Notebook",
                column: "UserId",
                principalTable: "Vomotion.Domain.Entities.User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vomotion.Domain.Entities.Language_Vomotion.Domain.Entities.~",
                table: "Vomotion.Domain.Entities.Language");

            migrationBuilder.DropForeignKey(
                name: "FK_Vomotion.Domain.Entities.Notebook_Vomotion.Domain.Entities.~",
                table: "Vomotion.Domain.Entities.Notebook");

            migrationBuilder.DropTable(
                name: "Vomotion.Domain.Entities.FlashCard");

            migrationBuilder.DropTable(
                name: "Vomotion.Domain.Entities.Note");

            migrationBuilder.DropTable(
                name: "Vomotion.Domain.Entities.User");

            migrationBuilder.DropTable(
                name: "Vomotion.Domain.Entities.Language");

            migrationBuilder.DropTable(
                name: "Vomotion.Domain.Entities.Notebook");
        }
    }
}
