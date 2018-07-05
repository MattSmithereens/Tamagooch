using System;
using System.Collections.Generic;
namespace Tamagotchi.Models
{
    public class Critter
    {
        private int _hunger = 100;
        private int _attention = 100;
        private int _rest = 100;
        private int _id;
        private string _name;
        private static List<Critter> _critterList = new List<Critter>() { };

        public string GetName()
        {
            return _name;
        }

        public static Critter Find(int searchId)
        {
            return _critterList[searchId - 1];
        }

        public static List<Critter> GetAll()
        {
            return _critterList;
        }

        public Critter(string newName)
        {
            _name = newName;
            _critterList.Add(this);
            _id = _critterList.Count;
        }

        public int GetHunger()
        {
            return _hunger;
        }

        public int GetAttention()
        {
            return _attention;
        }

        public int GetRest()
        {
            return _rest;
        }

        public int GetId()
        {
            return _id;
        }

        public void Feed()
        {
            this._hunger += 20;
            this._attention -= 1;
            this._rest -= 1;
        }

        public void Play()
        {
            this._attention += 20;
            this._hunger -= 1;
            this._rest -= 1;
        }

        public void Rest()
        {
            this._rest += 20;
            this._attention -= 1;
            this._hunger -= 1;
        }

        public static void PassTime()
        {
            foreach (Critter Critter in _critterList)
            {
                Critter._hunger -= 5;
                Critter._rest -= 5;
                Critter._attention -= 5;
            }

        }

        public bool IsDead()
        {
            if (_hunger <= 0 || _rest <= 0 || _attention <= 0) return true;
            else return false;
        }
    }
}
