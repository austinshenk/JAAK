using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;



public class Database
{

    String dbConnection;
    public Database()
    {

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
        catch (Exception fail)
        {
            MessageBox.Show(fail.Message);
            returnCode = false;
        }
        return returnCode;
    }

    public String querySingle(String query)
    {
        SQLiteConnection con = new SQLiteConnection(dbConnection);
        con.Open();
        SQLiteCommand com = new SQLiteCommand(con);
        com.CommandText = query;
        object value = com.ExecuteScalar();
        con.Close();
        if (value != null)
        {
            return value.ToString();
        }
        return "";

    }

    public DataTable Query(string sql)
    {
        SQLiteConnection cnn = new SQLiteConnection(dbConnection);
        {
            cnn.Open();
            using (SQLiteDataAdapter sda = new SQLiteDataAdapter(sql, cnn))
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
        }
    }

    public void Loadcmb(ComboBox comboBox, string sql, string valueMember, string displayMember)
    {
        SQLiteConnection cnn = new SQLiteConnection(dbConnection);
        {
            cnn.Open();
            using (SQLiteDataAdapter sda = new SQLiteDataAdapter(sql, cnn))
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);

                comboBox.ValueMember = valueMember;
                comboBox.DisplayMember = displayMember;
                comboBox.DataSource = dt;
            }
        }
    }

    public void LoadList(ListBox listBox, string sql, string valueMember, string displayMember)
    {
        SQLiteConnection cnn = new SQLiteConnection(dbConnection);
        {
            cnn.Open();
            using (SQLiteDataAdapter sda = new SQLiteDataAdapter(sql, cnn))
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);

                listBox.ValueMember = valueMember;
                listBox.DisplayMember = displayMember;
                listBox.DataSource = dt;
            }
        }
    }

    public int GetNewID(string Table, string fieldname)
    {
        int ID = -1;

        if (!exists(Table)) { return 0; }

        DataTable result = Query("select max(" + fieldname + ") from " + Table);
        DataRow row = result.Rows[0];
        int.TryParse(row["max(" + fieldname + ")"].ToString(), out ID);

        return ID + 1;
    }

    public bool exists(string Table, string fieldname, string key)
    {
        DataTable result = Query("select * from " + Table + " where " + fieldname + " = '" + key + "'");
        if (result.Rows.Count == 0) { return false; }
        else { return true; }
    }

    public bool exists(string Table)
    {
        DataTable result = Query("select * from " + Table);
        if (result.Rows.Count == 0) { return false; }
        else { return true; }
    }

    public void addBowler(String Bid, String fn, String mi, String ln, String gen, String add, String city, String st, String zc, String TNBA, String USBC, String lka, String ca, String sen)
    {
        Database db = new Database();
        Dictionary<String, String> data = new Dictionary<String, String>();
        data.Add("BowlerID", Bid);
        data.Add("FirstName", fn);
        data.Add("MI", mi);
        data.Add("LastName", ln);
        data.Add("Gender", gen);
        data.Add("Address", add);
        data.Add("City", city);
        data.Add("State", st);
        data.Add("ZipCode", zc);
        data.Add("TNBANumber", TNBA);
        data.Add("USBCNumber", USBC);
        data.Add("LastKnownAvg", lka);
        data.Add("CurrentAvg", ca);
        data.Add("Senate", sen);
        try
        {
            db.Insert("Bowler", data);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    public void addBowlingCenter(String cn, String gm, String add, String c, String s, String zc, String phone, String lane)
    {
        Database db = new Database();
        Dictionary<String, String> data = new Dictionary<String, String>();
        data.Add("CenterName", cn);
        data.Add("GeneralManager", gm);
        data.Add("Address", add);
        data.Add("City", c);
        data.Add("State", s);
        data.Add("ZipCode", zc);
        data.Add("PhoneNumber", phone);
        data.Add("Lanes", lane);
        try
        {
            db.Insert("BowlingCenter", data);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    public void addDivision(String Did, String Tid, String Eid, String Des, String uage, String uave, String usex, String minage, String maxage, String minave, String maxave, String sex, String HDCPper, String HDCPb)
    {
        Database db = new Database();
        Dictionary<String, String> data = new Dictionary<String, String>();
        data.Add("DivisionID", Did);
        data.Add("TournamentID", Tid);
        data.Add("EventID", Eid);
        data.Add("Description", Des);
        data.Add("UseAge", uage);
        data.Add("UseAve", uave);
        data.Add("UseSex", usex);
        data.Add("MinAge", minage);
        data.Add("MaxAge", maxage);
        data.Add("MinAve", minave);
        data.Add("MaxAve", maxave);
        data.Add("Sex", sex);
        data.Add("HDCPpercent", HDCPper);
        data.Add("HDCPbase", HDCPb);
        try
        {
            db.Insert("Division", data);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    public void addEvent(String Eid, String Tid, String name, String type, String bod, String df, String lin, String exp, String pf, String tpb)
    {
        Database db = new Database();
        Dictionary<String, String> data = new Dictionary<String, String>();
        data.Add("EventID", Eid);
        data.Add("TournamentID", Tid);
        data.Add("EventName", name);
        data.Add("EventType", type);
        data.Add("BowledOrDerived", bod);
        data.Add("DerivedFrom", df);
        data.Add("Linage", lin);
        data.Add("Expenses", exp);
        data.Add("PrizeFund", pf);
        data.Add("TotalPerBowler", tpb);

        try
        {
            db.Insert("Event", data);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

    }

    public void addScore(String Sid, String Bid, String Tid, String lane, String avg, String hand, String g1, String g2, String g3, String ss, String HDCP)
    {
        Database db = new Database();
        Dictionary<String, String> data = new Dictionary<String, String>();
        data.Add("SquadID", Sid);
        data.Add("BowlerID", Bid);
        data.Add("TournamentID", Tid);
        data.Add("LaneNum", lane);
        data.Add("Average", avg);
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

    public void addSquad(String Sid, String Tid, String Eid, String Sn, String cn, String d, String t)
    {
        Database db = new Database();
        Dictionary<String, String> data = new Dictionary<String, String>();
        data.Add("SquadID", Sid);
        data.Add("TournamentID", Tid);
        data.Add("EventID", Eid);
        data.Add("Name", Sn);
        data.Add("CenterName", cn);
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

    public void addTeam(String Reg, String Tid, String Sid, String Did, String name, String type, String Bid1, String Bid2, String Bid3, String Bid4, String sen, String c, String s)
    {
        Database db = new Database();
        Dictionary<String, String> data = new Dictionary<String, String>();
        data.Add("RegistrationNumber", Reg);
        data.Add("TournamentID", Tid);
        data.Add("SquadID", Sid);
        data.Add("DivisionID", Did);
        data.Add("Name", name);
        data.Add("Type", type);
        data.Add("Bowler1", Bid1);
        data.Add("Bowler2", Bid2);
        data.Add("Bowler3", Bid3);
        data.Add("Bowler4", Bid4);
        data.Add("Senate", sen);
        data.Add("City", c);
        data.Add("State", s);
        try
        {
            db.Insert("Team", data);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    public void addTournament(String Tid, String n, String sd, String ed, String Dir, String dp, String da, String dc, String ds, String dz, String ppd, String tpon, String pot, String not)
    {
        Database db = new Database();
        Dictionary<String, String> data = new Dictionary<String, String>();
        data.Add("TournamentID", Tid);
        data.Add("Name", n);
        data.Add("StartDate", sd);
        data.Add("EndDate", ed);
        data.Add("DirectorName", Dir);
        data.Add("DirectorPhone", dp);
        data.Add("DirectorAddress", da);
        data.Add("DirectorCity", dc);
        data.Add("DirectorState", ds);
        data.Add("DirectorZip", dz);
        data.Add("PrizePerDivision", ppd);
        data.Add("TopPercentOrNumber", tpon);
        data.Add("PercentOfTeams", pot);
        data.Add("NumberOfTeams", not);
        try
        {
            db.Insert("Tournament", data);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    public void updateBowler(String Bid, String fn, String mi, String ln, String gen, String add, String city, String st, String zc, String TNBA, String USBC, String lka, String ca, String sen)
    {
        Database db = new Database();
        Dictionary<String, String> data = new Dictionary<String, String>();
        data.Add("BowlerID", Bid);
        data.Add("FirstName", fn);
        data.Add("MI", mi);
        data.Add("LastName", ln);
        data.Add("Gender", gen);
        data.Add("Address", add);
        data.Add("City", city);
        data.Add("State", st);
        data.Add("ZipCode", zc);
        data.Add("TNBANumber", TNBA);
        data.Add("USBCNumber", USBC);
        data.Add("LastKnownAvg", lka);
        data.Add("CurrentAvg", ca);
        data.Add("Senate", sen);
        try
        {
            db.Update("Bowler", data, String.Format("Bowler.BowlerID = {0}", Bid));
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    public void updateBowlingCenter(String cn, String gm, String add, String c, String s, String zc, String phone, String lane)
    {
        Database db = new Database();
        Dictionary<String, String> data = new Dictionary<String, String>();
        data.Add("CenterName", cn);
        data.Add("GeneralManager", gm);
        data.Add("Address", add);
        data.Add("City", c);
        data.Add("State", s);
        data.Add("ZipCode", zc);
        data.Add("PhoneNumber", phone);
        data.Add("Lanes", lane);
        try
        {
            db.Update("BowlingCenter", data, String.Format("BowlingCenter.CenterName = {0}", cn));
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    public void updateDivision(String Did, String Tid, String Eid, String Des, String uage, String uave, String usex, String minage, String maxage, String minave, String maxave, String sex, String HDCPper, String HDCPb)
    {
        Database db = new Database();
        Dictionary<String, String> data = new Dictionary<String, String>();
        data.Add("DivisionID", Did);
        data.Add("TournamentID", Tid);
        data.Add("EventID", Eid);
        data.Add("Description", Des);
        data.Add("UseAge", uage);
        data.Add("UseAve", uave);
        data.Add("UseSex", usex);
        data.Add("MinAge", minage);
        data.Add("MaxAge", maxage);
        data.Add("MinAve", minave);
        data.Add("MaxAve", maxave);
        data.Add("Sex", sex);
        data.Add("HDCPpercent", HDCPper);
        data.Add("HDCPbase", HDCPb);
        try
        {
            db.Update("Division", data, String.Format("Division.DivisionID = {0}", Did));
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    public void updateEvent(String Eid, String Tid, String name, String type, String bod, String df, String lin, String exp, String pf, String tpb)
    {
        Database db = new Database();
        Dictionary<String, String> data = new Dictionary<String, String>();
        data.Add("EventID", Eid);
        data.Add("TournamentID", Tid);
        data.Add("EventName", name);
        data.Add("EventType", type);
        data.Add("BowledOrDerived", bod);
        data.Add("DerivedFrom", df);
        data.Add("Linage", lin);
        data.Add("Expenses", exp);
        data.Add("PrizeFund", pf);
        data.Add("TotalPerBowler", tpb);

        try
        {
            db.Update("Event", data, String.Format("Event.EventID = {0}", Eid));
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

    }

    public void updateScore(String Sid, String Bid, String Tid, String lane, String avg, String hand, String g1, String g2, String g3, String ss, String HDCP)
    {
        Database db = new Database();
        Dictionary<String, String> data = new Dictionary<String, String>();
        data.Add("SquadID", Sid);
        data.Add("BowlerID", Bid);
        data.Add("TournamentID", Tid);
        data.Add("LaneNum", lane);
        data.Add("Average", avg);
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

    public void updateSquad(String Sid, String Tid, String Eid, String Sn, String cn, String d, String t)
    {
        Database db = new Database();
        Dictionary<String, String> data = new Dictionary<String, String>();
        data.Add("SquadID", Sid);
        data.Add("TournamentID", Tid);
        data.Add("EventID", Eid);
        data.Add("Name", Sn);
        data.Add("CenterName", cn);
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

    public void updateTeam(String Reg, String Tid, String Sid, String Did, String name, String type, String Bid1, String Bid2, String Bid3, String Bid4, String sen, String c, String s)
    {
        Database db = new Database();
        Dictionary<String, String> data = new Dictionary<String, String>();
        data.Add("RegistrationNumber", Reg);
        data.Add("TournamentID", Tid);
        data.Add("SquadID", Sid);
        data.Add("DivisionID", Did);
        data.Add("Name", name);
        data.Add("Type", type);
        data.Add("Bowler1", Bid1);
        data.Add("Bowler2", Bid2);
        data.Add("Bowler3", Bid3);
        data.Add("Bowler4", Bid4);
        data.Add("Senate", sen);
        data.Add("City", c);
        data.Add("State", s);
        try
        {
            db.Update("Team", data, String.Format("Team.RegistrationNumber = {0}", Tid));
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    public void updateTournament(String Tid, String n, String sd, String ed, String Dir, String dp, String da, String dc, String ds, String dz, String ppd, String tpon, String pot, String not)
    {
        Database db = new Database();
        Dictionary<String, String> data = new Dictionary<String, String>();
        data.Add("TournamentID", Tid);
        data.Add("Name", n);
        data.Add("StartDate", sd);
        data.Add("EndDate", ed);
        data.Add("DirectorName", Dir);
        data.Add("DirectorPhone", dp);
        data.Add("DirectorAddress", da);
        data.Add("DirectorCity", dc);
        data.Add("DirectorState", ds);
        data.Add("DirectorZip", dz);
        data.Add("PrizePerDivision", ppd);
        data.Add("TopPercentOrNumber", tpon);
        data.Add("PercentOfTeams", pot);
        data.Add("NumberOfTeams", not);
        try
        {
            db.Update("Tournament", data, String.Format("Tournament.TournamentID = {0}", Tid));
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

    public void deleteBowlingCenter(String cn)
    {
        Database db = new Database();
        db.Delete("BowlingCenter", String.Format("BowlingCenter.CenterName = {0}", cn));
    }

    public void deleteDivision(String Did)
    {
        Database db = new Database();
        db.Delete("Division", String.Format("Division.DivisionID = {0}", Did));
    }

    public void deleteEvent(String Eid)
    {
        Database db = new Database();
        db.Delete("Event", String.Format("Event.EventID = {0}", Eid));
    }

    public void deleteScore(String Bid)
    {
        Database db = new Database();
        db.Delete("Score", String.Format("Score.ScoreID = {0}", Bid));
    }

    public void deleteSquad(String Sid)
    {
        Database db = new Database();
        db.Delete("Squad", String.Format("Squad.SquadID = {0}", Sid));
    }

    public void deleteTeam(String Reg)
    {
        Database db = new Database();
        db.Delete("Team", String.Format("Team.RegistrationNumber = {0}", Reg));
    }

    public void deleteTournament(String Tid)
    {
        Database db = new Database();
        db.Delete("Tournament", String.Format("Tournament.TournamentID = {0}", Tid));
        db.Delete("Event", String.Format("Event.TournamentID = {0}", Tid));
        db.Delete("Squad", String.Format("Squad.TournamentID = {0}", Tid));
        db.Delete("Division", String.Format("Division.TournamentID = {0}", Tid));
        db.Delete("Team", String.Format("Team.TournamentID = {0}", Tid));
        db.Delete("Scores", String.Format("Score.TournamentID = {0}", Tid));
    }



}
