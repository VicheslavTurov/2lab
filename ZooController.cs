using System;
using System.Collections.Generic;

namespace ZooProject
{
    // Singleton controller for the zoo
    public sealed class ZooController
    {
        private static ZooController _instance;
        private readonly List<Creature> _creatures;

        private ZooController()
        {
            _creatures = new List<Creature>();
        }

        public static ZooController GetInstance()
        {
            if (_instance == null)
                _instance = new ZooController();
            return _instance;
        }

        // Add a creature if not null
        public void AddCreature(Creature creature)
        {
            if (creature != null)
                _creatures.Add(creature);
        }

        // Show all creatures using a classic for loop
        public void ShowAllCreatures()
        {
            int count = _creatures.Count;
            if (count == 0)
            {
                Console.WriteLine("Zoo is empty.");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(_creatures[i].GetDescription());
            }
        }
    }
}