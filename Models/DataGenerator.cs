using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PastryShopApp.Models
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AppDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
                // Look for any Category
                if (context.Categories.Any())
                {
                    return;   // Data was already seeded
                }
                else
                {
                    context.Categories.AddRange(
                        new Category { CategoryId = 1, CategoryName = "filo pastry" },
                        new Category { CategoryId = 2, CategoryName = "flaky pastry" },
                        new Category { CategoryId = 3, CategoryName = "choux  pastry" },
                        new Category { CategoryId = 4, CategoryName = "puff pastry" }
                    );
                }
                // Look for any Pastry
                if (context.Pastries.Any())
                {
                    return;   // Data was already seeded
                }
                else
                {
                    context.Pastries.AddRange(
                        new Pastry
                        {
                            PastryId = 1,
                            PastryName = "Apple Pastry",
                            Price = 12.95M,
                            PastryShortDesc = "Our famous apple Pastries!",
                            PastryLongDesc = "Apple Pastry is a fruit Pastry (or tart) in which the principal filling ingredient is apples. It is sometimes served with whipped cream, Cheddar cheese, or ice cream on top. Pastry is generally used top-and-bottom, making it a double-crust pie, the upper crust of which may be a circular shaped crust or a pastry lattice woven of strips; exceptions are deep-dish apple pie with a top crust only, and open-face Tarte Tatin.",
                            CategoryId = 1,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/1/1e/FoodApplePie.jpg",
                            IsPastryInStock = true,
                            IsPastryOfWeek = true,
                            ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1e/FoodApplePie.jpg/240px-FoodApplePie.jpg",
                            AllergyInformation = ""
                        },
                        new Pastry
                        {
                            PastryId = 2,
                            PastryName = "Apple strudel",
                            Price = 18.95M,
                            PastryShortDesc = "You'll love it!",
                            PastryLongDesc = "Sliced apples and other fruit are wrapped and cooked in layers of filo pastry. The earliest known recipe is in Vienna, but several countries in central and eastern Europe claim this dish.",
                            CategoryId = 3,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/40/Strudel.jpg",
                            IsPastryInStock = true,
                            IsPastryOfWeek = false,
                            ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Strudel.jpg/240px-Strudel.jpg",
                            AllergyInformation = ""
                        },
                        new Pastry
                        {
                            PastryId = 3,
                            PastryName = "Puits d'amour",
                            Price = 18.95M,
                            PastryShortDesc = "You'll love it!",
                            PastryLongDesc =
                        "Translated in English as 'punch cake', a classical confection of pastry with a rum flavor. It is similar to the French pastry, the petit four. Commonly available in pastry shops and bakeries in Austria. It is a cake filled with cake crumbs, nougat chocolate, apricot jam and then soaked with rum. It is a cake filled with cake crumbs, nougat chocolate, apricot jam and then soaked with rum. The cake is cut into 1-1/2 inch square cubes,[1][2] covered with so-called Punschglasur (punch icing), a thick pink rum sugar glazing often drizzled with chocolate and a cocktail cherry on top. Nowadays, there are also Punschkrapfen in cylindrical form.",
                            CategoryId = 2,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/77/Punschkrapfen.jpg/2560px-Punschkrapfen.jpg",
                            IsPastryInStock = false,
                            IsPastryOfWeek = false,
                            ImageThumbnailUrl =
                        "https://upload.wikimedia.org/wikipedia/commons/thumb/7/77/Punschkrapfen.jpg/240px-Punschkrapfen.jpg",
                            AllergyInformation = ""
                        },
                        new Pastry
                        {
                            PastryId = 4,
                            PastryName = "Baklava",
                            Price = 15.95M,
                            PastryShortDesc = "Popular sweet pastries of Ottoman cuisine.",
                            PastryLongDesc = "Baklava is a layered pastry dessert made of filo pastry, filled with chopped nuts, and sweetened with syrup or honey. It was one of the most popular sweet pastries of Ottoman cuisine.[3] The pre-Ottoman origin of the dish is unknown, but, in modern times, it is a common dessert of Iranian, Turkish and Arab cuisines, and other countries of the Levant and Maghreb, along with the South Caucasus, Balkans, and Central Asia.",
                            CategoryId = 1,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/b/b7/Baklavas%2C_freshly_baked.jpg",
                            IsPastryInStock = true,
                            IsPastryOfWeek = false,
                            ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/commons/b/b7/Baklavas%2C_freshly_baked.jpg",
                            AllergyInformation = ""
                        },
                        new Pastry
                        {
                            PastryId = 5,
                            PastryName = "Bethmännchen",
                            Price = 13.95M,
                            PastryShortDesc = "Happy holidays with this pie!",
                            PastryLongDesc = "Bethmännchen (German for 'a little Bethmann) is a pastry made from marzipan with almond, powdered sugar, rosewater, flour and egg. It is a traditional cookie usually baked for Christmas Day and is widely available in chocolate shops around Frankfurt.[1] It is a special commodity sold in Frankfurt's Christmas market, one of the oldest Christmas markets [2] in Germany which dates back as far as 1393. The name comes from the family of Bethmann.[4] Legend has it that Parisian pastry chef Jean Jacques Gautenier developed the recipe for banker and city councilor Simon Moritz von Bethmann in 1838.[5] Originally the Bethmännchen were decorated with four almonds, one for each son of Simon Moritz. After the death of his son Heinrich in 1845, the fourth almond was removed. However, this story is unlikely, since Simon Moritz had died already in 1826. After one and a half centuries of manufacturing, its form and recipe has never been changed.",
                            CategoryId = 3,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/0/0d/Bethmaennchen_%28cropped%29.jpg",
                            IsPastryInStock = true,
                            IsPastryOfWeek = false,
                            ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/Bethmaennchen_%28cropped%29.jpg/240px-Bethmaennchen_%28cropped%29.jpg",
                            AllergyInformation = ""
                        },
                        new Pastry
                        {
                            PastryId = 6,
                            PastryName = "Boyoz",
                            Price = 17.95M,
                            PastryShortDesc = "A Turkish pastry associated with İzmir, Turkey",
                            PastryLongDesc = "A Turkish pastry associated with İzmir, Turkey. Boyoz paste is a mixture of flour, sunflower oil and a small addition of tahini. It is kneaded by hand and the ball of paste is left to repose for 2- hours. The paste is then flattened to the width of a dish and left to repose again. It is then kneaded and opened once more, before being formed into a roll and left to repose as such for a further period of several hours. When the tissue of the paste is still soft but about to detach into pieces, it is cut into small balls and put in rows of small pans and marinaded in vegetable oil between half an hour and one hour. Their paste then takes an oval form and acquires the consistence of a millefeuille. The small balls can then be put on a tray into a very high-temperature oven either in plain form or with fillings of cheese or spinach added inside.",
                            CategoryId = 3,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/59/Bossche_Bollen.jpg/1024px-Bossche_Bollen.jpg",
                            IsPastryInStock = true,
                            IsPastryOfWeek = false,
                            ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/59/Bossche_Bollen.jpg/320px-Bossche_Bollen.jpg",
                            AllergyInformation = ""
                        },
                        new Pastry
                        {
                            PastryId = 7,
                            PastryName = "Birnbrot Pie",
                            Price = 15.95M,
                            PastryShortDesc = "A traditional pastry originating in Switzerland.",
                            PastryLongDesc = "Birnbrot (literally pear bread) or Birnweggen (literally pear buns) are a traditional pastry originating in Switzerland with a filling of dried pears. They exist throughout Switzerland and popular variations include 'Bündener Birnbrot' (from the Kanton Graubünden), 'Glarner Birnbrot' (from the Kanton Glarus), 'Toggenburger Birnbrot' (from Toggenburg (district) and 'Luzerner Birnweggen' (from Luzern). Alongside dried pears the filling also contains raisins, walnuts and other dried fruit such as apples or figs. The filling is flavoured with candied fruit, coriander, cinnamon, star anise, anise, clove and some sort of alcohol. Birnweggen The difference between 'Birnbrot' and 'Birnweggen' lies in the way of preparation and the geographical prevalence: Birnbrot is prepared by mixing the filling with dough and surrounding it with a casing of yeast dough while Birnweggen are made by spreading the filling on a sheet of yeast dough and rolling it like a roulade. Birnweggen are popular in Zentralschweiz and Birnbrot can be found in the Ostschweiz near the Alps The variations of Toggenburg and Glarus cook and sear the pears before mixing it with the other ingredients. In Graubünden the pears are laid in pear brandy or rose water which gives a more distinguishable pear taste.",
                            CategoryId = 1,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/3/3c/B%C3%BCndner_Birnbrot.jpg",
                            IsPastryInStock = false,
                            IsPastryOfWeek = false,
                            ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3c/B%C3%BCndner_Birnbrot.jpg/240px-B%C3%BCndner_Birnbrot.jpg",
                            AllergyInformation = ""
                        },
                        new Pastry
                        {
                            PastryId = 8,
                            PastryName = "Canele Pie",
                            Price = 12.95M,
                            PastryShortDesc = "Our Halloween favorite",
                            PastryLongDesc = "A canelé (French: [kan.le]) is a small French pastry flavored with rum and vanilla with a soft and tender custard center and a dark, thick caramelized crust. It takes the shape of a small, striated cylinder up to five centimeters in height with a depression at the top. A specialty of the Bordeaux region of France, today it is widely available in pâtisseries in France and abroad. The canelé is believed to originate from the Couvent des Annonciades, Bordeaux in either the 15th or the 18th century.[1][2] (Though the article about this same pastry in the French Wikipedia Canelé says Différentes théories tentent de construire une histoire plus ancienne mais manquent totalement de fondement.Different theories attempt to construct a more ancient history but lack any foundation whatever.) The modern word canelé originates in Gascon, which was spoken in Bordeaux and a large area of southwestern France until the 19th century.[3] In Limoges, there was a food called canole, a bread made with flour and egg yolks, which may be the same item as that sold in Bordeaux since the 18th century under the name of canaule, also written canaulé or canaulet. Artisans known as canauliers who specialized in baking them registered a Corporation (or guild) with the Parliament of Bordeaux in 1663, which allowed only them to produce several specific foods: Blessed bread, canaules, and Retortillons. Since they were not a part of the Pastry Corporation (Guild), which had a monopoly over baking with milk and sugar or mixtionnée dough, they were prohibited from using those ingredients. The canauliers disputed the Pastry Chefs' privileges and on 3 March 1755 the council of State in Versailles ruled for the canauliers and ended the Pastry Chefs' monopoly. An edict of 1767 limited the number of authorized canaulier shops in a city to eight. It created very strict requirements for joining the profession. Nevertheless, in 1785 there were at least 39 canaulier shops in Bordeaux, at least ten of which were in the district (faubourg) of Saint-Seurin. The French Revolution abolished all the Corporations, but later census rolls continue to show shops of Canauliers and bakers of blessed bread. In the first quarter of the 20th century the canelé reappeared, even if it is difficult to date exactly when. An unknown pastry chef re-popularised the antique recipe of canauliers. He added rum and vanilla to his dough. It is likely that its current shape comes from the similarity (in French) of the word wave with the word 'cannelure' (fluting, corrugation, striations). The modern name 'canelé' is of recent origin. The Guide Gourmand de la France[4] does not mention it. Only in 1985, after the pastry's popularity had begun to explode, was the Brotherhood of the Canelé of Bordeaux (Confrérie du Canelé de Bordeaux)[5] created and the second 'n' of its name removed. The name canelé became a collective brand,[2][6] registered with the National Institute of Industrial Property of France by the Brotherhood. Ten years after the registration of the brand, there were at least 800 manufacturers in Aquitaine and 600 in the Gironde. In 1992, Gironde alone consumed an estimated 4.5 million canelés.",
                            CategoryId = 3,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/a/aa/Caneles_stemilion.jpg",
                            IsPastryInStock = true,
                            IsPastryOfWeek = true,
                            ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/aa/Caneles_stemilion.jpg/240px-Caneles_stemilion.jpg",
                            AllergyInformation = ""
                        },

                        new Pastry
                        {
                            PastryId = 9,
                            PastryName = "Gustavus",
                            Price = 15.95M,
                            PastryShortDesc = "My God, so sweet!",
                            PastryLongDesc = "Pastry named for King Gustavus Adolphus of Sweden, eaten every year on his memorial day, Gustavus Adolphus Day, 6 November. There are different recipes, but what they all have in common is a portrait of the king on top, made in chocolate or marzipan. Gustavus Adolphus pastry[1] (Swedish: Gustaf Adolfsbakelse) is a pastry traditionally eaten every 6 November in Sweden, Gustavus Adolphus Day, the death day of King Gustavus Adolphus the Great. It is especially popular in Gothenburg, a city founded by the king.[2] The pastry was created around 1900. Candy with the image of the king was sold by a konditorei in Gothenburg since the 1850s.[2] The earliest mention of a pastry is from the Western parts of Sweden during the 1890s,[2][3] where the pastry probably was created around the festivities when a statue of the king was erected in Gothenburg on a square, that since then is known as Gustaf Adolfs torg[2][4] ('Gustavus Adolphus Square'). One Gothenburg bakery, Bräutigams, claims to have created it in the early 20th century, with the years 1905 or 1909 mentioned.[4][5][6] Recipes for the pastry vary locally but most versions have a portrait of the king on the top, usually made of chocolate or marzipan.[2] In 2003, a competition arranged by Livrustkammaren and Gastronomiska akademien ('Gastronomic Academy of Sweden') elected a winner without the king's portrait.[7] The Swedish bakeries and konditoreis however preferred their old versions,[8] so the attempt to establish a standard Gustavus Adolphus pastry failed. Exactly how many Gustav Adolphus pastries are sold in November each year is not known. The newspaper Göteborgs-Tidningen in 2009 approximated the total Swedish sales and consumption to more than 10 000.[4]",
                            CategoryId = 1,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/c/cd/GustavAdolfBakelse.jpg",
                            IsPastryInStock = true,
                            IsPastryOfWeek = true,
                            ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cd/GustavAdolfBakelse.jpg/240px-GustavAdolfBakelse.jpg",
                            AllergyInformation = ""
                        },
                        new Pastry
                        {
                            PastryId = 10,
                            PastryName = "Lattice Pie",
                            Price = 15.95M,
                            PastryShortDesc = "Our delicious Lattice pie!",
                            PastryLongDesc = "A pastry used in a criss-crossing pattern of strips in the preparation of various foods. Latticed pastry is used as a type of lid on many various tarts and pies. The openings between the lattice allows fruit juices in pie fillings to evaporate during the cooking process, which can caramelize the filling.[59] Pictured is a strawberry-rhubarb pie with lattice pastry. Lattice pastry is a pastry used in a criss-crossing pattern of strips in the preparation of various foods. Latticed pastry is used as a type of lid on many various tarts and pies. The openings between the lattice allows fruit juices in pie fillings to evaporate during the cooking process, which can caramelize the filling.[1] Lattice pastry is a pastry used in a criss-crossing pattern of strips in the preparation of various foods. Latticed pastry is used as a type of lid on many various tarts and pies. The openings between the lattice allows fruit juices in pie fillings to evaporate during the cooking process, which can caramelize the filling.[1]",
                            CategoryId = 1,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/1/1e/Strawberry-rhubarb_pie_with_pastry_lattice%2C_May_2008.jpg",
                            IsPastryInStock = true,
                            IsPastryOfWeek = false,
                            ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1e/Strawberry-rhubarb_pie_with_pastry_lattice%2C_May_2008.jpg/240px-Strawberry-rhubarb_pie_with_pastry_lattice%2C_May_2008.jpg",
                            AllergyInformation = ""
                        },
                        new Pastry
                        {
                            PastryId = 11,
                            PastryName = "Macaron",
                            Price = 18.95M,
                            PastryShortDesc = "You'll love it!",
                            PastryLongDesc = "These have a debated origin but the earliest form of modern macaron was likely baked in France in the 1800s. French macarons are made with a mixture of almond flour and confectioners' sugar which is folded into a meringue of stiffly beaten egg whites. This mixture is tinted with food coloring and baked into disks, which are sandwiched with buttercream, ganache, or curd. Known for its smooth skin, ruffled feet, and delicate texture.",
                            CategoryId = 2,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2f/Arc-en-ciel_comestible.jpg/2560px-Arc-en-ciel_comestible.jpg",
                            IsPastryInStock = false,
                            IsPastryOfWeek = false,
                            ImageThumbnailUrl =
                        "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2f/Arc-en-ciel_comestible.jpg/240px-Arc-en-ciel_comestible.jpg",
                            AllergyInformation = ""
                        },
                        new Pastry
                        {
                            PastryId = 12,
                            PastryName = "Marillenknödel",
                            Price = 18.95M,
                            PastryShortDesc = "You'll love it!",
                            PastryLongDesc = "A pastry found in the traditional Bohemian and Viennese cuisines. 'Marillen' is the Austrian term for apricots and this pastry is found predominantly in areas where apricot orchards are common. Examples of such areas would include the Wachau and Vinschgau. Small dumplings are formed from dough, in which apricots are placed. The dumplings are then boiled and covered in streusel and powdered sugar. The dough is usually made of potato but is also made from 'Topfenteig' (quark cheese).",
                            CategoryId = 2,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/f/fe/Aprikosenkn%C3%B6del.jpg",
                            IsPastryInStock = false,
                            IsPastryOfWeek = true,
                            ImageThumbnailUrl =
                        "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fe/Aprikosenkn%C3%B6del.jpg/240px-Aprikosenkn%C3%B6del.jpg",
                            AllergyInformation = ""
                        },
                        new Pastry
                        {
                            PastryId = 13,
                            PastryName = "Milhoja",
                            Price = 18.95M,
                            PastryShortDesc = "You'll love it!",
                            PastryLongDesc = "A dessert made with stacked layers of puff pastry[69] filled with dulce de leche; a creamy mix of condensed milk, sugar, and vanilla; or sometimes white chocolate. In Argentina it's filled with Dulce de leche and topped with Italian merengue. Milhojas ('thousand sheets') are desserts made with stacked layers of puff pastry,[1] filled with dulce de leche; a creamy mix of condensed milk, sugar, and vanilla; or white chocolate. They are part of the cuisines of Argentina, Bolivia, Ecuador, Colombia, Chile, El Salvador, Guatemala, Mexico,[1] Peru, Portugal, Spain, UK (Gibraltar), Uruguay, and Venezuela.",
                            CategoryId = 2,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/c/c9/Milhojas_-_2009.jpg",
                            IsPastryInStock = false,
                            IsPastryOfWeek = true,
                            ImageThumbnailUrl =
                        "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c9/Milhojas_-_2009.jpg/240px-Milhojas_-_2009.jpg",
                            AllergyInformation = ""
                        },
                        new Pastry
                        {
                            PastryId = 14,
                            PastryName = "Mille-feuille",
                            Price = 18.95M,
                            PastryShortDesc = "You'll love it!",
                            PastryLongDesc =
                        "The mille-feuille (French pronunciation: [mil fœj], 'thousand sheets'),[71] vanilla slice, cream slice, custard slice, also known as the Napoleon or kremschnitt, is a pastry originating in France. Traditionally, a mille-feuille is made up of three layers of puff pastry (pâte feuilletée), alternating with two layers of pastry cream (crème pâtissière), but sometimes whipped cream, or jam are substituted. The top pastry layer is dusted with confectioner's sugar, and sometimes cocoa, or pulverized nuts (e.g. roasted almonds). Alternatively the top is glazed with icing or fondant in alternating white (icing) and brown (chocolate) stripes, and combed.",
                            CategoryId = 2,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/6/6b/Mille-feuille_20100916.jpg",
                            IsPastryInStock = false,
                            IsPastryOfWeek = true,
                            ImageThumbnailUrl =
                        "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6b/Mille-feuille_20100916.jpg/240px-Mille-feuille_20100916.jpg",
                            AllergyInformation = ""
                        },
                        new Pastry
                        {
                            PastryId = 15,
                            PastryName = "Chatti Pathiri",
                            Price = 18.95M,
                            PastryShortDesc = "You'll love it!",
                            PastryLongDesc =
                        "A layered pastry made in the North Malabar and Malabar region, of Kerala State. It is made in both sweet and savory variations. The dish is very similar to the Italian lasagna. Instead of pasta; pastry sheets or pancakes made with flour, egg, oil and water are used.",
                            CategoryId = 2,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/cd/S6001271.JPG",
                            IsPastryInStock = false,
                            IsPastryOfWeek = false,
                            ImageThumbnailUrl =
                        "https://upload.wikimedia.org/wikipedia/en/thumb/c/cd/S6001271.JPG/220px-S6001271.JPG",
                            AllergyInformation = ""
                        },
                        new Pastry
                        {
                            PastryId = 16,
                            PastryName = "Samosa",
                            Price = 18.95M,
                            PastryShortDesc = "You'll love it!",
                            PastryLongDesc =
                        "A fried or baked pastry with a savory filling such as spiced potatoes, onions, peas, lentils, ground lamb or chicken. The size, shape and consistency may vary, but many versions are triangular. Samosas are often accompanied by chutney.[95] Samosas are a popular appetizer or snack in the Indian subcontinent, Southeast Asia, Central Asia and Southwest Asia, the Arabian Peninsula, the Mediterranean, the Horn of Africa, North Africa, and South Africa. South Asian samosa has central Asian or middle eastern origin.[11] The samosa appeared in the Indian subcontinent, following the invasion of the Central Asian Turkic dynasties in the region.[12] A praise of the precursor of the samosa (as sanbusaj) can be found in a ninth century poem by Persian poet Ishaq al-Mawsili. Recipes are found in 10th–13th-century Arab cookery books, under the names sanbusak, sanbusaq, and sanbusaj, all deriving from the Persian word sanbosag. In Iran, the dish was popular until the 16th century, but by the 20th century, its popularity was restricted to certain provinces (such as the sambusas of Larestan).[3] Abolfazl Beyhaqi (995-1077), an Iranian historian, mentioned it in his history, Tarikh-e Beyhaghi.",
                            CategoryId = 2,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/c/cb/Samosachutney.jpg",
                            IsPastryInStock = false,
                            IsPastryOfWeek = false,
                            ImageThumbnailUrl =
                        "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cb/Samosachutney.jpg/280px-Samosachutney.jpg",
                            AllergyInformation = ""
                        },
                        new Pastry
                        {
                            PastryId = 17,
                            PastryName = "Welsh cake",
                            Price = 18.95M,
                            PastryShortDesc = "You'll love it!",
                            PastryLongDesc =
                        "Welsh cakes are made from flour, butter/lard, currants, eggs, milk, and spices such as cinnamon and nutmeg.They are roughly circular, a few inches (7–8 cm) in diameter and about half an inch (1–1.5 cm) thick. Fried in butter in a pan or on a bakestone, Welsh cakes are served hot or cold and dusted with caster sugar. They are frequently made fresh and sold in bakeries throughout Wales but can also be bought pre-packed in good supermarkets in the rest of the UK.",
                            CategoryId = 2,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/45/Closeup_of_Welsh_cakes%2C_February_2009.jpg",
                            IsPastryInStock = false,
                            IsPastryOfWeek = false,
                            ImageThumbnailUrl =
                        "https://upload.wikimedia.org/wikipedia/commons/thumb/4/45/Closeup_of_Welsh_cakes%2C_February_2009.jpg/240px-Closeup_of_Welsh_cakes%2C_February_2009.jpg",
                            AllergyInformation = ""
                        },
                        new Pastry
                        {
                            PastryId = 18,
                            PastryName = "Strudel",
                            Price = 18.95M,
                            PastryShortDesc = "You'll love it!",
                            PastryLongDesc =
                        "Layered pastry, typically with a sweet filling inside. Often served with cream. Strudel became well known and gained popularity in the 18th century through the Habsburg Empire. Pictured is a pecan strudel. See also – Apple strudel; Milk-cream strudel. The best-known strudels are Apfelstrudel (German for apple strudel) and Topfenstrudel (with sweet soft quark, in Austrian German Topfen), followed by the Millirahmstrudel (Milk-cream strudel, Milchrahmstrudel). Other strudel types include sour cherry (Weichselstrudel), sweet cherry, nut filled (Nussstrudel), Apricot Strudel, Plum Strudel, poppy seed strudel (Mohnstrudel), and raisin strudel.[7] There are also savoury strudels incorporating spinach, cabbage, potato, pumpkin, and sauerkraut,[8] and versions containing meat fillings like the Lungenstrudel or Fleischstrudel. Traditional strudel pastry differs from puff pastry in that it is very elastic. It is made[9] from flour with a high gluten content, water, oil and salt, with no sugar added. The dough is worked vigorously, rested, and then rolled out and stretched by hand very thinly with the help of a clean linen tea towel[10] or kitchen paper.[11] There are numerous techniques for manually pulling strudel dough. One method is to roll the dough thin before laying it over the back of the hands and drawing it thin by pulling the hands apart from one another.[12] Purists say that it should be so thin that you can read a newspaper through it. A legend has it that the Austrian Emperor's perfectionist cook decreed that it should be possible to read a love letter through it. The thin dough is laid out on a tea towel, and the filling is spread on it. The dough with the filling on top is rolled up carefully with the help of the tea towel and baked in the oven.",
                            CategoryId = 4,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/2/2b/Pecan_Strudel_profile%2C_November_2009.jpg",
                            IsPastryInStock = false,
                            IsPastryOfWeek = false,
                            ImageThumbnailUrl =
                        "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2b/Pecan_Strudel_profile%2C_November_2009.jpg/240px-Pecan_Strudel_profile%2C_November_2009.jpg",
                            AllergyInformation = ""
                        },
                        new Pastry
                        {
                            PastryId = 19,
                            PastryName = "Sufganiyah",
                            Price = 18.95M,
                            PastryShortDesc = "You'll love it!",
                            PastryLongDesc =
                        "A Chinese bakery product traditionally eaten during the Mid-Autumn Festival / Zhongqiu Festival. The festival is for lunar worship and moon watching, when mooncakes are regarded as an indispensable delicacy. Typically round or rectangular pastries. A rich thick filling usually made from red bean or lotus seed paste is surrounded by a thin (2–3 mm) crust and may contain yolks from salted duck eggs. Mooncakes are usually eaten in small wedges accompanied by Chinese tea.",
                            CategoryId = 4,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/9/98/Mooncake.jpg",
                            IsPastryInStock = false,
                            IsPastryOfWeek = false,
                            ImageThumbnailUrl =
                        "https://upload.wikimedia.org/wikipedia/commons/thumb/9/98/Mooncake.jpg/240px-Mooncake.jpg",
                            AllergyInformation = ""
                        },
                        new Pastry
                        {
                            PastryId = 20,
                            PastryName = "Pineapple cake",
                            Price = 18.95M,
                            PastryShortDesc = "You'll love it!",
                            PastryLongDesc = "Pineapple became a critical component of Taiwan's economy during the Japanese era, during which Japanese industrialists imported a wide variety of pineapple cultivars and established numerous processing plants.[2] By the late 1930s, Taiwan had become the third-largest exporter of pineapples in the world.[2] However, when pineapple production in Taiwan shifted toward domestic sales and use of fresh pineapple, local bakeries sought to use this surplus in pastries.[3] While pineapple cakes had historically been produced as a ceremonial food, a combination of governmental promotion and globalization popularized the pineapple cake. Pineapple cakes have become one of the top-selling souvenirs in Taiwan. Since 2005, the Taipei City Government has run an annual Taipei Pineapple Cake Cultural Festival to foster the growth the local tourism industry and promote sales of the pineapple cake.[5][6] In 2013, the revenue from Taiwan's pineapple cake bakeries totaled NT$40 billion (US$1.2 billion), and sales of pineapple cakes have also bolstered agricultural economies in rural parts of the country. The Chinese government will begin the embargo on March 1, 2021",
                            CategoryId = 4,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/6/64/Pineapple_Pastry.JPG",
                            IsPastryInStock = true,
                            IsPastryOfWeek = true,
                            ImageThumbnailUrl =
                        "https://upload.wikimedia.org/wikipedia/commons/thumb/6/64/Pineapple_Pastry.JPG/240px-Pineapple_Pastry.JPG",
                            AllergyInformation = ""
                        },
                        new Pastry
                        {
                            PastryId = 21,
                            PastryName = "Charlotte Pie",
                            Price = 18.95M,
                            PastryShortDesc = "You'll love it!",
                            PastryLongDesc = "A charlotte is a type of dessert or trifle that can be served hot or cold. It is also referred to as an 'icebox cake'. Bread, sponge cake or biscuits/cookies are used to line a mold, which is then filled with a fruit puree or custard. It can also be made using layers of breadcrumbs. The variant Charlotte russe uses a mold lined with ladyfingers and filled with Bavarian cream. Classically, stale bread dipped in butter was used as the lining, but sponge cake or ladyfingers may be used today. The filling may be covered with a thin layer of similarly flavoured gelatin. A type of trifle that can be served hot or cold. It can also be known as an 'ice-box cake'. Sweet Bread, sponge cake or biscuits/cookies are used to line a mold, which is then filled with a fruit puree or custard.",
                            CategoryId = 4,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/0/04/Charlotte_aux_poires_et_chocolat.jpg",
                            IsPastryInStock = true,
                            IsPastryOfWeek = true,
                            ImageThumbnailUrl =
                        "https://upload.wikimedia.org/wikipedia/commons/thumb/0/04/Charlotte_aux_poires_et_chocolat.jpg/240px-Charlotte_aux_poires_et_chocolat.jpg",
                            AllergyInformation = ""
                        }


                        );
                    context.SaveChanges();
                }
                if (context.ShoppingCartItems.Any())
                {
                    return;   // Data was already seeded
                }
                else
                {
                }
            }
        }
    }
}