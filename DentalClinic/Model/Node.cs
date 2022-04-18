using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.Model
{
    public class Node
    {
        private List<Node> _nodes = new List<Node>();

        public int ID { get; set; }
        public int ParentID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public List<Node> Nodes
        {
            get { return _nodes; }
            set { _nodes = value; }
        }
    }
}
