using automatonGame.bot.interfaces.Entorno;
using automatonGame.bot.interfaces.Helpers;
using automatonGame.bot.interfaces.Robots;


namespace automatonGame.bot.implementation {
    public class MiRobot : IRobot
    {
        public Tablero Tablero 
        { 
            get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); 
        }

        public AccionRobotDto GetAccionRobot()
        {
            throw new System.NotImplementedException();
        }
    }
}