using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        //Success
        public static string DressAdded = "The dress is added";
        public static string ListedDresses = "The dresses are listed";


        //Error
        public static string DressNameInvalid = "The dress name is invalid";
        public static string MaintenanceTime = "Maintenance Time";

        public static string DressNameAlreadyExists = "Dress name already exsist";

        public static string AuthorizationDenied = "Authorization is Denied";

        public static string UserNotFound = "User is not foud";

        public static string PasswordError = "Password is not correct";

        public static string SuccessfulLogin = "Login success";

        public static string UserAlreadyExists = "User is already exists";

        public static string AccessTokenCreated = "Access token is created";

        public static string UserRegistered = " The user is registered";

        public static string UserAdded = "The user is added";

        public static string UserDeleted = "User is deleted";

        public static string UserUpdated = "The user is updated";
    }
}
