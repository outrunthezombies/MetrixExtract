using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MetrixExtract
{
    public partial class FormJson : Form
    {
        public FormJson()
        {
            InitializeComponent();
        }

        private List<JiraIssue> jiraIssues = new List<JiraIssue>();
        private List<JiraColumn> jiraColumns = new List<JiraColumn>();
        private List<JiraWorkRateData> jiraWorkRateDatas = new List<JiraWorkRateData>();
        private string JSON = "";
        private long averageWorkingTime;
        private long medianWorkingTime;
        private long averageTotalTime;
        private long medianTotalTime;
        private long minWorkingTime;
        private long maxWorkingTime;
        private long minTotalTime;
        private long maxTotalTime;
        private readonly string separator = "____________________________________________________________________________";
        private enum JSONLocation
        {
            FilePath = 0,
            TextBox = 1,
            HardCoded = 2
        }
        private void SpitOutColumnValues(string header)
        {
            string output = header + Environment.NewLine + separator + Environment.NewLine + Environment.NewLine;
            foreach (JiraColumn thing in jiraColumns)
            {
                output += "Index:\t" + thing.Index + Environment.NewLine
                + "ID:\t" + thing.ID + Environment.NewLine
                + "Name:\t" + thing.Name + Environment.NewLine
                + Environment.NewLine;
            }
            TxtColumns.Text = output;
        }
        private void SpitOutWorkRateValues()
        {
            string output = "All Work Rate Values:" + Environment.NewLine + separator + Environment.NewLine + Environment.NewLine;
            foreach (JiraWorkRateData thing in jiraWorkRateDatas)
            {
                output += "Index: " + thing.Index + Environment.NewLine
                + "\t\tRate Start:\t\t" + thing.RateStart + " - " + thing.GetRateStartDateAsString() + Environment.NewLine
                + "\t\tRate End:\t\t" + thing.RateEnd + " - " + thing.GetRateEndDateAsString() + Environment.NewLine
                + "\t\tRate:\t\t\t" + thing.Rate + Environment.NewLine
                + "\t\tSystem Calculated Rate:\t" + thing.GetCalculatedRate + Environment.NewLine
                + "\t\tSystem Calc. Rate Str:\t" + thing.GetCalculatedRateAsString + Environment.NewLine 
                + Environment.NewLine;
            }
            TxtWorkRates.Text = output;
        }
        private void SpitOutIssueValues()
        {
            string output = "";

            foreach (JiraIssue thing in jiraIssues)
            {
                output += "Key: " + thing.Key + Environment.NewLine
                    + "Summary: " + thing.Summary + Environment.NewLine
                    + "Swimlane ID: " + thing.SwimLaneID + Environment.NewLine;
                for (int i = 0; i < thing.WorkingTime.Length && i < thing.LeaveTime.Length && i < thing.TotalTime.Length; i++)
                {
                    output += Environment.NewLine + "Column: " + jiraColumns[i].Name + Environment.NewLine
                        + "\t\tLeave Time:\t" + MetrixSharedCode.GetDateStringFromTimeStamp(thing.LeaveTime[i]) + " (" + thing.LeaveTime[i] + ")" + Environment.NewLine
                        + "\t\tWorking Time:\t" + thing.WorkingTimeAsStringByColumn(i) + " (" + thing.WorkingTime[i] + ")" + Environment.NewLine
                        + "\t\tTotal Time:\t" + thing.TotalTimeAsStringByColumn(i) + " (" + thing.TotalTime[i] + ")" + Environment.NewLine;
                }
                output += separator + Environment.NewLine + Environment.NewLine;
                }
            TxtIssues.Text = output;
        }
        private long[] CreateTimeArray(JProperty values)
        {
            List<JToken> items = values.Children().Children().ToList();
            long[] totalTimes = new long[items.Count];
            int index = 0;

            foreach (JValue item in items)
            {
                item.CreateReader();
                totalTimes[index] = (long)item.Value;
                index++;
            }
            return totalTimes;
        }
        private void BuildJiraIssuesAndColumnsFromJson(JSONLocation location =  JSONLocation.TextBox)
        {
            this.Cursor = Cursors.WaitCursor;
            string jsonText = TxtJson.Text;
            switch (location)
            {
                case JSONLocation.TextBox:
                    break;
                case JSONLocation.FilePath:
                    jsonText = JSON;
                    break;
                case JSONLocation.HardCoded:
                    jsonText = MetrixSharedCode.json;
                    break;
            }
            JObject json = JObject.Parse(jsonText);
            List<JToken> data = json.Children().ToList();
            jiraIssues.Clear();
            jiraColumns.Clear();
            jiraWorkRateDatas.Clear();

            if (jsonText == "")
            {
                TxtAverage.Text = "Nothing to parse!";
            }  else {
                foreach (JProperty item in data)
                {
                    item.CreateReader();
                    switch (item.Name)
                    {
                        case "issues":
                            List<JToken> issues = item.Children().Children().ToList();
                            foreach (JObject issue in issues)
                            {
                                issue.CreateReader();
                                List<JToken> values = issue.Children().ToList();
                                JiraIssue newJiraIssue = new JiraIssue();

                                foreach (JProperty value in values)
                                {
                                    value.CreateReader();
                                    switch (value.Name)
                                    {
                                        case "key":
                                            newJiraIssue.Key = (string)value.Value;
                                            break;
                                        case "summary":
                                            newJiraIssue.Summary = (string)value.Value;
                                            break;
                                        case "swimlaneId":
                                            newJiraIssue.SwimLaneID = (string)value.Value;
                                            break;
                                        case "totalTime":
                                            newJiraIssue.TotalTime = CreateTimeArray(value);
                                            break;
                                        case "workingTime":
                                            newJiraIssue.WorkingTime = CreateTimeArray(value);
                                            break;
                                        case "leaveTimes":
                                            newJiraIssue.LeaveTime = CreateTimeArray(value);
                                            break;
                                    }
                                }
                                jiraIssues.Add(newJiraIssue);
                            }
                            break;
                        case "columns":
                            List<JToken> columns = item.Children().Children().ToList();
                            int columnIndex = 0;
                            foreach (JObject column in columns)
                            {
                                column.CreateReader();
                                JiraColumn jiraColumn = new JiraColumn();

                                List<JToken> values = column.Children().ToList();
                                foreach (JProperty value in values)
                                {
                                    switch (value.Name)
                                    {
                                        case "id":
                                            jiraColumn.ID = Convert.ToString(value.Value);
                                            break;
                                        case "name":
                                            jiraColumn.Name = Convert.ToString(value.Value);
                                            break;
                                    }
                                }
                                jiraColumn.Index = columnIndex;
                                jiraColumns.Add(jiraColumn);
                                columnIndex++;
                            }
                            SpitOutColumnValues("All Columns:");
                            break;
                        case "workRateData":
                            List<JToken> workRateData = item.Children().Children().ToList();
                            foreach (JProperty workRate in workRateData)
                            {
                                workRate.CreateReader();
                                switch (workRate.Name)
                                {
                                    case "timezone":
                                        //MessageBox.Show(workRate.Value); //Time zone value
                                        break;
                                    case "rates":
                                        List<JToken> rates = workRate.Children().Children().ToList();
                                        int workRateDataIndex = 0;
                                        foreach (JObject rate in rates)
                                        {
                                            rate.CreateReader();
                                            List<JToken> values = rate.Children().ToList();
                                            JiraWorkRateData workRateValue = new JiraWorkRateData();

                                            foreach (JProperty value in values)
                                            {
                                                value.CreateReader();
                                                switch (value.Name)
                                                {
                                                    case "start":
                                                        workRateValue.RateStart = (long)value.Value;
                                                        break;
                                                    case "end":
                                                        workRateValue.RateEnd = (long)value.Value;
                                                        break;
                                                    case "rate":
                                                        workRateValue.Rate = (long)value.Value;
                                                        break;
                                                }
                                            }
                                            workRateValue.Index = workRateDataIndex;
                                            jiraWorkRateDatas.Add(workRateValue);
                                            workRateDataIndex++;
                                        }
                                        break;
                                }
                            }
                            SpitOutWorkRateValues();
                            SpitOutIssueValues();
                            break;
                    }
                }
                CalculateCycleTimes();
            }
            this.Cursor = Cursors.Default;
        }
        private void CalculateCycleTimes()
        {
            string output = "";
            long totalTime = 0;
            long workingTime = 0;
            int jiraIssueCount = 0;
            if (jiraIssues.Count > 0)
            {
                foreach (JiraIssue jiraIssue in jiraIssues)
                {
                    long tempTotalTime = jiraIssue.GetTotalTimeByColumn(MetrixSharedCode.inProgressColumn);
                    long tempWorkingTime = jiraIssue.GetWorkingTimeByColumn(MetrixSharedCode.inProgressColumn);
                    if ((tempTotalTime >= 0 || tempWorkingTime >= 0) && jiraIssue.LeaveTime[2] >= 0)
                    {
                        jiraIssueCount++;
                        totalTime += tempTotalTime;
                        workingTime += tempWorkingTime;
                        output += jiraIssue.Key + ": " + Environment.NewLine
                            + "\t\tWorking:\t" + MetrixSharedCode.GetSystemTimeElapsedAsString(tempWorkingTime) + Environment.NewLine
                            + "\t\tTotal:\t" + MetrixSharedCode.GetSystemTimeElapsedAsString(tempTotalTime) + Environment.NewLine + Environment.NewLine;
                    }
                }
                if (jiraIssueCount > 0)
                {
                    long[] workingTimeValues = new long[jiraIssues.Count];
                    long[] totalTimeValues = new long[jiraIssues.Count];
                    for (int i=0; i<jiraIssueCount; i++)
                    {
                        workingTimeValues[i] = jiraIssues[i].WorkingTime[MetrixSharedCode.inProgressColumn];
                        totalTimeValues[i] = jiraIssues[i].TotalTime[MetrixSharedCode.inProgressColumn];
                    }
                    Array.Sort(workingTimeValues);
                    Array.Sort(totalTimeValues);
                    medianWorkingTime = workingTimeValues[(int)Math.Round(((double)workingTimeValues.Count() + 1) / 2) - 1];
                    medianTotalTime = totalTimeValues[(int)Math.Round(((double)totalTimeValues.Count() + 1) / 2) - 1];

                    minWorkingTime = workingTimeValues[0];
                    maxWorkingTime = workingTimeValues[workingTimeValues.Count()-1];
                    minTotalTime = totalTimeValues[0];
                    maxTotalTime = totalTimeValues[totalTimeValues.Count() - 1];

                    averageWorkingTime = workingTime / jiraIssueCount;
                    averageTotalTime = totalTime / jiraIssueCount;
                    output = "Issues: " + jiraIssueCount + " of " + jiraIssues.Count + " Items" + Environment.NewLine + Environment.NewLine
                        + "\t\tWork Time Avg:\t" + MetrixSharedCode.GetSystemTimeElapsedAsString(averageWorkingTime) + Environment.NewLine
                        + "\t\tMedian Work Time:\t" + MetrixSharedCode.GetSystemTimeElapsedAsString(medianWorkingTime) + Environment.NewLine
                        + "\t\tMin Work Time:\t" + MetrixSharedCode.GetSystemTimeElapsedAsString(minWorkingTime) + Environment.NewLine
                        + "\t\tMax Work Time:\t" + MetrixSharedCode.GetSystemTimeElapsedAsString(maxWorkingTime) + Environment.NewLine
                        + "\t\tTotal Time Avg:\t" + MetrixSharedCode.GetSystemTimeElapsedAsString(averageTotalTime) + Environment.NewLine
                        + "\t\tMedian Total Time:\t" + MetrixSharedCode.GetSystemTimeElapsedAsString(medianTotalTime) + Environment.NewLine
                        + "\t\tMin Total Time:\t" + MetrixSharedCode.GetSystemTimeElapsedAsString(minTotalTime) + Environment.NewLine
                        + "\t\tMax Total Time:\t" + MetrixSharedCode.GetSystemTimeElapsedAsString(maxTotalTime) + Environment.NewLine
                        + Environment.NewLine + output;
                    TxtAverage.Text = "All Averages:" + Environment.NewLine + separator + Environment.NewLine + Environment.NewLine + output;
                } else
                {
                    TxtAverage.Text = "Nothing to Average!";
                }
            }
        }
        private void BtnLoadJSON_Click(object sender, EventArgs e)
        {
            JSON = File.ReadAllText(TxtJSONPath.Text);
            BuildJiraIssuesAndColumnsFromJson(JSONLocation.FilePath);
        }

        private void BtnParseFromCoded_Click(object sender, EventArgs e)
        {
            BuildJiraIssuesAndColumnsFromJson(JSONLocation.HardCoded);
        }
        private void BtnParseFromTextBox_Click(object sender, EventArgs e)
        {
            BuildJiraIssuesAndColumnsFromJson();
        }
    }
}
