using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_RPGGame
{
    internal class Player : Character
    {
        private int exp;
        private int level;
        private int expMaxAmount = 5;

        public int Exp
        {
            get { return exp; }
            set { exp = value; }
        }

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        public int ExpMaxAmount
        {
            get { return expMaxAmount; }
        }

        public void LevelUp()
        {
            this.level = level + 1;
        }

        public void GainExp(int gainExp)
        {
            exp += gainExp;

            if(exp >= expMaxAmount)
            {
                level = level + 1;
                MessageBox.Show("레벨업 했습니다!!");
            }
        }
    }

    internal class NPC : Character
    {

        public void Talk()
        {
            MessageBox.Show("도와줄게!");
        }
    }

}
