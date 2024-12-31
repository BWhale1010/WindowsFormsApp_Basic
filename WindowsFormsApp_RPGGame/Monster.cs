using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_RPGGame
{
    internal class Monster : Character
    {
        Random random = new Random();

        public int DropExp()
        {
            Random random = new Random();
            int dropExp = random.Next(8,10);

            return dropExp;
        }

        public int ramdomMonsterAndSkill()
        {
            return random.Next(0, 2);
        }

    }

    internal class Ork : Monster
    {
        public int AdditionalHit()
        {
            return 1;
        }

    }

    internal class Slime : Monster
    {
        public void HpRecover()
        {
            this.HP += 1;
        }
    }

}
