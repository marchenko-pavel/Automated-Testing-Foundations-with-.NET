
namespace Epam.Interface
{
    internal interface IFlyable
    {
        double FlyTo();
        int GetFlyTime();
        void FlyRun(int time_fly);
        void ViewCoordinete();                
    }
}
