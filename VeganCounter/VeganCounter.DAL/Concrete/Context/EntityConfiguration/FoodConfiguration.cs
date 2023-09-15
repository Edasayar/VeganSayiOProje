using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VeganCounter.Core.Enums;
using VeganCounter.Entities;

namespace VeganCounter.DAL.Concrete.Context.EntityConfiguration
{
    public class FoodConfiguration : BaseConfiguration<Food>
    {
        public override void Configure(EntityTypeBuilder<Food> builder)
        {


            base.Configure(builder);

            // Yemek Kategorisi
            builder.HasData(
                new Food { Id = 1, FoodName = "Vegan Yulaf Ezmesi", ProteinValue = 8, CarboValue = 30, FatValue = 10, Kcal = 300, Picture = "noodle_stir_fry.jpg", CreatedDate = DateTime.Now, State = State.Created, CategoryID = 1 },
                new Food { Id = 2, FoodName = "Vegan Fındıklı Muzlu Ekmek", ProteinValue = 15, CarboValue = 35, FatValue = 10, Kcal = 210, Picture = "vegan_lentil_curry.jpg", CreatedDate = DateTime.Now, State = State.Created, CategoryID = 1 },
                new Food { Id = 3, FoodName = "Vegan Gözleme", ProteinValue = 7, CarboValue = 25, FatValue = 11, Kcal = 210, Picture = "vegan_chickpea_salad.jpg", CreatedDate = DateTime.Now, State = State.Created, CategoryID = 1 },
                new Food { Id = 4, FoodName = "Vegan Kuruyemiş veYulaf Müsli", ProteinValue = 9, CarboValue = 35, FatValue = 13, Kcal = 350, Picture = "", CreatedDate = DateTime.Now, State = State.Created, CategoryID = 1 },
                new Food { Id = 5, FoodName = "Vegan Smoothie Kasesi", ProteinValue = 15, CarboValue = 20, FatValue = 10, Kcal = 350, Picture = "vegan_stuffed_peppers.jpg", CreatedDate = DateTime.Now, State = State.Created, CategoryID = 1 },
                 new Food { Id = 6, FoodName = "Vegan Omlet", ProteinValue = 15, CarboValue = 16, FatValue = 10, Kcal = 350, Picture = "vegan_stuffed_peppers.jpg", CreatedDate = DateTime.Now, State = State.Created, CategoryID = 1 },
                  new Food { Id = 7, FoodName = "Chia Tohumlu Puding", ProteinValue = 15, CarboValue = 20, FatValue = 10, Kcal = 350, Picture = "vegan_stuffed_peppers.jpg", CreatedDate = DateTime.Now, State = State.Created, CategoryID = 1 }
            );

            // Şarküteri Kategorisi
            builder.HasData(
                new Food { Id = 8, FoodName = "Vegan Kavrulmuş Tofu", ProteinValue = 18, CarboValue = 2, FatValue = 10, Kcal = 160, Picture = "vegan_smoked_tofu.jpg", CreatedDate = DateTime.Now, State = State.Created, CategoryID = 2 },
                new Food { Id = 9, FoodName = "Vegan Cashew Cheese", ProteinValue = 5, CarboValue = 8, FatValue = 12, Kcal = 150, Picture = "vegan_cashew_cheese.jpg", CreatedDate = DateTime.Now, State = State.Created, CategoryID = 2 },
                new Food { Id = 10, FoodName = "Vegan Seitan Sausages", ProteinValue = 20, CarboValue = 10, FatValue = 15, Kcal = 250, Picture = "vegan_seitan_sausages.jpg", CreatedDate = DateTime.Now, State = State.Created, CategoryID = 2 },
                new Food { Id = 11, FoodName = "Vegan Tempeh Bacon", ProteinValue = 15, CarboValue = 5, FatValue = 8, Kcal = 180, Picture = "vegan_tempeh_bacon.jpg", CreatedDate = DateTime.Now, State = State.Created, CategoryID = 2 },
                new Food { Id = 12, FoodName = "Vegan Smoky Tofu Sandwich", ProteinValue = 12, CarboValue = 25, FatValue = 6, Kcal = 220, Picture = "vegan_smoky_tofu_sandwich.jpg", CreatedDate = DateTime.Now, State = State.Created, CategoryID = 2 }
            );

            // Sebze Kategorisi
            builder.HasData(
                new Food { Id = 13, FoodName = "Tahin Soslu Izgara Patlıcan", ProteinValue = 5, CarboValue = 15, FatValue = 7, Kcal = 150, Picture = "grilled_eggplant.jpg", CreatedDate = DateTime.Now, State = State.Created, CategoryID = 3 },
                new Food { Id = 14, FoodName = "Vegan Zucchini Fritters", ProteinValue = 8, CarboValue = 20, FatValue = 5, Kcal = 180, Picture = "vegan_zucchini_fritters.jpg", CreatedDate = DateTime.Now, State = State.Created, CategoryID = 3 }, 
                new Food { Id = 15, FoodName = "Vegan Roasted Cauliflower", ProteinValue = 6, CarboValue = 12, FatValue = 4, Kcal = 120, Picture = "vegan_roasted_cauliflower.jpg", CreatedDate = DateTime.Now, State = State.Created, CategoryID = 3 },
                new Food { Id = 16, FoodName = "Vegan Spinach Stuffed Mushrooms", ProteinValue = 7, CarboValue = 18, FatValue = 5, Kcal = 150, Picture = "vegan_spinach_stuffed_mushrooms.jpg", CreatedDate = DateTime.Now, State = State.Created, CategoryID = 3 }
            );

            // Meyve Kategorisi
            builder.HasData(
                new Food { Id = 17, FoodName = "Karışık Meyve Smoothie Kasesi", ProteinValue = 8, CarboValue = 40, FatValue = 5, Kcal = 220, Picture = "mixed_berry_smoothie_bowl.jpg", CreatedDate = DateTime.Now, State = State.Created, CategoryID = 4 },
                new Food { Id = 18, FoodName = "Vegan Mango Sorbet", ProteinValue = 2, CarboValue = 30, FatValue = 0, Kcal = 120, Picture = "vegan_mango_sorbet.jpg", CreatedDate = DateTime.Now, State = State.Created, CategoryID = 4 },
                new Food { Id = 19, FoodName = "Vegan Kiwi Strawberry Popsicles", ProteinValue = 1, CarboValue = 15, FatValue = 0, Kcal = 70, Picture = "vegan_kiwi_strawberry_popsicles.jpg", CreatedDate = DateTime.Now, State = State.Created, CategoryID = 4 },
                new Food { Id = 20, FoodName = "Vegan Fruit Salad", ProteinValue = 3, CarboValue = 25, FatValue = 1, Kcal = 100, Picture = "vegan_fruit_salad.jpg", CreatedDate = DateTime.Now, State = State.Created, CategoryID = 4 },
                new Food { Id = 21, FoodName = "Vegan Banana Pancakes", ProteinValue = 6, CarboValue = 30, FatValue = 5, Kcal = 200, Picture = "vegan_banana_pancakes.jpg", CreatedDate = DateTime.Now, State = State.Created, CategoryID = 4 }
            );

            // İçecek Kategorisi
            builder.HasData(
                new Food { Id = 22, FoodName = "Salatalık Nane Limonatası", ProteinValue = 1, CarboValue = 10, FatValue = 0, Kcal = 50, Picture = "cucumber_mint_lemonade.jpg", CreatedDate = DateTime.Now, State = State.Created, CategoryID = 5 },
                new Food { Id = 23, FoodName = "Vegan Çilekli Limonata", ProteinValue = 1, CarboValue = 15, FatValue = 0, Kcal = 60, Picture = "vegan_strawberry_lemonade.jpg", CreatedDate = DateTime.Now, State = State.Created, CategoryID = 5 },
                new Food { Id = 24, FoodName = "Vegan Pineapple Hindistan Cevizli Smoothie", ProteinValue = 3, CarboValue = 20, FatValue = 2, Kcal = 90, Picture = "vegan_pineapple_coconut_smoothie.jpg", CreatedDate = DateTime.Now, State = State.Created, CategoryID = 5 },
                new Food { Id = 25, FoodName = "Vegan Green Detox ", ProteinValue = 2, CarboValue = 12, FatValue = 1, Kcal = 70, Picture = "vegan_green_detox_juice.jpg", CreatedDate = DateTime.Now, State = State.Created, CategoryID = 5 },
                new Food { Id = 26, FoodName = "Vegan Iced Coffee", ProteinValue = 1, CarboValue = 25, FatValue = 3, Kcal = 120, Picture = "vegan_iced_coffee.jpg", CreatedDate = DateTime.Now, State = State.Created, CategoryID = 5 }
            );

            // Salata Kategorisi
            builder.HasData(
                new Food { Id = 27, FoodName = "Nohutlu Vegan Kinoa Salatası", ProteinValue = 10, CarboValue = 20, FatValue = 6, Kcal = 180, Picture = "mediterranean_quinoa_salad.jpg", CreatedDate = DateTime.Now, State = State.Created, CategoryID = 6 },
                new Food { Id = 28, FoodName = "Vegan Greek Salad", ProteinValue = 8, CarboValue = 15, FatValue = 10, Kcal = 160, Picture = "vegan_greek_salad.jpg", CreatedDate = DateTime.Now, State = State.Created, CategoryID = 6 },
                new Food { Id = 29, FoodName = "Vegan Avocado Caprese Salad", ProteinValue = 6, CarboValue = 10, FatValue = 15, Kcal = 170, Picture = "vegan_avocado_caprese_salad.jpg", CreatedDate = DateTime.Now, State = State.Created, CategoryID = 6 },
                new Food { Id = 30, FoodName = "Vegan Caesar Salad", ProteinValue = 5, CarboValue = 12, FatValue = 8, Kcal = 140, Picture = "vegan_caesar_salad.jpg", CreatedDate = DateTime.Now, State = State.Created, CategoryID = 6 },
                new Food { Id = 31, FoodName = "Vegan Coleslaw", ProteinValue = 3, CarboValue = 18, FatValue = 5, Kcal = 120, Picture = "vegan_coleslaw.jpg", CreatedDate = DateTime.Now, State = State.Created, CategoryID = 6 }
            );

            // Tatlı Kategorisi
            builder.HasData(
                new Food { Id = 32, FoodName = "Vegan Çikolatalı Parça Kurabiye", ProteinValue = 4, CarboValue = 20, FatValue = 10, Kcal = 180, Picture = "vegan_chocolate_chip_cookies.jpg", CreatedDate = DateTime.Now, State = State.Created, CategoryID = 7 },
                new Food { Id = 33, FoodName = "Vegan Brownie", ProteinValue = 5, CarboValue = 25, FatValue = 12, Kcal = 200, Picture = "vegan_brownie.jpg", CreatedDate = DateTime.Now, State = State.Created, CategoryID = 7 },
                new Food { Id = 34, FoodName = "Vegan Çikolatalı Kek", ProteinValue = 6, CarboValue = 30, FatValue = 15, Kcal = 220, Picture = "vegan_chocolate_cake.jpg", CreatedDate = DateTime.Now, State = State.Created, CategoryID = 7 },
                new Food { Id = 35, FoodName = "Vegan Havuçlu Kek", ProteinValue = 4, CarboValue = 22, FatValue = 10, Kcal = 180, Picture = "vegan_carrot_cupcakes.jpg", CreatedDate = DateTime.Now, State = State.Created, CategoryID = 7 },
                new Food { Id = 36, FoodName = "Vegan Raspberry Cheesecake", ProteinValue = 7, CarboValue = 18, FatValue = 14, Kcal = 240, Picture = "vegan_raspberry_cheesecake.jpg", CreatedDate = DateTime.Now, State = State.Created, CategoryID = 7 }
            );
        }

    }
}
