using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Game : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    class Program
    {


        static void Main(string[] args)
        {
            int roomnumber = 1;
            System.Random rnd = new System.Random();
            while (roomnumber <= 10)
            {
                Playmessage(roomnumber);
                int usernumber = Convert.ToInt32(Console.ReadLine());

                int door = rnd.Next(1, 4);
                if (usernumber < 4 || usernumber > 0)
                {


                    if (usernumber == door)
                    {
                        Console.WriteLine("sorry you died");
                        break;
                    }
                    else
                    {
                        roomnumber += 1;
                    }
                }
            }
            if (roomnumber == 11)
            {
                Console.Write("You won nice job!");
            }
            else
            {
                Console.WriteLine("You died sorry");
            }

        }
        public static void Playmessage(int number)
        {
            Console.WriteLine("You must make it through all 10 rooms to survive...");
            Console.WriteLine("Your in room " + number);
            Console.WriteLine("I pick a number 1-3...");
        }
    }

}


