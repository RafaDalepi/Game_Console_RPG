using System;

namespace _2
{
    class knight
    {
        public string name;
        public float exp, stamina;
        public int attack, level, vida;
    
        public void xp(int a){
            exp = 0;
            if(a == 1){
                exp =+ 0.5f;
                if(exp == 10){
                    level++;
                }
            }
        }
    }
    
    class Program
    {
            static void Main(string[] args)  
        { 
            string player;        
            Console.WriteLine("Choose your class: ");
            player = Console.ReadLine();
            if(player == "knight" ){
                Console.WriteLine("Knights have a bonus on health"); 
                knight _player = new knight();
                Console.WriteLine("Choose your name: ");
                _player.name = Console.ReadLine();  
                _player.attack = 10;
                _player.level= 1; 
                _player.stamina=5; 
                _player.vida = 50;   
                _player.exp=0;                      
            }
            
            int vida, pot, round, bag;
            Random numGen = new Random();
            vida= 10;
            pot= 0;
            for (round = 0; vida > 0; round++){
                Console.WriteLine("------------\nRound: "+ round + "\nYour hp is: "+ vida);
                string _walk;                
                Console.WriteLine("Choose action: ");
                _walk = Console.ReadLine();                  
                if(_walk == "heal"){
                        if(pot > 0){
                        vida = vida + 10;
                        Console.WriteLine("You feel revigorated!\nYour HP is: "+ vida);                        
                    }else{
                        Console.WriteLine("you have no healing potions left");
                    }
                }else if(_walk == "walk"){
                    int dist = numGen.Next(1, 100);                                   
                    if(dist >= 60){
                        bag = Bag(pot);
                        if(bag>=5){
                            pot++; 
                            Console.WriteLine("You have walked "+ dist + " meters\nYou found a healing pot\nYou have now "+ pot +" healing potions ");
                        }else{
                            Console.WriteLine("You have walked "+ dist + " meters\nYou found a healing pot\nBut your bag is full\nyou have now "+pot+" healing potions left");
                        }
                    }else if(dist <= 59){
                        Console.WriteLine("You have walked "+ dist + " meters");
                    }
                //COMBATE   
                }else if(_walk == "fight" || vida > 0){        
                int enc = numGen.Next(1, 3);
                string action;                
                    Console.WriteLine("You looked aroud and found an skeleton in the distance");
                        for (int esk = 30; esk > 0;){
                        int atk =  numGen.Next(1, 20);
                        int eskAtk = numGen.Next(1, 30);
                        Console.WriteLine("What do you want to do? ");
                        action = Console.ReadLine();                        
                        if(action == "attack" || vida > 0 ){
                                if(atk >= 10 ){
                                    Console.WriteLine("Your attack is weak \nYour attack causesd "+ atk + " of damage");
                                    esk = esk - atk;
                                }else if(atk >= 11){
                                    Console.WriteLine("Your attack is strong \nYour attack causes " + atk + " of damage\nThe skeleton have now " + esk + " of hp");
                                    esk = esk - atk; 
                                }
                                vida = vida - eskAtk;
                                Console.WriteLine("The skeleton attaked you, causing "+ eskAtk + " of damage\nYour HP is now "+ vida);                              
                            }                             
                        if(action == "heal"){
                            if(pot < 1){
                                Console.WriteLine("You have no healing potions left");
                            }else{
                                vida = vida + 10;
                                pot--;
                                Console.WriteLine("You used a heling potion");
                            }
                        }else{
                            Console.WriteLine("Unexpected Comand");
                        }
                        if(esk < 1){
                            
                        }
                        if(vida <= 0){
                            break;
                        }
                    }
                }             
            }
        if(vida <= 0){
            Console.Clear();
            Console.WriteLine("You survived until round "+ round);
            Console.WriteLine("Game over");
            Console.ReadKey();                     
        }                       
    }
        static int Bag(int bag){
            bag=0;             
            if(bag <= 5){
                bag ++;
            }
            return bag;
        }            
    }
}

