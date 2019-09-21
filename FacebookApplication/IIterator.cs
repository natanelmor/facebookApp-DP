namespace FacebookApplication
{
    public interface IIterator
    {
        bool MoveNext();

        object Current { get; }

        void Reset();
    }
}
