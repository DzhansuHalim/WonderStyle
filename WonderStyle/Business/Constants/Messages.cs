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
    }
}
