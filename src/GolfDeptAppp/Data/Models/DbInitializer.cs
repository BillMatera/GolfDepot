using GolfDeptAppp.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace GolfDeptAppp.Data.Models
{
  
        public class DbInitializer
        {
            public static void Seed(IApplicationBuilder applicationBuilder)
            {
                AppDbContext context =
                    applicationBuilder.ApplicationServices.GetRequiredService<AppDbContext>();

                if (!context.Categories.Any())
                {
                    context.Categories.AddRange(Categories.Select(c => c.Value));
                }

                if (!context.Clubs.Any())
                {
                    context.AddRange
                    (
                         new Club
                         {
                             Name = "Taylormade M2 Driver",
                             Price = 399.00M,
                             ShortDescription = "New TaylorMade M2 Driver, Silver",
                             LongDescription = "BETTER EVERYTHING. The 2017 M2 driver brings golfers a new level of distance and forgiveness through all-new GeocousticTM technology. Along with the new Geocoustic design, the M2 driver houses a new Speed Pocket that is three times more flexible than it was in the original M2.",
                             Category = Categories["Driver"],
                             ImageUrl = "http://www.taylormadegolf.com/on/demandware.static/-/Sites-tmag-master-catalog/default/v1508141825333/zoom/WZ599_zoom_D.jpg",
                             InStock = true,
                             IsPreferredClub = true,
                             ImageThumbnailUrl = "http://www.taylormadegolf.com/on/demandware.static/-/Sites-tmag-master-catalog/default/v1508141825333/zoom/WZ599_zoom_D.jpg"
                         },
                    new Club
                    {
                        Name = "Callaway Driver",
                        Price = 159.99M,
                        ShortDescription = "Callaway XR Driver, Right Hand",
                        LongDescription = "Callaway XR Driver features speed from speed step crown to reduce drag and maximize speed through the swing, we have put in a Speed Step Crown and combined it with an optimized aerodynamic head shape. This driver has speed from R MOTO face technology.",
                        Category = Categories["Driver"],
                        ImageUrl = "https://s7d2.scene7.com/is/image/dkscdn/14CWYMXRDRVRXXDRV_is/",
                        InStock = true,
                        IsPreferredClub = false,
                        ImageThumbnailUrl = "https://s7d2.scene7.com/is/image/dkscdn/14CWYMXRDRVRXXDRV_is/"
                    },
                    new Club
                    {
                        Name = "Callaway Big Bertha Driver ",
                        Price = 393.95M,
                        ShortDescription = "Callaway Big Bertha Alpha Double Black Diamond Driver",
                        LongDescription = "Stiff Flex. The Callaway Big Bertha Alpha 816 Double Black Diamond driver features a Tour inspired shape, Dual Distance chambers, Gravity Core technology and Next Gen RMOTO technology.",
                        Category = Categories["Driver"],
                        ImageUrl = "https://www.carlsgolfland.com/media/catalog/product/cache/1/image/1200x/9df78eab33525d08d6e5fb8d27136e95/c/a/callaway_big_bertha_alpha_816_driver.jpg",
                        InStock = true,
                        IsPreferredClub = false,
                        ImageThumbnailUrl = "https://www.carlsgolfland.com/media/catalog/product/cache/1/image/1200x/9df78eab33525d08d6e5fb8d27136e95/c/a/callaway_big_bertha_alpha_816_driver.jpg"
                    },
                    new Club
                    {
                        Name = "GX-7 Driver ",
                        Price = 199.00M,
                        ShortDescription = "GX-7 Driver Left Handed",
                        LongDescription = "The new revolutionary GX-7 Driver quickly eliminates bad drives! Play from the tee or from the turf with the new GX-7 Driver delivering the distance of a driver",
                        Category = Categories["Driver"],
                        ImageUrl = "https://cdn-s3.si.com/s3fs-public/golf/1484690045/Bridgestone-Tour-B-XD-7-Driver.jpg ",
                        InStock = true,
                        IsPreferredClub = false,
                        ImageThumbnailUrl = "https://cdn-s3.si.com/s3fs-public/golf/1484690045/Bridgestone-Tour-B-XD-7-Driver.jpg"
                    },
                    new Club
                    {
                        Name = "PING G30 Driver",
                        Price = 240.00M,
                        ShortDescription = "A cocktail with sec, tequila and lime",
                        Category = Categories["Driver"],
                        LongDescription = "SF (Straight Flight) Tec models are available in 10∞ and 12∞ loft options and feature heel weighting that promotes a straighter ball flight T9S face material has a higher strength/weight ratio Thinner, hotter face adds distance and is more forgiving Thin crown walls help stabilize sound and save weight Increased perimeter weighting TFC 419D shaft has a higher balance point that can accommodate a heavier head",
                        ImageUrl = "https://imgs.2ndswing.com/images/clean-product/large/G30%20NEW%20FWG.jpg",
                        InStock = true,
                        IsPreferredClub = false,
                        ImageThumbnailUrl = "https://imgs.2ndswing.com/images/clean-product/large/G30%20NEW%20FWG.jpg"
                    },
                    new Club
                    {
                        Name = "Ping G400 Driver,",
                        Price = 399.00M,
                        ShortDescription = "Ping G400 Driver, Grey, Right Hand",
                        LongDescription = "Ping G400 Driver The multi-material design of the Ping G400 Driver combines drag-reducing technology with a speed-inducing forged face and MOI-raising tungsten sole weight to deliver longer drives and fairway-finding forgiveness. Features: Faster Shape Streamlined design combines with bolder turbulators and Vortec Technology to advance aerodynamics (15% less drag) for more clubhead speed.",
                        Category = Categories["Driver"],
                        ImageUrl = "https://usatgolfweek.files.wordpress.com/2017/07/ping-g400.jpg?w=1000&h=600&crop=1",
                        InStock = false,
                        IsPreferredClub = false,
                        ImageThumbnailUrl = "https://usatgolfweek.files.wordpress.com/2017/07/ping-g400.jpg?w=1000&h=600&crop=1"
                    },
                    new Club
                    {
                        Name = "Cobra Mens King F7+ Driver",
                        Price = 249.99M,
                        ShortDescription = "Cobra Mens King F7+ Driver Fujikura Pro XLR8 Black Regular Right Adjustable",
                        LongDescription = "The Cobra King F7+ Driver is Cobra's largest oversized driver delivers maximum playable distance with extreme forgiveness.it's Measurably Better. Three different CG settings in the front, back, and heel positions result in three very different ball flights to help you tune your optimum distance and trajectory under variable conditions. This helps to generate more ball speed on off center hits for effortless distance. Forged Ti-811 E9 Face A new, re-engineered Forged 8-11 Titanium E9 Fave is a variable thickness structure that is lighter, thinner, and hotter, creating faster ball speeds and a large sweet zone across the face.",
                        Category = Categories["Driver"],
                        ImageUrl = "https://cdn-s3.si.com/s3fs-public/2017/02/28/cobra-king-f7-background-new.png",
                        InStock = false,
                        IsPreferredClub = false,
                        ImageThumbnailUrl = "https://cdn-s3.si.com/s3fs-public/2017/02/28/cobra-king-f7-background-new.png"
                    },
                    new Club
                    {
                        Name = "Callaway Golf 2017 GBB Epic Star Driver",
                        Price = 699.99M,
                        ShortDescription = "Callaway Golf 2017 GBB Epic Star Driver 10.5 Mens/Right - Callaway Golf Drivers",
                        LongDescription = "Epic performance comes in a lightweight package with the Callaway GBB EPIC STAR Driver. Weighing just 286g, EPIC STAR features Jailbreak Technology to radically change how the head and face react at impact for distance. Exo-Cage and Triaxial Carbon allow for the optimization of discretionary weight placement for stability and forgiveness. An ultra-light Mitsubishi Grand Bassara shaft and Golf Pride J200 Grip help golfers take speed to new heights.",
                        Category = Categories["Driver"],
                        ImageUrl = "https://d3d71ba2asa5oz.cloudfront.net/40000065/images/14cal17epicsdmrhrega610501.jpg",
                        InStock = false,
                        IsPreferredClub = false,
                        ImageThumbnailUrl = "https://d3d71ba2asa5oz.cloudfront.net/40000065/images/14cal17epicsdmrhrega610501.jpg"
                    },
                    new Club
                    {
                        Name = "Men's Ray Cook Silver Ray SR600 ",
                        Price = 39.99M,
                        ShortDescription = "Men's Ray Cook Silver Ray SR600 35-Inch Right Hand Putter, Multicolor, 35",
                        LongDescription = "These premium cast putters are precisely tour weighted and balanced to provide a soft feel and offer optimum putting consistency. Features: Loft: 3* Lie: 70* Offset: Plumbers Neck Full Shaft Offset Head weight: 360 Grams",
                        Category = Categories["Putter"],
                        ImageUrl = "http://d3d71ba2asa5oz.cloudfront.net/40000065/images/11raysr600pmrhregst35i01.jpg",
                        InStock = false,
                        IsPreferredClub = false,
                        ImageThumbnailUrl = "http://d3d71ba2asa5oz.cloudfront.net/40000065/images/11raysr600pmrhregst35i01.jpg"
                    },
                    new Club
                    {
                        Name = "Cleveland 2135 Satin Elevado ",
                        Price = 149.99M,
                        ShortDescription = "Cleveland 2135 Satin Elevado Putters w/Pistol Grip Right 33",
                        LongDescription = "The new TFI 2135 Satin putters bring revolutionary feel - performance - and alignment technologies so you can setup and stroke putts more consistently.",
                        Category = Categories["Putter"],
                        ImageUrl = "http://d3d71ba2asa5oz.cloudfront.net/40000065/images/10clvtfi101mlhregst33i01one.jpg",
                        InStock = false,
                        IsPreferredClub = false,
                        ImageThumbnailUrl = "http://d3d71ba2asa5oz.cloudfront.net/40000065/images/10clvtfi101mlhregst33i01one.jpg"
                    },
                    new Club
                    {
                        Name = "New TaylorMade Daddy Long Legs Putter ",
                        Price = 99.99M,
                        ShortDescription = "New TaylorMade Daddy Long Legs Putter 34' Left Handed (No HC)",
                        LongDescription = "LEFT HANDED TaylorMade Daddy Long Legs putter 34 inches in length with a TaylorMade Winn Style Grip. The Daddy Long legs head is made of out 16 pieces and 8 different materials. The end result is the highest MOI of any putter TaylorMade has ever produced. That means you get amazing feel on the greens. Please note this putter is new, never hit, but does NOT come with the matching headcover. It is not included or available.",
                        Category = Categories["Putter"],
                        ImageUrl = "http://14043-presscdn-0-31.pagely.netdna-cdn.com/wp-content/uploads/2015/06/taylormade-daddy-long-lega.jpg",
                        InStock = false,
                        IsPreferredClub = false,
                        ImageThumbnailUrl = "http://14043-presscdn-0-31.pagely.netdna-cdn.com/wp-content/uploads/2015/06/taylormade-daddy-long-lega.jpg"
                    },
                    new Club
                    {
                        Name = "Cleveland TFi 2135 8.0 CB Putter",
                        Price = 99.99M,
                        ShortDescription = "Cleveland TFi 2135 8.0 CB Putter | RH | Steel | 38 inch ",
                        LongDescription = "We all have different putting strokes, address positions, and club preferences. And setting up over the ball perfectly every time is nearly impossible, leading to misalignment and off-center hits. As a result, we have developed an alignment technology that allows you to correctly align your putt no matter your set up- We call it 2135. There are too many things to worry about when you're trying to putt to win the hole or save par. Alignment doesn't have to be one of them. ",
                        Category = Categories["Putter"],
                        ImageUrl = "https://cdn.hurricanegolf.com/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/c/l/cleveland_tfi2135elevadoputter_sole_6.jpg",
                        InStock = false,
                        IsPreferredClub = false,
                        ImageThumbnailUrl = "https://cdn.hurricanegolf.com/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/c/l/cleveland_tfi2135elevadoputter_sole_6.jpg"
                    },
                    new Club
                    {
                        Name = "Odyssey White Hot",
                        Price = 99.99M,
                        ShortDescription = "Odyssey White Hot Pro 2.0 #1 Putter, Right Hand",
                        LongDescription = "Leaderboard Proven. Odyssey White Hot Pro 2.0 incorporates an improved version of the #1 insert on Tour to ensure the performance that elite players demand from a putter that's proven week in and week out on the leaderboards. Slay More Demons And Sink More Putts",
                        Category = Categories["Putter"],
                        ImageUrl = "http://www.puetzgolf.com/media/catalog/product/cache/1/image/1001x/9df78eab33525d08d6e5fb8d27136e95/o/d/odyssey-white-hot-rx-_9-back.jpg",
                        InStock = false,
                        IsPreferredClub = false,
                        ImageThumbnailUrl = "http://www.puetzgolf.com/media/catalog/product/cache/1/image/1001x/9df78eab33525d08d6e5fb8d27136e95/o/d/odyssey-white-hot-rx-_9-back.jpg"
                    },
                    new Club
                    {
                        Name = "Nike Method Core",
                        Price = 89.99M,
                        ShortDescription = "Nike Method Core X Mc-3I Putter",
                        LongDescription = "Putt with complete confidence while using the Method Core X MC-3i putter. The tour-proven RZN Groove Insert promotes forward roll and softens response for exceptional feel. The perimeter weighted 304 stainless steel head encourages consistency and precision, while increasing responsiveness.",
                        Category = Categories["Putter"],
                        ImageUrl = "https://imgs.2ndswing.com/images/clean-product/large/METHOD%20CORE%20MC3I%20PUT.jpg",
                        InStock = false,
                        IsPreferredClub = false,
                        ImageThumbnailUrl = "https://imgs.2ndswing.com/images/clean-product/large/METHOD%20CORE%20MC3I%20PUT.jpg"
                    },
                    new Club
                    {
                        Name = "Ping Cadence TR ",
                        Price = 159.99M,
                        ShortDescription = "Ping Cadence TR Series Craz-E-R Putters Right 33 Light",
                        LongDescription = "It varies in width to achieve a more-responsive face with feel of a traditional non-grooved face. Golfers can choose a standard-weight model with an aluminum insert or a heavyweight model with a steel insert to match their stroke tempo and improve their consistency. The sightline extends from top of the face to the back for easy alignment and more confidence.",
                        Category = Categories["Putter"],
                        ImageUrl = "https://imgs.2ndswing.com/images/clean-product/large/CAD%20TR%20RUSTL%20NEW%20PUT.jpg",
                        InStock = true,
                        IsPreferredClub = true,
                        ImageThumbnailUrl = "https://imgs.2ndswing.com/images/clean-product/large/CAD%20TR%20RUSTL%20NEW%20PUT.jpg"
                    },
                    new Club
                    {
                        Name = "Titleist Scotty Cameron  ",
                        Price = 379.00M,
                        ShortDescription = " Titleist Scotty Cameron Select Newport 2 Mallet Putters - 33 - Right Hand ",
                        LongDescription = "Scotty Cameron Select Newport M2 Mallet. Rectangular, boxy mid-mallet with 6061 aircraft aluminum face-sole technology, flowing single-bend shaft, and pop-through flange alignment system. 6061 aircraft grade aluminum inlays and face-sole construction selected for models designed for higher MOI and ìstraight-back/straight-throughî strokes. Integrated vibration dampening system which connects mid-milled face inlays and face-sole components to putter heads for soft but solid feel. Select heel-and-toe weighting technology, perfectly matched to shaft length. Red Matador Midsize grips. ",
                        Category = Categories["Putter"],
                        ImageUrl = "http://lghttp.51695.nexcesscdn.net/802BA50/magento//images/image/8d/scotty-cameron-golo-5-round-back-golf-putter-back.jpg",
                        InStock = true,
                        IsPreferredClub = false,
                        ImageThumbnailUrl = "http://lghttp.51695.nexcesscdn.net/802BA50/magento//images/image/8d/scotty-cameron-golo-5-round-back-golf-putter-back.jpg"
                    }
                    );
                }

                context.SaveChanges();
            }

            private static Dictionary<string, Category> categories;
            public static Dictionary<string, Category> Categories
            {
                get
                {
                    if (categories == null)
                    {
                        var genresList = new Category[]
                        {
                        new Category { CategoryName = "Driver", Description="All Drivers" },
                        new Category { CategoryName = "Putter", Description="All Putters" }
                        };

                        categories = new Dictionary<string, Category>();

                        foreach (Category genre in genresList)
                        {
                            categories.Add(genre.CategoryName, genre);
                        }
                    }

                    return categories;
                }
            }
        }
    }
