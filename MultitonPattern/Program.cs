using MultitonPattern.Models;
using System;

namespace MultitonPattern
{
    internal class Program
    {
        private static void Main()
        {
            // Explanation: Here we are simulating a scenario where we need multiple instances,
            // but they are controlled by a specific key. This is how the Multiton pattern works.

            // Create the first instance using the key "A"
            var instanceA = MultitonManager.GetInstance("A");

            // Create a second instance using the key "B"
            var instanceB = MultitonManager.GetInstance("B");

            // Attempt to create another instance with the same key "A".
            // This will return the same instance as the first one.
            var instanceA2 = MultitonManager.GetInstance("A");

            // Verify that 'instanceA' and 'instanceA2' are the same instance
            Console.WriteLine($"Instance A Hash: {instanceA.GetHashCode()}");
            Console.WriteLine($"Instance B Hash: {instanceB.GetHashCode()}");
            Console.WriteLine($"Instance A2 Hash (same as A): {instanceA2.GetHashCode()}");

            // This demonstrates that the Multiton pattern controls instances based on a key.
            // Here, "A" and "A2" are the same instance, but "B" is a different instance.

            // Pause the console to show these results
            Console.ReadLine();
        }
    }
}