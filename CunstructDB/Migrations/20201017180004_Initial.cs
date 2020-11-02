using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CunstructDB.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    CompletionMark = table.Column<string>(nullable: true),
                    AboutPayment = table.Column<string>(nullable: true),
                    CustomerID = table.Column<long>(nullable: true),
                    TypeOfJobID = table.Column<long>(nullable: true),
                    BrigadeID = table.Column<long>(nullable: true),
                    StaffID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Brigade",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Staff1ID = table.Column<long>(nullable: true),
                    Staff2ID = table.Column<long>(nullable: true),
                    Staff3ID = table.Column<long>(nullable: true),
                    OrderID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brigade", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Brigade_Order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    PassportData = table.Column<string>(nullable: true),
                    OrderID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Customer_Order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TypeOfJob",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    Material1ID = table.Column<long>(nullable: true),
                    Material2ID = table.Column<long>(nullable: true),
                    Material3ID = table.Column<long>(nullable: true),
                    OrderID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOfJob", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TypeOfJob_Order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Sex = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    PassportData = table.Column<string>(nullable: true),
                    PositionID = table.Column<long>(nullable: true),
                    BrigadeID = table.Column<long>(nullable: true),
                    BrigadeID1 = table.Column<long>(nullable: true),
                    BrigadeID2 = table.Column<long>(nullable: true),
                    OrderID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Staff_Brigade_BrigadeID",
                        column: x => x.BrigadeID,
                        principalTable: "Brigade",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Staff_Brigade_BrigadeID1",
                        column: x => x.BrigadeID1,
                        principalTable: "Brigade",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Staff_Brigade_BrigadeID2",
                        column: x => x.BrigadeID2,
                        principalTable: "Brigade",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Staff_Order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Material",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Packaging = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    TypeOfJobID = table.Column<long>(nullable: true),
                    TypeOfJobID1 = table.Column<long>(nullable: true),
                    TypeOfJobID2 = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Material", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Material_TypeOfJob_TypeOfJobID",
                        column: x => x.TypeOfJobID,
                        principalTable: "TypeOfJob",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Material_TypeOfJob_TypeOfJobID1",
                        column: x => x.TypeOfJobID1,
                        principalTable: "TypeOfJob",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Material_TypeOfJob_TypeOfJobID2",
                        column: x => x.TypeOfJobID2,
                        principalTable: "TypeOfJob",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Salary = table.Column<int>(nullable: false),
                    Responsibilities = table.Column<string>(nullable: true),
                    Requirements = table.Column<string>(nullable: true),
                    StaffID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Position_Staff_StaffID",
                        column: x => x.StaffID,
                        principalTable: "Staff",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Brigade_OrderID",
                table: "Brigade",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_OrderID",
                table: "Customer",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Material_TypeOfJobID",
                table: "Material",
                column: "TypeOfJobID");

            migrationBuilder.CreateIndex(
                name: "IX_Material_TypeOfJobID1",
                table: "Material",
                column: "TypeOfJobID1");

            migrationBuilder.CreateIndex(
                name: "IX_Material_TypeOfJobID2",
                table: "Material",
                column: "TypeOfJobID2");

            migrationBuilder.CreateIndex(
                name: "IX_Position_StaffID",
                table: "Position",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_BrigadeID",
                table: "Staff",
                column: "BrigadeID");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_BrigadeID1",
                table: "Staff",
                column: "BrigadeID1");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_BrigadeID2",
                table: "Staff",
                column: "BrigadeID2");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_OrderID",
                table: "Staff",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_TypeOfJob_OrderID",
                table: "TypeOfJob",
                column: "OrderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Material");

            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropTable(
                name: "TypeOfJob");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Brigade");

            migrationBuilder.DropTable(
                name: "Order");
        }
    }
}
