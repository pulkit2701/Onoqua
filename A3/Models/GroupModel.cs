using A3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace A3.Models
{
    public class GroupModel
    {
        public List<Group> Groups { get; set; }
        public Group SelectedGroup { get; set; }
        public List<Field> Fields { get; set; }

        public List<Field> FieldsSearchList  { get; set; }

        public Field SelectedField { get; set; }

        public GroupModel()
        {
            SelectedGroup = new Group();
            Groups = new List<Group>();
            Fields = new List<Field>();
        }
    }
}