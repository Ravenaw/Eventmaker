﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventmaker.Model
{
    class Event
    {
        private int ID;
        private string Name;
        private string Description;
        private string Place;
        private DateTime DateTime;

        public Event(int id, string name, string description, string place, DateTime dateTime)
        {
            ID = id;
            Name = name;
            Description = description;
            Place = place;
            DateTime = dateTime;
        }

        public override string ToString()
        {
            return $"{ID.ToString()}\t{Name}\t{Description}\t{Place}\t{DateTime.Date.ToString()}";
        }
    }
}
