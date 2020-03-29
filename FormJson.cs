﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void SpitOutColumnValues(string header)
        {
            string output = "";
            output += header + System.Environment.NewLine;
            output += "______________________________________" + System.Environment.NewLine;
            foreach (JiraColumn thing in jiraColumns)
            {
                output += "Index: " + thing.Index + System.Environment.NewLine
                + "ID: " + thing.ID + System.Environment.NewLine
                + "Name: " + thing.Name + System.Environment.NewLine
                + "Rate Start: " + thing.RateStart + System.Environment.NewLine
                + "Rate End: " + thing.RateEnd + System.Environment.NewLine
                + "System Calculated Rate: " + thing.CalculatedRate + System.Environment.NewLine
                + "System Calc. Rate Str: " + thing.CalculatedRateAsString
                + System.Environment.NewLine + System.Environment.NewLine;
            }
            output += "______________________________________" + System.Environment.NewLine + System.Environment.NewLine;
            TxtRates.Text = output;
        }

        private void SpitOutIssueValues()
        {
            string output = "";

            foreach (JiraIssue thing in jiraIssues)
            {
                output += "Key: " + thing.Key + System.Environment.NewLine
                    + "Summary: " + thing.Summary + System.Environment.NewLine
                    + "Swimlane ID: " + thing.SwimLaneID + System.Environment.NewLine;
                for (int i = 0; i < thing.WorkingTime.Length; i++)
                {
                    output += "Working Time - " + jiraColumns[i].Name + ": " 
                            + thing.WorkingTime[i] + ", " + thing.WorkingTimeAsStringByColumn(i) + System.Environment.NewLine;
                }
                for (int i = 0; i < thing.LeaveTime.Length; i++)
                {
                    output += "Leave Time - " + jiraColumns[i].Name + ": " + thing.LeaveTime[i] + ", " + thing.LeaveTimeAsStringByColumn(i) + System.Environment.NewLine;
                }
                for (int i = 0; i < thing.TotalTime.Length; i++)
                {
                    output += "Total Time - " + jiraColumns[i].Name + ": " + thing.TotalTime[i] + ", " + thing.TotalTimeAsStringByColumn(i) + System.Environment.NewLine;
                }
                output += "______________________________________" + System.Environment.NewLine + System.Environment.NewLine;
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
        private void BuildJiraIssuesAndColumnsFromJson()
        {
            JObject json = JObject.Parse(TxtJson.Text);
            List<JToken> data = json.Children().ToList();
            TxtRates.Clear();
            jiraIssues.Clear();
            jiraColumns.Clear();

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
                        SpitOutColumnValues("After Columns:");
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
                                    int index = 0;
                                    foreach (JObject rate in rates)
                                    {
                                        rate.CreateReader();
                                        List<JToken> values = rate.Children().ToList();
                                        JiraColumn tempColumn = jiraColumns[index];

                                        foreach (JProperty value in values)
                                        {
                                            value.CreateReader();
                                            switch (value.Name)
                                            {
                                                case "start":
                                                    tempColumn.RateStart = (long)value.Value;
                                                    break;
                                                case "end":
                                                    tempColumn.RateEnd = (long)value.Value;
                                                    break;
                                                case "rate":
                                                    tempColumn.Rate = (long)value.Value;
                                                    break;
                                            }
                                        }
                                        jiraColumns[index] = tempColumn;
                                        SpitOutColumnValues("After Rate: " + index);
                                        index++;
                                    }
                                    break;
                            }
                        }
                        SpitOutColumnValues("After All Values:");
                        SpitOutIssueValues();
                        break;
                }
            }
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            BuildJiraIssuesAndColumnsFromJson();
        }
    }
}