using System;
using System.Data.OleDb;
using System.Data;
using Atlassian.Jira;
using System.Threading.Tasks;
using System.Text;

public static class MetrixSharedCode
{
    private static string username = "gbsalsman@gmail.com";
    private static string password = "Rollins!970";
    private static string encodedcredentials = Convert.ToBase64String(Encoding.UTF8.GetBytes(username + ":" + password));
    private static string restServer = "https://outrunthezombies.atlassian.net";
    private static string restUrl = "/rest/greenhopper/latest/rapid/charts/controlchart?rapidViewId=6&swimlaneId=11&days=0&projectKey=METRIX";
    private static string jiraProjectKey = "outrunthezombies";
    private static string jqlQuery = "project = outrunthezombies";
    private static int itemsPerPage = 100;
    private static int itemStart = 0;

    private static readonly string sConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source =C:\\Users\\Greg\\source\\repos\\Metrixfest\\Metrixfest\\metrixfest.mdb;Persist Security Info=False;";

    public static OleDbConnection oOleDbConnection;
    public static OleDbCommand oOleDbCommand;
    public static OleDbDataReader oOleDbDataReader;

    public enum RecordType
    {
        CycleTime = 0,
        Health = 1
    }
    public static Boolean OpenDBConnection(string sql)
    {
        try
        {
            oOleDbConnection = new OleDbConnection();
            oOleDbConnection.ConnectionString = sConnectionString;
            oOleDbConnection.Open();
            if (oOleDbConnection.State == ConnectionState.Open)
            {
                oOleDbCommand = new OleDbCommand(sql, oOleDbConnection);
            }

            return true;
        } catch (Exception ex) {
            oOleDbCommand = null;
            oOleDbConnection = null;
            Console.WriteLine(ex.StackTrace);

            return false;
        }
    }

    public static void CloseDBConnection()
    {
        try
        {
            oOleDbConnection.Close();
        } catch (Exception ex) {
            Console.WriteLine(ex.StackTrace);
        }
        finally {
            oOleDbCommand = null;
            oOleDbConnection = null;
        }
    }

    private static string GetJsonData()
    {
        string consumerKey = null;
        string consumerSecret = null;
        string oAuthAccessToken = null;
        string oAuthTokenSecret = null;

        Jira jiraConn = Jira.CreateOAuthRestClient(restServer, consumerKey, consumerSecret, oAuthAccessToken, oAuthTokenSecret);

        Task<IPagedQueryResult<Issue>> issueList = jiraConn.Issues.GetIssuesFromJqlAsync(jqlQuery);

        Task i = (Task)issueList.Result;

        return issueList.ToString();
    }

    private static async Task ForEachIssue(Jira jiraObject, string projectKey, Action<Issue> actionItem)
    {
        int itemsPerPage = 100;
        int startAt = 0;

        while (true)
        {
            IPagedQueryResult<Issue> result = await jiraObject.Issues.GetIssuesFromJqlAsync(jqlQuery, itemsPerPage, startAt);
            if (result.TotalItems == 0)
            {
                break;
            } else {
                foreach (Issue issue in result)
                {
                    //actionItem()
                }
            }
        }
    }
    public static string GetDateStringFromTimeStamp(long timestamp, Boolean localtime=true)
    {
        DateTime dt = new DateTime(1970, 1, 1) + TimeSpan.FromMilliseconds(timestamp);
        string returnValue = dt.ToLocalTime().ToString();

        if (!localtime)
            returnValue = dt.ToString();

        return returnValue;
    }
    public static string GetSystemTimeElapsedAsString(long input)
    {
        TimeSpan iSpan = TimeSpan.FromMilliseconds(input);
        string output = "";

        if (iSpan.Days > 0)
        {
            output += iSpan.Days + " days, ";
        }
        if (iSpan.Hours > 0)
        {
            output += iSpan.Hours + " hours, ";
        }
        if (iSpan.Minutes > 0)
        {
            output += iSpan.Minutes + " minutes, ";
        }
        output += iSpan.Seconds + " seconds";

        return output;
    }
    public static string json = "{\"issues\":[{\"totalTime\":[3924,2900190,25215791],\"workingTime\":[0,0,0],\"leaveTimes\":[1585498139341,1585501039531,1585526255322],\"key\":\"METRIX-9\",\"summary\":\"Issue with JSON for URL index out of bounds Line 177 FormJSON.cs\",\"swimlaneId\":11},{\"totalTime\":[8994,3319767,0],\"workingTime\":[0,0,0],\"leaveTimes\":[1585522935555,1585526255322,-1],\"key\":\"METRIX-11\",\"summary\":\"As a user I'd like to know the average cycle time of issues from the control chart\",\"swimlaneId\":11},{\"totalTime\":[2934078,0,0],\"workingTime\":[0,0,0],\"leaveTimes\":[1585526255322,-1,-1],\"key\":\"METRIX-12\",\"summary\":\"As a user I'd like to select the columns to use for working time\",\"swimlaneId\":11},{\"totalTime\":[4560,1648484,31245313],\"workingTime\":[0,0,0],\"leaveTimes\":[1585493361525,1585495010009,1585526255322],\"key\":\"METRIX-8\",\"summary\":\"Fix Date out as it appears to be a different time zone than EST\",\"swimlaneId\":11},{\"totalTime\":[15780,33216097,0],\"workingTime\":[0,0,0],\"leaveTimes\":[1585493039225,1585526255322,-1],\"key\":\"METRIX-5\",\"summary\":\"DELETE ME #2\",\"swimlaneId\":11},{\"totalTime\":[23792,33215995,0],\"workingTime\":[0,0,0],\"leaveTimes\":[1585493039327,1585526255322,-1],\"key\":\"METRIX-4\",\"summary\":\"DELETE ME #1\",\"swimlaneId\":11},{\"totalTime\":[12360,33088323,0],\"workingTime\":[0,0,0],\"leaveTimes\":[1585493166999,1585526255322,-1],\"key\":\"METRIX-7\",\"summary\":\"DELETE ME #4\",\"swimlaneId\":11},{\"totalTime\":[3111,1110084,15911947],\"workingTime\":[0,0,0],\"leaveTimes\":[1585509233291,1585510343375,1585526255322],\"key\":\"METRIX-10\",\"summary\":\"General code cleanup and refactoring\",\"swimlaneId\":11},{\"totalTime\":[19375,33088426,0],\"workingTime\":[0,0,0],\"leaveTimes\":[1585493166896,1585526255322,-1],\"key\":\"METRIX-6\",\"summary\":\"DELETE ME #3\",\"swimlaneId\":11},{\"totalTime\":[10509,507201,98031099],\"workingTime\":[0,0,0],\"leaveTimes\":[1585427717022,1585428224223,1585526255322],\"key\":\"METRIX-1\",\"summary\":\"As a user I'd like to be able to select which feature I want to use\",\"swimlaneId\":11},{\"totalTime\":[33723071,0,0],\"workingTime\":[0,0,0],\"leaveTimes\":[1585526255322,-1,-1],\"key\":\"METRIX-3\",\"summary\":\"As a user I'd like to be able to see the average cycle time for issues in a packet of JSON so that I can report on it\",\"swimlaneId\":11},{\"totalTime\":[96994411,0,0],\"workingTime\":[0,0,0],\"leaveTimes\":[1585526255322,-1,-1],\"key\":\"METRIX-2\",\"summary\":\"As a user I'd like to be able to connect to the JSON directly to get my data from Jira\",\"swimlaneId\":11}],\"columns\":[{\"id\":37,\"name\":\"To Do\"},{\"id\":38,\"name\":\"In Progress\"},{\"id\":39,\"name\":\"Done\"}],\"currentTime\":1585526255322,\"workRateData\":{\"timezone\":\"America/Toronto\",\"rates\":[{\"start\":1585427706513,\"end\":1585526255322,\"rate\":0}]}}";
}