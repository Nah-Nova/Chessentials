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
    static class TurnLable
    {
        public static Label lb_turn = new Label()
        {
            Text = "White",
            Location = new Point(588, 175),
            Font = new Font("Arial", 16, FontStyle.Bold),
            ForeColor = Color.White,
            BackColor = Color.Black // Set the background color to black
        };

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


    internal class Program
    {
        class MyForm : Form
        {
            public MyForm()
            {
                this.Text = "Chessentials";
                this.Size = new System.Drawing.Size(690, 600);
                this.BackColor = Color.Black; // Set the background color of the form to black

                Label lb1 = new Label();
                lb1.Text = "===TURN===";
                lb1.Location = new Point(570, 150);
                lb1.Font = new Font("Arial", 12, FontStyle.Bold);
                lb1.ForeColor = Color.White;

                Board bd = new Board(this);

                this.Controls.Add(lb1);
                this.Controls.Add(TurnLable.lb_turn);
            }
        }

        static void Main(string[] args)
        {
            MyForm form = new MyForm();
            Application.Run(form);
        }
    }
}
