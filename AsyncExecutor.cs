using System;
using System.Collections;
using System.Threading;

public class SignalEnumerator : IEnumerator
{
    private bool signaled { get; set; }

    public object Current
    {
        get
        {
            return null;
        }
    }

    public SignalEnumerator()
    {
        signaled = false;
    }

    public bool MoveNext()
    {
        if(signaled)
        {
            Thread.MemoryBarrier();
            return false;
        }
        return true;
    }
    
    public void Reset()
    {
        signaled = false;
    }
    public void Notify()
    {
        signaled = true;
        Thread.MemoryBarrier();
    }
}
public class AsyncExecutor : SignalEnumerator
{
    public AsyncExecutor(Action action)
    {
        (new Thread(() =>
        {
            action();
            Notify();
        })).Start();
    }
    public AsyncExecutor(Action<AsyncExecutor> action)
    {
        (new Thread(() =>
        {
            action(this);
            Notify();
        })).Start();
    }
}
