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
            
                vida= 100;
                Console.WriteLine("Your HP is: "+ vida);
                
            for (int round = 1; vida > 0; round++)
        {
                Console.WriteLine("------------\n Round: "+ round);
                string _walk;
                Console.WriteLine("Choose action: ");
                _walk = Console.ReadLine();                       
                if(_walk == "Heal"){
                        Console.WriteLine("You feel revigorated!");
                        vida = vida + 10;
                        Console.WriteLine("Your HP is: "+ vida);
                }
                if(_walk == "walk"){            
                Random numGen = new Random();
               
                int enc = numGen.Next(1, 3);
                int dist = numGen.Next(10, 20);
                int pot;
                string action;
                int gn = numGen.Next(1,2);
                                
                pot = 0 ;                    
                    
                    if(enc == 1){                        
                        if(gn == 1){
                            pot++;
                                Console.WriteLine("You have walked "+ dist + " meters \nYou have now "+ pot +" healing potions \nYou found a healing pot");
                        }else if(gn == 2){
                            Console.WriteLine("You have walked "+ dist + " meters");
                        } 
                    }
                    if(enc == 2){
                        for (int esk = 30; esk > 0;)
                        {
                        int atk =  numGen.Next(1, 20);
                        int eskAtk = numGen.Next(1, 30);
                        Console.WriteLine("You found a skeleton.\nWhat do you want to do?: ");
                        action = Console.ReadLine();                        
                        if(action == "attack"){
                                if(atk <=10 ){
                                    Console.WriteLine("Your attack is weak \nYour attack causesd "+ atk + " of damage");
                                    esk = esk - atk;
                                }else if(atk >= 11){
                                    Console.WriteLine("Your attack is strong \nYour attack causes " + atk + " of damage\nThe skeleton have now " + esk + " of hp");
                                    esk = esk - atk; 
                                }
                                if(eskAtk<= 30){
                                    vida = vida - eskAtk;
                                    Console.WriteLine("The skeleton attaked you, causing "+ eskAtk + " of damage\nYour HP is now "+ vida + "\nThe skeleton have now " + esk + " of hp");                                
                                }
                            }else if(action == "heal"){
                                if(pot == 0){
                                    Console.WriteLine("You have no healing potions left");
                                }else{
                                    vida = vida + 10;
                                    pot--;
                                    Console.WriteLine("You used a heling potion");
                                }
                            }
                        }
                    }else{
                Console.WriteLine("Unexpected Comand");
            } 
                    
        }
        if(vida == 0){
            Console.WriteLine("Game over");
            Console.ReadKey();
            }
            }   
        }
    }
}
