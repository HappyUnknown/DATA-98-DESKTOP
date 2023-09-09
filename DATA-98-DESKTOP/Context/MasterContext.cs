using DATA_98_DESKTOP.Class;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_98_DESKTOP.Context
{
    class MasterContext : DbContext
    {
        public DbSet<Master> Masters { get; set; }
        public MasterContext() : base("Data98Connection")
        {

        }
        public bool NicknameRegistered(string nick)
        {
            MasterContext db = new MasterContext();
            List<Master> masters = db.Masters.ToList();
            for (int i = 0; i < masters.Count; i++)
            {
                if (nick == masters[i].Nickname)
                {
                    db.Dispose();
                    return true;
                }
            }
            db.Dispose();
            return false;
        }

        public Master LogMasterIn(string nick, string pass)
        {
            MasterContext db = new MasterContext();
            List<Master> masters = db.Masters.ToList();
            for (int i = 0; i < masters.Count; i++)
            {
                if (nick == masters[i].Nickname && pass == masters[i].PassMD5)
                {
                    db.Dispose();
                    return masters[i];
                }
            }
            db.Dispose();
            return null;
        }

        public int NextId()
        {
            var db = new MasterContext();
            int maxId = db.Masters.Max(x => x.Id);
            int nextId = maxId + 1;
            db.Dispose();
            return nextId;
        }
    }
}
