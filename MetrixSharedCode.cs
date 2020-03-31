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
    public static int inProgressColumn = 1;
    public static int doneColumn = 2;
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
    public static string json = "{\"issues\":[{\"totalTime\":[1396837,1523328,13872451],\"workingTime\":[1396837,1523328,13872451],\"leaveTimes\":[1585580235590,1585580239369,1585594111820],\"key\":\"METRIX-15\",\"summary\":\"Do calculation for average on issues that are resolved only\"},{\"totalTime\":[1292617,1346795,13912994],\"workingTime\":[1292617,1346795,13912994],\"leaveTimes\":[1585578852031,1585580198826,1585594111820],\"key\":\"METRIX-16\",\"summary\":\"Leave Time on issues should be a DateTime not elapsed\"},{\"totalTime\":[3924,2900190,93072289],\"workingTime\":[0,0,53311820],\"leaveTimes\":[1585498139341,1585501039531,1585594111820],\"key\":\"METRIX-9\",\"summary\":\"Issue with JSON for URL index out of bounds Line 177 FormJSON.cs\"},{\"totalTime\":[8994,49987624,21188641],\"workingTime\":[0,32123179,21188641],\"leaveTimes\":[1585522935555,1585572923179,1585594111820],\"key\":\"METRIX-11\",\"summary\":\"As a user I'd like to know the average cycle time of issues from the control chart\"},{\"totalTime\":[70790576,0,0],\"workingTime\":[53311820,0,0],\"leaveTimes\":[1585594111820,-1,-1],\"key\":\"METRIX-12\",\"summary\":\"As a user I'd like to select the columns to use for working time\"},{\"totalTime\":[4560,1648484,99101811],\"workingTime\":[0,0,53311820],\"leaveTimes\":[1585493361525,1585495010009,1585594111820],\"key\":\"METRIX-8\",\"summary\":\"Fix Date out as it appears to be a different time zone than EST\"},{\"totalTime\":[4379,3415208,17745791],\"workingTime\":[4379,3415208,17745791],\"leaveTimes\":[1585572950821,1585576366029,1585594111820],\"key\":\"METRIX-13\",\"summary\":\"Convert load of JSON from file instead of copy/paste in textbox\"},{\"totalTime\":[15618110,874368,1053090],\"workingTime\":[15618110,874368,1053090],\"leaveTimes\":[1585592184362,1585593058730,1585594111820],\"key\":\"METRIX-14\",\"summary\":\"TxtRates.Text doesn't clear when reloading (other Txt fields work)\"},{\"totalTime\":[3111,1110084,83768445],\"workingTime\":[0,0,53311820],\"leaveTimes\":[1585509233291,1585510343375,1585594111820],\"key\":\"METRIX-10\",\"summary\":\"General code cleanup and refactoring\"},{\"totalTime\":[10509,507201,165887597],\"workingTime\":[0,0,53311820],\"leaveTimes\":[1585427717022,1585428224223,1585594111820],\"key\":\"METRIX-1\",\"summary\":\"As a user I'd like to be able to select which feature I want to use\"},{\"totalTime\":[4333998,0,0],\"workingTime\":[4333998,0,0],\"leaveTimes\":[1585594111820,-1,-1],\"key\":\"METRIX-19\",\"summary\":\"Make sure reopens don't get calculated into cycle time\"},{\"totalTime\":[164850909,0,0],\"workingTime\":[53311820,0,0],\"leaveTimes\":[1585594111820,-1,-1],\"key\":\"METRIX-2\",\"summary\":\"As a user I'd like to be able to connect to the JSON directly to get my data from Jira\"}],\"columns\":[{\"id\":37,\"name\":\"To Do\"},{\"id\":38,\"name\":\"In Progress\"},{\"id\":39,\"name\":\"Done\"}],\"currentTime\":1585594111820,\"workRateData\":{\"timezone\":\"America/Toronto\",\"rates\":[{\"start\":1585427706513,\"end\":1585540800000,\"rate\":0},{\"start\":1585540800000,\"end\":1585594111820,\"rate\":1}]}}";
}