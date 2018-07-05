using System;

namespace DLL
{
    class Program
    {
        static void Main(string[] args)
        {
            DblLnkLst dlList= new DblLnkLst();
            dlList.add(5);
            dlList.add(8);
            dlList.add(10);
            dlList.reverse();
        }
    }
}
