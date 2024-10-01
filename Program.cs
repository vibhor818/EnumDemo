
using EnumDemo;
namespace VBNamespace
{
    public enum MotorFunctions
    {
        Start = 1,
        Stop,
        Reset
    }
    public enum StudentResult
    {
        Pass = 1,
        Fail
    }

    class Program
    {

        public static void Main(string[] args)
        {
            // FileStream fs=new FileStream("",FileMode.Create,FileAccess.Write);
            Motor motor = new Motor();
            motor.TestMotor();
        }
        public void MotorFunction(int motorOperation)
        {
            if (motorOperation == (int)MotorFunctions.Start)
            {
                Console.WriteLine("Motor has started");
            }
            if (motorOperation == (int)MotorFunctions.Stop)
            {
                Console.WriteLine("Motor has stopped");
            }
            if (motorOperation == (int)MotorFunctions.Reset)
            {
                Console.WriteLine("Motor has reset");
            }
        }
    }
}
