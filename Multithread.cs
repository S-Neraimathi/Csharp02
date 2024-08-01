using System.Threading;

class Multithread{
    public void multithreading(){
        Thread thread1 = new Thread(DoWork);
        Thread thread2 = new Thread(DoWork);

        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();

        Console.WriteLine("Both threads have finished");

    }

    private void DoWork(){
        Console.WriteLine("Thread started");
        Thread.Sleep(2000);
        Console.WriteLine("Thread completed");
    }
}