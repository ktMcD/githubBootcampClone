using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    public interface IKeyedInstrument
    {
        List<Key> Keys { get; set; }
        void PlayNote(Key keyPressed);
    }
}
