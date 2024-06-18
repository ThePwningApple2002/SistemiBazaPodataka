﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovacNaCudovistaLibrary
{
    public class ErrorMessage
    {
        public required int StatusCode { get; set; }
        public required string Message { get; set; }

        [SetsRequiredMembers]
        public ErrorMessage(string message, int statusCode = 400)
        {
            StatusCode = statusCode;
            Message = message;
        }
    }

}
