using FQ25L062_ExerciceDemineur.Tools;

namespace FQ25L062_ExerciceDemineur.Messages
{
    public class SetHasBombMessage : IMessage
    {
        public bool Result { get; set; }        
    }
}
