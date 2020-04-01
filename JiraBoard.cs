using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetrixExtract
{
    class JiraBoard
    {
        /* URL to API: https://outrunthezombies.atlassian.net/rest/agile/1.0/board */

        private int rapidViewID;
        private int projectID;
        private string projectKey;
        private string projectName;
        private string boardName;
        private string boardType;

        public int RapidViewID
        {
            get => rapidViewID;
            set => rapidViewID = value;
        }
        public int ProjectID
        {
            get => projectID;
            set => projectID = value;
        }
        public string ProjectKey
        {
            get => projectKey;
            set => projectKey = value;
        }
        public string Name
        {
            get => boardName;
            set => boardName = value;
        }
        public string ProjectName
        {
            get => projectName;
            set => projectName = value;
        }
        public string Type
        {
            get => boardType;
            set => boardType = value;
        }
        private List<JiraFilter> filter;
        public List<JiraFilter> Filters
        {
            get => filter;
            set => filter = value;
        }
    }
}
