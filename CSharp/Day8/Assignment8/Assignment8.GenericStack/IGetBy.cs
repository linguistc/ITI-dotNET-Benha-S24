namespace Assignment8.GenericStack
{
    public interface IGetBy<T> 
    {
        T GetByIndex(int index);
    }
}