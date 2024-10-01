using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VBNamespace;
namespace EnumDemo
{
     class Motor
    {
        public void TestMotor()
        {
            int motorOp = (int)MotorFunctions.Stop;
            Program pro = new Program();
            pro.MotorFunction(motorOp);
        }
    }
}
