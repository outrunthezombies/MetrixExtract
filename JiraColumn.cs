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
        private long workRateStart, workRateEnd, workRateRate;
        public long RateStart
        {
            get => workRateStart;
            set => workRateStart = value;
        }
        public long RateEnd
        {
            get => workRateEnd;
            set => workRateEnd = value;
        }
        public long Rate
        {
            get => workRateRate;
            set => workRateRate = value;
        }
        public long CalculatedRate
        {
            get => workRateEnd - workRateStart;
        }
        public string CalculatedRateAsString
        {
            get => MetrixSharedCode.GetSystemTimeAsString(workRateEnd - workRateStart);
        }
    }
}
