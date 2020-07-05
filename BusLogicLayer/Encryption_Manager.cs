using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatAccessLayer;
using System.Data;

namespace BusLogicLayer
{
    class Encryption_Manager // Class that will perform Encryption and Decryption
    {
        private int key; //cypher key for encryption
        private CRUDcontext crud = new CRUDcontext();
        public List<String> authenticateUser<T>()
        {
            DataSet data = crud.executeQuery("tblUser", "none", "Read");
            
            List<String> passwords = new List<string>();
            foreach (DataTable dt in data.Tables)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    passwords.Add(dr.ItemArray[4].ToString());
                }
              
            }
            foreach (String password in passwords)
            {
                //Decrypt
            }
            return passwords;
        }
        public string EncryptPassword(string password)
        {
            
            return password;
        }
    }
}
