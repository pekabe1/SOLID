using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    /// <summary>

    /// Klasa bazowa wózek widłowy

    /// </summary>

    public abstract class Forklift

    {

        public abstract string Drive();

        public virtual string LiftTheLoad()

        {

            return "Podnoszę ładunek";

        }

    }

    /// <summary>

    /// Klasa dziedzicząca wózek elektryczny

    /// </summary>

    public class ElectricForklift : Forklift

    {

        public override string Drive()

        {

            return "Wózek elektryczny jedzie";

        }

        public override string LiftTheLoad()

        {

            return $"{base.LiftTheLoad()} wózkiem elektrycznym";

        }

    }

    /// <summary>

    /// Klasa dziedzicząca samochód, która dziedziczy po klasie wózek widłowy. Czy to jest OK?

    /// </summary>

    public class Car : Vechicle
    {
        public override string Drive()
        {
            return "Samochód jedzie";
        }
    }

    public abstract class Vechicle
    {
        public abstract string Drive();
    }


}
