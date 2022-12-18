using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C_Infrustructure.Migrations
{
    public partial class abc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grup",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "10, 1"),
                    GrupAdı = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grup", x => x.ID)
                        .Annotation("SqlServer:Clustered", true);
                });

            migrationBuilder.CreateTable(
                name: "İletişimTürü",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "10, 1"),
                    İletişimNumarasıID = table.Column<int>(type: "int", nullable: false),
                    iletişimNoTür = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_İletişimTürü", x => x.ID)
                        .Annotation("SqlServer:Clustered", true);
                });

            migrationBuilder.CreateTable(
                name: "Kişiler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "10, 1"),
                    İsim = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Soyisim = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    NickName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Açıklama = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DoğumTarihi = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2022, 12, 18, 10, 46, 3, 9, DateTimeKind.Local).AddTicks(6791))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kişiler", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "İletişimNumarası",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "10, 1"),
                    TürID = table.Column<int>(type: "int", nullable: false),
                    Numara = table.Column<int>(type: "int", nullable: false),
                    KisiID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_İletişimNumarası", x => x.ID);
                    table.ForeignKey(
                        name: "FK_İletişimNumarası_İletişimTürü_TürID",
                        column: x => x.TürID,
                        principalTable: "İletişimTürü",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_İletişimNumarası_Kişiler_KisiID",
                        column: x => x.KisiID,
                        principalTable: "Kişiler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KisiGrupları",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "10, 1"),
                    KisiID = table.Column<int>(type: "int", nullable: false),
                    GrupID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KisiGrupları", x => x.ID);
                    table.ForeignKey(
                        name: "FK_KisiGrupları_Grup_GrupID",
                        column: x => x.GrupID,
                        principalTable: "Grup",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_KisiGrupları_Kişiler_KisiID",
                        column: x => x.KisiID,
                        principalTable: "Kişiler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mailler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "10, 1"),
                    MailAdresi = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    KisiID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mailler", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Mailler_Kişiler_KisiID",
                        column: x => x.KisiID,
                        principalTable: "Kişiler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_İletişimNumarası_KisiID",
                table: "İletişimNumarası",
                column: "KisiID");

            migrationBuilder.CreateIndex(
                name: "IX_İletişimNumarası_TürID",
                table: "İletişimNumarası",
                column: "TürID");

            migrationBuilder.CreateIndex(
                name: "IX_KisiGrupları_GrupID",
                table: "KisiGrupları",
                column: "GrupID");

            migrationBuilder.CreateIndex(
                name: "IX_KisiGrupları_KisiID",
                table: "KisiGrupları",
                column: "KisiID");

            migrationBuilder.CreateIndex(
                name: "IX_Mailler_KisiID",
                table: "Mailler",
                column: "KisiID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "İletişimNumarası");

            migrationBuilder.DropTable(
                name: "KisiGrupları");

            migrationBuilder.DropTable(
                name: "Mailler");

            migrationBuilder.DropTable(
                name: "İletişimTürü");

            migrationBuilder.DropTable(
                name: "Grup");

            migrationBuilder.DropTable(
                name: "Kişiler");
        }
    }
}
