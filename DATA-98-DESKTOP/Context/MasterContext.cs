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
            List<Master> masters = Masters.ToList();
            for (int i = 0; i < masters.Count; i++)
                if (nick == masters[i].Nickname)
                    return true;
            return false;
        }

        public Master LogMasterIn(string nick, string pass)
        {
            List<Master> masters = Masters.ToList();
            for (int i = 0; i < masters.Count; i++)
                if (nick == masters[i].Nickname && pass == masters[i].PassMD5)
                    return masters[i];
            return null;
        }

        public int NextId()
        {
            int maxId = Masters.Max(x => x.Id);
            int nextId = maxId + 1;
            return nextId;
        }

        public int GetNicknameId(string nick)
        {
            List<Master> masters = Masters.ToList();
            for (int i = 0; i < masters.Count; i++)
                if (masters[i].Nickname == nick) 
                    return masters[i].Id;
            return 0;
        }
    }
}
