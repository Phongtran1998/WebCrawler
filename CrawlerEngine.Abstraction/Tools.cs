﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CrawlerEngine.Abstraction
{
    public class Tools
    {
        public static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using var sha256Hash = SHA256.Create();
            // ComputeHash - returns byte array  
            var bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

            // Convert byte array to a string   
            var builder = new StringBuilder();
            foreach (var t in bytes)
            {
                builder.Append(t.ToString("x2"));
            }
            return builder.ToString();
        }

        public static string StrDateTimeFormat = "yyyy-MM-dd HH:mm:ss.fff";
    }
}
