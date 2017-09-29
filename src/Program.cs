using System;
using evolution.simulator.graphs;
using evolution.simulator.algebra;

namespace evolution.simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO
            var location = new Vector3();
            location.X = 4.0f;
            var node = new Node<Vector3>(location);

            Console.WriteLine($"node value is: {node.Value.ToString()}");

        }
    }
}
