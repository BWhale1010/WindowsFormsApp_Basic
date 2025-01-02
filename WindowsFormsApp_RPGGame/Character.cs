using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_RPGGame
{
    internal class Character
    {
        private string name;
        private int hp;
        private int att;

        public Character(int hp, int att)
        {
            this.hp = hp;
            this.att = att;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int HP
        {
            get { return hp; }
            set { hp = value; }
        }

        public int Att
        {
            get { return att; }
            set { att = value; }
        }

        public int Attack()
        {

            return att;
        }

        public virtual void Talk()
        {
            //MessageBox.Show("");
        }
    }
}
