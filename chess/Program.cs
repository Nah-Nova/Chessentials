//CREATED BY: Noa Heutz 2023

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using chess;

namespace Chess
{
    // Static class to manage the turn label
    static class TurnLable
    {
        // The label that displays the current turn
        public static Label lb_turn = new Label()
        {
            Text = "White",
            Location = new Point(588, 175),
            Font = new Font("Arial", 16, FontStyle.Bold),
            ForeColor = Color.White,
            BackColor = Color.Black // Set the background color to black
        };

        // Method to change the text and colors of the turn label
        public static void changeTextTurn()
        {
            if (lb_turn.Text == "White")
            {
                lb_turn.Text = "Black";
                lb_turn.ForeColor = Color.Black;
                lb_turn.BackColor = Color.White;
            }
            else
            {
                lb_turn.Text = "White";
                lb_turn.ForeColor = Color.White;
                lb_turn.BackColor = Color.Black;
            }
        }
    }


    // Main program class
    internal class Program
    {
        // Custom form class
        class MyForm : Form
        {
            public MyForm()
            {
                // Set form properties
                this.Text = "Chessentials";
                this.Size = new System.Drawing.Size(690, 600);
                this.BackColor = Color.Black; // Set the background color of the form to black

                // Create and configure the "TURN" label
                Label lb1 = new Label();
                lb1.Text = "===TURN===";
                lb1.Location = new Point(570, 150);
                lb1.Font = new Font("Arial", 12, FontStyle.Bold);
                lb1.ForeColor = Color.White;

                // Create a board object
                Board bd = new Board(this);

                // Add controls to the form
                this.Controls.Add(lb1);
                this.Controls.Add(TurnLable.lb_turn);
            }
        }

        // Entry point of the program
        static void Main(string[] args)
        {
            // Create an instance of the custom form
            MyForm form = new MyForm();

            // Run the application
            Application.Run(form);
        }
    }
}
