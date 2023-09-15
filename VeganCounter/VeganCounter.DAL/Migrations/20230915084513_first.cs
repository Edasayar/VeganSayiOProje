using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VeganCounter.DAL.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddedFoods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    FoodID = table.Column<int>(type: "int", nullable: false),
                    CalculatedProtein = table.Column<double>(type: "float", nullable: false),
                    CalculatedFat = table.Column<double>(type: "float", nullable: false),
                    CalculatedCarbo = table.Column<double>(type: "float", nullable: false),
                    CalculatedKcal = table.Column<double>(type: "float", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddedFoods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DailyMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyMessages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProteinValue = table.Column<double>(type: "float", nullable: false),
                    FatValue = table.Column<double>(type: "float", nullable: false),
                    CarboValue = table.Column<double>(type: "float", nullable: false),
                    Kcal = table.Column<double>(type: "float", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MealType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: true),
                    Weight = table.Column<double>(type: "float", nullable: true),
                    DailyMessageId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_DailyMessages_DailyMessageId",
                        column: x => x.DailyMessageId,
                        principalTable: "DailyMessages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MealFoods",
                columns: table => new
                {
                    FoodsId = table.Column<int>(type: "int", nullable: false),
                    MealsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealFoods", x => new { x.FoodsId, x.MealsId });
                    table.ForeignKey(
                        name: "FK_MealFoods_Foods_FoodsId",
                        column: x => x.FoodsId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MealFoods_Meals_MealsId",
                        column: x => x.MealsId,
                        principalTable: "Meals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAddedFoods",
                columns: table => new
                {
                    AddedFoodsId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAddedFoods", x => new { x.AddedFoodsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_UserAddedFoods_AddedFoods_AddedFoodsId",
                        column: x => x.AddedFoodsId,
                        principalTable: "AddedFoods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAddedFoods_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserMeals",
                columns: table => new
                {
                    MealsId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMeals", x => new { x.MealsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_UserMeals_Meals_MealsId",
                        column: x => x.MealsId,
                        principalTable: "Meals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserMeals_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedDate", "FoodId", "State", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Yemek", new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(9433), null, "Created", null },
                    { 2, "Şarküteri", new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(9434), null, "Created", null },
                    { 3, "Sebze", new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(9435), null, "Created", null },
                    { 4, "Meyve", new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(9436), null, "Created", null },
                    { 5, "İçecek", new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(9436), null, "Created", null },
                    { 6, "Salata", new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(9437), null, "Created", null },
                    { 7, "Tatlı", new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(9438), null, "Created", null }
                });

            migrationBuilder.InsertData(
                table: "DailyMessages",
                columns: new[] { "Id", "CreatedDate", "MessageText", "State", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 15, 11, 45, 12, 798, DateTimeKind.Local).AddTicks(179), "Mesaj 1", "Created", null },
                    { 2, new DateTime(2023, 9, 15, 11, 45, 12, 798, DateTimeKind.Local).AddTicks(180), "Mesaj 2", "Created", null },
                    { 3, new DateTime(2023, 9, 15, 11, 45, 12, 798, DateTimeKind.Local).AddTicks(181), "Mesaj 3", "Created", null },
                    { 4, new DateTime(2023, 9, 15, 11, 45, 12, 798, DateTimeKind.Local).AddTicks(181), "Mesaj 4", "Created", null },
                    { 5, new DateTime(2023, 9, 15, 11, 45, 12, 798, DateTimeKind.Local).AddTicks(182), "Mesaj 5", "Created", null },
                    { 6, new DateTime(2023, 9, 15, 11, 45, 12, 798, DateTimeKind.Local).AddTicks(183), "Mesaj 6", "Created", null },
                    { 7, new DateTime(2023, 9, 15, 11, 45, 12, 798, DateTimeKind.Local).AddTicks(184), "Mesaj 7", "Created", null },
                    { 8, new DateTime(2023, 9, 15, 11, 45, 12, 798, DateTimeKind.Local).AddTicks(184), "Mesaj 8", "Created", null }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "CarboValue", "CategoryID", "CreatedDate", "FatValue", "FoodName", "Kcal", "Picture", "ProteinValue", "State", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 30.0, 1, new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(9059), 10.0, "Vegan Yulaf Ezmesi", 300.0, "noodle_stir_fry.jpg", 8.0, "Created", null },
                    { 2, 35.0, 1, new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(9061), 10.0, "Vegan Fındıklı Muzlu Ekmek", 210.0, "vegan_lentil_curry.jpg", 15.0, "Created", null },
                    { 3, 25.0, 1, new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(9063), 11.0, "Vegan Gözleme", 210.0, "vegan_chickpea_salad.jpg", 7.0, "Created", null },
                    { 4, 35.0, 1, new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(9064), 13.0, "Vegan Kuruyemiş veYulaf Müsli", 350.0, "", 9.0, "Created", null },
                    { 5, 20.0, 1, new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(9065), 10.0, "Vegan Smoothie Kasesi", 350.0, "vegan_stuffed_peppers.jpg", 15.0, "Created", null },
                    { 6, 16.0, 1, new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(9066), 10.0, "Vegan Omlet", 350.0, "vegan_stuffed_peppers.jpg", 15.0, "Created", null },
                    { 7, 20.0, 1, new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(9067), 10.0, "Chia Tohumlu Puding", 350.0, "vegan_stuffed_peppers.jpg", 15.0, "Created", null },
                    { 8, 2.0, 2, new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(9073), 10.0, "Vegan Kavrulmuş Tofu", 160.0, "vegan_smoked_tofu.jpg", 18.0, "Created", null },
                    { 9, 8.0, 2, new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(9075), 12.0, "Vegan Cashew Cheese", 150.0, "vegan_cashew_cheese.jpg", 5.0, "Created", null },
                    { 10, 10.0, 2, new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(9076), 15.0, "Vegan Seitan Sausages", 250.0, "vegan_seitan_sausages.jpg", 20.0, "Created", null },
                    { 11, 5.0, 2, new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(9077), 8.0, "Vegan Tempeh Bacon", 180.0, "vegan_tempeh_bacon.jpg", 15.0, "Created", null },
                    { 12, 25.0, 2, new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(9079), 6.0, "Vegan Smoky Tofu Sandwich", 220.0, "vegan_smoky_tofu_sandwich.jpg", 12.0, "Created", null },
                    { 13, 15.0, 3, new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(9083), 7.0, "Tahin Soslu Izgara Patlıcan", 150.0, "grilled_eggplant.jpg", 5.0, "Created", null },
                    { 14, 20.0, 3, new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(9084), 5.0, "Vegan Zucchini Fritters", 180.0, "vegan_zucchini_fritters.jpg", 8.0, "Created", null },
                    { 15, 12.0, 3, new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(9085), 4.0, "Vegan Roasted Cauliflower", 120.0, "vegan_roasted_cauliflower.jpg", 6.0, "Created", null },
                    { 16, 18.0, 3, new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(9087), 5.0, "Vegan Spinach Stuffed Mushrooms", 150.0, "vegan_spinach_stuffed_mushrooms.jpg", 7.0, "Created", null },
                    { 17, 40.0, 4, new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(9127), 5.0, "Karışık Meyve Smoothie Kasesi", 220.0, "mixed_berry_smoothie_bowl.jpg", 8.0, "Created", null },
                    { 18, 30.0, 4, new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(9128), 0.0, "Vegan Mango Sorbet", 120.0, "vegan_mango_sorbet.jpg", 2.0, "Created", null },
                    { 19, 15.0, 4, new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(9130), 0.0, "Vegan Kiwi Strawberry Popsicles", 70.0, "vegan_kiwi_strawberry_popsicles.jpg", 1.0, "Created", null },
                    { 20, 25.0, 4, new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(9131), 1.0, "Vegan Fruit Salad", 100.0, "vegan_fruit_salad.jpg", 3.0, "Created", null },
                    { 21, 30.0, 4, new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(9132), 5.0, "Vegan Banana Pancakes", 200.0, "vegan_banana_pancakes.jpg", 6.0, "Created", null },
                    { 22, 10.0, 5, new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(9136), 0.0, "Salatalık Nane Limonatası", 50.0, "cucumber_mint_lemonade.jpg", 1.0, "Created", null },
                    { 23, 15.0, 5, new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(9137), 0.0, "Vegan Çilekli Limonata", 60.0, "vegan_strawberry_lemonade.jpg", 1.0, "Created", null },
                    { 24, 20.0, 5, new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(9138), 2.0, "Vegan Pineapple Hindistan Cevizli Smoothie", 90.0, "vegan_pineapple_coconut_smoothie.jpg", 3.0, "Created", null },
                    { 25, 12.0, 5, new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(9140), 1.0, "Vegan Green Detox ", 70.0, "vegan_green_detox_juice.jpg", 2.0, "Created", null },
                    { 26, 25.0, 5, new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(9141), 3.0, "Vegan Iced Coffee", 120.0, "vegan_iced_coffee.jpg", 1.0, "Created", null },
                    { 27, 20.0, 6, new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(9143), 6.0, "Nohutlu Vegan Kinoa Salatası", 180.0, "mediterranean_quinoa_salad.jpg", 10.0, "Created", null }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "CarboValue", "CategoryID", "CreatedDate", "FatValue", "FoodName", "Kcal", "Picture", "ProteinValue", "State", "UpdatedDate" },
                values: new object[,]
                {
                    { 28, 15.0, 6, new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(9144), 10.0, "Vegan Greek Salad", 160.0, "vegan_greek_salad.jpg", 8.0, "Created", null },
                    { 29, 10.0, 6, new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(9146), 15.0, "Vegan Avocado Caprese Salad", 170.0, "vegan_avocado_caprese_salad.jpg", 6.0, "Created", null },
                    { 30, 12.0, 6, new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(9147), 8.0, "Vegan Caesar Salad", 140.0, "vegan_caesar_salad.jpg", 5.0, "Created", null },
                    { 31, 18.0, 6, new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(9148), 5.0, "Vegan Coleslaw", 120.0, "vegan_coleslaw.jpg", 3.0, "Created", null },
                    { 32, 20.0, 7, new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(9150), 10.0, "Vegan Çikolatalı Parça Kurabiye", 180.0, "vegan_chocolate_chip_cookies.jpg", 4.0, "Created", null },
                    { 33, 25.0, 7, new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(9152), 12.0, "Vegan Brownie", 200.0, "vegan_brownie.jpg", 5.0, "Created", null },
                    { 34, 30.0, 7, new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(9153), 15.0, "Vegan Çikolatalı Kek", 220.0, "vegan_chocolate_cake.jpg", 6.0, "Created", null },
                    { 35, 22.0, 7, new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(9154), 10.0, "Vegan Havuçlu Kek", 180.0, "vegan_carrot_cupcakes.jpg", 4.0, "Created", null },
                    { 36, 18.0, 7, new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(9155), 14.0, "Vegan Raspberry Cheesecake", 240.0, "vegan_raspberry_cheesecake.jpg", 7.0, "Created", null }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CreatedDate", "MealType", "State", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(8763), "Kahvaltı", "Created", null },
                    { 2, new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(8764), "Öğle Yemeği", "Created", null },
                    { 3, new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(8765), "Akşam Yemeği", "Created", null },
                    { 4, new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(8766), "Ara Öğün", "Created", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDay", "CreatedDate", "DailyMessageId", "Email", "Gender", "Height", "Password", "Role", "State", "UpdatedDate", "UserName", "Weight" },
                values: new object[,]
                {
                    { 1, new DateTime(1990, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(8370), null, "admin@admin.com", "Male", null, "Admin", "Admin", "Created", null, "Admin", null },
                    { 2, new DateTime(1990, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(8379), null, "user1@user.com", "Female", null, "User1.", "StandartUser", "Created", null, "User1", null },
                    { 3, new DateTime(1990, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(8381), null, "user2@user.com", "Female", null, "User2.", "StandartUser", "Created", null, "User2", null },
                    { 4, new DateTime(1990, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(8383), null, "user3@user.com", "Female", null, "User3.", "StandartUser", "Created", null, "User3", null },
                    { 5, new DateTime(1990, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(8384), null, "user4@user.com", "Female", null, "User4.", "StandartUser", "Created", null, "User4", null },
                    { 6, new DateTime(1990, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 15, 11, 45, 12, 797, DateTimeKind.Local).AddTicks(8385), null, "user5@user.com", "Female", null, "User5.", "StandartUser", "Created", null, "User5", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_FoodId",
                table: "Categories",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_MealFoods_MealsId",
                table: "MealFoods",
                column: "MealsId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAddedFoods_UsersId",
                table: "UserAddedFoods",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMeals_UsersId",
                table: "UserMeals",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_DailyMessageId",
                table: "Users",
                column: "DailyMessageId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "MealFoods");

            migrationBuilder.DropTable(
                name: "UserAddedFoods");

            migrationBuilder.DropTable(
                name: "UserMeals");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "AddedFoods");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "DailyMessages");
        }
    }
}
