using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_writer_relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WirterName",
                table: "Writers",
                newName: "WriterName");

            migrationBuilder.RenameColumn(
                name: "WirterImage",
                table: "Writers",
                newName: "WriterImage");

            migrationBuilder.RenameColumn(
                name: "WirterAbout",
                table: "Writers",
                newName: "WriterAbout");

            migrationBuilder.RenameColumn(
                name: "WirterID",
                table: "Writers",
                newName: "WriterID");

            migrationBuilder.AddColumn<int>(
                name: "WriterID",
                table: "Blogs",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_WriterID",
                table: "Blogs",
                column: "WriterID");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Writers_WriterID",
                table: "Blogs",
                column: "WriterID",
                principalTable: "Writers",
                principalColumn: "WriterID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Writers_WriterID",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_WriterID",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "WriterID",
                table: "Blogs");

            migrationBuilder.RenameColumn(
                name: "WriterName",
                table: "Writers",
                newName: "WirterName");

            migrationBuilder.RenameColumn(
                name: "WriterImage",
                table: "Writers",
                newName: "WirterImage");

            migrationBuilder.RenameColumn(
                name: "WriterAbout",
                table: "Writers",
                newName: "WirterAbout");

            migrationBuilder.RenameColumn(
                name: "WriterID",
                table: "Writers",
                newName: "WirterID");
        }
    }
}
