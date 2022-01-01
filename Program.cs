using System;
namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Ekrana girilen sayiya kadar olan tek sayilari ekrana yazdir.
            Console.WriteLine("Lutfen bir sayi giriniz") ;
            int _counter = int.Parse(Console.ReadLine()) ;
            for (int i=0 ; i <= _counter; i++)
            {
                if(i%2==1)
                    Console.WriteLine(i) ;
            }


            //1 ile 1000 arasindaki tek ve cift sayilarin kendiclerinde toplamlarinin ekrana yazdir.

            int oddsum = 0;
            int evensum= 0 ;
            for(int i=1 ; i<=1000 ; i++)
            {
                if(i%2==1)
                    oddsum+= i ; //tekToplam = tektoplam + i 

                else
                    evensum+= i ; // cifttoplam= cift toplam + i
            }

            Console.WriteLine("OddSum:"+ oddsum) ;
            Console.WriteLine("EvenSum:"+ evensum) ;

            //break, continue 
            for (int i = 1 ; i<10 ; i++)
                {
                    if(i==4)
                        break;
                    Console.WriteLine(i ) ;
                }
            for(int i = 1 ; i <10 ; i++)
                {
                    if (i==4)    
                        continue ;
                    Console.WriteLine(i ) ;

                }




        }   


        }
    }

