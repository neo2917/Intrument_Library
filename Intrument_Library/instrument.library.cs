using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intrument_Library
{
    public abstract class Instrument
    {
        public string serialNumber { get; set; }
        public string Name { get; set; }

        public Instrument(string _name)
        {
            Name = _name;
        }

        public abstract void Play();
    }

    public class Guitar : Instrument
    {
        public Guitar(string _name) : base(_name)
        {

        }
        public override void Play()
        {
            //throw new NotImplementedException();
            Console.WriteLine($"I am playing {Name} guitar");
        }
    }

    public class Mandolin : Instrument
    {
        public Mandolin(string _name) : base(_name)
        {

        }
        public override void Play()
        {
            //throw new NotImplementedException();
            Console.WriteLine($"I am playing {Name} guitar");
        }
    }

    public class Ukele : Instrument
    {
        public Ukele(string _name) : base(_name)
        {

        }

        public override void Play()
        {
            //throw new NotImplementedException();
            Console.WriteLine($"I am playing {Name} guitar");
        }
    }
}
