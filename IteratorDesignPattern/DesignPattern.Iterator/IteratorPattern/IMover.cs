namespace DesignPattern.Iterator.IteratorPattern
{
    public interface IMover<T>
    {
        IIterator<T> CreateIterator();
    }
}
