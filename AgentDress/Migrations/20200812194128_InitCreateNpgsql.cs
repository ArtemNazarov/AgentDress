using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AgentDress.Migrations
{
    public partial class InitCreateNpgsql : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "public");

            migrationBuilder.CreateTable(
                name: "Categories",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DressCategory = table.Column<string>(nullable: true),
                    Age = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DressTypes",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DressTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
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
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
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
                        principalSchema: "public",
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dresses_DressTypes_DressTypeId",
                        column: x => x.DressTypeId,
                        principalSchema: "public",
                        principalTable: "DressTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dresses_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalSchema: "public",
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
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
                        principalSchema: "public",
                        principalTable: "Dresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DressCollections",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true),
                    DressId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DressCollections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DressCollections_Dresses_DressId",
                        column: x => x.DressId,
                        principalSchema: "public",
                        principalTable: "Dresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
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
                        principalSchema: "public",
                        principalTable: "Dresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
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
                        principalSchema: "public",
                        principalTable: "Dresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Colors_DressId",
                schema: "public",
                table: "Colors",
                column: "DressId");

            migrationBuilder.CreateIndex(
                name: "IX_DressCollections_DressId",
                schema: "public",
                table: "DressCollections",
                column: "DressId");

            migrationBuilder.CreateIndex(
                name: "IX_Dresses_CategoryId",
                schema: "public",
                table: "Dresses",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Dresses_DressCollectionId",
                schema: "public",
                table: "Dresses",
                column: "DressCollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Dresses_DressTypeId",
                schema: "public",
                table: "Dresses",
                column: "DressTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Dresses_ManufacturerId",
                schema: "public",
                table: "Dresses",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Dresses_StoreId",
                schema: "public",
                table: "Dresses",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Sizes_DressId",
                schema: "public",
                table: "Sizes",
                column: "DressId");

            migrationBuilder.CreateIndex(
                name: "IX_Stores_DressId",
                schema: "public",
                table: "Stores",
                column: "DressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dresses_DressCollections_DressCollectionId",
                schema: "public",
                table: "Dresses",
                column: "DressCollectionId",
                principalSchema: "public",
                principalTable: "DressCollections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Dresses_Stores_StoreId",
                schema: "public",
                table: "Dresses",
                column: "StoreId",
                principalSchema: "public",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DressCollections_Dresses_DressId",
                schema: "public",
                table: "DressCollections");

            migrationBuilder.DropForeignKey(
                name: "FK_Stores_Dresses_DressId",
                schema: "public",
                table: "Stores");

            migrationBuilder.DropTable(
                name: "Colors",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Sizes",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Dresses",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Categories",
                schema: "public");

            migrationBuilder.DropTable(
                name: "DressCollections",
                schema: "public");

            migrationBuilder.DropTable(
                name: "DressTypes",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Manufacturers",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Stores",
                schema: "public");
        }
    }
}
