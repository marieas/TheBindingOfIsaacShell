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

namespace TheBindingOfIsaac
{
    enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }
   
    public partial class Form1 : Form
    {
        public EventHandler NewDirectionReceived;
        Direction currentDirection;
        
        public Form1()
        {
            InitializeComponent();

            currentDirection = Direction.Right;

            this.KeyDown += Form1_KeyDown;
            NewDirectionReceived += direction_received;


            Task.Run(() => MoveTask());

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private Task MoveTask()
        {
            while (true)
            {
                Thread.Sleep(500);
                NewDirectionReceived(this,new EventArgs());
            }
        }

        //metode som sjekker om isaac kommer borti et item eller en fiende
        //
        private void IntersectCheck()
        {
            isaac.PerformSafely(() =>
            {
                foreach (Control item in this.Controls)
                {
                    if (item is PictureBox && item.Name != "isaac")
                    {
                        if (isaac.Bounds.IntersectsWith(item.Bounds))
                        {
                            item.Hide();
                        }
                    }
                }
            });
        }
        private void direction_received(object sender, EventArgs e)
        {
            MoveIsaac(currentDirection);
            IntersectCheck();
        }
        //Må legge til alle retninger isaac kan gå
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                currentDirection = Direction.Up;
        }

        //Kan skrives om til en generell metode som kan flytte hvilken som helst figur
        // i dette tilfellet flytter han på imaget som ligger på formen og heter isaac
        private void MoveIsaac(Direction moveDirection)
        {
            var xLocation = isaac.Location.X;
            var yLocation = isaac.Location.Y;

            //Her må du ha en sjekk på hvilken retning man skal flytte isaac,
            // og øke/minske x, y koordinater ut ifra det. Eksempelet under
            // viser at isaac flytter seg til høyre ( x-aksens verdi øker)
            isaac.PerformSafely(()=>isaac.Location = new Point(xLocation + 10, yLocation));
          
        }

        private void isaac_Click(object sender, EventArgs e)
        {

        }
    }
}
