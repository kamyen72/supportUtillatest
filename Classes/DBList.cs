﻿namespace DupRecRemoval.Classes
{
    public class DBList
    {
       public List<db> dbs {  get; set; }

        public DBList() { 
            dbs = new List<db>();
            db db = new db();
            db.connStr = db_ace99.connStr;
            db.ip = db_ace99.ip;
            db.userId = db_ace99.userId;
            db.password = db_ace99.password;
            db.dbfullname = db_ace99.dbfullname;
            db.MyID = db_ace99.MyID;
            db.shortname = db_ace99.shortname;
            dbs.Add(db);

            db = new db();
            db.connStr = db_king4d.connStr;
            db.ip = db_king4d.ip;
            db.userId = db_king4d.userId;
            db.password = db_king4d.password;
            db.dbfullname = db_king4d.dbfullname;
            db.MyID = db_king4d.MyID;
            db.shortname = db_king4d.shortname;
            dbs.Add(db);

            db = new db();
            db.connStr = db_togelking.connStr;
            db.ip = db_togelking.ip;
            db.userId = db_togelking.userId;
            db.password = db_togelking.password;
            db.dbfullname = db_togelking.dbfullname;
            db.MyID = db_togelking.MyID;
            db.shortname = db_togelking.shortname;
            dbs.Add(db);

            db = new db();
            db.connStr = db_bv.connStr;
            db.ip = db_bv.ip;
            db.userId = db_bv.userId;
            db.password = db_bv.password;
            db.dbfullname = db_bv.dbfullname;
            db.MyID=db_bv.MyID;
            db.shortname = db_bv.shortname;
            dbs.Add(db);

            db = new db();
            db.connStr = db_wl.connStr;
            db.ip = db_wl.ip;
            db.userId = db_wl.userId;
            db.password = db_wl.password;
            db.dbfullname = db_wl.dbfullname;
            db.MyID= db_wl.MyID;
            db.shortname = db_wl.shortname;
            dbs.Add(db);

            db = new db();
            db.connStr = db_ghl55.connStr;
            db.ip = db_ghl55.ip;
            db.userId = db_ghl55.userId;
            db.password = db_ghl55.password;
            db.dbfullname = db_ghl55.dbfullname;
            db.MyID = db_ghl55.MyID;
            db.shortname = db_ghl55.shortname;
            dbs.Add(db);

            db = new db();
            db.connStr = db_tm.connStr;
            db.ip = db_tm.ip;
            db.userId = db_tm.userId;
            db.password = db_tm.password;
            db.dbfullname = db_tm.dbfullname;
            db.MyID=db_tm.MyID;
            db.shortname = db_tm.shortname;
            dbs.Add(db);

            db = new db();
            db.connStr = db_tm2.connStr;
            db.ip = db_tm2.ip;
            db.userId = db_tm2.userId;
            db.password = db_tm2.password;
            db.dbfullname = db_tm2.dbfullname;
            db.MyID= db_tm2.MyID;
            db.shortname = db_tm2.shortname;
            dbs.Add(db);

            db = new db();
            db.connStr = db_tm3.connStr;
            db.ip = db_tm3.ip;
            db.userId = db_tm3.userId;
            db.password = db_tm3.password;
            db.dbfullname = db_tm3.dbfullname;
            db.MyID = db_tm3.MyID;
            db.shortname = db_tm3.shortname;
            dbs.Add(db);

            db = new db();
            db.connStr = db_local.connStr;
            db.ip = db_local.ip;
            db.userId = db_local.userId;
            db.password = db_local.password;
            db.dbfullname = db_local.dbfullname;
            db.MyID = db_local.MyID;
            db.shortname = db_local.shortname;
            dbs.Add(db);

            db = new db();
            db.connStr = db_ghlstaging.connStr;
            db.ip = db_ghlstaging.ip;
            db.userId = db_ghlstaging.userId;
            db.password = db_ghlstaging.password;
            db.dbfullname = db_ghlstaging.dbfullname;
            db.MyID= db_ghlstaging.MyID;
            db.shortname = db_ghlstaging.shortname;
            dbs.Add(db);

        }
    }
}
