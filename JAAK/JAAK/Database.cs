using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;



public class Database
{

    String dbConnection;
    public Database(){

    dbConnection = "Data Source=JAAKdatabase.s3db";
	
    }

    public int ExecuteNonQuery(string sql)
    {
        SQLiteConnection cnn = new SQLiteConnection(dbConnection);
        cnn.Open();
        SQLiteCommand mycommand = new SQLiteCommand(cnn);
        mycommand.CommandText = sql;
        int rowsUpdated = mycommand.ExecuteNonQuery();
        cnn.Close();
        return rowsUpdated;
    }
    public bool Update(String tableName, Dictionary<String, String> data, String where)
    {
        String vals = "";
        Boolean returnCode = true;
        if (data.Count >= 1)
        {
            foreach (KeyValuePair<String, String> val in data)
            {
                vals += String.Format(" {0} = '{1}',", val.Key.ToString(), val.Value.ToString());
            }
            vals = vals.Substring(0, vals.Length - 1);
        }
        try
        {
            this.ExecuteNonQuery(String.Format("update {0} set {1} where {2};", tableName, vals, where));
        }
        catch
        {
            returnCode = false;
        }
        return returnCode;
    }
 
   
    public bool Delete(String tableName, String where)
    {
        Boolean returnCode = true;
        try
        {
            this.ExecuteNonQuery(String.Format("delete from {0} where {1};", tableName, where));
        }
        catch (Exception fail)
        {
            MessageBox.Show(fail.Message);
            returnCode = false;
        }
        return returnCode;
    }
	 

    public bool Insert(String tableName, Dictionary<String, String> data)
    {
        String columns = "";
        String values = "";
        Boolean returnCode = true;
        foreach (KeyValuePair<String, String> val in data)
        {
            columns += String.Format(" {0},", val.Key.ToString());
            values += String.Format(" '{0}',", val.Value);
        }
        columns = columns.Substring(0, columns.Length - 1);
        values = values.Substring(0, values.Length - 1);
        try
        {
            this.ExecuteNonQuery(String.Format("insert into {0}({1}) values({2});", tableName, columns, values));
        }
        catch(Exception fail)
        {
            MessageBox.Show(fail.Message);
            returnCode = false;
        }
        return returnCode;
    }

    public void addBowler(String Bid, String TNBA, String USBC, String n, String lka, String ca, String sen, String div, String gen){
        Database db = new Database();
        Dictionary<String, String> data = new Dictionary<String, String>();
        data.Add("BowlerID", Bid);
        data.Add("TNBANumber", TNBA);
        data.Add("USBCNumber", USBC);
        data.Add("Name", n);
        data.Add("LastKnownAvg", lka);
        data.Add("CurrentAvg", ca);
        data.Add("Senate", sen);
        data.Add("Division", div);
        data.Add("Gender", gen);
        try
        {
                db.Insert("Bowler", data);
        }
        catch(Exception ex){
            MessageBox.Show(ex.Message);
        }
    }

    public void addTournament(String Tid, String n, String Dir, String sd, String ed)
    {
        Database db = new Database();
        Dictionary<String, String> data = new Dictionary<String, String>();
        data.Add("TournamentID", Tid);
        data.Add("Name", n);
        data.Add("Director", Dir);
        data.Add("StartDate", sd);
        data.Add("EndDate", ed);
        try
        {
            db.Insert("Tournament", data);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    public void addSquad(String Sid, String Tid, String cn, String type, String d, String t)
    {
        Database db = new Database();
        Dictionary<String, String> data = new Dictionary<String, String>();
        data.Add("SquadID", Sid);
        data.Add("TournamentID", Tid);
        data.Add("CenterName", cn);
        data.Add("Type", type);
        data.Add("Date", d);
        data.Add("Time", t);
        try
        {
            db.Insert("Squad", data);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    public void addTeam(String Tid, String type, String Bid1, String Bid2, String Bid3, String Bid4, String reg, String ass)
    {
        Database db = new Database();
        Dictionary<String, String> data = new Dictionary<String, String>();
        data.Add("TeamID", Tid);
        data.Add("Type", type);
        data.Add("Bowler1", Bid1);
        data.Add("Bowler2", Bid2);
        data.Add("Bowler3", Bid3);
        data.Add("Bowler4", Bid4);
        data.Add("Region", reg);
        data.Add("Association", ass);
        try
        {
            db.Insert("Team", data);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    public void addScore(String Sid, String Bid, String lane, String hand, String g1, String g2, String g3, String ss, String HDCP)
    {
        Database db = new Database();
        Dictionary<String, String> data = new Dictionary<String, String>();
        data.Add("SquadID", Sid);
        data.Add("BowlerID", Bid);
        data.Add("LaneNum", lane);
        data.Add("Handicap", hand);
        data.Add("Game1", g1);
        data.Add("Game2", g2);
        data.Add("Game3", g3);
        data.Add("ScratchSeries", ss);
        data.Add("HDCPSeries", HDCP);
        try
        {
            db.Insert("Score", data);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    public void addBowlingCenter(String cn, String gm, String add, String phone)
    {
        Database db = new Database();
        Dictionary<String, String> data = new Dictionary<String, String>();
        data.Add("CenterName", cn);
        data.Add("GeneralManager", gm);
        data.Add("Address", add);
        data.Add("PhoneNumber", phone);        
        try
        {
            db.Insert("BowlingCenter", data);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    public void updateBowler(String Bid, String TNBA, String USBC, String n, String lka, String ca, String sen, String div, String gen)
    {
        Database db = new Database();
        Dictionary<String, String> data = new Dictionary<String, String>();
        data.Add("BowlerID", Bid);
        data.Add("TNBANumber", TNBA);
        data.Add("USBCNumber", USBC);
        data.Add("Name", n);
        data.Add("LastKnownAvg", lka);
        data.Add("CurrentAvg", ca);
        data.Add("Senate", sen);
        data.Add("Division", div);
        data.Add("Gender", gen);
        try
        {
            db.Update("Bowler", data, String.Format("Bowler.BowlerID = {0}", Bid));
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    public void updateTournament(String Tid, String n, String Dir, String sd, String ed)
    {
        Database db = new Database();
        Dictionary<String, String> data = new Dictionary<String, String>();
        data.Add("TournamentID", Tid);
        data.Add("Name", n);
        data.Add("Director", Dir);
        data.Add("StartDate", sd);
        data.Add("EndDate", ed);
        try
        {
            db.Update("Tournament", data, String.Format("Tournament.TournamentID = {0}", Tid));
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    public void updateSquad(String Sid, String Tid, String cn, String type, String d, String t)
    {
        Database db = new Database();
        Dictionary<String, String> data = new Dictionary<String, String>();
        data.Add("SquadID", Sid);
        data.Add("TournamentID", Tid);
        data.Add("CenterName", cn);
        data.Add("Type", type);
        data.Add("Date", d);
        data.Add("Time", t);
        try
        {
            db.Update("Squad", data, String.Format("Squad.SquadID = {0}", Sid));
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    public void updateTeam(String Tid, String type, String Bid1, String Bid2, String Bid3, String Bid4, String reg, String ass)
    {
        Database db = new Database();
        Dictionary<String, String> data = new Dictionary<String, String>();
        data.Add("TeamID", Tid);
        data.Add("Type", type);
        data.Add("Bowler1", Bid1);
        data.Add("Bowler2", Bid2);
        data.Add("Bowler3", Bid3);
        data.Add("Bowler4", Bid4);
        data.Add("Region", reg);
        data.Add("Association", ass);
        try
        {
            db.Update("Team", data, String.Format("Team.TeamID = {0}", Tid));
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    public void updateScore(String Sid, String Bid, String lane, String hand, String g1, String g2, String g3, String ss, String HDCP)
    {
        Database db = new Database();
        Dictionary<String, String> data = new Dictionary<String, String>();
        data.Add("SquadID", Sid);
        data.Add("BowlerID", Bid);
        data.Add("LaneNum", lane);
        data.Add("Handicap", hand);
        data.Add("Game1", g1);
        data.Add("Game2", g2);
        data.Add("Game3", g3);
        data.Add("ScratchSeries", ss);
        data.Add("HDCPSeries", HDCP);
        try
        {
            db.Update("Score", data, String.Format("Score.ScoreID = {0}", Sid));
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    public void updateBowlingCenter(String cn, String gm, String add, String phone)
    {
        Database db = new Database();
        Dictionary<String, String> data = new Dictionary<String, String>();
        data.Add("CenterName", cn);
        data.Add("GeneralManager", gm);
        data.Add("Address", add);
        data.Add("PhoneNumber", phone);
        try
        {
            db.Update("BowlingCenter", data, String.Format("BowlingCenter.CenterName = {0}", cn));
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    public void deleteBowler(String Bid)
    {
        Database db = new Database();
        db.Delete("Bowler", String.Format("Bowler.BowlerID = {0}", Bid));
    }

    public void deleteTournament(String Tid)
    {
        Database db = new Database();
        db.Delete("Tournament", String.Format("Tournament.TournamentID = {0}", Tid));
    }

    public void deleteSquad(String Sid)
    {
        Database db = new Database();
        db.Delete("Squad", String.Format("Squad.SquadID = {0}", Sid));
    }

    public void deleteTeam(String Tid)
    {
        Database db = new Database();
        db.Delete("Team", String.Format("Team.TeamID = {0}", Tid));
    }

    public void deleteScore(String Bid)
    {
        Database db = new Database();
        db.Delete("Score", String.Format("Score.ScoreID = {0}", Bid));
    }

    public void deleteBowlingCenter(String cn)
    {
        Database db = new Database();
        db.Delete("BowlingCenter", String.Format("BowlingCenter.CenterName = {0}", cn));
    }

}
