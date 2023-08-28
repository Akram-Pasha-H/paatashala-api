using PaatashalaApi.DTOs;
using PaatashalaApi.Models;
using System.Security.Cryptography;
using System.Text;

namespace PaatashalaApi.HelperObject
{
    public class TokenHelper
    {
        private const string _alg = "HmacSHA256";
        private const string _salt = "rz8LuOtFBXphj9WQfvFh";
        private static int _expirationMinutes = 43800;
        public static string GenerateToken(string username, string password, long ticks)
        {
            string hash = string.Join(":", new string[] { username, ticks.ToString() });
            string hashLeft = "";
            string hashRight = "";
            using (HMAC hmac = HMACSHA256.Create(_alg))
            {
                hmac.Key = Encoding.UTF8.GetBytes(SMSDataformatter.EncryptText(password));
                hmac.ComputeHash(Encoding.UTF8.GetBytes(hash));
                hashLeft = Convert.ToBase64String(hmac.Hash);
                hashRight = string.Join(":", new string[] { username, ticks.ToString() });
            }
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Join(":", hashLeft, hashRight)));
        }
        public static bool IsTokenValid(string token, out string message)
        {
            message = "Access Denied!";
            bool result = false;
            try
            {
                string key = Encoding.UTF8.GetString(Convert.FromBase64String(token));
                string[] parts = key.Split(new char[] { ':' });
                if (parts.Length == 3)
                {
                    string hash = parts[0];
                    string username = parts[1];
                    long ticks = long.Parse(parts[2]);
                    DateTime timeStamp = new DateTime(ticks);
                    bool expired = Math.Abs((DateTime.UtcNow - timeStamp).TotalMinutes) > _expirationMinutes;
                    if (!expired)
                    {
                        using (WebSchoolContext db = new WebSchoolContext())
                        {
                            var user = db.TblAppLogins.FirstOrDefault(f => f.Email == username);
                            if (user != null)
                            {
                                string computedToken = GenerateToken(username, user.Password, ticks);
                                result = (token == computedToken);
                            }
                            if (!result)
                            {
                                var empUser = db.TblLogins.FirstOrDefault(f => f.UserName == username);
                                if (empUser != null)
                                {
                                    string computedToken = GenerateToken(username, empUser.Password, ticks);
                                    result = (token == computedToken);
                                }
                            }

                            if (!result)
                            {
                                message = "Access Denied!";
                            }
                        }
                    }
                    else
                    {
                        message = "Token Expired!";
                    }
                }
                else
                {
                    message = "Invalid Token";
                }
            }
            catch
            {
            }
            return result;
        }


    }
}

