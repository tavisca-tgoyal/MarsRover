using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {

            string positionAndDirection = "(2,3) E";
            string boundary = "(30, 40)";


        }
    }

    public interface IMovement
    {
        void turn(char);
        void moveForward();
    }

    public interface ILanding
    {
        void dropToPosition();
    }

    class Rover : IMovement, ILanding
    {
        GPS gpsInfo = new GPS();

        Map mapOfMars = new Map();
        void ILanding.dropToPosition()
        {
            throw new NotImplementedException();
        }
        void IMovement.turn(char command)
        {
            throw new NotImplementedException();
        }

        void IMovement.moveForward()
        {
            throw new NotImplementedException();
        }


    }

    class GPS
    {
        int xCoordinate;
        int yCoordinate;

        char direction;

        void setPosition(int xCoordinate, int yCoordinate)
        {
            this.xCoordinate = xCoordinate;
            this.yCoordinate = yCoordinate;
        }

        void setDirection(char direction)
        {
            this.direction = direction;
        }
    }

    class Map
    {
        int width;
        int breadth;

        Map(int width, int breadth)
        {
            this.width = width;
            this.breadth = breadth;
        }
    }
}
