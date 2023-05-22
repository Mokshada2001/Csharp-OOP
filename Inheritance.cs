using System;
namespace OOPS
{
//Base Class
    public class Father
    {
        public void FatherMethod()
        {
            Console.WriteLine("This property belong to Father");
        }
    }
    //Derived class
    public class Child : Father
    {
        public void ChildMethod()
        {
            Console.WriteLine("This property belong to Child");
        }
    }
}

