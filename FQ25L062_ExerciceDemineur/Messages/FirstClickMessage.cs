using FQ25L062_ExerciceDemineur.Tools;

namespace FQ25L062_ExerciceDemineur.Messages
{
    public class FirstClickMessage : IMessage
    {
        public FirstClickMessage(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; }
        public int Y { get; }


    }
}
