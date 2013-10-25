using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccessLayer
{
    public class AdvantexeDataAccessLayer
    {
         private readonly AdvantexeEntities db;

         public AdvantexeDataAccessLayer()
        {
            db = new AdvantexeEntities();
        }

        public ManageLogin CheckValidUserInfo(ManageLogin LoginInfo)
        {

            ManageLogin Managelogin = new ManageLogin();
            var getManageloginInfo = from l in db.Users where l.EmailID == LoginInfo.UserName && l.Password == LoginInfo.Password select l;
            BusinessObject.ManageLogin log = new BusinessObject.ManageLogin();
            try
            {
                if (getManageloginInfo.Count() > 0)
                {
                    foreach (var item in getManageloginInfo)
                    {
                        log.UserName = item.EmailID;
                        log.Password = item.Password;
                    }
                }
               return log;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
