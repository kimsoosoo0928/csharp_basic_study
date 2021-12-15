class BaseArray<U> where U : Base
{
    public U[] Array { get; set; }
    public BaseArray(int size)
    {
        Array = new U[size];
            
    }

    public void CopyArray<T>(T[] Source) where T : U
    {
        Source.CopyTo(Array, 0); 
    }
}
