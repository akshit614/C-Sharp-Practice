using System;
using System.Threading;

// understading Multi Threading
class ThreadsProgram
{
    static void Main(string[] args)
    {
        Thread newThread = new Thread(MessagThread);
        Thread newThread2 = new Thread(MessagThread2);
        newThread.Start();
        newThread2.Start();
        Console.WriteLine("Main thread is going on.");
    }
    static void MessagThread()
    {
        Console.WriteLine("Worker 1 thread is going on.");
    }
    static void MessagThread2()
    {
        Thread.Sleep(100);
        Console.WriteLine("Worker 2 thread is going on.");
    }

}