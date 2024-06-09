using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    public class Harpsichord : Instrument, IKeyedInstrument,IPurchasable
    {
        public double Cost { get; set; }
        public List<Key> Keys { get; set; }
        public void PlayNote(Key keyPressed)
        {
            // Plays the sound
        }
    }
}
