using automatonGame.bot.interfaces.Robots;

public abstract class BaseBotTest
{
    private IRobot? robot;

    public IRobot Robot 
    {
        get 
        {
            if(robot == null)
            {
                throw new NullReferenceException();
            }

            return robot;
        }
    } 

    [SetUp]
    public void Setup()
    {
        robot = RobotFactory.Create();
    }
}