using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetrixExtract
{
    class JiraWorkRateData
    {
        private int indexID;
        private long workRateStart, workRateEnd, workRateRate;
        private long CalculateRate()
        {
            return workRateEnd - workRateStart;
        }
        public int Index
        {
            get => indexID;
            set => indexID = value;
        }
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
        public long GetCalculatedRate
        {
            get => CalculateRate();
        }
        public string GetCalculatedRateAsString
        {
            get => MetrixSharedCode.GetSystemTimeElapsedAsString(CalculateRate());
        }
        public string GetRateStartDateAsString()
        {
            return MetrixSharedCode.GetDateStringFromTimeStamp(workRateStart);
        }
        public string GetRateEndDateAsString()
        {
            return MetrixSharedCode.GetDateStringFromTimeStamp(workRateEnd);
        }
    }
}
