﻿namespace Observer.Classes
{
    internal interface IObservable
    {
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void Notify();
    }
}
