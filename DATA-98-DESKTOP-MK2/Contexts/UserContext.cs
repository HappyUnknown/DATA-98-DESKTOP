using DATA_98_DESKTOP_MK2.Entities;
using DATA_98_DESKTOP_MK2.Extensions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_98_DESKTOP_MK2.Contexts
{
    class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public UserContext() : base("Data98Connection")
        {

        }
        public bool NicknameRegistered(string nick)
        {
            List<User> users = Users.ToList();
            for (int i = 0; i < users.Count; i++)
                if (nick == users[i].Nickname)
                    return true;
            return false;
        }

        public User LogMasterIn(string nick, string pass)
        {
            List<User> users = Users.ToList();
            for (int i = 0; i < users.Count; i++)
                if (nick == users[i].Nickname && pass.HashMD5() == users[i].PassMD5)
                    return users[i];
            return null;
        }

        public int NextId()
        {
            int? maxID = Users.Max(x => x.ID);
            if (maxID == null) { return 0; }
            else return -1;
            int nextID = maxID.Value + 1;
            return nextID;
        }

        public int GetNicknameId(string nick)
        {
            List<User> masters = Users.ToList();
            for (int i = 0; i < masters.Count; i++)
                if (masters[i].Nickname == nick)
                    return masters[i].ID;
            return 0;
        }
        public string GetNicknameById(int id)
        {
            List<User> masters = Users.ToList();
            for (int i = 0; i < masters.Count; i++)
                if (masters[i].ID == id)
                    return masters[i].Nickname;
            return "NO_NICKNAME";
        }
    }
}
