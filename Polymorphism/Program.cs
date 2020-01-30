using System;
using System.Collections.Generic;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<CharacterBase> party = new List<CharacterBase>();
            //party.Add(new Hunter());
            //party.Add(new Soldier());
            //party.Add(new Wizard());

            List<CharacterBase> party = new List<CharacterBase>{
                new Hunter(),
                new Soldier(),
                new Wizard()
            };

            foreach(CharacterBase member in party){
                Console.WriteLine(member.Attack());
            }
        }
    }

    public abstract class CharacterBase {
        public abstract string Attack();
    }

    public class Hunter : CharacterBase{
        public override string Attack(){
            return("矢を放つ");
        }
    }
    public class Soldier : CharacterBase {
        public override string Attack(){
            return("剣を振るう");
        }
    }
    public class Wizard : CharacterBase {
        public override string Attack(){
            return("呪文を唱える");
        }
    }
}
