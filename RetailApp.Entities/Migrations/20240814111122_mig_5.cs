using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RetailApp.Entities.Migrations
{
    /// <inheritdoc />
    public partial class mig_5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopCarts_Orders_orderId",
                table: "ShopCarts");

            migrationBuilder.RenameColumn(
                name: "orderId",
                table: "ShopCarts",
                newName: "OrderId");

            migrationBuilder.RenameColumn(
                name: "shopCartId",
                table: "ShopCarts",
                newName: "ShopCartId");

            migrationBuilder.RenameIndex(
                name: "IX_ShopCarts_orderId",
                table: "ShopCarts",
                newName: "IX_ShopCarts_OrderId");

            migrationBuilder.RenameColumn(
                name: "orderQuantity",
                table: "Orders",
                newName: "OrderQuantity");

            migrationBuilder.RenameColumn(
                name: "orderDate",
                table: "Orders",
                newName: "OrderDate");

            migrationBuilder.RenameColumn(
                name: "orderCost",
                table: "Orders",
                newName: "OrderCost");

            migrationBuilder.RenameColumn(
                name: "orderId",
                table: "Orders",
                newName: "OrderId");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "OrderDetails",
                newName: "OrderQuantity");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Admins",
                newName: "AdminName");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Admins",
                newName: "AdminAddress");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Admins",
                newName: "AdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopCarts_Orders_OrderId",
                table: "ShopCarts",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopCarts_Orders_OrderId",
                table: "ShopCarts");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "ShopCarts",
                newName: "orderId");

            migrationBuilder.RenameColumn(
                name: "ShopCartId",
                table: "ShopCarts",
                newName: "shopCartId");

            migrationBuilder.RenameIndex(
                name: "IX_ShopCarts_OrderId",
                table: "ShopCarts",
                newName: "IX_ShopCarts_orderId");

            migrationBuilder.RenameColumn(
                name: "OrderQuantity",
                table: "Orders",
                newName: "orderQuantity");

            migrationBuilder.RenameColumn(
                name: "OrderDate",
                table: "Orders",
                newName: "orderDate");

            migrationBuilder.RenameColumn(
                name: "OrderCost",
                table: "Orders",
                newName: "orderCost");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "Orders",
                newName: "orderId");

            migrationBuilder.RenameColumn(
                name: "OrderQuantity",
                table: "OrderDetails",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "AdminName",
                table: "Admins",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "AdminAddress",
                table: "Admins",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "AdminId",
                table: "Admins",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopCarts_Orders_orderId",
                table: "ShopCarts",
                column: "orderId",
                principalTable: "Orders",
                principalColumn: "orderId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
