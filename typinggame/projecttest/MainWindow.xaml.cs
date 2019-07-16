using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;

namespace projecttest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            LifeBlock.Visibility = Visibility.Hidden;
            ScoreBlock.Visibility = Visibility.Hidden;
            AttentionBlock.Visibility = Visibility.Hidden;
            TimerBlock.Visibility = Visibility.Hidden;

            Line.Visibility = Visibility.Hidden;
            InputBox.Visibility = Visibility.Hidden;

            FallingWordA.Visibility = Visibility.Hidden;
            FallingWordB.Visibility = Visibility.Hidden;
            FallingWordC.Visibility = Visibility.Hidden;
            FallingWordD.Visibility = Visibility.Hidden;

            RuleBlock.Visibility = Visibility.Hidden;
            BackButton.Visibility = Visibility.Hidden;

            DifficultyBlock.Visibility = Visibility.Hidden;
            NormalButton.Visibility = Visibility.Hidden;
            HardButton.Visibility = Visibility.Hidden;
            HellButton.Visibility = Visibility.Hidden;

            CreditBlock.Visibility = Visibility.Hidden;

            RestartButton.Visibility = Visibility.Hidden;
        }

        Random rand = new Random();

        // Difficulty: normal
        string[] fruit = { "Acai", "Apple", "Akee", "Apricot", "Avocado", "Banana", "Bilberry", "Blackberry", "Blackcurrant",
        "Black sapote", "Blueberry", "Boysenberry", "Buddha's hand", "Crab apples", "Currant", "Cherry", "Cherimoya", "Chico fruit",
        "Cloudberry", "Coconut", "Cranberry", "Cucumber", "Damson", "Date", "Dragonfruit", "Durian", "Elderberry", "Feijoa", "Fig",
        "Goji berry", "Gooseberry", "Grape", "Grapefruit", "Guava", "Honeyberry", "Huckleberry", "Jabuticaba", "Jackfruit", "Jambul", "Japanese Plum",
        "Jostaberry", "Jujube", "Juniper Berry", "Kiwano", "Kiwifruit", "Kumquat", "Lemon", "Lime", "Loquat", "Longan", "Lychee", "Mango", "Mangosteen", "Marionberry", "Melon",
        "Miracle Fruit", "Mulberry", "Nectarine", "Nance", "Olive", "Orange", "Papaya", "Passionfruit", "Peach", "Pear", "Persimmon", "Plantain", "Plum", "Pineapple",
        "Plumcot", "Pomegranate", "Pomelo", "Purple Mangosteen", "Quince", "Raspberry", "Rambutan", "Redcurrant", "Satal Berry", "Salak", "Satsuma", "Soursop",
        "Star Apple", "Strawberry", "Surinam Cherry", "Tamarillo", "Tamarillo", "Ugli Fruit", "White Currant", "White Sapote", "Yuzu"};

        // Difficulty: hard
        string[] pokemon = { "Bulbasaur", "Ivysaur", "Venusaur", "Charmander", "Charmeleon", "Charizard", "Squirtle",
        "Wartortle", "Blastoise", "Caterpie", "Metapod", "Butterfree", "Weedle", "Kakuna", "Beedrill", "Pidgey",
        "Pidgeotto", "Pidgeot", "Rattata", "Raticate", "Spearow", "Fearow", "Ekans", "Arbok", "Pikachu", "Raichu",
        "Sandshrew", "Sandslash", "Nidoran", "Nidorina", "Nidoqueen", "Nidoran", "Nidorino", "Nidoking", "Clefairy",
        "Clefable", "Vulpix", "Ninetales", "Jigglypuff", "Wigglytuff", "Zubat", "Golbat", "Oddish", "Gloom", "Vileplume",
        "Paras", "Parasect", "Venonat", "Venomoth", "Diglett", "Dugtrio", "Meowth", "Persian", "Psyduck", "Golduck", "Mankey",
        "Primeape", "Growlithe", "Arcanine", "Poliwag", "Poliwhirl", "Poliwrath", "Abra", "Kadabra", "Alakazam", "Machop",
        "Machoke", "Machamp", "Bellsprout", "Weepinbell", "Victreebel", "Tentacool", "Tentacruel", "Geodude", "Graveler",
        "Golem", "Ponyta", "Rapidash", "Slowpoke", "Slowbro", "Magnemite", "Magneton", "Farfetch'd", "Doduo", "Dodrio",
        "Seel", "Dewgong", "Grimer", "Muk", "Shellder", "Cloyster", "Gastly", "Haunter", "Gengar", "Onix", "Drowzee",
        "Hypno", "Krabby", "Kingler", "Voltorb", "Electrode", "Exeggcute", "Exeggutor", "Cubone", "Marowak", "Hitmonlee",
        "Hitmonchan", "Lickitung", "Koffing", "Weezing", "Rhyhorn", "Rhydon", "Chansey", "Tangela", "Kangaskhan", "Horsea",
        "Seadra", "Goldeen", "Seaking", "Staryu", "Starmie", "Mr. Mime", "Scyther", "Jynx", "Electabuzz", "Magmar", "Pinsir",
        "Tauros", "Magikarp", "Gyarados", "Lapras", "Ditto", "Eevee", "Vaporeon", "Jolteon", "Flareon", "Porygon", "Omanyte",
        "Omastar", "Kabuto", "Kabutops", "Aerodactyl", "Snorlax", "Articuno", "Zapdos", "Moltres", "Dratini", "Dragonair", "Dragonite", "Mewtwo", "Mew" };

        // Difficulty: hell
        string[] countries = {"Afghanistan", "Albania", "Algeria", "American Samoa", "Andorra", "Angola", "Anguilla", "Antarctica",
        "Argentina", "Armenia", "Aruba", "Australia", "Austria", "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh",
        "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bermuda", "Bhutan", "Bolivia", "Botswana", "Bouvet Island",
        "Brazil", "British Indian Ocean Territory", "Brunei Darussalam", "Bulgaria", "Burkina Faso", "Burundi", "Cambodia", "Cameroon", "Canada",
        "Cape Verde", "Cayman Islands", "Central African Republic", "Chad", "Chile", "China", "Christmas Island", "Cocos Islands",
        "Colombia", "Comoros", "Congo", "Congo", "Cook Islands", "Costa Rica", "Cote d'Ivoire", "Croatia",
        "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "East Timor", "Ecuador", "Egypt", "El Salvador",
        "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Falkland Islands", "Faroe Islands", "Fiji", "Finland", "France", "France Metropolitan",
        "French Guiana", "French Polynesia", "French Southern Territories", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Gibraltar", "Greece", "Greenland",
        "Grenada", "Guadeloupe", "Guam", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Holy See",
        "Honduras", "Hong Kong", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Israel", "Italy", "Jamaica", "Japan",
        "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea", "Kuwait", "Kyrgyzstan", "Lao",
        "Latvia", "Lebanon", "Lesotho", "Liberia", "Libyan Arab Jamahiriya", "Liechtenstein", "Lithuania", "Luxembourg", "Macau", "Macedonia",
        "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Martinique", "Mauritania", "Mauritius", "Mayotte", "Mexico", "Micronesia",
        "Moldova", "Monaco", "Mongolia", "Montserrat", "Morocco", "Mozambique", "Myanmar", "Namibia", "Nauru", "Nepal", "Netherlands", "Netherlands Antilles", "New Caledonia",
        "New Zealand", "Nicaragua", "Niger", "Nigeria", "Niue", "Norfolk Island", "Northern Mariana Islands", "Norway", "Oman", "Pakistan", "Palau", "Panama", "Papua New Guinea", "Paraguay",
        "Peru", "Philippines", "Pitcairn", "Poland", "Portugal", "Puerto Rico", "Qatar", "Reunion", "Romania", "Russian Federation", "Rwanda", "Saint Lucia",
        "Samoa", "San Marino", "Saudi Arabia", "Senegal", "Seychelles", "Sierra Leone", "Singapore", "Slovakia",
        "Slovenia", "Solomon Islands", "Somalia", "South Africa", "Spain", "Sri Lanka", "St. Helena", "Sudan", "Suriname",
        "Swaziland", "Sweden", "Switzerland", "Syrian Arab Republic", "Taiwan", "Tajikistan", "Tanzania", "Thailand",
        "Togo", "Tokelau", "Tonga", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom",
        "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Venezuela", "Vietnam", "VirginIslands",
        "Western Sahara", "Yemen", "Yugoslavia", "Zambia", "Zimbabwe"};

        // Difficulty: Animal

string[] animal = {"Aardvark",
"Albatross",
"Alligator",
"Alpaca",
"Ant",
"Anteater",
"Antelope",
"Ape",
"Armadillo",
"Donkey",
"Baboon",
"Badger",
"Barracuda",
"Bat",
"Bear",
"Beaver",
"Bee",
"Bison",
"Boar",
"Buffalo",
"Butterfly",
"Camel",
"Capybara",
"Caribou",
"Cassowary",
"Cat",
"Caterpillar",
"Cattle",
"Chamois",
"Cheetah",
"Chicken",
"Chimpanzee",
"Chinchilla",
"Chough",
"Clam",
"Cobra",
"Cockroach",
"Cod",
"Cormorant",
"Coyote",
"Crab",
"Crane",
"Crocodile",
"Crow",
"Curlew",
"Deer",
"Dinosaur",
"Dog",
"Dogfish",
"Dolphin",
"Dotterel",
"Dove",
"Dragonfly",
"Duck",
"Dugong",
"Dunlin",
"Eagle",
"Echidna",
"Eel",
"Eland",
"Elephant",
"Elk",
"Emu",
"Falcon",
"Ferret",
"Finch",
"Fish",
"Flamingo",
"Fly",
"Fox",
"Frog",
"Gaur",
"Gazelle",
"Gerbil",
"Giraffe",
"Gnat",
"Gnu",
"Goat",
"Goldfinch",
"Goldfish",
"Goose",
"Gorilla",
"Goshawk",
"Grasshopper",
"Grouse",
"Guanaco",
"Gull",
"Hamster",
"Hare",
"Hawk",
"Hedgehog",
"Heron",
"Herring",
"Hippopotamus",
"Hornet",
"Horse",
"Human",
"Hummingbird",
"Hyena",
"Ibex",
"Ibis",
"Jackal",
"Jaguar",
"Jay",
"Jellyfish",
"Kangaroo",
"Kingfisher",
"Koala",
"Kookabura",
"Kouprey",
"Kudu",
"Lapwing",
"Lark",
"Lemur",
"Leopard",
"Lion",
"Llama",
"Lobster",
"Locust",
"Loris",
"Louse",
"Lyrebird",
"Magpie",
"Mallard",
"Manatee",
"Mandrill",
"Mantis",
"Marten",
"Meerkat",
"Mink",
"Mole",
"Mongoose",
"Monkey",
"Moose",
"Mosquito",
"Mouse",
"Mule",
"Narwhal",
"Newt",
"Nightingale",
"Octopus",
"Okapi",
"Opossum",
"Oryx",
"Ostrich",
"Otter",
"Owl",
"Oyster",
"Panther",
"Parrot",
"Partridge",
"Peafowl",
"Pelican",
"Penguin",
"Pheasant",
"Pig",
"Pigeon",
"Pony",
"Porcupine",
"Porpoise",
"Quail",
"Quelea",
"Quetzal",
"Rabbit",
"Raccoon",
"Rail",
"Ram",
"Rat",
"Raven",
"Red deer",
"Red panda",
"Reindeer",
"Rhinoceros",
"Rook",
"Salamander",
"Salmon",
"Sand Dollar",
"Sandpiper",
"Sardine",
"Scorpion",
"Seahorse",
"Seal",
"Shark",
"Sheep",
"Shrew",
"Skunk",
"Snail",
"Snake",
"Sparrow",
"Spider",
"Spoonbill",
"Squid",
"Squirrel",
"Starling",
"Stingray",
"Stinkbug",
"Stork",
"Swallow",
"Swan",
"Tapir",
"Tarsier",
"Termite",
"Tiger",
"Toad",
"Trout",
"Turkey",
"Turtle",
"Viper",
"Vulture",
"Wallaby",
"Walrus",
"Wasp",
"Weasel",
"Whale",
"Wildcat",
"Wolf",
"Wolverine",
"Wombat",
"Woodcock",
"Woodpecker",
"Worm",
"Wren",
"Yak",
"Zebra"
};

        System.Windows.Threading.DispatcherTimer gameTimer = new System.Windows.Threading.DispatcherTimer();
        System.Windows.Threading.DispatcherTimer timer1 = new System.Windows.Threading.DispatcherTimer();
        System.Windows.Threading.DispatcherTimer timer2 = new System.Windows.Threading.DispatcherTimer();
        System.Windows.Threading.DispatcherTimer timer3 = new System.Windows.Threading.DispatcherTimer();
        System.Windows.Threading.DispatcherTimer timer4 = new System.Windows.Threading.DispatcherTimer();

        Game currentgame;
        GameController currentgamecontroller;

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            // Hide
            StartButton.Visibility = Visibility.Hidden;
            RuleButton.Visibility = Visibility.Hidden;
            ExitButton.Visibility = Visibility.Hidden;
            TitleBlock.Visibility = Visibility.Hidden;
            CreditButton.Visibility = Visibility.Hidden;
    
            // Display
            DifficultyBlock.Visibility = Visibility.Visible;
            BackButton.Visibility = Visibility.Visible;
            NormalButton.Visibility = Visibility.Visible;
            HardButton.Visibility = Visibility.Visible;
            HellButton.Visibility = Visibility.Visible;

            // timerArray
            System.Windows.Threading.DispatcherTimer[] timerArray = new System.Windows.Threading.DispatcherTimer[5];
            timerArray[0] = gameTimer;
            timerArray[1] = timer1;
            timerArray[2] = timer2;
            timerArray[3] = timer3;
            timerArray[4] = timer4;

            // textBlock Array
            TextBlock[] fallingWord = new TextBlock[4];
            fallingWord[0] = FallingWordA;
            fallingWord[1] = FallingWordB;
            fallingWord[2] = FallingWordC;
            fallingWord[3] = FallingWordD;

            Button[] buttons = new Button[3];
            buttons[0] = NormalButton;
            buttons[1] = HardButton;
            buttons[2] = HellButton;

            currentgame = new Game(fallingWord, buttons, timerArray, InputBox, TimerBlock, LifeBlock, ScoreBlock);
            currentgamecontroller = new GameController(currentgame);
        }

        // Select diffuculty - normal
        private void NormalButton_Click(object sender, RoutedEventArgs e)
        {
            // Difficulty
            currentgame.WordArray = fruit;

            // Hide
            DifficultyBlock.Visibility = Visibility.Hidden;
            NormalButton.Visibility = Visibility.Hidden;
            HardButton.Visibility = Visibility.Hidden;
            HellButton.Visibility = Visibility.Hidden;
            BackButton.Visibility = Visibility.Hidden;

            // Display
            LifeBlock.Visibility = Visibility.Visible;
            ScoreBlock.Visibility = Visibility.Visible;
            AttentionBlock.Visibility = Visibility.Visible;
            Line.Visibility = Visibility.Visible;
            InputBox.Visibility = Visibility.Visible;
            TimerBlock.Visibility = Visibility.Visible;
            FallingWordA.Visibility = Visibility.Visible;
            FallingWordB.Visibility = Visibility.Visible;
            FallingWordC.Visibility = Visibility.Visible;
            FallingWordD.Visibility = Visibility.Visible;
            RestartButton.Visibility = Visibility.Visible;

            // Focus to InputBox after Click the Normal Button
            InputBox.Focus();
        }

        // Select difficulty - hard
        private void HardButton_Click(object sender, RoutedEventArgs e)
        {
            // Difficulty
            currentgame.WordArray = animal;

            // Hide
            DifficultyBlock.Visibility = Visibility.Hidden;
            NormalButton.Visibility = Visibility.Hidden;
            HardButton.Visibility = Visibility.Hidden;
            HellButton.Visibility = Visibility.Hidden;
            BackButton.Visibility = Visibility.Hidden;

            // Display
            LifeBlock.Visibility = Visibility.Visible;
            ScoreBlock.Visibility = Visibility.Visible;
            AttentionBlock.Visibility = Visibility.Visible;
            Line.Visibility = Visibility.Visible;
            InputBox.Visibility = Visibility.Visible;
            TimerBlock.Visibility = Visibility.Visible;
            FallingWordA.Visibility = Visibility.Visible;
            FallingWordB.Visibility = Visibility.Visible;
            FallingWordC.Visibility = Visibility.Visible;
            FallingWordD.Visibility = Visibility.Visible;
            RestartButton.Visibility = Visibility.Visible;

            // Focus to InputBox after Click the Hard Button
            InputBox.Focus();
        }

        private void HellButton_Click(object sender, RoutedEventArgs e)
        {
            // Difficulty
            currentgame.WordArray = countries;

            // Hide
            DifficultyBlock.Visibility = Visibility.Hidden;
            NormalButton.Visibility = Visibility.Hidden;
            HardButton.Visibility = Visibility.Hidden;
            HellButton.Visibility = Visibility.Hidden;
            BackButton.Visibility = Visibility.Hidden;

            // Display
            LifeBlock.Visibility = Visibility.Visible;
            ScoreBlock.Visibility = Visibility.Visible;
            AttentionBlock.Visibility = Visibility.Visible;
            Line.Visibility = Visibility.Visible;
            InputBox.Visibility = Visibility.Visible;
            TimerBlock.Visibility = Visibility.Visible;
            FallingWordA.Visibility = Visibility.Visible;
            FallingWordB.Visibility = Visibility.Visible;
            FallingWordC.Visibility = Visibility.Visible;
            FallingWordD.Visibility = Visibility.Visible;
            RestartButton.Visibility = Visibility.Visible;

            // Focus to InputBox after Click the Hell Button
            InputBox.Focus();
        }       

        // Exit Button
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        // Rule Button
        private void RuleButton_Click(object sender, RoutedEventArgs e)
        {
            // Display
            RuleBlock.Visibility = Visibility.Visible;
            BackButton.Visibility = Visibility.Visible;

            // Hide
            TitleBlock.Visibility = Visibility.Hidden;
            StartButton.Visibility = Visibility.Hidden;
            ExitButton.Visibility = Visibility.Hidden;
            RuleButton.Visibility = Visibility.Hidden;
            CreditButton.Visibility = Visibility.Hidden;
        }

        // Credit Button
        private void CreditButton_Click(object sender, RoutedEventArgs e)
        {
            // Display
            CreditBlock.Visibility = Visibility.Visible;
            BackButton.Visibility = Visibility.Visible;

            // Hide
            TitleBlock.Visibility = Visibility.Hidden;
            StartButton.Visibility = Visibility.Hidden;
            ExitButton.Visibility = Visibility.Hidden;
            RuleButton.Visibility = Visibility.Hidden;
            CreditButton.Visibility = Visibility.Hidden;
        }

        // Back Button
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            TitleBlock.Visibility = Visibility.Visible;
            StartButton.Visibility = Visibility.Visible;
            ExitButton.Visibility = Visibility.Visible;
            RuleButton.Visibility = Visibility.Visible;
            CreditButton.Visibility = Visibility.Visible;

            DifficultyBlock.Visibility = Visibility.Hidden;
            NormalButton.Visibility = Visibility.Hidden;
            HardButton.Visibility = Visibility.Hidden;
            HellButton.Visibility = Visibility.Hidden;
            RuleBlock.Visibility = Visibility.Hidden;
            BackButton.Visibility = Visibility.Hidden;
            CreditBlock.Visibility = Visibility.Hidden;
        }

        // Restart Button
        private void RestartButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
            System.Diagnostics.Process.Start(Environment.GetCommandLineArgs()[0]);
        }

    }
}

public class WordController
{
    private static Random rand = new Random();

    // Change foreground or/and  background color of falling word
    public static void ChangeTextColor(Game game, int index)
    {
        int i = rand.Next(1, 11);

        if (i == 0)
        {
            game.TextBlock[index].Foreground = Brushes.Red;
            game.TextBlock[index].Background = Brushes.Black;
        }
        else if (i == 1)
        {
            game.TextBlock[index].Foreground = Brushes.Blue;
            game.TextBlock[index].Background = Brushes.Orange;
        }
        else if (i == 2)
        {
            game.TextBlock[index].Foreground = Brushes.Yellow;
            game.TextBlock[index].Background = Brushes.Black;
        }
        else if (i == 3)
        {
            game.TextBlock[index].Foreground = Brushes.Pink;
            game.TextBlock[index].Background = Brushes.Blue;
        }
        else if (i == 4)
        {
            game.TextBlock[index].Foreground = Brushes.White;
            game.TextBlock[index].Background = Brushes.Purple;
        }
        else if (i == 5)
        {
            game.TextBlock[index].Foreground = Brushes.Red;
            game.TextBlock[index].Background = Brushes.Green;
        }
        else if (i == 6)
        {
            game.TextBlock[index].Background = Brushes.Aqua;
            game.TextBlock[index].Foreground = Brushes.Green;
        }
        else if (i == 7)
        {
            game.TextBlock[index].Background = Brushes.Yellow;
            game.TextBlock[index].Foreground = Brushes.Red;
        }
        else if (i == 8)
        {
            game.TextBlock[index].Foreground = Brushes.LightBlue;
            game.TextBlock[index].Background = Brushes.Black;
        }
        else if (i == 9)
        {
            game.TextBlock[index].Foreground = Brushes.Black;
            game.TextBlock[index].Background = Brushes.White;
        }
        else if (i == 10)
        {
            game.TextBlock[index].Background = Brushes.Green;
            game.TextBlock[index].Foreground = Brushes.LightBlue;
        }
    }

    // Initalize the text of FallingWord randomly (without repetition)
    public static void InitializeWord(Game game, int index)
    {
        if (index == 0)
        {
            do{
                game.TextBlock[0].Text = game.WordArray[rand.Next(game.WordArray.Count())];
            } while (game.TextBlock[0].Text == game.TextBlock[1].Text || game.TextBlock[0].Text == game.TextBlock[2].Text || game.TextBlock[0].Text == game.TextBlock[3].Text);
        }
        else if (index == 1)
        {
            do{
                game.TextBlock[1].Text = game.WordArray[rand.Next(game.WordArray.Count())];
            } while (game.TextBlock[1].Text == game.TextBlock[0].Text || game.TextBlock[1].Text == game.TextBlock[2].Text || game.TextBlock[1].Text == game.TextBlock[3].Text);
        }
        else if (index == 2)
        {
            do{
                game.TextBlock[2].Text = game.WordArray[rand.Next(game.WordArray.Count())];
            } while (game.TextBlock[2].Text == game.TextBlock[0].Text || game.TextBlock[2].Text == game.TextBlock[1].Text || game.TextBlock[2].Text == game.TextBlock[3].Text);

        }
        else if (index == 3)
        {
            do{
                game.TextBlock[3].Text = game.WordArray[rand.Next(game.WordArray.Count())];
            } while (game.TextBlock[3].Text == game.TextBlock[0].Text || game.TextBlock[3].Text == game.TextBlock[1].Text || game.TextBlock[3].Text == game.TextBlock[2].Text);
        }
        ChangeTextColor(game, index);
    }

    // Control the falling of word;
    public static void FallWord(Game game, int index)
    {
        int counter = 0;
        int top = 0;

        if (index == 0)
        {
            counter = game.CounterA;
        }
        else if (index == 1)
        {
            counter = game.CounterB;
        }
        else if (index == 2)
        {
            counter = game.CounterC;
        }
        else if (index == 3)
        {
            counter = game.CounterD;
        }

        if (game.RemainingTime == 0 && index == 0)
        {
            GameOverController.NoTimeMessage(game.Score);
        }
        else if (game.RemainingTime > 0)
        {

            if (counter == 539)
            {
                game.Life--;
                game.LifeBlock.Text = "Life: " + game.Life;

                if (game.Life == 0)
                {
                    game.RemainingTime = -1;

                    GameOverController.NoLifeMessage(game.Score);
                }
                else
                {
                    WordController.InitializeWord(game, index);

                    if (index == 0)
                    {
                        game.CounterA = 0;
                    }
                    else if (index == 1)
                    {
                        game.CounterB = 0;
                    }
                    else if (index == 2)
                    {
                        game.CounterC = 0;
                    }
                    else if (index == 3)
                    {
                        game.CounterD = 0;
                    }

                    game.TimerArray[index+1].Interval = TimeSpan.FromSeconds(game.RandTime[rand.Next(10)]);
                }
            }
            else if (counter < 539)
            {
                if (index == 0)
                {
                    game.CounterA++;
                    top = game.CounterA;
                }
                else if (index == 1)
                {
                    game.CounterB++;
                    top = game.CounterB;
                }
                else if (index == 2)
                {
                    game.CounterC++;
                    top = game.CounterC;
                }
                else if (index == 3)
                {
                    game.CounterD++;
                    top = game.CounterD;
                }

                game.TextBlock[index].Margin = new System.Windows.Thickness(200*index, top, 0, 0);
            }
        }
    }
}

public class GameOverController
{
    // Display a message when time is up
    public static void NoTimeMessage(int score)
    {
        MessageBoxResult dialog = MessageBox.Show(string.Format("Time's Up! Your Score is {0}\nPlay Again?", score), "Confirmation", MessageBoxButton.YesNo);

        if (dialog == MessageBoxResult.Yes)
        {
            Application.Current.Shutdown();
            System.Diagnostics.Process.Start(Environment.GetCommandLineArgs()[0]);
        }
        else
        {
            Environment.Exit(0);
        }
    }

    // Display a message when life is 0
    public static void NoLifeMessage(int score)
    {
        MessageBoxResult dialog = MessageBox.Show(string.Format("Game Over! Your Score is {0}\nPlay Again?", score), "Confirmation", MessageBoxButton.YesNo);

        if (dialog == MessageBoxResult.Yes)
        {
            Application.Current.Shutdown();
            System.Diagnostics.Process.Start(Environment.GetCommandLineArgs()[0]);
        }
        else
        {
            Environment.Exit(0);
        }
    }
}

public class InputBoxController
{
    static Random rand = new Random();

    // Check whether Input word is Equal to Falling word
    public static void CheckEqual(Game game)
    {
        if (game.InputBox.Text.ToLower() == game.TextBlock[0].Text.ToLower())
        {
            game.Score++;
            game.ScoreBlock.Text = "Score: " + game.Score;
            game.InputBox.Text = "";
            game.TimerArray[1].Interval = TimeSpan.FromSeconds(game.RandTime[rand.Next(10)]);
            game.CounterA = 0;

            WordController.InitializeWord(game, 0);
        }
        else if (game.InputBox.Text.ToLower() == game.TextBlock[1].Text.ToLower())
        {
            game.Score++;
            game.ScoreBlock.Text = "Score: " + game.Score;
            game.InputBox.Text = "";
            game.TimerArray[2].Interval = TimeSpan.FromSeconds(game.RandTime[rand.Next(10)]);
            game.CounterB = 0;

            WordController.InitializeWord(game, 1);
        }
        else if (game.InputBox.Text.ToLower() == game.TextBlock[2].Text.ToLower())
        {
            game.Score++;
            game.ScoreBlock.Text = "Score: " + game.Score;
            game.InputBox.Text = "";
            game.TimerArray[3].Interval = TimeSpan.FromSeconds(game.RandTime[rand.Next(10)]);
            game.CounterC = 0;

            WordController.InitializeWord(game, 2);
        }
        else if (game.InputBox.Text.ToLower() == game.TextBlock[3].Text.ToLower())
        {
            game.Score++;
            game.ScoreBlock.Text = "Score: " + game.Score;
            game.InputBox.Text = "";
            game.TimerArray[4].Interval = TimeSpan.FromSeconds(game.RandTime[rand.Next(10)]);
            game.CounterD = 0;

            WordController.InitializeWord(game, 3);
        }
    }
}

public class Game
{
    private string[] wordArray;
    private TextBlock[] textBlock;
    private double[] randtime = { 0.03, 0.02, 0.0125, 0.00625, 0.004, 0.003125, 0.002, 0.0015625, 0.001, 0.0005 };
    private int life = 5;
    private int score = 0;
    private int remainingtime = 60;
    private Button[] buttons;
    private System.Windows.Threading.DispatcherTimer[] timerArray;
    private TextBox inputBox;
    private TextBlock timerBlock;
    private TextBlock lifeBlock;
    private TextBlock scoreBlock;

    private int counterA = 10;
    private int counterB = 10;
    private int counterC = 10;
    private int counterD = 10;

    public Game(TextBlock[] textBlock, Button[] buttons, System.Windows.Threading.DispatcherTimer[] timerArray, TextBox inputBox, TextBlock timerBlock, TextBlock lifeBlock, TextBlock scoreBlock)
    {
        this.textBlock = textBlock;
        this.buttons = buttons;
        this.timerArray = timerArray;
        this.inputBox = inputBox;
        this.timerBlock = timerBlock;
        this.lifeBlock = lifeBlock;
        this.scoreBlock = scoreBlock;
    }

    public string[] WordArray
    {
        get
        {
            return wordArray;
        }
        set
        {
            wordArray = value;
        }
    }

    public TextBlock[] TextBlock
    {
        get
        {
            return textBlock;
        }
        set
        {
            textBlock = value;
        }
    }

    public double[] RandTime
    {
        get
        {
            return randtime;
        }
    }

    public int CounterA
    {
        get
        {
            return counterA;
        }
        set
        {
            counterA = value;
        }
    }

    public int CounterB
    {
        get
        {
            return counterB;
        }
        set
        {
            counterB = value;
        }
    }

    public int CounterC
    {
        get
        {
            return counterC;
        }
        set
        {
            counterC = value;
        }
    }

    public int CounterD
    {
        get
        {
            return counterD;
        }
        set
        {
            counterD = value;
        }
    }

    public int RemainingTime
    {
        get
        {
            return remainingtime;
        }
        set
        {
            remainingtime = value;
        }
    }

    public int Score
    {
        get
        {
            return score;
        }
        set
        {
            score = value;
        }
    }

    public int Life
    {
        get
        {
            return life;
        }
        set
        {
            life = value;
        }
    }

    public System.Windows.Threading.DispatcherTimer[] TimerArray
    {
        get
        {
            return timerArray;
        }
        set
        {
            timerArray = value;
        }
    }

    public TextBlock LifeBlock
    {
        get
        {
            return lifeBlock;
        }
        set
        {
            lifeBlock = value;
        }
    }

    public Button[] Buttons
    {
        get
        {
            return buttons;
        }
        set
        {
            buttons = value;
        }
    }

    public TextBox InputBox
    {
        get
        {
            return inputBox;
        }
        set
        {
            inputBox = value;
        }
    }

    public TextBlock TimerBlock
    {
        get
        {
            return timerBlock;
        }
        set
        {
            timerBlock = value;
        }
    }

    public TextBlock ScoreBlock
    {
        get
        {
            return scoreBlock;
        }
        set
        {
            scoreBlock = value;
        }
    }
}

public class GameController
{

    private Game game;

    private Random rand = new Random();

    public GameController(Game game)
    {
        this.game = game;
        game.Buttons[0].Click += new RoutedEventHandler(Process);
        game.Buttons[1].Click += new RoutedEventHandler(Process);
        game.Buttons[2].Click += new RoutedEventHandler(Process);
        game.InputBox.TextChanged += new TextChangedEventHandler(InputBox_TextChanged);
    }

    public void Process(object sender, RoutedEventArgs e)
    {
        // Initialize Timer for the game
        game.TimerArray[0].Tick += GameTimerTick;
        game.TimerArray[0].Interval = TimeSpan.FromSeconds(1);
        game.TimerArray[0].Start();

        // Initialize FallingWord A
        WordController.InitializeWord(game, 0);
        game.TimerArray[1].Tick += TimerATick;
        game.TimerArray[1].Interval = TimeSpan.FromSeconds(game.RandTime[rand.Next(10)]);
        game.TimerArray[1].Start();

        // Initialize FallingWord B
        WordController.InitializeWord(game, 1);
        game.TimerArray[2].Tick += TimerBTick;
        game.TimerArray[2].Interval = TimeSpan.FromSeconds(game.RandTime[rand.Next(10)]);
        game.TimerArray[2].Start();

        // Initialize FallingWord C
        WordController.InitializeWord(game, 2);
        game.TimerArray[3].Tick += TimerCTick;
        game.TimerArray[3].Interval = TimeSpan.FromSeconds(game.RandTime[rand.Next(10)]);
        game.TimerArray[3].Start();

        // Initialize FallingWord D
        WordController.InitializeWord(game, 3);
        game.TimerArray[4].Tick += TimerDTick;
        game.TimerArray[4].Interval = TimeSpan.FromSeconds(game.RandTime[rand.Next(10)]);
        game.TimerArray[4].Start();
    }

    private void GameTimerTick(object sender, EventArgs e)
    {
        if (game.RemainingTime > 0)
        {
            game.RemainingTime--;
        }

        if (game.RemainingTime == -1)
        {
            game.TimerBlock.Text = "Remain Time: 0s";
        }
        else
        {
            game.TimerBlock.Text = "Remain Time: " + game.RemainingTime + "s";
        }
    }

    private void TimerATick(object sender, EventArgs e)
    {
        WordController.FallWord(game, 0);
    }

    private void TimerBTick(object sender, EventArgs e)
    {
        WordController.FallWord(game, 1);
    }

    private void TimerCTick(object sender, EventArgs e)
    {
        WordController.FallWord(game, 2);
    }

    private void TimerDTick(object sender, EventArgs e)
    {
        WordController.FallWord(game, 3);
    }

    private void InputBox_TextChanged(object sender, TextChangedEventArgs e)
    {
        InputBoxController.CheckEqual(game);
    }
}
