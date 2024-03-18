using System;

namespace test.Basics.Lab09.Interfaces
{
    public class StosEmptyException : Exception
    {
        public StosEmptyException() { }
        public StosEmptyException(string message) : base(message) { }
        public StosEmptyException(string message, Exception inner) : base(message, inner) { }
    }

    public interface IStos<T>
    {
        //w interfejsie nie deklaruje się konstruktora

        //wstawia element typu T na stos
        void Push(T value);

        //zwraca szczytowy element stosu
        T Peek { get; }

        //zdejmuje szczytowy element ze stosu i go zwraca
        T Pop();

        //zwraca liczbę elementów na stosie
        int Count { get; }

        //zwraca true, jeśli stos jest pusty, a false w przeciwnym przypadku
        bool IsEmpty { get; }

        //opróżnia stos
        void Clear();

        //kopiuje (klonuje, płytka kopia) i eksportuje stos do tablicy
        T[] ToArray();
    }
}
