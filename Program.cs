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
                Console.WriteLine("Your HP is: "+ vida);
                
            for (int round = 1; vida > 0; round++)
            {
                Console.WriteLine("------------\n Round: "+ round);
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
                string action;
                int gn = numGen.Next(1,2);
                int atk =  numGen.Next(1,20);
                
                int gob;
                
                pot = 0 ;                
                gob = 20;     
                    if(enc==1){                        
                        if(gn == 1){
                            pot++;
                                Console.WriteLine(" You walk "+ dist + " meters \n You have now "+ pot +" healing potions \n You found a healing pot");
                        }else if(gn == 2){
                            Console.WriteLine("You walks "+ dist + " meters");
                        } 
                    }
                    if(enc==2){
                        Console.WriteLine("you found a skeleton.\n What do you want to do?: ");
                        action = Console.ReadLine();
                        for (int esk = 30; esk > 0;)
                        {
                            if(action == "attack"){
                                if(atk <=10 ){
                                    Console.WriteLine("Your attack is weak \n Your attack causesd"+ atk + "of damage");
                                    esk = esk - atk;
                                }else if(atk >= 11){
                                    Console.WriteLine("Your attack is strong \n Your attrack causes" +atk + "of damage");
                                    esk = esk - atk; 
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

