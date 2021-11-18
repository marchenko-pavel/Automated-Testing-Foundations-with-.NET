using System;

namespace Interfaces_and_abstract_classes
{
    internal interface IFlyable
    {
        double FlyTo();
        int GetFlyTime();
        void Fly_Run(int time_fly);
        void view_coordinete();                
    }
}
