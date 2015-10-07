using System.Collections.Generic;
using Fortius.Gui;
using Fortius.Structures;

namespace Bakery.App.Operations
{
    public class CommandCategory : ViewModel, ITreeNode<CommandCategory>
    {
        public CommandCategory()
        {
            ChildItems = new List<CommandCategory>();
        }

        public string Name { get; set; }

        public CommandCategory Parent { get; set; }
        
        public ICollection<CommandCategory> ChildItems { get; private set; }

        public override bool HasChanges
        {
            get { return false; }
        }
        public override void Dispose()
        {
            
        }
    }
}