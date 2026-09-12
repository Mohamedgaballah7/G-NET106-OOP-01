namespace c_oop01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //question 1 a & b
            #region question one
            // a
            /*
                 while DeliveryAddress variable is copied into another variable and the copy is modified the original variable will not be affected.
                    This is because DeliveryAddress is a value type (struct) and when it is copied, a new instance of the struct is created in memory.
                Any changes made to the copy will not affect the original instance.
                */
            // b
            /*while Customer variable is copied into another variable and one variable modifies the object or its properties, the changes will be reflected in both variables.
                This is because Customer is a reference type (class) and when it is copied, only the reference to the object in memory is copied, not the object itself.
                Any changes made to the object through either variable will affect the same instance in memory.
                */
            #endregion

        }
    }
}
