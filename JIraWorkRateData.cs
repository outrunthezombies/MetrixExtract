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
        public int Index
        {
            get => indexID;
            set => indexID = value;
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
