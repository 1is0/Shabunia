﻿using System;
using System.Collections.Generic;
using System.Text;


namespace _5th_LR
{
    public enum TypeOfVolleyball
    {
        NoTipe = 1,
        BeachVolleyball,
        IndoorVolleyball,
        SnowVolleyball
    }
    class Volleyballist : Sportsman
    {
        private readonly string typeOfSport;

        private string GetTypeOfSport()
        {
            return typeOfSport;
        }

        public TypeOfVolleyball Type { get; set; }

        public Volleyballist() : base()
        {
            typeOfSport = "Volleyball";
            Type = (TypeOfVolleyball)1;
        }

        public Volleyballist(string name, string surName, int weight, int height, int age, double experience,
                           string diet, string injury, string typeOfSport, int numberOfWins, Achievements achievement, TypeOfVolleyball type)
                            : base(name, surName, weight, height, age, experience, diet, injury, numberOfWins, achievement)
        {
            this.typeOfSport = "Volleyball";
            Type = type;
        }

        public override void Movement()
        {
            if (Type == (TypeOfVolleyball)1)
            {
                Console.WriteLine("Goes to the beach");
            }
            else if (Type == (TypeOfVolleyball)2)
            {
                Console.WriteLine("Goes to the playground");
            }
            else if (Type == (TypeOfVolleyball)3)
            {
                Console.WriteLine("Leave on street");
            }
            else
            {
                Console.WriteLine("\nPlaying alone with a ball");
            }
        }

        public override string ToString() => base.ToString() + $"\n Type of sport: {GetTypeOfSport()} \nType Of Volleyball: {Type}";
    }
}
