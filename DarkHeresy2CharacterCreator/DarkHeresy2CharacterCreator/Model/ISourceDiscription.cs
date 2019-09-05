using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkHeresy2CharacterCreator.Model
{
    /// <summary>
    /// Interface to disriptable the source of the characters details
    /// </summary>
    interface ISourceDiscription
    {
        SourceList SourceBook { get; set; }
        int SourcePage { get; set; }
    }
}
