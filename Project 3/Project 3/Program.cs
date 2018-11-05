/****************************
 * Uninfected               *
 * Project 3                *
 * Rohill, Jae, Sabi, Tyler * 
 * Professional Practice 1  *
 ****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Project_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test
            L4();
        }
        public static void L4()
        {
            //Starting room

            //Opening Sequence
            OpeningSequence();

            Console.WriteLine("You are in L4");
            Console.WriteLine(" ## MOVE ##");
            Console.WriteLine("");
            Console.WriteLine(" 1. [North] Exit the Quarantine Room. Go into the Hallway");
            Console.WriteLine("");
            Console.WriteLine("## ACTION ##");
            Console.WriteLine("");
            Console.WriteLine(" Q. SEARCH Doctor's Corpse Lying on the Ground");
            Console.WriteLine(" W. INSPECT ZOMBIE lying on the Ground");
            char response = Convert.ToChar(Console.ReadKey().KeyChar);

            switch (response)
            {
                case '1':
                    L3();
                    break;
                case 'q':
                    break;
                case 'w':
                    break;
            }

        }

        public static void L3()
        {
            //Corridor

            Console.Clear();
            Console.WriteLine("You are in L3");
            Console.ReadLine();
        }

        public static void L2()
        {

        }

        public static void K2()
        {

        }

        public static void J2()
        {

        }
        public static void J3()
        {

        }
        public static void J4()
        {

        }
        public static void J5()
        {

        }
        public static void I5()
        {

        }
        public static void H5()
        {

        }
        public static void G5()
        {

        }
        public static void G6()
        {

        }
        public static void G7()
        {

        }
        public static void G8()
        {

        }
        public static void G9()
        {
            //Exit
        }
        public static void F5()
        {

        }
        public static void E5()
        {

        }
        public static void D5()
        {

        }
        public static void D4()
        {

        }
        public static void D6()
        {

        }
        public static void D7()
        {

        }
        public static void D8()
        {

        }
        public static void C8()
        {

        }
        public static void B8()
        {

        }

        public static void OpeningSequence()
        {
            //Opening Sequence
            Console.WriteLine("");
            Console.WriteLine(" You wake up in bed surrounded by fibreglass walls. There is one door.");
            Thread.Sleep(1000);
            Console.WriteLine("\n The glass room is inside another slightly bigger room. You had been quarantined here 2 days ago...");
            Thread.Sleep(1000);
            Console.WriteLine("\n Press any key to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\n [A doctor arrives running through the door.]");
            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine("\n Doctor - 'You're still alive!");
            Thread.Sleep(1000);
            Console.Write("\n There is .. ");
            Thread.Sleep(1000);
            Console.WriteLine("no way.. the only explanation is that ...'");
            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine("\n [The Doctor stops mid sentence]");
            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine("\n [Someone is running towards the room outside in the hallway.]");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("\n [But it is not human]");
            Console.WriteLine("\n Press any key to continue");
            Console.Clear();
            Console.WriteLine("\n Doctor - 'You are the only hope now!");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("\n [The Doctor has a sudden sense of urgency]");
            Thread.Sleep(2000);
            Console.Clear();
            Console.Write("\n Doctor - 'I have to get you to ...");
            Thread.Sleep(1500);
            Console.Write(" OH GOD!!!");
            Thread.Sleep(1500);
            Console.WriteLine(" NO!!! ARG.. ");
            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine("\n <!!!!!!!!!!>");
            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine("\n [A ZOMBIE has rushed through the open door and attacks the doctor]");
            Thread.Sleep(2500);
            Console.WriteLine("\n [The ZOMBIE has bitten the doctor's shoulder]");
            Thread.Sleep(2500);
            Console.WriteLine("\n [The Doctor Fights back with 'Surgical Scissors']");
            Thread.Sleep(2500);
            Console.WriteLine("\n [The Doctor clinches the scissors in his fist and frantically stabs the ZOMBIE's face multiple times]");
            Thread.Sleep(2500);
            Console.WriteLine("\n [The ZOMBIE staggers backwards and falls. It is lifeless.]");
            Thread.Sleep(2500);
            Console.WriteLine("\n [The Doctor unlocks the door to your glass room. His bloodied hands staining the door panel as he pushes it.]");
            Thread.Sleep(2500);
            Console.WriteLine("\n Press any key to continue");
            Console.ReadLine();
            Console.Clear();
            Console.Write("\n Doctor - 'You have to ... ");
            Thread.Sleep(2500);
            Console.WriteLine("AARRRRRGH!! It's over for me now. OH GOD...");
            Thread.Sleep(2500);
            Console.WriteLine("\n Doctor - 'I'm Sorry...");
            Thread.Sleep(2500);
            Console.Clear();
            Console.WriteLine("\n [The Doctor slits his throat with 'Surgical Scissors'.]");
            Thread.Sleep(2500);
            Console.WriteLine("\n [It's over]");
            Thread.Sleep(2500);
            Console.WriteLine("\n Press any key to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\n [You are alone. There is only the humming of the ventilation.]");
            Thread.Sleep(2500);
            Console.WriteLine("\n [The Room filled with death.]");
            Thread.Sleep(2500);
            Console.WriteLine("\n Press any key to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\n You arrived in the hospital 3 days ago... However it wasn't just an ordinary cold virus...");
            Thread.Sleep(2500);
            Console.WriteLine("\n The doctor, now lying in a pool of blood through the open glass door,");
            Thread.Sleep(2500);
            Console.WriteLine("\n had recommended keeping you under quarantine until they knew what the virus was exactly...");
            Thread.Sleep(2500);
            Console.WriteLine("\n Press any key to continue");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("\n OBJECTIVE: EXIT THE HOSPITAL");
            Console.WriteLine("\n OBJECTIVE: SURVIVE");
            Console.WriteLine("\n OBJECTIVE: GAIN KNOWLEDGE ABOUT THE INFECTION");
            Console.WriteLine("\n Press any key to continue");
            Console.ReadLine();
            Console.Clear();
        }

    }
}
