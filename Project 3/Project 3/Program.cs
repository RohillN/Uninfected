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
        public static Character[] player = new Character[1];
        public static Character[] zombie = new Character[10];
        public struct Character
        {
            public int attack;
            public int health;

        }
        public static void Info()
        {
            player.attack = 0;
            player.health = 10;

        }

        static void Main(string[] args)
        {
            //Test
            SkipOpeningSequence();
        }

        static void SkipOpeningSequence()
        {
            //Skip Option

            Console.WriteLine("\n Skip the Opening Sequence?");
            Console.WriteLine("\n 1. Yes");
            Console.WriteLine(" 2. No");
            char skip = Convert.ToChar(Console.ReadKey().KeyChar);

            switch (skip)
            {
                case '1':
                    Console.Clear();
                    L4();
                    break;
                case '2':
                    Console.Clear();
                    OpeningSequence();
                    break;
            }
        }
        public static void L4()
        {
            //Starting room

            Console.WriteLine("\n You are in L4");
            Console.WriteLine(" [QUARANTINE ROOM]");
            Console.WriteLine("\n There is a glass cell used to quarantine potentially infected patients.");
            Console.WriteLine("\n The Doctor is dead on the floor. He is clutching 'Surgical Scissors'");
            Console.WriteLine("\n ZOMBIE is crumpled against the wall next to the door.\n\n");
            Console.WriteLine(" ## MOVE ##");
            Console.WriteLine("");
            Console.WriteLine(" W. [North] Exit the Quarantine Room. Go into the Hallway");
            Console.WriteLine(" A. [West] Room Wall");
            Console.WriteLine(" S. [South] Room Wall");
            Console.WriteLine(" D. [East] Room Wall");
            Console.WriteLine("");
            Console.WriteLine("## ACTION ##");
            Console.WriteLine("");
            Console.WriteLine(" 1. SEARCH Doctor's Corpse Lying on the Ground");
            Console.WriteLine(" 2. INSPECT ZOMBIE lying on the Ground");
            char response = Convert.ToChar(Console.ReadKey().KeyChar);

            switch (response)
            {
                case 'w':
                    Moving();
                    L3();
                    break;
                case 'a':
                    Console.WriteLine("\n There is a wall.");
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    L4();
                    break;
                case 's':
                    Console.WriteLine("\n There is a wall.");
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    L4();
                    break;
                case 'd':
                    Console.WriteLine("\n There is a wall.");
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    L4();
                    break;
                case '1':
                    break;
                case '2':
                    break;
            }

        }

        public static void L3()
        {
            //Corridor

            Console.Clear();
            Console.WriteLine("\n You are in L3");
            Console.WriteLine(" [HALLWAY]");
            Console.WriteLine("\n There is screaming further down the hallway.");
            Console.WriteLine("\n The florescent light is blinking.");
            Console.WriteLine("\n There are two doors. [West] ICU 1. [EAST] ICU 2\n\n");
            Console.WriteLine(" ## MOVE ##");
            Console.WriteLine("");
            Console.WriteLine(" W. [North] hallway");
            Console.WriteLine(" A. [West] Enter ICU 1");
            Console.WriteLine(" S. [South] Enter the Quarantine Room");
            Console.WriteLine(" D. [East] Enter ICU 2");
            Console.WriteLine("");
            Console.WriteLine("## ACTION ##");
            Console.WriteLine("");
            Console.WriteLine(" 1. SEARCH Doctor's Corpse Lying on the Ground");
            Console.WriteLine(" 2. INSPECT ZOMBIE lying on the Ground");
            char response = Convert.ToChar(Console.ReadKey().KeyChar);

            switch (response)
            {
                case 'w':
                    Moving();
                    L2();
                    break;
                case 'a':
                    Opening();
                    Console.WriteLine("\n The Door is Locked.");
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    L3();
                    break;
                case 's':
                    Moving();
                    L4();
                    break;
                case 'd':
                    Opening();
                    Console.WriteLine("\n The Door is Locked.");
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    L3();
                    break;
                case '1':
                    break;
                case '2':
                    break;
            }           
        }

        public static void L2()
        {
            Console.WriteLine("You are in L2");
            Console.WriteLine(" [HALLWAY CORNER]");
            Console.WriteLine(" There is a wheelchair in the corner. ");
            Console.WriteLine(" Strange… the arms grasping wheels aren’t attached to a body… ");
            Console.WriteLine(" There is 1 door. [North] Emergency Room 1.");
            Console.WriteLine(" ## MOVE ##");
            Console.WriteLine("");
            Console.WriteLine(" W. [North] Enter 'Emergency Room 1'");
            Console.WriteLine(" A. [West] Hallway");
            Console.WriteLine(" S. [South] Hallway");
            Console.WriteLine(" D. [East] Wall");
            Console.WriteLine("");
            Console.WriteLine("## ACTION ##");
            Console.WriteLine("");
            Console.WriteLine(" 1. SEARCH Doctor's Corpse Lying on the Ground");
            Console.WriteLine(" 2. INSPECT ZOMBIE lying on the Ground");
            char response = Convert.ToChar(Console.ReadKey().KeyChar);

            switch (response)
            {
                case 'w':
                    Opening();
                    Console.WriteLine("\n The Door is Locked.");
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    L2();
                    break;
                case 'a':
                    Moving();
                    K2();
                    break;
                case 's':
                    Moving();
                    L3();
                    break;
                case 'd':
                    Console.WriteLine("\n There is a wall.");
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    L2();
                    break;
                case '1':
                    break;
                case '2':
                    break;
            }           
        }

        public static void K2()
        {
            Console.WriteLine("You are in K2");
            Console.WriteLine(" [HALLWAY]");
            Console.WriteLine("There is a corpse on the floor. Lying face down in blood. ");
            Console.WriteLine(" ## MOVE ##");
            Console.WriteLine("");
            Console.WriteLine(" W. [North] Wall");
            Console.WriteLine(" A. [West] J2");
            Console.WriteLine(" S. [South] Wall");
            Console.WriteLine(" D. [East] L2");
            Console.WriteLine("");
            Console.WriteLine("## ACTION ##");
            Console.WriteLine("");
            Console.WriteLine(" 1. ");
            Console.WriteLine(" 2. ");
            Console.WriteLine(" 3. ");
            Console.WriteLine(" 4. ");
            char response = Convert.ToChar(Console.ReadKey().KeyChar);

            switch (response)
            {
                case 'w':
                    Console.WriteLine("\n There is a wall.");
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    K2();
                    break;
                case 'a':
                    Moving();
                    J2();
                    break;
                case 's':
                    Console.WriteLine("\n There is a wall.");
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    K2();
                    break;
                case 'd':
                    Moving();
                    L2();
                    break;
                case '1':
                    break;
                case '2':
                    break;
                case '3':
                    break;
                case '4':
                    break;
            }
        }

        public static void J2()
        {
            Console.WriteLine("You are in J2");
            Console.WriteLine(" [HALLWAY CORNER]");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" ## MOVE ##");
            Console.WriteLine("");
            Console.WriteLine(" W. [North] J1");
            Console.WriteLine(" A. [West]");
            Console.WriteLine(" S. [South] J3");
            Console.WriteLine(" D. [East]");
            Console.WriteLine("");
            Console.WriteLine("## ACTION ##");
            Console.WriteLine("");
            Console.WriteLine(" 1. ");
            Console.WriteLine(" 2. ");
            Console.WriteLine(" 3. ");
            Console.WriteLine(" 4. ");
            char response = Convert.ToChar(Console.ReadKey().KeyChar);

            switch (response)
            {
                case 'w':
                    Opening();
                    Console.WriteLine("\n The Door is Locked.");
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    J2();
                    break;
                case 'a':
                    Console.WriteLine("\n There is a wall.");
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    J2();
                    break;
                case 's':
                    Moving();
                    J3();
                    break;
                case 'd':
                    Moving();
                    K2();
                    break;
                case '1':
                    break;
                case '2':
                    break;
                case '3':
                    break;
                case '4':
                    break;
            }
        }
        public static void J3()
        {
            Console.WriteLine("You are in J3");
            Console.WriteLine(" [HALLWAY]");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" ## MOVE ##");
            Console.WriteLine("");
            Console.WriteLine(" W. [North] J2");
            Console.WriteLine(" A. [West]");
            Console.WriteLine(" S. [South] J4");
            Console.WriteLine(" D. [East]");
            Console.WriteLine("");
            Console.WriteLine("## ACTION ##");
            Console.WriteLine("");
            Console.WriteLine(" 1. ");
            Console.WriteLine(" 2. ");
            Console.WriteLine(" 3. ");
            Console.WriteLine(" 4. ");
            char response = Convert.ToChar(Console.ReadKey().KeyChar);

            switch (response)
            {
                case 'w':
                    Moving();
                    J2();
                    break;
                case 'a':
                    Opening();
                    Console.WriteLine("\n The Door is Locked.");
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    J3();
                    break;
                case 's':
                    Moving();
                    J4();
                    break;
                case 'd':
                    Console.WriteLine("\n There is a wall.");
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    J3();
                    break;
                case '1':
                    break;
                case '2':
                    break;
                case '3':
                    break;
                case '4':
                    break;
            }
        }
        public static void J4()
        {
            Console.WriteLine("You are in J4");
            Console.WriteLine(" [HALLWAY]");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" ## MOVE ##");
            Console.WriteLine("");
            Console.WriteLine(" W. [North] J3");
            Console.WriteLine(" A. [West]");
            Console.WriteLine(" S. [South] J5");
            Console.WriteLine(" D. [East]");
            Console.WriteLine("");
            Console.WriteLine("## ACTION ##");
            Console.WriteLine("");
            Console.WriteLine(" 1. ");
            Console.WriteLine(" 2. ");
            Console.WriteLine(" 3. ");
            Console.WriteLine(" 4. ");
            char response = Convert.ToChar(Console.ReadKey().KeyChar);

            switch (response)
            {
                case 'w':
                    Moving();
                    J3();
                    break;
                case 'a':
                    Console.WriteLine("\n There is a wall.");
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    J4();
                    break;
                case 's':
                    Moving();
                    J5();
                    break;
                case 'd':
                    Console.WriteLine("\n There is a wall.");
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    J4();
                    break;
                case '1':
                    break;
                case '2':
                    break;
                case '3':
                    break;
                case '4':
                    break;
            }
        }
        public static void J5()
        {
            Console.WriteLine("You are in J5");
            Console.WriteLine(" [HALLWAY INTERSECTION]");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" ## MOVE ##");
            Console.WriteLine("");
            Console.WriteLine(" W. [North] J4");
            Console.WriteLine(" A. [West] I5");
            Console.WriteLine(" S. [South] Wall");
            Console.WriteLine(" D. [East]");
            Console.WriteLine("");
            Console.WriteLine("## ACTION ##");
            Console.WriteLine("");
            Console.WriteLine(" 1. ");
            Console.WriteLine(" 2. ");
            Console.WriteLine(" 3. ");
            Console.WriteLine(" 4. ");
            char response = Convert.ToChar(Console.ReadKey().KeyChar);

            switch (response)
            {
                case 'w':
                    Moving();
                    J4();
                    break;
                case 'a':
                    Moving();
                    I5();
                    break;
                case 's':
                    Console.WriteLine("\n There is a wall.");
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    J5();
                    break;
                case 'd':
                    Console.WriteLine("\n There is a wall.");
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    J5();
                    break;
                case '1':
                    break;
                case '2':
                    break;
                case '3':
                    break;
                case '4':
                    break;
            }
        }
        public static void I5()
        {
            Console.WriteLine("You are in I5");
            Console.WriteLine(" [HALLWAY]");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" ## MOVE ##");
            Console.WriteLine("");
            Console.WriteLine(" W. [North] Wall");
            Console.WriteLine(" A. [West] H5");
            Console.WriteLine(" S. [South] Wall");
            Console.WriteLine(" D. [East] J5");
            Console.WriteLine("");
            Console.WriteLine("## ACTION ##");
            Console.WriteLine("");
            Console.WriteLine(" 1. ");
            Console.WriteLine(" 2. ");
            Console.WriteLine(" 3. ");
            Console.WriteLine(" 4. ");
            char response = Convert.ToChar(Console.ReadKey().KeyChar);

            switch (response)
            {
                case 'w':
                    Console.WriteLine("\n There is a wall.");
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    I5();
                    break;
                case 'a':
                    Moving();
                    H5();
                    break;
                case 's':
                    Console.WriteLine("\n There is a wall.");
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    I5();
                    break;
                case 'd':
                    Moving();
                    J5();
                    break;
                case '1':
                    break;
                case '2':
                    break;
                case '3':
                    break;
                case '4':
                    break;
            }
        }
        public static void H5()
        {
            Console.WriteLine("You are in H5");
            Console.WriteLine(" [HALLWAY]");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" ## MOVE ##");
            Console.WriteLine("");
            Console.WriteLine(" W. [North] Wall");
            Console.WriteLine(" A. [West] G5");
            Console.WriteLine(" S. [South] Wall");
            Console.WriteLine(" D. [East] I5");
            Console.WriteLine("");
            Console.WriteLine("## ACTION ##");
            Console.WriteLine("");
            Console.WriteLine(" 1. ");
            Console.WriteLine(" 2. ");
            Console.WriteLine(" 3. ");
            Console.WriteLine(" 4. ");
            char response = Convert.ToChar(Console.ReadKey().KeyChar);

            switch (response)
            {
                case 'w':
                    Console.WriteLine("\n There is a wall.");
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    H5();
                    break;
                case 'a':
                    Moving();
                    G5();
                    break;
                case 's':
                    Console.WriteLine("\n There is a wall.");
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    H5();
                    break;
                case 'd':
                    Moving();
                    I5();
                    break;
                case '1':
                    break;
                case '2':
                    break;
                case '3':
                    break;
                case '4':
                    break;
            }
        }
        public static void G5()
        {
            Console.WriteLine("You are in G5");
            Console.WriteLine(" [HALLWAY INTERSECTION]");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" ## MOVE ##");
            Console.WriteLine("");
            Console.WriteLine(" W. [North] Wall");
            Console.WriteLine(" A. [West] F5");
            Console.WriteLine(" S. [South] G6");
            Console.WriteLine(" D. [East] H5");
            Console.WriteLine("");
            Console.WriteLine("## ACTION ##");
            Console.WriteLine("");
            Console.WriteLine(" 1. ");
            Console.WriteLine(" 2. ");
            Console.WriteLine(" 3. ");
            Console.WriteLine(" 4. ");
            char response = Convert.ToChar(Console.ReadKey().KeyChar);

            switch (response)
            {
                case 'w':
                    Console.WriteLine("\n There is a wall.");
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    G5();
                    break;
                case 'a':
                    Moving();
                    F5();
                    break;
                case 's':
                    Moving();
                    G6();
                    break;
                case 'd':
                    Moving();
                    H5();
                    break;
                case '1':
                    break;
                case '2':
                    break;
                case '3':
                    break;
                case '4':
                    break;
            }
        }
        public static void G6()
        {
            Console.WriteLine("You are in G6");
            Console.WriteLine(" [HALLWAY]");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" ## MOVE ##");
            Console.WriteLine("");
            Console.WriteLine(" W. [North] Wall");
            Console.WriteLine(" A. [West]");
            Console.WriteLine(" S. [South] Wall");
            Console.WriteLine(" D. [East]");
            Console.WriteLine("");
            Console.WriteLine("## ACTION ##");
            Console.WriteLine("");
            Console.WriteLine(" 1. ");
            Console.WriteLine(" 2. ");
            Console.WriteLine(" 3. ");
            Console.WriteLine(" 4. ");
            char response = Convert.ToChar(Console.ReadKey().KeyChar);

            switch (response)
            {
                case 'w':
                    Moving();
                    G5();
                    break;
                case 'a':
                    Console.WriteLine("\n There is a wall.");
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    G6();
                    break;
                case 's':
                    Moving();
                    G7();
                    break;
                case 'd':
                    Console.WriteLine("\n There is a wall.");
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    G6();
                    break;
                case '1':
                    break;
                case '2':
                    break;
                case '3':
                    break;
                case '4':
                    break;
            }
        }
        public static void G7()
        {
            Console.WriteLine("You are in G7");
            Console.WriteLine(" [HALLWAY]");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" ## MOVE ##");
            Console.WriteLine("");
            Console.WriteLine(" W. [North] ");
            Console.WriteLine(" A. [West]");
            Console.WriteLine(" S. [South] ");
            Console.WriteLine(" D. [East]");
            Console.WriteLine("");
            Console.WriteLine("## ACTION ##");
            Console.WriteLine("");
            Console.WriteLine(" 1. ");
            Console.WriteLine(" 2. ");
            Console.WriteLine(" 3. ");
            Console.WriteLine(" 4. ");
            char response = Convert.ToChar(Console.ReadKey().KeyChar);

            switch (response)
            {
                case 'w':
                    Moving();
                    G6();
                    break;
                case 'a':
                    Console.WriteLine("\n There is a wall.");
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    G7();
                    break;
                case 's':
                    Moving();
                    G8();
                    break;
                case 'd':
                    Console.WriteLine("\n There is a wall.");
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    G7();
                    break;
                case '1':
                    break;
                case '2':
                    break;
                case '3':
                    break;
                case '4':
                    break;
            }
        }
        public static void G8()
        {
            Console.WriteLine("You are in G8");
            Console.WriteLine(" [HALLWAY]");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" ## MOVE ##");
            Console.WriteLine("");
            Console.WriteLine(" W. [North] ");
            Console.WriteLine(" A. [West]");
            Console.WriteLine(" S. [South] ");
            Console.WriteLine(" D. [East]");
            Console.WriteLine("");
            Console.WriteLine("## ACTION ##");
            Console.WriteLine("");
            Console.WriteLine(" 1. ");
            Console.WriteLine(" 2. ");
            Console.WriteLine(" 3. ");
            Console.WriteLine(" 4. ");
            char response = Convert.ToChar(Console.ReadKey().KeyChar);

            switch (response)
            {
                case 'w':
                    Moving();
                    G7();
                    break;
                case 'a':
                    Console.WriteLine("\n There is a wall.");
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    G8();
                    break;
                case 's':
                    Opening();
                    Console.WriteLine("Do you have a key?");
                    //if key == yes | Then the player can escape! 
                    break;
                case 'd':
                    Console.WriteLine("\n There is a wall.");
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    G8();
                    break;
                case '1':
                    break;
                case '2':
                    break;
                case '3':
                    break;
                case '4':
                    break;
            }
        }
        public static void G9()
        {
            //Exit
        }
        public static void F5()
        {
            Console.WriteLine("You are in F5");
            Console.WriteLine(" [HALLWAY]");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" ## MOVE ##");
            Console.WriteLine("");
            Console.WriteLine(" W. [North] ");
            Console.WriteLine(" A. [West]");
            Console.WriteLine(" S. [South] ");
            Console.WriteLine(" D. [East]");
            Console.WriteLine("");
            Console.WriteLine("## ACTION ##");
            Console.WriteLine("");
            Console.WriteLine(" 1. ");
            Console.WriteLine(" 2. ");
            Console.WriteLine(" 3. ");
            Console.WriteLine(" 4. ");
            char response = Convert.ToChar(Console.ReadKey().KeyChar);

            switch (response)
            {
                case 'w':
                    Console.WriteLine("\n There is a wall.");
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    F5();
                    break;
                case 'a':
                    Moving();
                    E5();
                    break;
                case 's':
                    Console.WriteLine("\n There is a wall.");
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    F5();
                    break;
                case 'd':
                    Moving();
                    G5();
                    break;
                case '1':
                    break;
                case '2':
                    break;
                case '3':
                    break;
                case '4':
                    break;
            }
        }
        public static void E5()
        {
            Console.WriteLine("You are in E5");
            Console.WriteLine(" [HALLWAY]");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" ## MOVE ##");
            Console.WriteLine("");
            Console.WriteLine(" W. [North] ");
            Console.WriteLine(" A. [West]");
            Console.WriteLine(" S. [South] ");
            Console.WriteLine(" D. [East]");
            Console.WriteLine("");
            Console.WriteLine("## ACTION ##");
            Console.WriteLine("");
            Console.WriteLine(" 1. ");
            Console.WriteLine(" 2. ");
            Console.WriteLine(" 3. ");
            Console.WriteLine(" 4. ");
            char response = Convert.ToChar(Console.ReadKey().KeyChar);

            switch (response)
            {
                case 'w':
                    Console.WriteLine("\n There is a wall.");
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    E5();
                    break;
                case 'a':
                    Moving();
                    D5();
                    break;
                case 's':
                    Console.WriteLine("\n There is a wall.");
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    E5();
                    break;
                case 'd':
                    Moving();
                    F5();
                    break;
                case '1':
                    break;
                case '2':
                    break;
                case '3':
                    break;
                case '4':
                    break;
            }
        }
        public static void D5()
        {
            Console.WriteLine("You are in D5");
            Console.WriteLine(" [HALLWAY INTERSECTION]");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" ## MOVE ##");
            Console.WriteLine("");
            Console.WriteLine(" W. [North] ");
            Console.WriteLine(" A. [West]");
            Console.WriteLine(" S. [South] ");
            Console.WriteLine(" D. [East]");
            Console.WriteLine("");
            Console.WriteLine("## ACTION ##");
            Console.WriteLine("");
            Console.WriteLine(" 1. ");
            Console.WriteLine(" 2. ");
            Console.WriteLine(" 3. ");
            Console.WriteLine(" 4. ");
            char response = Convert.ToChar(Console.ReadKey().KeyChar);

            switch (response)
            {
                case 'w':
                    Moving();
                    D4();
                    break;
                case 'a':
                    Console.WriteLine("\n There is a wall.");
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    D5();
                    break;
                case 's':
                    Moving();
                    D6();
                    break;
                case 'd':
                    Moving();
                    E5();
                    break;
                case '1':
                    break;
                case '2':
                    break;
                case '3':
                    break;
                case '4':
                    break;
            }
        }
        public static void D4()
        {
            Console.WriteLine("You are in D4");
            Console.WriteLine(" [HALLWAY]");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" ## MOVE ##");
            Console.WriteLine("");
            Console.WriteLine(" W. [North] ");
            Console.WriteLine(" A. [West]");
            Console.WriteLine(" S. [South] ");
            Console.WriteLine(" D. [East]");
            Console.WriteLine("");
            Console.WriteLine("## ACTION ##");
            Console.WriteLine("");
            Console.WriteLine(" 1. ");
            Console.WriteLine(" 2. ");
            Console.WriteLine(" 3. ");
            Console.WriteLine(" 4. ");
            char response = Convert.ToChar(Console.ReadKey().KeyChar);

            switch (response)
            {
                case 'w':
                    //Hallway blocked
                    break;
                case 'a':
                    Console.WriteLine("\n There is a wall.");
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    D4();
                    break;
                case 's':
                    Moving();
                    D5();
                    break;
                case 'd':
                    Console.WriteLine("\n There is a wall.");
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    D4();
                    break;
                case '1':
                    break;
                case '2':
                    break;
                case '3':
                    break;
                case '4':
                    break;
            }
        }
        public static void D6()
        {
            Console.WriteLine("You are in D6");
            Console.WriteLine(" [HALLWAY]");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" ## MOVE ##");
            Console.WriteLine("");
            Console.WriteLine(" W. [North] ");
            Console.WriteLine(" A. [West]");
            Console.WriteLine(" S. [South] ");
            Console.WriteLine(" D. [East]");
            Console.WriteLine("");
            Console.WriteLine("## ACTION ##");
            Console.WriteLine("");
            Console.WriteLine(" 1. ");
            Console.WriteLine(" 2. ");
            Console.WriteLine(" 3. ");
            Console.WriteLine(" 4. ");
            char response = Convert.ToChar(Console.ReadKey().KeyChar);

            switch (response)
            {
                case 'w':
                    Moving();
                    D5();
                    break;
                case 'a':
                    Console.WriteLine("\n There is a wall.");
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    D6();
                    break;
                case 's':
                    Moving();
                    D7();
                    break;
                case 'd':
                    Console.WriteLine("\n There is a wall.");
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    D6();
                    break;
                case '1':
                    break;
                case '2':
                    break;
                case '3':
                    break;
                case '4':
                    break;
            }
        }
        public static void D7()
        {
            Console.WriteLine("You are in D7");
            Console.WriteLine(" [HALLWAY]");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" ## MOVE ##");
            Console.WriteLine("");
            Console.WriteLine(" W. [North] ");
            Console.WriteLine(" A. [West]");
            Console.WriteLine(" S. [South] ");
            Console.WriteLine(" D. [East]");
            Console.WriteLine("");
            Console.WriteLine("## ACTION ##");
            Console.WriteLine("");
            Console.WriteLine(" 1. ");
            Console.WriteLine(" 2. ");
            Console.WriteLine(" 3. ");
            Console.WriteLine(" 4. ");
            char response = Convert.ToChar(Console.ReadKey().KeyChar);

            switch (response)
            {
                case 'w':
                    Moving();
                    D6();
                    break;
                case 'a':
                    Console.WriteLine("\n There is a wall.");
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    D7();
                    break;
                case 's':
                    Moving();
                    D8();
                    break;
                case 'd':
                    Opening();
                    Console.WriteLine("\n The Door is Locked.");
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    D7();
                    break;
                case '1':
                    break;
                case '2':
                    break;
                case '3':
                    break;
                case '4':
                    break;
            }
        }
        public static void D8()
        {
            Console.WriteLine("You are in D8");
            Console.WriteLine(" [HALLWAY CORNER]");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" ## MOVE ##");
            Console.WriteLine("");
            Console.WriteLine(" W. [North] ");
            Console.WriteLine(" A. [West]");
            Console.WriteLine(" S. [South] ");
            Console.WriteLine(" D. [East]");
            Console.WriteLine("");
            Console.WriteLine("## ACTION ##");
            Console.WriteLine("");
            Console.WriteLine(" 1. ");
            Console.WriteLine(" 2. ");
            Console.WriteLine(" 3. ");
            Console.WriteLine(" 4. ");
            char response = Convert.ToChar(Console.ReadKey().KeyChar);

            switch (response)
            {
                case 'w':
                    Moving();
                    D7();
                    break;
                case 'a':
                    Moving();
                    C8();
                    break;
                case 's':
                    Opening();
                    Console.WriteLine("\n The Door is Locked.");
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    D8();
                    break;
                case 'd':
                    Console.WriteLine("\n There is a wall.");
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    D8();
                    break;
                case '1':
                    break;
                case '2':
                    break;
                case '3':
                    break;
                case '4':
                    break;
            }
        }
        public static void C8()
        {
            Console.WriteLine("You are in C8");
            Console.WriteLine(" [HALLWAY]");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" ## MOVE ##");
            Console.WriteLine("");
            Console.WriteLine(" W. [North] ");
            Console.WriteLine(" A. [West]");
            Console.WriteLine(" S. [South] ");
            Console.WriteLine(" D. [East]");
            Console.WriteLine("");
            Console.WriteLine("## ACTION ##");
            Console.WriteLine("");
            Console.WriteLine(" 1. ");
            Console.WriteLine(" 2. ");
            Console.WriteLine(" 3. ");
            Console.WriteLine(" 4. ");
            char response = Convert.ToChar(Console.ReadKey().KeyChar);

            switch (response)
            {
                case 'w':
                    Console.WriteLine("\n There is a wall.");
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case 'a':
                    Moving();
                    B8();
                    break;
                case 's':
                    Console.WriteLine("\n There is a wall.");
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case 'd':
                    Moving();
                    D8();
                    break;
                case '1':
                    break;
                case '2':
                    break;
                case '3':
                    break;
                case '4':
                    break;
            }
        }
        public static void B8()
        {
            Console.WriteLine("You are in B8");
            Console.WriteLine(" [HALLWAY CORNER]");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" ## MOVE ##");
            Console.WriteLine("");
            Console.WriteLine(" W. [North] ");
            Console.WriteLine(" A. [West]");
            Console.WriteLine(" S. [South] ");
            Console.WriteLine(" D. [East]");
            Console.WriteLine("");
            Console.WriteLine("## ACTION ##");
            Console.WriteLine("");
            Console.WriteLine(" 1. ");
            Console.WriteLine(" 2. ");
            Console.WriteLine(" 3. ");
            Console.WriteLine(" 4. ");
            char response = Convert.ToChar(Console.ReadKey().KeyChar);

            switch (response)
            {
                case 'w':
                    Console.WriteLine("\n There is a wall.");
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case 'a':
                    Opening();
                    //Do you have a key
                    //A8();
                    break;
                case 's':
                    Opening();
                    //Do you have a key
                    //B9()
                    break;
                case 'd':
                    Moving();
                    C8();
                    break;
                case '1':
                    break;
                case '2':
                    break;
                case '3':
                    break;
                case '4':
                    break;
            }
        }

        public static void Moving()
        {
            Console.Clear();
            Console.Write("\n Moving ");
            Thread.Sleep(300);
            Console.Write(". ");
            Thread.Sleep(300);
            Console.Write(". ");
            Thread.Sleep(300);
            Console.Write(". ");
            Thread.Sleep(300);
            Console.Clear();
        }

        public static void Opening()
        {
            Console.Clear();
            Console.Write("\n Opening ");
            Thread.Sleep(300);
            Console.Write(". ");
            Thread.Sleep(300);
            Console.Write(". ");
            Thread.Sleep(300);
            Console.Write(". ");
            Thread.Sleep(300);
            Console.Clear();
        }

        public static void OpeningSequence()
        {
            //Opening Sequence
            Console.Write("\n Loading ");
            Thread.Sleep(1000);
            Console.Write(". ");
            Thread.Sleep(1000);
            Console.Write(". ");
            Thread.Sleep(1000);
            Console.Write(". ");
            Thread.Sleep(1000);

            Console.Clear();
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
            L4();
        }
        public static void Battle()
        {

            Random rand = new Random();
            Console.WriteLine("A ZOMBIE approaches.");
            Console.WriteLine(" [HALLWAY CORNER]");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("## ACTION ##");
            Console.WriteLine("");
            Console.WriteLine(" 1. Attack ");
            Console.WriteLine(" 2. Block ");
            Console.WriteLine(" 3. Flee");
            char response = Convert.ToChar(Console.ReadKey().KeyChar);

            switch (response)
            {
                case '1':
                    int damage = rand.Next(1, attack);
                    if (damage>2)
                    {

                    }
                    break;
                case '2':
                    Console.Clear();
                    Console.WriteLine("You ready yourself for the ZOMBIE's attack");         
                    Thread.Sleep(300);
                    Console.Write(". ");
                    Thread.Sleep(300);
                    Console.Write(". ");
                    Thread.Sleep(300);
                    Console.Write(". ");
                    Thread.Sleep(300);
                    Console.WriteLine("The ZOMBIE lunges itself at you");
                    Thread.Sleep(300);
                    Console.Write(". ");
                    Thread.Sleep(300);
                    Console.Write(". ");
                    Thread.Sleep(300);
                    Console.Write(". ");
                    Thread.Sleep(300);
                    Console.WriteLine("You successfully dodge the ZOMBIE's attack.");
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
                case '3':

                    break;

                    /* Combat system between player and zombie, uses next random to hit 1-weapon with a 1 and 2 being a "splash" and any other number = 1 damage done to zombie,
                    player starts with 10 health, each zombie has 5 health. zombie rolls 1,3 with 1 and 2 "splashing" players health is remembered, zombie has chance to drop something beneficial?
                    if player health = 0 game is over, if zombie health = 0 player returns to the method they were in with their current health - medkit to restore health?*/
            }
        }
    }
}
