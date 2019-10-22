using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.I
{
    interface IStandartDoor 

    {
        string Open();
        string Close();
    }
    interface IAutomaticDoor
    {
        string AutomaticClosing();
        string AutomaticOpening();
    }
    interface IGlasses
    {
        int Glasses();
    }

    public class WoodenDoor : IStandartDoor,IGlasses

    {

        public string Close()

        {

            return "Zamykam";

        }

        public int Glasses()
        {

            return 1;
        }
        public string Open()

        {

            return "Otwieram";

        }

    }
    public class SmartDoor : IAutomaticDoor
    {
        public string AutomaticClosing()

        {

            return "Zamykam zdalnie";

        }

        public string AutomaticOpening()

        {

            return "Otwieram zdalnie";
        }
    }
}
