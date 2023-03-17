using automatonGame.bot.implementation;
using automatonGame.bot.interfaces.Robots;

public static class RobotFactory 
{
    public static IRobot Create()
    {
        return new MiRobot();
    }
}