using System;
using FeelLibrary;

namespace FeedLibrary
{
    public static class Feed
    {
        public static void FeedPet()
        {
            Console.WriteLine("Feeding the dog with some food...");
            Feel.FeelHappy();
        }
    }
}
