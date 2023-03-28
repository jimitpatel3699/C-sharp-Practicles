using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Practicle7
{
    //Solid principle demo
    //SRP demo(Single Responsibility Principle)
    //class have only one reason to change.
    //I take senario of E-commerce site for perform SRP demo.where E-commrce site have muliple classes
    //and that classes have multiple responsibities,
    //but one class always responsible for handle one type responsibility.

    
    //Validate_Data class is used to validate user inserted data in signup and signin form.
    //according that validate_info() overloaded method called and that method passed comaands to other related methods.
    internal class ValidateData
    {
        
        public bool validate_info(string username, string password)
        {
            bool status = false;
            if (username!="" && password!="")
            {
                status = Login.Login_user(username, password);

            }
            if (status)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool validate_info(string username, string pass, double mobile, string bdate, string gender)
        {
            bool status = false;
            if (username != "" && pass != "" && mobile != null && bdate != "" && gender !="")
            {
                status = Register.Register_user(username, pass, mobile, bdate, gender);

            }
            if (status)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    //Login class which have only responsibility to check user data in db and available then select.
    internal static class Login
    {
        public static bool Login_user(string username, string pass)
        {
            //code select user data from database
              Console.WriteLine($"Welcome! {username}");
               return true;
            
           
            
        }
        
    }

    //Register class which have only responsibility to inseer user data in db it's responible for validate user data.

    internal static class Register
    {
        public static bool Register_user(string username, string pass, double mobile, string bdate, string gender)
        {

            //insert user data and register it in to db.
            Console.WriteLine("user register");
            return true;

        }

    }

    
}
