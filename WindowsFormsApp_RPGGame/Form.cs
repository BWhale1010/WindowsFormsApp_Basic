using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_RPGGame
{
    public partial class Form : System.Windows.Forms.Form
    {

        NPC npc = new NPC(10, 1);
        Monster monster = new Monster(0,0);

        //private Ork ork;
        //private Slime slime;

        public Form()
        {
            InitializeComponent();

            Random random = new Random();
            Player player = new Player(20, random.Next(5, 10));
            player.Name = "PLAYER";
            //player.HP = 20;
            //player.Att = random.Next(5, 10);

            

            npc.Att = 1;

            int choseMonTypeVal = monster.ramdomMonsterAndSkill();

            if (choseMonTypeVal == 0)
            {
                monster = new Ork(random.Next(15, 20), random.Next(5, 8));
                monster.Name = "ORK";
                monster.HP = random.Next(15,20);
                monster.Att = random.Next(5, 8);
                //ork = new Ork();
            }
            else
            {
                monster = new Slime(random.Next(12, 25), random.Next(3, 6));
                monster.Name = "SLIME";
                monster.HP = random.Next(12, 25);
                monster.Att = random.Next(3,6);
                //slime = new Slime();

            }
            monster.HP = 2;

            while (player.HP >= 1 && monster.HP >= 1)
            {
                
                player.Talk();
                int monsterDamage = player.Attack();
                monster.HP -= monsterDamage;

                monster.Talk();
                int playDamage = monster.Attack();
                //monster.AddHitCount();
                player.HP -= playDamage;


                if (monster.ramdomMonsterAndSkill() == 0) 
                {
                    if (monster.Name.Equals("ORK"))
                    {
                        playDamage = ((Ork)monster).AdditionalHit();
                        player.HP -= playDamage;
                    }
                    else if (monster.Name.Equals("SLIME"))
                    {
                        ((Slime)monster).HpRecover();
                    }
                }

                npc.Talk();
                monsterDamage = npc.Attack();
                monster.HP -= monsterDamage;

                if (monster.HP < 1 || player.HP < 1)
                {
                    break;
                }
            }

            if (player.HP> monster.HP) 
            {
                player.HP = 20;
                MessageBox.Show("플레이어 승");
                player.GainExp(monster.DropExp());
                
            } 
            else
            {
                MessageBox.Show("몬스터 승");
            }

        }
    }
}
