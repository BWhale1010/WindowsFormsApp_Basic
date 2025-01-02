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

        public Player(int hp, int att) : base(hp, att)
        {
        }

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

        public void LevelUp(int addedHp)
        {
            this.level = level + 1;
            this.HP = HP + addedHp;

        }

        public void LevelUp(int addedHp, int addedAtt)
        {
            this.level = level + 1;
            this.HP = HP + addedHp;
            this.Att = Att + addedAtt;
        }

        public void GainExp(int gainExp)
        {
            Random random = new Random();
            int randomAddstat = random.Next(0,3);
            int addHp = 5;
            int addAtt = 2;

            exp += gainExp;

            if (exp >= expMaxAmount)
            {
                if (randomAddstat == 0)
                {
                    LevelUp();
                }
                else if (randomAddstat == 1)
                {
                    LevelUp(addHp);
                }
                else
                {
                    LevelUp(addHp, addAtt);
                }

                MessageBox.Show("레벨업 했습니다!!");
            }
        }

        public override void Talk()
        {
            MessageBox.Show("몬스터 죽어라!");
        }
    }

    internal class NPC : Character
    {
        public NPC(int hp, int att) : base(hp, att)
        {
        }

        public override void Talk()
        {
            MessageBox.Show("도와줄게!");
        }
    }

}
