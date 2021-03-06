﻿using System;
using System.Text;

namespace MsieJavaScriptEngine.Test.Common.Interop
{
	public static class Base64Encoder
	{
		public const int DATA_URI_MAX = 32768;


		public static string Encode(string value)
		{
			return Convert.ToBase64String(Encoding.GetEncoding(0).GetBytes(value));
		}
	}
}