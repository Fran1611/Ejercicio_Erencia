using System;

namespace Herencia
{
    public interface ICalifications<T> where T : Person
    {
        void Califications(T Object, int score);
    }
}