using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.TimeSpan;

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
        public long[] WorkingTime
        {
            get => issueWorkingTime;
            set => issueWorkingTime = value;
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
            return MetrixSharedCode.GetSystemTimeAsString(issueTotalTime[column]);
        }
        public string WorkingTimeAsStringByColumn(int column)
        {
            return MetrixSharedCode.GetSystemTimeAsString(issueWorkingTime[column]);
        }
        public string LeaveTimeAsStringByColumn(int column)
        { 
            {
                try
                {
                    return (new DateTime(1970, 1, 1) + TimeSpan.FromMilliseconds(Convert.ToDouble(issueLeaveTime[column]))).ToString();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print(ex.StackTrace);
                    return DateTime.Now.ToString();
                }
            }
        }
    }
}
