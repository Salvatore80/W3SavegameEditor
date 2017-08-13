using System.Collections.ObjectModel;
using System.Linq;

namespace W3SavegameEditor.Models
{
    public class SavegameDataModel
    {
        public int Version1 { get; set; }
        public int Version2 { get; set; }
        public int Version3 { get; set; }

        public ObservableCollection<string> VariableNames { get; set; }

        public ObservableCollection<VariableModel> Variables { get; set; }

        public int Saves
        {
            get
            {
                return Variables.Single(v => v.Name == "saveInfo").Children.Where(v => v.Name == "type").Count(v => v.Value == "2");
            }
        }

        public int Loads
        {
            get
            {
                return Variables.Single(v => v.Name == "saveInfo").Children.Where(v => v.Name == "type").Count(v => v.Value == "3");
            }
        }
    }
}