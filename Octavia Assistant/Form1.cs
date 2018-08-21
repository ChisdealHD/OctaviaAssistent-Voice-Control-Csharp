using System;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Media;

namespace Octavia_Assistant
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine _recognizer = new SpeechRecognitionEngine();
        SpeechSynthesizer Alexis = new SpeechSynthesizer();
        SpeechRecognitionEngine startlistening = new SpeechRecognitionEngine();

        Boolean wake = true;

        //String condition;
        //String temp;
        //String high;
        //String low;

        public Boolean search = false;
        public Boolean fnlsearch = false;
        public Boolean meh111 = false;
        public Boolean meh122 = false;


        public Form1()
        {

            try
            {
                _recognizer.SetInputToDefaultAudioDevice();
                _recognizer.RequestRecognizerUpdate();
                _recognizer.LoadGrammar(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"cmds.txt")))));
                _recognizer.SpeechRecognized += rec_SpeachRecongnized;
                _recognizer.SetInputToDefaultAudioDevice();
                _recognizer.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch { return; }


            Alexis.SelectVoiceByHints(VoiceGender.Female);

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            SoundPlayer warframethemesong = new System.Media.SoundPlayer(Properties.Resources.Octavia_Song_Second_Dream);
            warframethemesong.Play();
            Alexis.Speak("Connecting to Warframe!");
            Alexis.Speak("looking for Players!");
            Alexis.Speak("Checking Server Status");
            Alexis.Speak("Looking for ChisdealHD Mappa");
            Alexis.Speak("Found Server Data");
            Alexis.Speak("internalizing Server Data");
            Alexis.Speak("Server Data is Done");
            Alexis.Speak("Logging in to Mainframe");
            Alexis.Speak("Looking for Developers.");
            Alexis.Speak("I'm here ready go!");
            warframethemesong.Stop();
            wake = false;
            comboBox2.Text = Properties.Settings.Default.fortniteplat;

            textBox4.Text = Properties.Settings.Default.fortnite;

            comboBox1.Text = Properties.Settings.Default.bf1plat;

            textBox5.Text = Properties.Settings.Default.bf1;

            textBox6.Text = Properties.Settings.Default.bf3;

            comboBox3.Text = Properties.Settings.Default.bf3plat;

            comboBox5.Text = Properties.Settings.Default.bfhplat;

            textBox11.Text = Properties.Settings.Default.bfh;

            textBox8.Text = Properties.Settings.Default.hypixel;

            textBox10.Text = Properties.Settings.Default.mixer;

            textBox9.Text = Properties.Settings.Default.twitch;

            textBox7.Text = Properties.Settings.Default.bf4;

            comboBox4.Text = Properties.Settings.Default.bf4plat;
        }

        public void restart()
        {
            Process.Start(@"C:\Users\Grant\source\repos\ChisAI\ChisAI\bin\Debug\ChisAI.exe");
            Environment.Exit(0);
        }

        public void say(String h)
        {
            Alexis.Speak(h);
            textBox1.AppendText("Octavia sid: " + h + "\n");
        }

        private void rec_SpeachRecongnized(object sender, SpeechRecognizedEventArgs e)
        {
            string r = e.Result.Text;

            if (search)
            {
                Process.Start("https://www.google.com/#q=" + r);
                search = false;
            }

            if (r == "hey Octavia")
            {
                wake = true;
                label1.Text = ("States: Active");
                say("What can i help you Tenno?");
            }
            if (r == "sleep")
            {
                wake = false;
                label1.Text = ("States: Offline");
            }

            if (wake == true && search == false)
            {
                SoundPlayer warframethemesong = new System.Media.SoundPlayer(Properties.Resources.Octavia_Song_Second_Dream);

                if (r == "search for")
                {
                    search = true;
                    wake = false;
                }

                if (r == "what time is it")
                {
                    say(DateTime.Now.ToString("h:mm tt"));
                    wake = false;
                }

                if (r == "what is today")
                {
                    say(DateTime.Now.ToString("dd/MM/yyyy"));
                    wake = false;
                }

                if (r == "play theme song")
                {
                    warframethemesong.Play();
                    wake = false;
                }

                if (r == "play im blue")
                {
                    SoundPlayer Player = new System.Media.SoundPlayer(Properties.Resources.Octavia_Im_Blue);
                    Player.Play();
                    wake = false;
                }

                if (r == "play lost woods")
                {
                    SoundPlayer Player = new System.Media.SoundPlayer(Properties.Resources.Octavia_Lost_Woods_from_Legend_of_Zelda);
                    Player.Play();
                    wake = false;
                }

                if (r == "play mortal kombat")
                {
                    SoundPlayer Player = new System.Media.SoundPlayer(Properties.Resources.Octavia_MORTAL_KOMBAT);
                    Player.Play();
                    wake = false;
                }

                if (r == "play assassins creed 2 theme song")
                {
                    SoundPlayer Player = new System.Media.SoundPlayer(Properties.Resources.Octavia_Assassins_Creed_2);
                    Player.Play();
                    wake = false;
                }

                if (r == "play decades dance")
                {
                    SoundPlayer Player = new System.Media.SoundPlayer(Properties.Resources.Octavia_Decades_Dance);
                    Player.Play();
                    wake = false;
                }

                if (r == "play epic sax guy")
                {
                    SoundPlayer Player = new System.Media.SoundPlayer(Properties.Resources.Octavia_Epic_Sax_Guy);
                    Player.Play();
                    wake = false;
                }

                if (r == "play eye of the tiger")
                {
                    SoundPlayer Player = new System.Media.SoundPlayer(Properties.Resources.Octavia_Eye_of_the_Tiger);
                    Player.Play();
                    wake = false;
                }

                if (r == "play ostron")
                {
                    SoundPlayer Player = new System.Media.SoundPlayer(Properties.Resources.Octavia_Ostron);
                    Player.Play();
                    wake = false;
                }

                if (r == "play shooting stars")
                {
                    SoundPlayer Player = new System.Media.SoundPlayer(Properties.Resources.Octavia_Shooting_Stars);
                    Player.Play();
                    wake = false;
                }

                if (r == "play smoke weed everyday")
                {
                    SoundPlayer Player = new System.Media.SoundPlayer(Properties.Resources.Octavia_Smoke_Weed_Everyday);
                    Player.Play();
                    wake = false;
                }

                if (r == "play undertale")
                {
                    SoundPlayer Player = new System.Media.SoundPlayer(Properties.Resources.Octavia_Undertale_Megalovania);
                    Player.Play();
                    wake = false;
                }

                if (r == "play another one bites the dust")
                {
                    SoundPlayer Player = new System.Media.SoundPlayer(Properties.Resources.Octavia_Another_One_Bites_the_Dust);
                    Player.Play();
                    wake = false;
                }

                if (r == "play Pumped Up Kicks")
                {
                    SoundPlayer Player = new System.Media.SoundPlayer(Properties.Resources.Octavia_Pumped_Up_Kicks);
                    Player.Play();
                    wake = false;
                }

                if (r == "play Believer")
                {
                    SoundPlayer Player = new System.Media.SoundPlayer(Properties.Resources.Imagine_Dragons___Believer_Kid_Comet_Remix);
                    Player.Play();
                    wake = false;
                }
                /*if (r == "open Music Player")
                {
                    musicplayer Music = new musicplayer();
                    Music.Show();
                    wake = false;
                }*/

                if (r == "stop theme song")
                {
                    warframethemesong.Stop();
                    wake = false;
                }

                if (r == "open Spam bot")
                {
                    say("Opening, SpamBOT!");
                    Spambot Spambot = new Spambot();
                    Spambot.Show();
                    wake = false;
                }

                if (r == "open site")
                {
                    Process.Start("http://warframe.com");
                    wake = false;
                }
                if (r == "who is ChisdealHD")
                {
                    say("ChisdealHD is Your Lotus master, Him can boss me round and take orders do missions. we got duty to go, so Tenno are you Ready to face to His Youtube Channel.");

                    switch (MessageBox.Show("Do you want show ChisdealHD Youtube channel?", "Opening a Browser?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        case DialogResult.Yes:
                            say("OK opening ChisdealHD Youtube Channel?");
                            Process.Start("http://youtube.com/chisdealhd");
                            wake = false;
                            break;

                        case DialogResult.No:
                            say("Sorry Hear that Tenno, next time you can talk me about ChisdealHD.");
                            wake = false;
                            break;
                    }
                }

                //+Game Status HERE+

                if (r == "what my fortnite stats")
                 {
                     try
                     {
                        WebClient client = new WebClient();

                        string myJSON = client.DownloadString("https://chisdealhdapi.000webhostapp.com/octaviaData/fortniteapp.php?user=" + textBox4.Text + "&plat="+ comboBox2.Text);
                        var jObject = Newtonsoft.Json.Linq.JObject.Parse(myJSON);
                        string stats = ((string)jObject["Fortnite"]);
                        say(stats);
                        fnlsearch = false;
                        wake = false;
                    }
                    catch
                    {
                        say("Sorry API is DOWN, Please come back Later or check your Internet connection.");
                        fnlsearch = false;
                        wake = false;
                    }
                 }

                if (r == "what my battlefield 3 stats")
                {
                    try
                    {
                        WebClient client = new WebClient();

                        string myJSON = client.DownloadString("https://chisdealhdapi.000webhostapp.com/octaviaData/battlefieldthreeapp.php?user=" + textBox6.Text + "&plat=" + comboBox3.Text);
                        var jObject = Newtonsoft.Json.Linq.JObject.Parse(myJSON);
                        string stats = ((string)jObject["BattlefieldThree"]);
                        say(stats);
                        wake = false;
                    }
                    catch
                    {
                        say("Sorry API is DOWN, Please come back Later or check your Internet connection.");
                        wake = false;
                    }
                }

                if (r == "what is your name")
                {
                    say("My name is, Octavia AI. i am the AI of Warframe i can do you some good musics and many more. i will have lot Upgrades, so check out Website all times for updates.");
                    wake = false;
                }

                if (r == "what is my name")
                {
                    say("You are my Tenno!");
                    wake = false;
                }

                //+Warframe Status HERE+

                if (r == "is baro here")
                {
                    try
                    {
                        WebClient client = new WebClient();

                        string myJSON = client.DownloadString("https://chisdealhdapi.000webhostapp.com/octaviaData/warframedata.php");
                        var jObject = Newtonsoft.Json.Linq.JObject.Parse(myJSON);
                        string baro = ((string)jObject["Warframe"]["baro"]["message"]);
                        say(baro);
                        wake = false;
                    }
                    catch
                    {
                        say("Sorry API is DOWN, Please come back Later or check your Internet connection.");
                        wake = false;
                    }
                }

                if (r == "is sortie here")
                {
                    try
                    {
                        WebClient client = new WebClient();

                        string myJSON = client.DownloadString("https://chisdealhdapi.000webhostapp.com/octaviaData/warframedata.php");
                        var jObject = Newtonsoft.Json.Linq.JObject.Parse(myJSON);
                        string sortie = ((string)jObject["Warframe"]["sortie"]["message"]);
                        say(sortie);
                        wake = false;
                    }
                    catch
                    {
                        say("Sorry API is DOWN, Please come back Later or check your Internet connection.");
                        wake = false;
                    }
                }

                if (r == "is daily deals on sale")
                {
                    try
                    {
                        WebClient client = new WebClient();

                        string myJSON = client.DownloadString("https://chisdealhdapi.000webhostapp.com/octaviaData/warframedata.php");
                        var jObject = Newtonsoft.Json.Linq.JObject.Parse(myJSON);
                        string dailydeals = ((string)jObject["Warframe"]["dailyDeals"]["message"]);
                        say(dailydeals);
                        wake = false;
                    }
                    catch
                    {
                        say("Sorry API is DOWN, Please come back Later or check your Internet connection.");
                        wake = false;
                    }
                }

                if (r == "is earth daytime")
                {
                    try
                    {
                        WebClient client = new WebClient();

                        string myJSON = client.DownloadString("https://chisdealhdapi.000webhostapp.com/octaviaData/warframedata.php");
                        var jObject = Newtonsoft.Json.Linq.JObject.Parse(myJSON);
                        string earth = ((string)jObject["Warframe"]["earth"]["message"]);
                        say(earth);
                        wake = false;
                    }
                    catch
                    {
                        say("Sorry API is DOWN, Please come back Later or check your Internet connection.");
                        wake = false;
                    }
                }

                if (r == "is cetus daytime")
                {
                    try
                    {
                        WebClient client = new WebClient();

                        string myJSON = client.DownloadString("https://chisdealhdapi.000webhostapp.com/octaviaData/warframedata.php");
                        var jObject = Newtonsoft.Json.Linq.JObject.Parse(myJSON);
                        string cetus = ((string)jObject["Warframe"]["cetus"]["message"]);
                        say(cetus);
                        wake = false;
                    }
                    catch
                    {
                        say("Sorry API is DOWN, Please come back Later or check your Internet connection.");
                        wake = false;
                    }
                }

                //+Mixer Status HERE+

                if (r == "am i live on mixer")
                {
                    try
                    {
                        WebClient client = new WebClient();

                        string myJSON = client.DownloadString("https://chisdealhdapi.000webhostapp.com/octaviaData/mixerapp.php?user="+textBox10.Text);
                        var jObject = Newtonsoft.Json.Linq.JObject.Parse(myJSON);
                        string mixer = ((string)jObject["Mixer"]["live"]);
                        say(mixer);
                        wake = false;
                    }
                    catch
                    {
                        say("Sorry API is DOWN, Please come back Later or check your Internet connection.");
                        wake = false;
                    }
                }

                if (r == "what level am i on mixer")
                {
                    try
                    {
                        WebClient client = new WebClient();

                        string myJSON = client.DownloadString("https://chisdealhdapi.000webhostapp.com/octaviaData/mixerapp.php?user=" + textBox10.Text);
                        var jObject = Newtonsoft.Json.Linq.JObject.Parse(myJSON);
                        string mixer = ((string)jObject["Mixer"]["level"]);
                        say(mixer);
                        wake = false;
                    }
                    catch
                    {
                        say("Sorry API is DOWN, Please come back Later or check your Internet connection.");
                        wake = false;
                    }
                }

                if (r == "how many followers on mixer")
                {
                    try
                    {
                        WebClient client = new WebClient();

                        string myJSON = client.DownloadString("https://chisdealhdapi.000webhostapp.com/octaviaData/mixerapp.php?user=" + textBox10.Text);
                        var jObject = Newtonsoft.Json.Linq.JObject.Parse(myJSON);
                        string mixer = ((string)jObject["Mixer"]["followers"]);
                        say(mixer);
                        wake = false;
                    }
                    catch
                    {
                        say("Sorry API is DOWN, Please come back Later or check your Internet connection.");
                        wake = false;
                    }
                }

                if (r == "am i featured on mixer")
                {
                    try
                    {
                        WebClient client = new WebClient();

                        string myJSON = client.DownloadString("https://chisdealhdapi.000webhostapp.com/octaviaData/mixerapp.php?user=" + textBox10.Text);
                        var jObject = Newtonsoft.Json.Linq.JObject.Parse(myJSON);
                        string mixer = ((string)jObject["Mixer"]["featured"]);
                        say(mixer);
                        wake = false;
                    }
                    catch
                    {
                        say("Sorry API is DOWN, Please come back Later or check your Internet connection.");
                        wake = false;
                    }
                }

                if (r == "what game i playing on mixer")
                {
                    try
                    {
                        WebClient client = new WebClient();

                        string myJSON = client.DownloadString("https://chisdealhdapi.000webhostapp.com/octaviaData/mixerapp.php?user=" + textBox10.Text);
                        var jObject = Newtonsoft.Json.Linq.JObject.Parse(myJSON);
                        string mixer = ((string)jObject["Mixer"]["game"]);
                        say(mixer);
                        wake = false;
                    }
                    catch
                    {
                        say("Sorry API is DOWN, Please come back Later or check your Internet connection.");
                        wake = false;
                    }
                }

                if (r == "how much sparks do i have on mixer")
                {
                    try
                    {
                        WebClient client = new WebClient();

                        string myJSON = client.DownloadString("https://chisdealhdapi.000webhostapp.com/octaviaData/mixerapp.php?user=" + textBox10.Text);
                        var jObject = Newtonsoft.Json.Linq.JObject.Parse(myJSON);
                        string mixer = ((string)jObject["Mixer"]["sparks"]);
                        say(mixer);
                        wake = false;
                    }
                    catch
                    {
                        say("Sorry API is DOWN, Please come back Later or check your Internet connection.");
                        wake = false;
                    }
                }

                if (r == "whats my title on mixer")
                {
                    try
                    {
                        WebClient client = new WebClient();

                        string myJSON = client.DownloadString("https://chisdealhdapi.000webhostapp.com/octaviaData/mixerapp.php?user=" + textBox10.Text);
                        var jObject = Newtonsoft.Json.Linq.JObject.Parse(myJSON);
                        string mixer = ((string)jObject["Mixer"]["title"]);
                        say(mixer);
                        wake = false;
                    }
                    catch
                    {
                        say("Sorry API is DOWN, Please come back Later or check your Internet connection.");
                        wake = false;
                    }
                }

            }
            textBox1.AppendText("You sid: "+ r + "\n");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=EU8FVJV5847T2");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("https://shapeshift.io/shifty.html?destination=12X5QPwWQQu6g5W4RnDbHNsiv7zVc5Eeui&output=BTC&apiKey=fd5282419e5183e5b54d31eb13b582fcca5ae761ca706af11a76afc7c5489bdac3869c1fe450071238d2e8b6ed67d75f22220b7e4258e82841a0e88c2a1de662");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.patreon.com/chisdealhd");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/9dTUCeW");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.fortniteplat = comboBox2.Text;

            Properties.Settings.Default.fortnite = textBox4.Text;

            Properties.Settings.Default.bf1plat = comboBox1.Text;

            Properties.Settings.Default.bf1 = textBox5.Text;

            Properties.Settings.Default.bf3 = textBox6.Text;

            Properties.Settings.Default.bf3plat = comboBox3.Text;

            Properties.Settings.Default.bfhplat = comboBox5.Text;

            Properties.Settings.Default.bfh = textBox11.Text;

            Properties.Settings.Default.hypixel = textBox8.Text;

            Properties.Settings.Default.mixer = textBox10.Text;

            Properties.Settings.Default.twitch = textBox9.Text;

            Properties.Settings.Default.bf4 = textBox7.Text;

            Properties.Settings.Default.bf4plat = comboBox4.Text;


            Properties.Settings.Default.Save();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.fortniteplat = comboBox2.Text;

            Properties.Settings.Default.fortnite = textBox4.Text;

            Properties.Settings.Default.bf1plat = comboBox1.Text;

            Properties.Settings.Default.bf1 = textBox5.Text;

            Properties.Settings.Default.bf3 = textBox6.Text;

            Properties.Settings.Default.bf3plat = comboBox3.Text;

            Properties.Settings.Default.bfhplat = comboBox5.Text;

            Properties.Settings.Default.bfh = textBox11.Text;

            Properties.Settings.Default.hypixel = textBox8.Text;

            Properties.Settings.Default.mixer = textBox10.Text;

            Properties.Settings.Default.twitch = textBox9.Text;

            Properties.Settings.Default.bf4 = textBox7.Text;

            Properties.Settings.Default.bf4plat = comboBox4.Text;


            Properties.Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.fortniteplat = comboBox2.Text;
            Properties.Settings.Default.fortnite = textBox4.Text;
            Properties.Settings.Default.Save();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.bf3 = textBox6.Text;
            Properties.Settings.Default.bf3plat = comboBox3.Text;
            Properties.Settings.Default.Save();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.mixer = textBox10.Text;
            Properties.Settings.Default.Save();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.hypixel = textBox8.Text;
            Properties.Settings.Default.Save();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.twitch = textBox9.Text;
            Properties.Settings.Default.Save();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.bfhplat = comboBox5.Text;
            Properties.Settings.Default.bfh = textBox11.Text;
            Properties.Settings.Default.Save();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.bf4 = textBox7.Text;
            Properties.Settings.Default.bf4plat = comboBox4.Text;
            Properties.Settings.Default.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.bf1plat = comboBox1.Text;
            Properties.Settings.Default.bf1 = textBox5.Text;
            Properties.Settings.Default.Save();
        }
    }
}
