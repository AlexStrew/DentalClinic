using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DentalClinic.Model
{
    public class Tree
    {

        private static Core db = new Core();
        private static List<mkb_codes> treeTable = db.context.mkb_codes.ToList();

        public static List<Node> FillTreeNodeList(int parentID)
        {
            Node node;
            List<Node> resultTreeNodeList = new List<Node>();
            foreach (var item in treeTable.Where(x => x.ParentID == parentID).OrderBy(x => x.Code).ToList())
            {
                node = new Node()
                {
                    ID = item.ID,
                    Code = item.Code,
                    Description = item.Description,
                    ParentID = item.ParentID ?? 0,
                    Nodes = FillTreeNodeList(item.ID)
                };
                resultTreeNodeList.Add(node);

            }
            return resultTreeNodeList;
        }
    }
}
