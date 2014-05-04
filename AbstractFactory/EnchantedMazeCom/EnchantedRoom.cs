﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.EnchantedMazeCom
{
    public class EnchantedRoom : Room
    {
        public EnchantedRoom(int roomNumber)
            :base(roomNumber)
        {
        }
        public override void Enter()
        {
            Console.WriteLine("Enter a enchanted room {0}.", RoomNumber);
        }
    }   
}
