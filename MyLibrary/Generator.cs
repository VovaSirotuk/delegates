namespace MyLibrary
{
    // делегат
    public delegate void StateHandler(object sender, OverflowedEventArgs e);

    public class Generator
    {
        
        public event StateHandler Overflowed;

        public void CheckQueue(int elementsCount,int size)
        {
            if (elementsCount >= size)
            {
                if (Overflowed != null)
                    Overflowed(this, new OverflowedEventArgs($"Черга переповнена", elementsCount, size));
            }
        }
    }
}
