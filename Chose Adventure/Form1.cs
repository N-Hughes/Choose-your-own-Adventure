using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Chose_Adventure
{
    public partial class Form1 : Form
    {
        int page = 1;

        Random randgen = new Random();

            //Soundplayer
            SoundPlayer fart = new SoundPlayer(Properties.Resources.buttonSound);
        
        

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = randgen.Next(2,4);
            }
            else if (page == 2)
            {
                page = 13;
            }
            else if (page == 3)
            {
                page = 14;
            }
            else if (page == 4)
            {
                page = 3;
            }
            else if (page == 5)
            {
                page = 3;
            }
            else if (page == 6)
            {
                page = 7;
            }
            else if (page == 7)
            {
                page = 9;
            }
            else if (page == 8)
            {
                page = 3;
            }
            else if (page == 9)
            {
                page = 10;
            }
            else if (page == 10)
            {
                page = 3;
            }
            else if (page == 11)
            {
                page = 3;
            }
            else if (page == 12)
            {
                page = 3;
            }
            else if (page == 13)
            {
                page = randgen.Next(4,6);
            }
            else if (page == 14)
            {
                page = 15;
            }
            else if (page == 15)
            {
                page = 16; 
            }
            else if (page == 16)
            {
                page = 25;
            }
            else if (page == 17)
            {
                page = 25;
            }
            else if (page == 18)
            {
                page = 25;
            }
            else if (page == 19)
            {
                page = 20;
            }
            else if (page == 20)
            {
                page = 25;
            }
            else if (page == 21)
            {
                page = 22;
            }
            else if (page == 22)
            {
                page = 25; 
            }
            else if (page == 23)
            {
                page = 25;
            }
            else if (page == 24)
            {
                page = 25; 
            }
            else if (page == 25)
            {
                page = 1;
            }

            DisplayPage();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {

            }
            else if (page == 2)
            {
                page = 6; 
            }
            else if (page == 3)
            {
                page = 19;
            }
            else if (page == 4)
            {
                page = 3;
            }
            else if (page == 5)
            {
                page = 3;
            }
            else if (page == 6)
            {
                page = 8; 
            }
            else if (page == 7)
            {
                page = 12;
            }
            else if (page == 8)
            {
                page = 3;
            }
            else if (page == 9)
            {
                page = 11;
            }
            else if (page == 10)
            {
                page = 3;
            }
            else if (page == 11)
            {
                page = 3;
            }
            else if (page == 12)
            {
                page = 3; 
            }
            else if (page == 13)
            {
                page = 3; 
            }
            else if (page == 14)
            {
                page = 18;
            }
            else if (page == 15)
            {
                page = 17;
            }
            else if (page == 16)
            {
                page = 25;
            }
            else if (page == 17)
            {
                page = 25; 
            }
            else if (page == 18)
            {
                page = 25;
            }
            else if (page == 19)
            {
                page = 21;
            }
            else if (page == 20)
            {
                page = 25;
            }
            else if (page == 21)
            {
                page = 23;
            }
            else if (page == 22)
            {
                page = 25;
            }
            else if (page == 23)
            {
                page = 25;
            }
            else if (page == 24)
            {
                page = 25;
            }
            else if (page == 25)
            {
                Application.Exit();
            }

            DisplayPage();


        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                
            }
            else if (page == 2)
            {

            }
            else if (page == 3)
            {

            }
            else if (page == 4)
            {

            }
            else if (page == 5)
            {

            }
            else if (page == 6)
            {

            }
            else if (page == 7)
            {

            }
            else if (page == 8)
            {

            }
            else if (page == 9)
            {

            }
            else if (page == 10)
            {

            }
            else if (page == 11)
            {

            }
            else if (page == 12)
            {

            }
            else if (page == 13)
            {

            }
            else if (page == 14)
            {

            }
            else if (page == 15)
            {

            }
            else if (page == 16)
            {

            }
            else if (page == 17)
            {

            }
            else if (page == 18)
            {

            }
            else if (page == 19)
            {
                page = 24;
            }
            else if (page == 20)
            {

            }
            else if (page == 21)
            {

            }
            else if (page == 22)
            {

            }
            else if (page == 23)
            {

            }
            else if (page == 24)
            {
                page = 25;
            }
            else if (page == 25)
            {
               
            }

            DisplayPage();

                
        }

        public void DisplayPage()
        {
            //Playing Button Click
            fart.Play();

            switch (page)
            {
                case 1:
                    outputLabel.Visible = true;
                    button1.Text = "Continue.";
                    button2.Visible = false;
                    break;
                case 2:
                    button2.Visible = true;
                    outputLabel.Text = "Greeting my child, how was your bathroom trip";
                    button1.Text = "Good.";
                    button2.Text = "Bad.";
                    break;
                case 3:
                    button2.Visible = true;
                    outputLabel.Text = "Don't make your father angry..";
                    button1.Text = "Where have you put me father";
                    button2.Text = "I'm sorry papa";
                    break;
                case 4:
                    outputLabel.Text = "You hear your father say (YOU WILL BE SAVED!!) \n\nYou get punched in the face and carried away by your father...";
                    button1.Text = "Contuine";
                    button2.Text = "Contuine";
                    break;
                case 5:
                    outputLabel.Text = "Quickly run I will save the people the LOCATION (As you are running away you turn back to see your father run into the place you used the restroom. Because you are not paying attention you fall and knock yourself out)";
                    button1.Text = "Continue";
                    button2.Text = "Continue";
                    break;
                case 6:
                    outputLabel.Text = "GET ON THE GROUND (You were shot by the man) \n\nHow do you heal your wound?";
                    button1.Text = "Bandage it up DIY style";
                    button2.Text = "Lick it";
                    break;
                case 7:
                    outputLabel.Text = "You Quickly grab napkins and start wrapping up your bullet wound \n\nHow do you stop the robber";
                    button1.Text = "Pull a gun on the Robber";
                    button2.Text = "Escape the location";
                    break;
                case 8:
                    outputLabel.Text = "You lick the wound, Which proceeds to taste gross and feel very painful as everyone in the restaurant makes fun of you. You get knocked out by the robber shortly after you feel the worst embarrassment you will in your lifetime.";
                    button1.Text = "Continue";
                    button2.Text = "Continue";
                    break;
                case 9:
                    outputLabel.Text = "You quickly pull a gun from your anus. You start shooting the robber out of angry and fear.";
                    button1.Text = "Yes";
                    button2.Text = "No";
                    break;
                case 10:
                    outputLabel.Text = "You quickly pocket the gun then you go back to shooting until you are arrested by police.";
                    Thread.Sleep(10000);
                    Refresh();
                    outputLabel.Text = "As you are in the police car you start looking for the robbers gun. You soon find it and shoot both officers in the car. You crash and die on impact";
                    button1.Text = "Continue";
                    button2.Text = "Continue";
                    break;
                case 11:
                    outputLabel.Text = " You look away from the gun and start shooting again. The police show up and arrest you.";
                    Thread.Sleep(5000);
                    outputLabel.Text = "As you are in the police car you start looking for the robbers gun but remember you didn't take it. You quickly black out shortly after from panicking";
                    button1.Text = "Continue";
                    button2.Text = "Continue";
                    break;
                case 12:
                    outputLabel.Text = "You quickly stand up and head for the door. You die from getting shot the second you got up";
                    button1.Text = "Continue";
                    button2.Text = "Continue";
                    break;
                case 13:
                    outputLabel.Text = "Thank god. Allow us to leave this forsaken place. (As you leave someone runs in followed up by gun shots)";
                    button1.Text = "Continue";
                    button2.Text = "Continue";
                    break;
                case 14:
                    outputLabel.Text = "Your father talks to you in a stern tone. He must really not want you to know anything. You can't understand what he's saying \n\nHow do you respond";
                    button1.Text = "Shoot FATHER";
                    button2.Text = "You ask FATHER to repeat himself";
                    break;
                case 15:
                    outputLabel.Text = "You don't have a gun. But you already screamed out at FATHER that you will shoot him. FATHER is angry. You have no choice you have to make a gun on the spot \n\nHow do you respond";
                    button1.Text = "Learn how to make a gun";
                    button2.Text = "Tackle FATHER and search the location";
                    break;
                case 16:
                    outputLabel.Text = "You've taken too long. FATHER gets to you and repeatedly stabs you until you die.";
                    button1.Text = "Continue";
                    button2.Text = "Continue";
                    break;
                case 17:
                    outputLabel.Text = "You tackled FATHER to the ground. He is knocked out cold. While searching you find a gun in a closet. No need to make one anymore. You head back to FATHER; he is still knocked out coldYou're scared to shoot. You are about to murder someone after all. Suddenly you hear a loud knocking sound from a door in the corner.The knocking scares you so much that you have a heart attack. You've died";
                    button1.Text = "Continue";
                    button2.Text = "Continue";
                    break;
                case 18:
                    outputLabel.Text = "DON'T TELL ME TO SPEAK AGAIN CHILD. FATHER says. Father picks up the knife in anger. You've been stabbed multiple times. You won't survive. You've Died";
                    button1.Text = "Continue";
                    button2.Text = "Continue";
                    break;
                case 19:
                    button3.Visible = true;
                    outputLabel.Text = "While waiting for a response you look around. This area is so unfamiliar with you. Your father responds (Because of this little stunt you will not see the light of day. This is your last night on this earth before I save you)\n\nConfused by what FATHER has just said you...";
                    button1.Text = "Fly Away";
                    button2.Text = "Scream at FATHER in anger";
                    button3.Text = "Make a run for it";
                    break;
                case 20:
                    button3.Visible = false;
                    outputLabel.Text = "This has all been a dream. You've been peeing this whole time and you thought it was real. You come back to reality";
                    button1.Text = "Continue";
                    button2.Text = "Continue";
                    break;
                case 21:
                    button3.Visible = false;
                    outputLabel.Text = "You scream your heart out at your father. You call him insults and tell him he is an awful father. You crossed the line. Your father grabs a knife off of a table in anger. Luckily someone knocks on the house door! You might be saved!\n\nYou can't wait anymore you have to do something you....";
                    button1.Text = "Grab the Knife";
                    button2.Text = "Open the knocking door";
                    break;
                case 22:
                    outputLabel.Text = "You fight for the knife. You don't want to die./nYip Yip Horray! You grabbed the knife and you stab out your father eyes. He kicks you away and crawls away in agony. You get back up with the knife. You're ready to kill; you are a monster. The knife goes into fathers shoulder like butter. This won't kill him. You then dragged the knife from his shoulder down to his hip. You've killed him. The neighbor kicks the door down and sees what happens. (YOU TOURTURED YOUR FATHER I HOPE YOU DIE PAINFULLY) ...You can't breath. Why? It has only been a second since he kicked the door down nothing could happen. Unless you've been shot?\n\n...You have...";
                    button1.Text = "Continue";
                    button2.Text = "Continue";
                    break;
                case 23:
                    outputLabel.Text = "You try to move. You can't. What's wrong you ask yourself? I got out of the seat why can't I move. Is it fear? It's the knife. That must be why. You look down to confirm what you thought. Your throat is open. Dripping blood. This is the end. You've Died";
                    button1.Text = "Continue";
                    button2.Text = "Continue";
                    break;
                case 24:
                    button3.Visible = false;
                    outputLabel.Text = "You run. Who knows where or to why but you run. you are able to make it to a door but a long, cold, damp hallway is presented before you. You are unsure of what lays beyond but you run down this hallway anyways. How long has it been? Days? Minutes? maybe hours. Who knows how long you've ran but you are tired. (I give up) you say to yourself and you choose to lay in a corner, crying. You will die here. Slowly.But, Eventually.";
                    button1.Text = "Continue";
                    button2.Text = "Continue";
                    break;
                case 25:
                    outputLabel.Text = "Continue Playing?";
                    button1.Text = "Yes";
                    button2.Text = "No.";
                    break;
            }
        }
    }
}