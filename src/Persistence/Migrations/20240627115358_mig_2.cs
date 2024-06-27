using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Deals_DealId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Tasks_TaskId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Deals_Tasks_TaskId",
                table: "Deals");

            migrationBuilder.DropForeignKey(
                name: "FK_PotentialCustomers_Contacts_ContactId",
                table: "PotentialCustomers");

            migrationBuilder.DropIndex(
                name: "IX_PotentialCustomers_ContactId",
                table: "PotentialCustomers");

            migrationBuilder.DropIndex(
                name: "IX_Deals_TaskId",
                table: "Deals");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_DealId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "ContactId",
                table: "PotentialCustomers");

            migrationBuilder.DropColumn(
                name: "InterestedPoduct",
                table: "PotentialCustomers");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "Deals");

            migrationBuilder.DropColumn(
                name: "TaskId",
                table: "Deals");

            migrationBuilder.DropColumn(
                name: "DealId",
                table: "Contacts");

            migrationBuilder.RenameColumn(
                name: "Sector",
                table: "PotentialCustomers",
                newName: "InterestedProduct");

            migrationBuilder.RenameColumn(
                name: "DealStatus",
                table: "PotentialCustomers",
                newName: "LeadStatus");

            migrationBuilder.RenameColumn(
                name: "TaskId",
                table: "Contacts",
                newName: "PotentialCustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_TaskId",
                table: "Contacts",
                newName: "IX_Contacts_PotentialCustomerId");

            migrationBuilder.AddColumn<Guid>(
                name: "CustomerId",
                table: "Tasks",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PotentialCustomerId",
                table: "Tasks",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CustomerId",
                table: "Deals",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PotentialCustomerId",
                table: "Deals",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_CustomerId",
                table: "Tasks",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_PotentialCustomerId",
                table: "Tasks",
                column: "PotentialCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Deals_CustomerId",
                table: "Deals",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Deals_PotentialCustomerId",
                table: "Deals",
                column: "PotentialCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_CustomerId",
                table: "Contacts",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Customers_CustomerId",
                table: "Contacts",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_PotentialCustomers_PotentialCustomerId",
                table: "Contacts",
                column: "PotentialCustomerId",
                principalTable: "PotentialCustomers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Deals_Customers_CustomerId",
                table: "Deals",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Deals_PotentialCustomers_PotentialCustomerId",
                table: "Deals",
                column: "PotentialCustomerId",
                principalTable: "PotentialCustomers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Customers_CustomerId",
                table: "Tasks",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_PotentialCustomers_PotentialCustomerId",
                table: "Tasks",
                column: "PotentialCustomerId",
                principalTable: "PotentialCustomers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Customers_CustomerId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_PotentialCustomers_PotentialCustomerId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Deals_Customers_CustomerId",
                table: "Deals");

            migrationBuilder.DropForeignKey(
                name: "FK_Deals_PotentialCustomers_PotentialCustomerId",
                table: "Deals");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Customers_CustomerId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_PotentialCustomers_PotentialCustomerId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_CustomerId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_PotentialCustomerId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Deals_CustomerId",
                table: "Deals");

            migrationBuilder.DropIndex(
                name: "IX_Deals_PotentialCustomerId",
                table: "Deals");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_CustomerId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "PotentialCustomerId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Deals");

            migrationBuilder.DropColumn(
                name: "PotentialCustomerId",
                table: "Deals");

            migrationBuilder.RenameColumn(
                name: "LeadStatus",
                table: "PotentialCustomers",
                newName: "DealStatus");

            migrationBuilder.RenameColumn(
                name: "InterestedProduct",
                table: "PotentialCustomers",
                newName: "Sector");

            migrationBuilder.RenameColumn(
                name: "PotentialCustomerId",
                table: "Contacts",
                newName: "TaskId");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_PotentialCustomerId",
                table: "Contacts",
                newName: "IX_Contacts_TaskId");

            migrationBuilder.AddColumn<Guid>(
                name: "ContactId",
                table: "PotentialCustomers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "InterestedPoduct",
                table: "PotentialCustomers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Deals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "TaskId",
                table: "Deals",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "DealId",
                table: "Contacts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PotentialCustomers_ContactId",
                table: "PotentialCustomers",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Deals_TaskId",
                table: "Deals",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_DealId",
                table: "Contacts",
                column: "DealId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Deals_DealId",
                table: "Contacts",
                column: "DealId",
                principalTable: "Deals",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Tasks_TaskId",
                table: "Contacts",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Deals_Tasks_TaskId",
                table: "Deals",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PotentialCustomers_Contacts_ContactId",
                table: "PotentialCustomers",
                column: "ContactId",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
