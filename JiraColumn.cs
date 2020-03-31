namespace MetrixExtract
{
    class JiraColumn
    {
        /* URL to API: https://outrunthezombies.atlassian.net/rest/greenhopper/latest/rapid/charts/controlchart?rapidViewId=6&swimlaneId=10&swimlaneId=11&quickFilterId=14 */

        private int indexID;
        public int Index
        {
            get => indexID;
            set => indexID = value;
        }
        private string jiraID;
        public string ID
        {
            get => jiraID;
            set => jiraID = value;
        }
        private string columnName;
        public string Name
        {
            get => columnName;
            set => columnName = value;
        }
        private long lCurrentTime;
        public long CurrentTime
        {
            get => lCurrentTime;
            set => lCurrentTime = value;
        }
        public string GetCurrentTimeAsString
        {
            get => MetrixSharedCode.GetSystemTimeElapsedAsString(lCurrentTime);
        }
    }
}
