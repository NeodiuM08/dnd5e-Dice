using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//This is a dice roller to simulate the creation of a character in Dungeons and Dragons, 5th Edition.
//4 dice (6 sides) are rolled, 6 times.  The lowest of each of these sets is dropped to give you the three highest, which you add together.
//The result is 6 numbers, these can be used by a player to assign as attributes however they want on a character sheet, this isnt important, only that there is 6 numbers, properly caluclated.
//Generally when the total of these 6 numbers is less than 70 points in total, our group tends to re-roll the whole lot, because a character starting that weak would be meh.
//Characters to powerful are also pretty meh, but I haven't worked that out yet.
namespace Diceroll5e
{
    public partial class Diceroller : Form
    {
        public Diceroller()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            int check = 0;
            while (check < 70)
            {
                //////////////////////SET 1////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                Random random = new Random();
                int dices1d1 = random.Next(1, Convert.ToInt32(textBox1.Text) + 1);         //Sets the first dice as a d6 based on input from text box
                int dices1d2 = random.Next(1, Convert.ToInt32(textBox1.Text) + 1);         //Sets the first dice as a d6 based on input from text box
                int dices1d3 = random.Next(1, Convert.ToInt32(textBox1.Text) + 1);         //Sets the first dice as a d6 based on input from text box
                int dices1d4 = random.Next(1, Convert.ToInt32(textBox1.Text) + 1);         //Sets the first dice as a d6 based on input from text box
                set1dice1.Text = Convert.ToString(dices1d1);                               //Converts the int number rolled into text to be displayed in the label for dice 1
                set1dice2.Text = Convert.ToString(dices1d2);                               //Converts the int number rolled into text to be displayed in the label for dice 2
                set1dice3.Text = Convert.ToString(dices1d3);                               //Converts the int number rolled into text to be displayed in the label for dice 3
                set1dice4.Text = Convert.ToString(dices1d4);                               //Converts the int number rolled into text to be displayed in the label for dice 4
                                                                                           //Need to identify, then remove the lowest number from the 4 integers (this gets us the 3 highest dice)
                int[] dicearray1 = new int[4];                                                  //Create an array full of the random numbers from 1 to 4
                dicearray1[0] = dices1d1;                                                  //Fill in the random numbers to the array slots (start at 0, not 1)
                dicearray1[1] = dices1d2;
                dicearray1[2] = dices1d3;
                dicearray1[3] = dices1d4;
                Array.Sort(dicearray1);                                                         //Sort them (i think default looks to be from smallest to largets

                int total1 = dicearray1[1] + dicearray1[2] + dicearray1[3];                     //Adds the dice together (changed this to be the dice from the array, slots 1,2,3 - dropping 0 - which i think will be the lowest)
                dicetotal1.Text = Convert.ToString(total1);                                     //Displays the total of the dice added together in text format.

                /////////////////////SET 2////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                int dices2d1 = random.Next(1, Convert.ToInt32(textBox1.Text) + 1);         //Sets the first dice as a d6 based on input from text box
                int dices2d2 = random.Next(1, Convert.ToInt32(textBox1.Text) + 1);         //Sets the first dice as a d6 based on input from text box
                int dices2d3 = random.Next(1, Convert.ToInt32(textBox1.Text) + 1);         //Sets the first dice as a d6 based on input from text box
                int dices2d4 = random.Next(1, Convert.ToInt32(textBox1.Text) + 1);         //Sets the first dice as a d6 based on input from text box
                set2dice1.Text = Convert.ToString(dices2d1);                               //Converts the int number rolled into text to be displayed in the label for dice 1
                set2dice2.Text = Convert.ToString(dices2d2);                               //Converts the int number rolled into text to be displayed in the label for dice 2
                set2dice3.Text = Convert.ToString(dices2d3);                               //Converts the int number rolled into text to be displayed in the label for dice 3
                set2dice4.Text = Convert.ToString(dices2d4);                               //Converts the int number rolled into text to be displayed in the label for dice 4
                                                                                           //Need to identify, then remove the lowest number from the 4 integers (this gets us the 3 highest dice)
                int[] dicearray2 = new int[4];                                                  //Create an array full of the random numbers from 1 to 4
                dicearray2[0] = dices2d1;                                                  //Fill in the random numbers to the array slots (start at 0, not 1)
                dicearray2[1] = dices2d2;
                dicearray2[2] = dices2d3;
                dicearray2[3] = dices2d4;
                Array.Sort(dicearray2);                                                         //Sort them (i think default looks to be from smallest to largets

                int total2 = dicearray2[1] + dicearray2[2] + dicearray2[3];                     //Adds the dice together (changed this to be the dice from the array, slots 1,2,3 - dropping 0 - which i think will be the lowest)
                dicetotal2.Text = Convert.ToString(total2);                                     //Displays the total of the dice added together in text format.

                /////////////////////SET 3////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                int dices3d1 = random.Next(1, Convert.ToInt32(textBox1.Text) + 1);         //Sets the first dice as a d6 based on input from text box
                int dices3d2 = random.Next(1, Convert.ToInt32(textBox1.Text) + 1);         //Sets the first dice as a d6 based on input from text box
                int dices3d3 = random.Next(1, Convert.ToInt32(textBox1.Text) + 1);         //Sets the first dice as a d6 based on input from text box
                int dices3d4 = random.Next(1, Convert.ToInt32(textBox1.Text) + 1);         //Sets the first dice as a d6 based on input from text box
                set3dice1.Text = Convert.ToString(dices3d1);                               //Converts the int number rolled into text to be displayed in the label for dice 1
                set3dice2.Text = Convert.ToString(dices3d2);                               //Converts the int number rolled into text to be displayed in the label for dice 2
                set3dice3.Text = Convert.ToString(dices3d3);                               //Converts the int number rolled into text to be displayed in the label for dice 3
                set3dice4.Text = Convert.ToString(dices3d4);                               //Converts the int number rolled into text to be displayed in the label for dice 4
                                                                                           //Need to identify, then remove the lowest number from the 4 integers (this gets us the 3 highest dice)
                int[] dicearray3 = new int[4];                                                  //Create an array full of the random numbers from 1 to 4
                dicearray3[0] = dices3d1;                                                  //Fill in the random numbers to the array slots (start at 0, not 1)
                dicearray3[1] = dices3d2;
                dicearray3[2] = dices3d3;
                dicearray3[3] = dices3d4;
                Array.Sort(dicearray3);                                                         //Sort them (i think default looks to be from smallest to largets

                int total3 = dicearray3[1] + dicearray3[2] + dicearray3[3];                     //Adds the dice together (changed this to be the dice from the array, slots 1,2,3 - dropping 0 - which i think will be the lowest)
                dicetotal3.Text = Convert.ToString(total3);

                /////////////////////SET 4//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                int dices4d1 = random.Next(1, Convert.ToInt32(textBox1.Text) + 1);         //Sets the first dice as a d6 based on input from text box
                int dices4d2 = random.Next(1, Convert.ToInt32(textBox1.Text) + 1);         //Sets the first dice as a d6 based on input from text box
                int dices4d3 = random.Next(1, Convert.ToInt32(textBox1.Text) + 1);         //Sets the first dice as a d6 based on input from text box
                int dices4d4 = random.Next(1, Convert.ToInt32(textBox1.Text) + 1);         //Sets the first dice as a d6 based on input from text box
                set4dice1.Text = Convert.ToString(dices4d1);                               //Converts the int number rolled into text to be displayed in the label for dice 1
                set4dice2.Text = Convert.ToString(dices4d2);                               //Converts the int number rolled into text to be displayed in the label for dice 2
                set4dice3.Text = Convert.ToString(dices4d3);                               //Converts the int number rolled into text to be displayed in the label for dice 3
                set4dice4.Text = Convert.ToString(dices4d4);                               //Converts the int number rolled into text to be displayed in the label for dice 4
                                                                                           //Need to identify, then remove the lowest number from the 4 integers (this gets us the 3 highest dice)
                int[] dicearray4 = new int[4];                                                  //Create an array full of the random numbers from 1 to 4
                dicearray4[0] = dices4d1;                                                  //Fill in the random numbers to the array slots (start at 0, not 1)
                dicearray4[1] = dices4d2;
                dicearray4[2] = dices4d3;
                dicearray4[3] = dices4d4;
                Array.Sort(dicearray4);                                                         //Sort them (i think default looks to be from smallest to largets

                int total4 = dicearray4[1] + dicearray4[2] + dicearray4[3];                     //Adds the dice together (changed this to be the dice from the array, slots 1,2,3 - dropping 0 - which i think will be the lowest)
                dicetotal4.Text = Convert.ToString(total4);

                ////////////////////SET 5 ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                int dices5d1 = random.Next(1, Convert.ToInt32(textBox1.Text) + 1);         //Sets the first dice as a d6 based on input from text box
                int dices5d2 = random.Next(1, Convert.ToInt32(textBox1.Text) + 1);         //Sets the first dice as a d6 based on input from text box
                int dices5d3 = random.Next(1, Convert.ToInt32(textBox1.Text) + 1);         //Sets the first dice as a d6 based on input from text box
                int dices5d4 = random.Next(1, Convert.ToInt32(textBox1.Text) + 1);         //Sets the first dice as a d6 based on input from text box
                set5dice1.Text = Convert.ToString(dices5d1);                               //Converts the int number rolled into text to be displayed in the label for dice 1
                set5dice2.Text = Convert.ToString(dices5d2);                               //Converts the int number rolled into text to be displayed in the label for dice 2
                set5dice3.Text = Convert.ToString(dices5d3);                               //Converts the int number rolled into text to be displayed in the label for dice 3
                set5dice4.Text = Convert.ToString(dices5d4);                               //Converts the int number rolled into text to be displayed in the label for dice 4
                                                                                           //Need to identify, then remove the lowest number from the 4 integers (this gets us the 3 highest dice)
                int[] dicearray5 = new int[4];                                                  //Create an array full of the random numbers from 1 to 4
                dicearray5[0] = dices5d1;                                                  //Fill in the random numbers to the array slots (start at 0, not 1)
                dicearray5[1] = dices5d2;
                dicearray5[2] = dices5d3;
                dicearray5[3] = dices5d4;
                Array.Sort(dicearray5);                                                         //Sort them (i think default looks to be from smallest to largets

                int total5 = dicearray5[1] + dicearray5[2] + dicearray5[3];                     //Adds the dice together (changed this to be the dice from the array, slots 1,2,3 - dropping 0 - which i think will be the lowest)
                dicetotal5.Text = Convert.ToString(total5);

                /////////////////////SET 6////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                int dices6d1 = random.Next(1, Convert.ToInt32(textBox1.Text) + 1);         //Sets the first dice as a d6 based on input from text box
                int dices6d2 = random.Next(1, Convert.ToInt32(textBox1.Text) + 1);         //Sets the first dice as a d6 based on input from text box
                int dices6d3 = random.Next(1, Convert.ToInt32(textBox1.Text) + 1);         //Sets the first dice as a d6 based on input from text box
                int dices6d4 = random.Next(1, Convert.ToInt32(textBox1.Text) + 1);         //Sets the first dice as a d6 based on input from text box
                set6dice1.Text = Convert.ToString(dices6d1);                               //Converts the int number rolled into text to be displayed in the label for dice 1
                set6dice2.Text = Convert.ToString(dices6d2);                               //Converts the int number rolled into text to be displayed in the label for dice 2
                set6dice3.Text = Convert.ToString(dices6d3);                               //Converts the int number rolled into text to be displayed in the label for dice 3
                set6dice4.Text = Convert.ToString(dices6d4);                               //Converts the int number rolled into text to be displayed in the label for dice 4
                                                                                           //Need to identify, then remove the lowest number from the 4 integers (this gets us the 3 highest dice)
                int[] dicearray6 = new int[4];                                                  //Create an array full of the random numbers from 1 to 4
                dicearray6[0] = dices6d1;                                                  //Fill in the random numbers to the array slots (start at 0, not 1)
                dicearray6[1] = dices6d2;
                dicearray6[2] = dices6d3;
                dicearray6[3] = dices6d4;
                Array.Sort(dicearray6);                                                         //Sort them (i think default looks to be from smallest to largets

                int total6 = dicearray6[1] + dicearray6[2] + dicearray6[3];                     //Adds the dice together (changed this to be the dice from the array, slots 1,2,3 - dropping 0 - which i think will be the lowest)
                dicetotal6.Text = Convert.ToString(total6);

                /////////////////////TOTAL /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                int sumofattributes = total1 + total2 + total3 + total4 + total5 + total6;                   //adds the totals of each set of dice (which is only the three highest) together.0
                FinalTotal.Text = Convert.ToString(sumofattributes);                                         //Displays the result of the total character power.
                check = sumofattributes;                                                                     //This is part of the while loop, if the character power totaled above is less than 70, it re-runs the loop. Cause characters under 70 are poop.
            }        
        }
    }
}
