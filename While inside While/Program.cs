using System;
namespace Basic_Writing_Structure
{
    class program{
        static void Main()
        {            
            bool main=true;
            while(main){
                bool inner=true;
                while(inner){
                Console.Clear();
                 int num=int.Parse(Console.ReadLine());
                if(num==1){
                    Console.WriteLine("Put Your Love Nubmer");
                    int nice=int.Parse(Console.ReadLine());
                    if(nice==00){
                        inner=false;
                    }else{
                        inner=false;
                        main=false;
                    }
                }
                }
            }
        }
       
    }
}