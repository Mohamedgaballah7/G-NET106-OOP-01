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
            //question 2 a & b
            #region question two
            // a
            /*
             All fields are public, so any code can access and change them directly.
             There is no validation, so invalid values can be assigned.
             The data is not hidden, which breaks encapsulation cuz the internal state of Shipment is exposed directly.
            */

            // b
            /*
             Hiding the internal data from direct access.
             Controlling access to the fields.
             Allowing validation before changing values.
             Improving encapsulation and data safety.
            */
            #endregion
            //Part 02 : Practical
            #region Create a DeliveryAddress struct
            //DeliveryAddress address1 = new DeliveryAddress("New York", "5th Avenue", 123);
            //DeliveryAddress address2 = new DeliveryAddress();
            //address2 = address1;
            //address2.city = "Los Angeles";
            //Console.WriteLine(address1.GetFullAddress());
            //Console.WriteLine(address2.GetFullAddress()); 
            #endregion

            //point 2 


        }
    }
}
