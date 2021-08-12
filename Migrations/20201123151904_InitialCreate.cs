using Microsoft.EntityFrameworkCore.Migrations;

namespace kursach.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    AccountId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    password = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.AccountId);
                });

            migrationBuilder.CreateTable(
                name: "CryptKeys",
                columns: table => new
                {
                    CryptkeyId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    encryptKey = table.Column<string>(type: "TEXT", nullable: true),
                    decryptKey = table.Column<string>(type: "TEXT", nullable: true),
                    AccountId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CryptKeys", x => x.CryptkeyId);
                    table.ForeignKey(
                        name: "FK_CryptKeys_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CryptMessages",
                columns: table => new
                {
                    CryptMessageId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    cryptmessage = table.Column<string>(type: "TEXT", nullable: true),
                    AccountId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CryptMessages", x => x.CryptMessageId);
                    table.ForeignKey(
                        name: "FK_CryptMessages_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CryptKeys_AccountId",
                table: "CryptKeys",
                column: "AccountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CryptMessages_AccountId",
                table: "CryptMessages",
                column: "AccountId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CryptKeys");

            migrationBuilder.DropTable(
                name: "CryptMessages");

            migrationBuilder.DropTable(
                name: "Accounts");
        }
    }
}
