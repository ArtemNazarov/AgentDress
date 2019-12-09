using Microsoft.EntityFrameworkCore.Migrations;

namespace AgentDressReborn.Migrations
{
    public partial class InitCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DressCategory = table.Column<string>(nullable: true),
                    Age = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DressTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DressTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Bik = table.Column<string>(nullable: true),
                    Ogrn = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dresses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false),
                    DressTypeId = table.Column<int>(nullable: false),
                    ManufacturerId = table.Column<int>(nullable: false),
                    DressCollectionId = table.Column<int>(nullable: true),
                    StoreId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dresses_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dresses_DressTypes_DressTypeId",
                        column: x => x.DressTypeId,
                        principalTable: "DressTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dresses_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sColor = table.Column<string>(nullable: true),
                    Opacity = table.Column<string>(nullable: true),
                    SortOrder = table.Column<int>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    DressId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Colors_Dresses_DressId",
                        column: x => x.DressId,
                        principalTable: "Dresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DressCollections",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    DressId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DressCollections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DressCollections_Dresses_DressId",
                        column: x => x.DressId,
                        principalTable: "Dresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sSize = table.Column<string>(nullable: true),
                    SortOrder = table.Column<int>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    DressId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sizes_Dresses_DressId",
                        column: x => x.DressId,
                        principalTable: "Dresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    PostalCode = table.Column<int>(nullable: false),
                    Country = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    WebSite = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(nullable: true),
                    DressId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stores_Dresses_DressId",
                        column: x => x.DressId,
                        principalTable: "Dresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Colors_DressId",
                table: "Colors",
                column: "DressId");

            migrationBuilder.CreateIndex(
                name: "IX_DressCollections_DressId",
                table: "DressCollections",
                column: "DressId");

            migrationBuilder.CreateIndex(
                name: "IX_Dresses_CategoryId",
                table: "Dresses",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Dresses_DressCollectionId",
                table: "Dresses",
                column: "DressCollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Dresses_DressTypeId",
                table: "Dresses",
                column: "DressTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Dresses_ManufacturerId",
                table: "Dresses",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Dresses_StoreId",
                table: "Dresses",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Sizes_DressId",
                table: "Sizes",
                column: "DressId");

            migrationBuilder.CreateIndex(
                name: "IX_Stores_DressId",
                table: "Stores",
                column: "DressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dresses_DressCollections_DressCollectionId",
                table: "Dresses",
                column: "DressCollectionId",
                principalTable: "DressCollections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Dresses_Stores_StoreId",
                table: "Dresses",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DressCollections_Dresses_DressId",
                table: "DressCollections");

            migrationBuilder.DropForeignKey(
                name: "FK_Stores_Dresses_DressId",
                table: "Stores");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "Dresses");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "DressCollections");

            migrationBuilder.DropTable(
                name: "DressTypes");

            migrationBuilder.DropTable(
                name: "Manufacturers");

            migrationBuilder.DropTable(
                name: "Stores");
        }
    }
}
