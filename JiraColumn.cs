namespace MetrixExtract
{
    class JiraColumn
    {
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
            get => MetrixSharedCode.GetSystemTimeAsString(lCurrentTime);
        }
    }
}
