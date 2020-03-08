using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class ActivityEntityAdded3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("035045ef-f7c8-4b19-9807-fa1a217275e8"), "drinks", "London", new DateTime(2020, 1, 6, 17, 8, 47, 896, DateTimeKind.Local).AddTicks(1342), "Activity 2 months ago", "Past Activity 1", "Pub" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("fb626182-6b7d-45d8-9365-3e81d5cd12a0"), "culture", "Paris", new DateTime(2020, 2, 6, 17, 8, 47, 903, DateTimeKind.Local).AddTicks(8750), "Activity 1 month ago", "Past Activity 2", "Louvre" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("43b83e5c-7d45-4290-83a6-31973ed55883"), "culture", "London", new DateTime(2020, 4, 6, 17, 8, 47, 903, DateTimeKind.Local).AddTicks(8893), "Activity 1 month in future", "Future Activity 1", "Natural History Museum" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("96a12317-f91b-4b6e-ab83-f1c1f7c5abd7"), "music", "London", new DateTime(2020, 5, 6, 17, 8, 47, 903, DateTimeKind.Local).AddTicks(8901), "Activity 2 months in future", "Future Activity 2", "O2 Arena" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("9a20e5ee-e775-4940-9a83-bec0ae55563d"), "drinks", "London", new DateTime(2020, 6, 6, 17, 8, 47, 903, DateTimeKind.Local).AddTicks(8904), "Activity 3 months in future", "Future Activity 3", "Another pub" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("f69cd766-e854-4dee-8f8c-f693827bf93a"), "drinks", "London", new DateTime(2020, 7, 6, 17, 8, 47, 903, DateTimeKind.Local).AddTicks(8912), "Activity 4 months in future", "Future Activity 4", "Yet another pub" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("fcd24396-9014-4cc6-9a2d-09ecce7609c5"), "drinks", "London", new DateTime(2020, 8, 6, 17, 8, 47, 903, DateTimeKind.Local).AddTicks(8916), "Activity 5 months in future", "Future Activity 5", "Just another pub" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("b8702e43-67b5-419f-aeb6-798a9edda887"), "music", "London", new DateTime(2020, 9, 6, 17, 8, 47, 903, DateTimeKind.Local).AddTicks(8920), "Activity 6 months in future", "Future Activity 6", "Roundhouse Camden" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("46715405-eb5d-4798-b7f6-de8984d9c7b0"), "travel", "London", new DateTime(2020, 10, 6, 17, 8, 47, 903, DateTimeKind.Local).AddTicks(8923), "Activity 2 months ago", "Future Activity 7", "Somewhere on the Thames" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("65e679f4-cb48-4fbb-8500-aef52293d653"), "film", "London", new DateTime(2020, 11, 6, 17, 8, 47, 903, DateTimeKind.Local).AddTicks(8927), "Activity 8 months in future", "Future Activity 8", "Cinema" });

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Value 103" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("035045ef-f7c8-4b19-9807-fa1a217275e8"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("43b83e5c-7d45-4290-83a6-31973ed55883"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("46715405-eb5d-4798-b7f6-de8984d9c7b0"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("65e679f4-cb48-4fbb-8500-aef52293d653"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("96a12317-f91b-4b6e-ab83-f1c1f7c5abd7"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("9a20e5ee-e775-4940-9a83-bec0ae55563d"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b8702e43-67b5-419f-aeb6-798a9edda887"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("f69cd766-e854-4dee-8f8c-f693827bf93a"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("fb626182-6b7d-45d8-9365-3e81d5cd12a0"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("fcd24396-9014-4cc6-9a2d-09ecce7609c5"));

            migrationBuilder.DeleteData(
                table: "Values",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
