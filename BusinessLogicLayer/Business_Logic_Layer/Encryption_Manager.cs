using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEN381_PA1_Hagen_Johann.Database_Entities;
using SEN381_PA1_Hagen_Johann.Business_Logic_Layer.CRUD_Strategy;

namespace SEN381_PA1_Hagen_Johann.Business_Logic_Layer
{
    class Encryption_Manager // Class that will perform Encryption and Decryption
    {
        private int key; //cypher key for encryption
        private CRUDcontext crud = new CRUDcontext();
        public List<String> authenticateUser<T>()
        {
            List<User> users = crud.executeQuery<User>("User", "none", "Read");
            
            List<String> passwords = new List<string>();
            foreach (User user in users)
            {
               
              
            }
            return passwords;
        }
        public string EncryptPassword(string password)
        {
            
            return password;
        }
    }
}
