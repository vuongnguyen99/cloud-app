﻿//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace cloudapp_core.Exception
//{
//    public class ValidationException : Exception
//    {
//        public IDictionary<string, string[]> Failures { get; } = new Dictionary<string, string[]>();
//        public IDictionary<string, object[]> ValidateFailures { get; } = new Dictionary<string, object[]>();
//        public ValidationException() : base("One or more validation failures have occurred.") { }
//        public ValidationException(string message) : base(message) { }
//        public ValidationException(IDictionary<string, string[]> failures) : this() => Failures = failures ?? throw new ArgumentNullException(nameof(failures));
//        public ValidationException(IDictionary<string, object[]> failures) : this() => ValidateFailures = failures ?? throw new ArgumentNullException(nameof(failures));

//    }
//}