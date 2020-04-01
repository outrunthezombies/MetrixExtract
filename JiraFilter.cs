using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetrixExtract
{
    class JiraFilter
    {
        /* URL to API: https://outrunthezombies.atlassian.net/rest/agile/1.0/board/6/quickfilter */

        private int filterID;
        private int boardID;
        private string filterName;
        private string filterJql;
        private string filterDescription;
        private int filterPosition;

        public int ID
        {
            get => filterID;
            set => filterID = value;
        }
        public int BoardID
        {
            get => boardID;
            set => boardID = value;
        }
        public string Name
        {
            get => filterName;
            set => filterName = value;
        }
        public string JQL
        {
            get => filterJql;
            set => filterJql = value;
        }
        public string Description
        {
            get => filterDescription;
            set => filterDescription = value;
        }
        public int Position
        {
            get => filterPosition;
            set => filterPosition = value;
        }
    }
}
