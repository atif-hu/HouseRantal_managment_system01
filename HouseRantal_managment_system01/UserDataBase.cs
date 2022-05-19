using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HouseRantal_managment_system01
{
    public class UserDataBase
    {
        public static List<User> GetUsers()

{

            List<User> userList = new List<User>()

{

new User(){UserID=0, UserName="Dev", UserEmail="Dev@gmail.com",Password="85675",City="Pune"},

new User(){UserID=1, UserName="Atif Hussain", UserEmail="Atif@gmail.com",Password="98637851",City="gya"},

new User(){UserID=2, UserName="Tarang Bisen", UserEmail="Tarang@gmail.com",Password="967346",City="Hyd"},

new User(){UserID=3, UserName="Aryan", UserEmail="Aryan@gmail.com",Password="54764596648",City="Mumbai"},

new User(){UserID=4, UserName="Anshuman", UserEmail="Anshuman123@gmail.com",Password="qwert",City="Chennai"},

new User(){UserID=5, UserName="Kartik", UserEmail="Kartik123@gmail.com",Password="abcde",City="Jaipur"}

};

            return userList;

        }
    }
}
