namespace Mango.Web.Utility
{
    public class SD
    {
        public const string TokenCookie = "JWTToken";

        #region Base API URL
        public static string CouponAPIBase { get; set; }
        public static string ProductAPIBase { get; set; }
        public static string AuthAPIBase { get; set; }
        public static string ShoppingCartAPIBase { get; set; }
        public static string OrderAPIBase { get; set; }
        #endregion

        #region ROLE
        public const string RoleAdmin = "ADMIN";
        public const string RoleCustomer = "CUSTOMER"; 
        #endregion

        #region Enum API Type
        public enum ApiType
        {
            GET,
            POST,
            PUT,
            DELETE
        }
        #endregion

        #region Status
        public const string Status_Pending = "Pending";
        public const string Status_Approved = "Approved";
        public const string Status_ReadyForPickup = "ReadyForPickup";
        public const string Status_Completed = "Completed";
        public const string Status_Refunded = "Refunded";
        public const string Status_Cancelled = "Cancelled";
        #endregion

        #region Enum ContentType
        public enum ContentType
        {
            Json,
            MultipartFormData,
        } 
        #endregion
    }
}
