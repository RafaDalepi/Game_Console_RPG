﻿using System;

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
            int vida, pot, round, bag;
            Random numGen = new Random();
            bag = 5;
            vida= 1;
            pot = 0;
            for (round = 1; vida > 0; round++){
                Console.WriteLine("------------\nRound: "+ round + "\nYour hp is: "+ vida);
                string _walk;                
                Console.WriteLine("Choose action: ");
                _walk = Console.ReadLine();                  
                if(_walk == "heal"){
                        if(pot > 0){
                        Console.WriteLine("You feel revigorated!\nYour HP is: "+ vida);
                        vida = vida + 10;
                    }else{
                        Console.WriteLine("you have no healing potions left");
                    }
                }else if(_walk == "walk"){
                    int dist = numGen.Next(1, 100);                
                    if(dist >= 60){
                        pot++;
                        Console.WriteLine("You have walked "+ dist + " meters\nYou found a healing pot\nYou have now "+ pot +" healing potions ");
                    }else if(dist <= 29){
                        Console.WriteLine("You have walked "+ dist + " meters");
                    } 
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
                                if(atk <=10 ){
                                    Console.WriteLine("Your attack is weak \nYour attack causesd "+ atk + " of damage");
                                    esk = esk - atk;
                                }else if(atk >= 11){
                                    Console.WriteLine("Your attack is strong \nYour attack causes " + atk + " of damage\nThe skeleton have now " + esk + " of hp");
                                    esk = esk - atk; 
                                }
                                vida = vida - eskAtk;
                                Console.WriteLine("The skeleton attaked you, causing "+ eskAtk + " of damage\nYour HP is now "+ vida);                                
                            }else if(action == "heal"){
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
    }
}
