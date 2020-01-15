namespace Bilfabrik.Model.Steering
{
    interface ISteering
    {
        string SoundTheHorn();
        string ToString();
        string TurnLeft(int degrees);
        string TurnRight(int degrees);
    }
}