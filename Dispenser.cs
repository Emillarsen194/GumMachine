using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumMachine
{
    class Dispenser
    {
        static Stack<Gum> blueber = new Stack<Gum>();
        static Stack<Gum> bromber = new Stack<Gum>();
        static Stack<Gum> fruttigum = new Stack<Gum>();
        static Stack<Gum> appels = new Stack<Gum>();
        static Stack<Gum> jord = new Stack<Gum>();
        static Stack<Gum> apel = new Stack<Gum>();

      


        private bool handle;
 
        private bool empty;
        private int quanity;

       

        public bool Empty
        {

            get
            {
                return empty;
            }
           set
            {
                empty = value;
            }
        }

        public bool Handle
        {
            get
            {
                return handle;
            }

            set
            {
                handle = value;
            }
        }

        public int Quanity
        {
            get
            {
                return quanity;
            }

            set
            {
                quanity = value;
            }

        }


        public Dispenser()
        {

        }
        public void Addgum()
        {
       
            for (int i = 0; i < 14; i++)
            {
                Gum blueberry = new Gum("blåbær");
                blueber.Push(blueberry);
                
            }
           
            
            for (int i = 0; i < 7; i++)
            {
            Gum bromberry = new Gum("Brømbær");
            bromber.Push(bromberry);
            }

            for (int i = 0; i < 11; i++)
            {
            Gum trutti = new Gum("Trutti Frutti");
            fruttigum.Push(trutti);

            }

            for (int i = 0; i < 10; i++)
            {
            Gum orange = new Gum("Appelsin");
            appels.Push(orange);

            }

            for (int i = 0; i < 8; i++)
            {
            Gum strawberry = new Gum("Jordbær");
            jord.Push(strawberry);

            }

            for (int i = 0; i < 5; i++)
            {
            Gum apple = new Gum("Æble");
            apel.Push(apple);
            }

           
           
        }

        public Stack<Gum> ReturnlistGumBlueberry()
        {
           return blueber;
        }

        public Stack<Gum> ReturnlistGumBromberry()
        {
            return bromber;
        }

        public Stack<Gum> ReturnlistGumFrutti()
        {
            return fruttigum;
            
        }

        public Stack<Gum> ReturnlistGumOrange()
        {
            return appels;
        }

        public Stack<Gum> ReturnlistGumstrawberry()
        {
            return jord;
        }

        public Stack<Gum> ReturnlistGumapple()
        {
            return apel;
        }

     





        public void PullAGum(bool handle)
        {
            if (handle == true)
            {

                Random whatgum = new Random();
        
                int pull = whatgum.Next(1, 7);

                switch (pull)
                {
                    case 1:

                    
                                Console.WriteLine("Du trak et stykke: " + ReturnlistGumBlueberry().Pop().TypeOfGum);
                               
                           

                      

                        
                        break;
                    case 2:
                        foreach (Gum gum in ReturnlistGumBromberry())
                        {
                               
                                
                                Console.WriteLine("Du trak et stykke: " + ReturnlistGumBromberry().Pop().TypeOfGum);
                                
                         

                     
                        }
                        break;
                    case 3:
                    
                                
                                Console.WriteLine("Du trak et stykke Trutti Frutti" + ReturnlistGumFrutti().Pop().TypeOfGum);
                          
                                
                                
     
                        break;
                    case 4:
           
                                
                                Console.WriteLine("Du trak et stykke Appelsin" + ReturnlistGumOrange().Pop().TypeOfGum);
                   
                          
                        
                        break;
                    case 5:

            

                                Console.WriteLine("Du trak et stykke " + ReturnlistGumstrawberry().Pop().TypeOfGum);
                       
                        break;
                    case 6:
                      
                                Console.WriteLine("Du trak et stykke: " + ReturnlistGumapple().Pop().TypeOfGum);
                    
                        break;
                }

            }

        }

        //public void Throwitout()
        //{
        //        int j = 0;
        //    for (int i = 0; i < gumi.Count; i++)
        //    {
        //        if (gumi[i].Quanity == 0)
        //        {
        //            j++;

        //        }

        //        if (j == 6)
        //        {

        //        Empty = true;

        //        }

        //    }
           

        }
    }


















