using System;

namespace _2
{
    class knight
    {
        public string name;
        public string stamina;
        public float experience;
        public int attack;
    }
    
    class Program
{
        static void Main(string[] args)
        {      
            int vida;
            
                vida= 10;
                if(vida>0){
                    Console.WriteLine("Your HP is: "+ vida);
                }else{
                    Console.WriteLine("You died");
                }
            for (int round = 1; vida > 0; round++)
            {
                Console.WriteLine("------------------");
                Console.WriteLine("Round: "+ round);
                string _walk;
                Console.WriteLine("Choose action: ");
                _walk = Console.ReadLine();                       
                if(_walk == "Drink pot"){
                        Console.WriteLine("You feel revigorated!");
                        vida++;
                        Console.WriteLine("Your HP is: "+ vida);
                }
                if(_walk == "walk"){            
                Random numGen = new Random();
               
                int enc = numGen.Next(1, 3);
                int dist = numGen.Next(10, 20);
                int pot;
                pot=0;
                    
                    if(enc==1){                        
                        int gn = numGen.Next(1,2);
                            if(gn == 1){
                                pot++;
                                Console.WriteLine("you walks "+ dist + " meters");
                                Console.WriteLine("You found a healing pot");
                                Console.WriteLine("you have now "+ pot +" healing potions");
                        }else if(gn == 2){
                            Console.WriteLine("You walks "+ dist + " meters");
                        }else if(enc==2){
                            Console.WriteLine("You found a skeleton");
                            vida--;      
                            Console.WriteLine("Your HP is "+ vida);          
                        }else if(enc==3){
                            Console.WriteLine("You found a goblin");
                            vida --;
                            vida --;
                            Console.WriteLine("Your HP is "+ vida);
                        }else{
                        Console.WriteLine("Unexpected Comand");
                        }
                    }
                }
            }
        }   
    }
}
