using Onoqua.Entities.Models;
using System.Collections.Generic;

namespace Onoqua.Models
{
    public class GroupModel
    {
        public List<Group> Groups { get; set; }
        public Group SelectedGroup { get; set; }
        public List<Field> Fields { get; set; }

        public GroupModel()
        {
            SelectedGroup = new Group();
            Groups = new List<Group>();
            Fields = new List<Field>();
        }
    }
}