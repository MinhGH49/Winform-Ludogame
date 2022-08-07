using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoProduct
{
    internal class LudoDice:Button
    {
        //private LudoDriver driver;

        // private int diceNum;

        Random random = new Random();
        
        public int diceNumb { get; set; }

        public LudoDice()
        {
            this.BackgroundImage = Properties.Resources.dice_default;
            //this.Click += Dice_Click;
            //this.Location = new Point(0, 0);
            this.Size = new Size(170, 170);
            //this.Location = new Point(1070, 4);
            this.Click += Dice_Click;


        }

        //event handler 
        //khi duoc nhan vao thi tao so random,
        //thay doi hinh xuc xac
        //goi ham Driver.Setmove

        public event EventHandler<DiceRolledArgs> DiceRolledEvent;

        /*public void FireDiceRolledEvent(int dice)
        {
            DiceRolledEvent?.Invoke(this, new DiceRolledArgs(dice,que));
        }*/


        public void RollDice()
        {
            diceNumb = random.Next(1, 7);
            UpdateDiceDisplay(diceNumb);
            //FireDiceRolledEvent(diceNum);
            

        }


        private void Dice_Click(object sender, EventArgs e)
        {
            RollDice();

        }

        private void UpdateDiceDisplay(int diceResult)
        {
            switch (diceResult)
            {
                case 1: this.BackgroundImage = Properties.Resources.dice_six_faces_one; break;
                case 2: this.BackgroundImage = Properties.Resources.dice_six_faces_two; break;
                case 3: this.BackgroundImage = Properties.Resources.dice_six_faces_three; break;
                case 4: this.BackgroundImage = Properties.Resources.dice_six_faces_four; break;
                case 5: this.BackgroundImage = Properties.Resources.dice_six_faces_five; break;
                case 6: this.BackgroundImage = Properties.Resources.dice_six_faces_six; break;


            }
        }


   
    }
}
