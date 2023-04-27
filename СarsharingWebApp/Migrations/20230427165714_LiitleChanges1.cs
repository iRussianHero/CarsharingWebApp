using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace СarsharingWebApp.Migrations
{
    /// <inheritdoc />
    public partial class LiitleChanges1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarId",
                table: "OrderRate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "OrderRate",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
