using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Entity
{
    internal class UserService
    {
        public Gpt_bot Add(int id, string promt, string last_message)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Gpt_bot gpt_Bot = new Gpt_bot() { Id = id, Promt = promt, Last_message = last_message };
                db.Gpt_bots.Add(gpt_Bot);
                db.SaveChanges();

                return gpt_Bot;
            }
        }
    }
}