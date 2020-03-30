using System;

namespace MetrixExtract
{
    class JiraIssue
    {
        private string issueKey;
        private string issueSummary;
        private string issueSwimLaneId;

        public string Key
        {
            get => issueKey;
            set => issueKey = value;
        }
        public string Summary
        {
            get => issueSummary;
            set =>issueSummary = value;
        }

        public string SwimLaneID
        {
            get => issueSwimLaneId;
            set => issueSwimLaneId = value;
        }

        private long[] issueTotalTime, issueWorkingTime, issueLeaveTime;

        public long[] TotalTime
        {
            get => issueTotalTime;
            set => issueTotalTime = value;
        }
        public long GetTotalTimeByColumn(int column)
        {
            return issueTotalTime[column];

        }
        public long[] WorkingTime
        {
            get => issueWorkingTime;
            set => issueWorkingTime = value;
        }
        public long GetWorkingTimeByColumn(int column)
        {
            return issueWorkingTime[column];

        }
        public long[] LeaveTime
        {
            get => issueLeaveTime;
            set => issueLeaveTime = value;
        }
        public long TotalTimeByColumn(int column)
        {
            return issueTotalTime[column];
        }
        public string TotalTimeAsStringByColumn(int column)
        {
            return MetrixSharedCode.GetSystemTimeElapsedAsString(issueTotalTime[column]);
        }
        public string WorkingTimeAsStringByColumn(int column)
        {
            return MetrixSharedCode.GetSystemTimeElapsedAsString(issueWorkingTime[column]);
        }
    }
}