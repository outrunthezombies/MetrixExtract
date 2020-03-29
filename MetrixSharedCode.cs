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
}