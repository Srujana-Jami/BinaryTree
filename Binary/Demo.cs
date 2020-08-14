using System;

namespace Binary
{
    class Demo
    {
        static void Main(string[] args)
        {
            Binary bt = new Binary();

            bt.CreateTree();

            bt.Display();
            Console.WriteLine();

            Console.WriteLine(" Preorder is : ");
            bt.Preorder();

            Console.WriteLine("   ");
           
            
            Console.WriteLine("Inorder is : ");
            bt.Inorder();

            Console.WriteLine("   ");

            Console.WriteLine("Postorder is : ");
            bt.Postorder();

            Console.WriteLine("  ");

            Console.WriteLine("Height of the tree is : " + bt.Height());

        }
    }
}
