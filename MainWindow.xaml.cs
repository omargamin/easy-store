using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Xstore
{
    public partial class MainWindow : Window
    {
        // قائمة التطبيقات
        private List<ApplicationInfo> apps;

        public MainWindow()
        {
            InitializeComponent();
            InitializeApps();  // تهيئة التطبيقات
            LoadApps(apps);    // تحميل التطبيقات على واجهة المستخدم
        }

        // كلاس للتطبيق
        private class ApplicationInfo
        {
            public string Name { get; set; }
            public string Link { get; set; }
        }

        // تهيئة قائمة التطبيقات
        private void InitializeApps()
        {
            apps = new List<ApplicationInfo>
            {

new ApplicationInfo { Name = "Minecraft", Link = "https://www.minecraft.net/" },
new ApplicationInfo { Name = "Fortnite", Link = "https://www.epicgames.com/fortnite" },
new ApplicationInfo { Name = "Among Us", Link = "https://www.innersloth.com/gameAmongUs.php" },
new ApplicationInfo { Name = "The Witcher 3", Link = "https://thewitcher.com/en/witcher3" },
new ApplicationInfo { Name = "Cyberpunk 2077", Link = "https://www.cyberpunk.net/" },
new ApplicationInfo { Name = "Red Dead Redemption 2", Link = "https://www.rockstargames.com/reddeadredemption2/" },
new ApplicationInfo { Name = "Apex Legends", Link = "https://www.ea.com/games/apex-legends" },
new ApplicationInfo { Name = "Valorant", Link = "https://playvalorant.com/" },
new ApplicationInfo { Name = "League of Legends", Link = "https://www.leagueoflegends.com/" },
new ApplicationInfo { Name = "Call of Duty: Warzone", Link = "https://www.callofduty.com/warzone" },
new ApplicationInfo { Name = "Genshin Impact", Link = "https://genshin.mihoyo.com/en" },
new ApplicationInfo { Name = "Fall Guys", Link = "https://fallguys.com/" },
new ApplicationInfo { Name = "Rocket League", Link = "https://www.rocketleaguegame.com/" },
new ApplicationInfo { Name = "FIFA 22", Link = "https://www.ea.com/games/fifa/fifa-22" },
new ApplicationInfo { Name = "Minecraft Dungeons", Link = "https://www.minecraft.net/en-us/about-dungeons" },
new ApplicationInfo { Name = "World of Warcraft", Link = "https://worldofwarcraft.com/" },
new ApplicationInfo { Name = "PUBG", Link = "https://www.pubg.com/" },
new ApplicationInfo { Name = "Overwatch", Link = "https://us.shop.battle.net/en-us/product/overwatch" },
new ApplicationInfo { Name = "Hunt: Showdown", Link = "https://www.huntshowdown.com/" },
new ApplicationInfo { Name = "The Elder Scrolls V: Skyrim", Link = "https://elderscrolls.bethesda.net/en/skyrim" },
new ApplicationInfo { Name = "Dead by Daylight", Link = "https://deadbydaylight.com/" },
new ApplicationInfo { Name = "Counter-Strike: Global Offensive", Link = "https://store.steampowered.com/app/730/CounterStrike_Global_Offensive/" },
new ApplicationInfo { Name = "Dota 2", Link = "https://www.dota2.com/" },
new ApplicationInfo { Name = "Destiny 2", Link = "https://www.bungie.net/7/en/Destiny/NewLight" },
new ApplicationInfo { Name = "Horizon Zero Dawn", Link = "https://www.playstation.com/en-us/games/horizon-zero-dawn/" },
new ApplicationInfo { Name = "Animal Crossing: New Horizons", Link = "https://www.animal-crossing.com/new-horizons/" },
new ApplicationInfo { Name = "The Last of Us Part II", Link = "https://www.playstation.com/en-us/games/the-last-of-us-part-ii/" },
new ApplicationInfo { Name = "Resident Evil Village", Link = "https://www.residentevil.com/village/" },
new ApplicationInfo { Name = "Tetris Effect", Link = "https://www.tetris.com/what-is-tetris-effect" },
new ApplicationInfo { Name = "Sea of Thieves", Link = "https://www.seaofthieves.com/" },
new ApplicationInfo { Name = "Uncharted 4", Link = "https://www.playstation.com/en-us/games/uncharted-4-a-thiefs-end/" },
new ApplicationInfo { Name = "Grand Theft Auto V", Link = "https://www.rockstargames.com/V" },
new ApplicationInfo { Name = "Monster Hunter: World", Link = "https://www.monsterhunterworld.com/" },
new ApplicationInfo { Name = "The Sims 4", Link = "https://www.ea.com/games/the-sims/the-sims-4" },
new ApplicationInfo { Name = "Final Fantasy XIV", Link = "https://na.finalfantasyxiv.com/" },
new ApplicationInfo { Name = "Tom Clancy's Rainbow Six Siege", Link = "https://www.ubisoft.com/game/rainbow-six/siege" },
new ApplicationInfo { Name = "Madden NFL 22", Link = "https://www.ea.com/games/madden-nfl/madden-nfl-22" },
new ApplicationInfo { Name = "Diablo III", Link = "https://us.diablo3.com/" },
new ApplicationInfo { Name = "Bioshock Infinite", Link = "https://www.2k.com/en-US/game/bioshock-infinite" },
new ApplicationInfo { Name = "Shadow of the Tomb Raider", Link = "https://tombraider.square-enix-games.com/" },
new ApplicationInfo { Name = "Farming Simulator 19", Link = "https://www.farming-simulator.com/" },
new ApplicationInfo { Name = "Stardew Valley", Link = "https://www.stardewvalley.net/" },
new ApplicationInfo { Name = "Dead Space", Link = "https://www.ea.com/games/dead-space" },
new ApplicationInfo { Name = "Lords Mobile", Link = "https://www.lordsmobile.com/" },
new ApplicationInfo { Name = "Star Wars Battlefront II", Link = "https://www.ea.com/games/starwars/battlefront/battlefront-2" },
new ApplicationInfo { Name = "Guitar Hero Live", Link = "https://www.guitarherogame.com/" },
new ApplicationInfo { Name = "Call of Duty: Black Ops Cold War", Link = "https://www.callofduty.com/blackopscoldwar" },
new ApplicationInfo { Name = "Injustice 2", Link = "https://www.injustice.com/" },
new ApplicationInfo { Name = "Super Mario Odyssey", Link = "https://www.nintendo.com/games/detail/super-mario-odyssey-switch/" },
new ApplicationInfo { Name = "Halo: Master Chief Collection", Link = "https://www.halowaypoint.com/en-us/games/halo-master-chief-collection" },
new ApplicationInfo { Name = "Spiderman PS4", Link = "https://www.playstation.com/en-us/games/marvels-spider-man/" },
new ApplicationInfo { Name = "No Man's Sky", Link = "https://www.nomanssky.com/" },
new ApplicationInfo { Name = "Cities: Skylines", Link = "https://www.paradoxplaza.com/cities-skylines" },
new ApplicationInfo { Name = "The Walking Dead: A New Frontier", Link = "https://www.telltalegames.com/games/thewalkingdead" },
new ApplicationInfo { Name = "Far Cry 5", Link = "https://www.ubisoft.com/game/far-cry/far-cry-5" },
new ApplicationInfo { Name = "Hitman 3", Link = "https://www.ioi.dk/hitman-3/" },
new ApplicationInfo { Name = "Borderlands 3", Link = "https://borderlands.com/en-US/" },
new ApplicationInfo { Name = "Satisfactory", Link = "https://www.satisfactorygame.com/" },
new ApplicationInfo { Name = "Control", Link = "https://controlgame.com/" },
new ApplicationInfo { Name = "World War Z", Link = "https://www.worldwarzgame.com/" },
new ApplicationInfo { Name = "Escape from Tarkov", Link = "https://www.escapefromtarkov.com/" },
new ApplicationInfo { Name = "Watch Dogs: Legion", Link = "https://www.ubisoft.com/game/watch-dogs/watch-dogs-legion" },
new ApplicationInfo { Name = "Resident Evil 2 Remake", Link = "https://www.residentevil2.com/" },
new ApplicationInfo { Name = "The Division 2", Link = "https://www.ubisoft.com/game/the-division/the-division-2" },
new ApplicationInfo { Name = "Metro Exodus", Link = "https://www.metrothegame.com/" },
new ApplicationInfo { Name = "Dark Souls III", Link = "https://en.bandainamcoent.eu/dark-souls/dark-souls-iii" },
new ApplicationInfo { Name = "Bloodborne", Link = "https://www.playstation.com/en-us/games/bloodborne/" },
new ApplicationInfo { Name = "Shadow of Mordor", Link = "https://www.shadowofmordor.com/" },
new ApplicationInfo { Name = "Assassin's Creed Valhalla", Link = "https://www.ubisoft.com/game/assassins-creed/assassins-creed-valhalla" },
new ApplicationInfo { Name = "Mortal Kombat 11", Link = "https://www.mortalkombat.com/" },
new ApplicationInfo { Name = "Tekken 7", Link = "https://www.tekken-official.jp/" },
new ApplicationInfo { Name = "Dragon Age: Inquisition", Link = "https://www.ea.com/games/dragon-age/dragon-age-inquisition" },
new ApplicationInfo { Name = "Divinity: Original Sin 2", Link = "https://divinity.game/" },
new ApplicationInfo { Name = "The Forest", Link = "https://theforestgame.com/" },
new ApplicationInfo { Name = "Risk of Rain 2", Link = "https://riskofrain.com/" },
new ApplicationInfo { Name = "Fallout 4", Link = "https://fallout.bethesda.net/en/fallout4" },
new ApplicationInfo { Name = "Skyrim Special Edition", Link = "https://elderscrolls.bethesda.net/en/skyrim" },
new ApplicationInfo { Name = "Subnautica", Link = "https://unknownworlds.com/subnautica/" },
new ApplicationInfo { Name = "The Outer Worlds", Link = "https://www.obsidian.net/games/the-outer-worlds" },
new ApplicationInfo { Name = "ARK: Survival Evolved", Link = "https://www.playark.com/" },
new ApplicationInfo { Name = "Noita", Link = "https://noitagame.com/" },
new ApplicationInfo { Name = "Hades", Link = "https://supergiantgames.com/games/hades/" },
new ApplicationInfo { Name = "Axiom Verge", Link = "https://www.axiomverge.com/" },
new ApplicationInfo { Name = "Monster Hunter Rise", Link = "https://www.monsterhunter.com/rise/en-us/" },
new ApplicationInfo { Name = "Outer Wilds", Link = "https://www.mobiusdigitalgames.com/outerwilds" },
new ApplicationInfo { Name = "Slay the Spire", Link = "https://www.slaythespire.com/" },
new ApplicationInfo { Name = "Hollow Knight", Link = "https://hollowknight.com/" },
new ApplicationInfo { Name = "Celeste", Link = "https://maddytoys.com/" },
new ApplicationInfo { Name = "The Stanley Parable", Link = "http://www.stanleyparable.com/" },
new ApplicationInfo { Name = "Spelunky 2", Link = "https://www.spelunkyworld.com/spelunky2/" },
new ApplicationInfo { Name = "Streets of Rage 4", Link = "https://streetsofrage4.com/" },
new ApplicationInfo { Name = "Battlefield V", Link = "https://www.ea.com/games/battlefield/battlefield-5" },
new ApplicationInfo { Name = "F1 2021", Link = "https://www.formula1game.com/" },
new ApplicationInfo { Name = "Need for Speed Heat", Link = "https://www.ea.com/games/need-for-speed/need-for-speed-heat" },
new ApplicationInfo { Name = "Wasteland 3", Link = "https://www.wasteland3.com/" },
new ApplicationInfo { Name = "Stardew Valley", Link = "https://www.stardewvalley.net/" },
new ApplicationInfo { Name = "StarCraft II", Link = "https://starcraft2.com/en-us/" },
new ApplicationInfo { Name = "Call of Duty: Warzone", Link = "https://www.callofduty.com/warzone" },
new ApplicationInfo { Name = "FIFA 21", Link = "https://www.ea.com/games/fifa/fifa-21" },
new ApplicationInfo { Name = "Rocket League", Link = "https://www.rocketleaguegame.com/" },
new ApplicationInfo { Name = "Genshin Impact", Link = "https://genshin.mihoyo.com/" },
new ApplicationInfo { Name = "Fortnite", Link = "https://www.epicgames.com/fortnite" },
new ApplicationInfo { Name = "Valorant", Link = "https://playvalorant.com/" },
new ApplicationInfo { Name = "Minecraft", Link = "https://www.minecraft.net/" },
new ApplicationInfo { Name = "Overwatch", Link = "https://playoverwatch.com/" },
new ApplicationInfo { Name = "PUBG", Link = "https://www.pubg.com/" },
new ApplicationInfo { Name = "Apex Legends", Link = "https://www.ea.com/games/apex-legends" },
new ApplicationInfo { Name = "League of Legends", Link = "https://na.leagueoflegends.com/" },
new ApplicationInfo { Name = "Team Fortress 2", Link = "https://www.teamfortress.com/" },
new ApplicationInfo { Name = "Minecraft Dungeons", Link = "https://www.minecraft.net/en-us/about-dungeons" },
new ApplicationInfo { Name = "The Witcher 3: Wild Hunt", Link = "https://thewitcher.com/en/witcher3" },
new ApplicationInfo { Name = "Among Us", Link = "https://innersloth.itch.io/among-us" },
new ApplicationInfo { Name = "Counter-Strike: Global Offensive", Link = "https://www.counter-strike.net/" },
new ApplicationInfo { Name = "Tom Clancy's Rainbow Six Siege", Link = "https://www.ubisoft.com/game/rainbow-six/siege" },
new ApplicationInfo { Name = "Assassin's Creed Odyssey", Link = "https://www.ubisoft.com/game/assassins-creed/assassins-creed-odyssey" },
new ApplicationInfo { Name = "Battlefield 1", Link = "https://www.ea.com/games/battlefield/battlefield-1" },
new ApplicationInfo { Name = "Red Dead Redemption 2", Link = "https://www.rockstargames.com/reddeadredemption2" },
new ApplicationInfo { Name = "Hunt: Showdown", Link = "https://www.huntshowdown.com/" },
new ApplicationInfo { Name = "Dead by Daylight", Link = "https://deadbydaylight.com/" },
new ApplicationInfo { Name = "Fall Guys", Link = "https://www.fallguys.com/" },
new ApplicationInfo { Name = "The Elder Scrolls Online", Link = "https://www.elderscrollsonline.com/en-us/home" },
new ApplicationInfo { Name = "Left 4 Dead 2", Link = "https://store.steampowered.com/app/550/Left_4_Dead_2/" },
new ApplicationInfo { Name = "Stardew Valley", Link = "https://www.stardewvalley.net/" },
new ApplicationInfo { Name = "Path of Exile", Link = "https://www.pathofexile.com/" },
new ApplicationInfo { Name = "Monster Hunter: World", Link = "https://www.monsterhunter.com/world/en-us/" },
new ApplicationInfo { Name = "Warframe", Link = "https://www.warframe.com/" },
new ApplicationInfo { Name = "Minecraft: Java Edition", Link = "https://www.minecraft.net/en-us" },
new ApplicationInfo { Name = "The Sims 4", Link = "https://www.ea.com/games/the-sims/the-sims-4" },
new ApplicationInfo { Name = "Grand Theft Auto V", Link = "https://www.rockstargames.com/V" },
new ApplicationInfo { Name = "Worms Battlegrounds", Link = "https://store.steampowered.com/app/314160/Worms_Battlegrounds/" },
new ApplicationInfo { Name = "Cities: Skylines", Link = "https://www.paradoxplaza.com/cities-skylines" },
new ApplicationInfo { Name = "Sid Meier's Civilization VI", Link = "https://www.civilization.com/" },
new ApplicationInfo { Name = "Elite Dangerous", Link = "https://www.elitedangerous.com/" },
new ApplicationInfo { Name = "Kingdom Come: Deliverance", Link = "https://www.kingdomcomerpg.com/" },
new ApplicationInfo { Name = "No Man's Sky", Link = "https://www.nomanssky.com/" },
new ApplicationInfo { Name = "The Forest", Link = "https://theforestgame.com/" },
new ApplicationInfo { Name = "Trove", Link = "https://www.trovegame.com/" },
new ApplicationInfo { Name = "Dying Light", Link = "https://www.dyinglightgame.com/" },
new ApplicationInfo { Name = "Spelunky 2", Link = "https://www.spelunkyworld.com/spelunky2/" },
new ApplicationInfo { Name = "Sea of Thieves", Link = "https://www.seaofthieves.com/" },
new ApplicationInfo { Name = "Escape from Tarkov", Link = "https://www.escapefromtarkov.com/" },
new ApplicationInfo { Name = "Borderlands 3", Link = "https://borderlands.com/en-US/" },


            };
        }

        // تحميل التطبيقات على واجهة المستخدم
        private void LoadApps(List<ApplicationInfo> appsToLoad)
        {
            AppsPanel.Children.Clear(); // تأكد من مسح أي محتويات قديمة في لوحة التطبيقات

            foreach (var app in appsToLoad)
            {
                StackPanel appPanel = new StackPanel
                {
                    Orientation = Orientation.Horizontal,
                    Margin = new Thickness(5)
                };

                TextBlock appName = new TextBlock
                {
                    Text = app.Name,
                    Width = 150,
                    Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.White)
                };

                Button downloadButton = new Button
                {
                    Content = "دخول/تحميل",
                    Tag = app.Link, // رابط التطبيق
                    Margin = new Thickness(5),
                    Width = 110
                };

                downloadButton.Click += DownloadButton_Click;

                appPanel.Children.Add(appName);
                appPanel.Children.Add(downloadButton);
                AppsPanel.Children.Add(appPanel); // أضف التطبيق إلى الواجهة
            }
        }

        // عند الضغط على زر تحميل
        private void DownloadButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            string link = button.Tag.ToString();

            try
            {
                if (!string.IsNullOrEmpty(link))
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = link,
                        UseShellExecute = true
                    });
                }
                else
                {
                    MessageBox.Show("الرابط غير صالح.", "خطأ", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"فشل فتح الرابط: {ex.Message}", "خطأ", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // البحث عن التطبيقات
        private void SearchApps(string searchText)
        {
            var filteredApps = apps
                .Where(app => app.Name.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            LoadApps(filteredApps);
        }

        // عند تغيير النص في مربع البحث
        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            SearchApps(SearchBox.Text);
        }

        // عند الضغط على زر البحث
        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            SearchApps(SearchBox.Text);
        }

        // عند الضغط على زر إعادة التحميل
        private void ReloadButton_Click(object sender, RoutedEventArgs e)
        {
            LoadApps(apps); // إعادة تحميل التطبيقات
        }
    }
}
