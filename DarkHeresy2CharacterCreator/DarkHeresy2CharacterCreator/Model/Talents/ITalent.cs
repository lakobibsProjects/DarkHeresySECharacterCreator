using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web.UI;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace DarkHeresy2CharacterCreator.Model.Talents
{
    interface ITalent : IAptitudeDependent, IPrerequisitable, INotifyPropertyChanged
    {
        string Name { get; set; }
        int Tier { get; }
        string Discription { get; set; }
        SourceList SourceBook { get; }
        int SourcePage { get; }
        List<ValueTuple<IPrerequisitable, int>> Prerequisites { get; }
        ObservableCollection<string> Specializations { get; }        
    }
}
