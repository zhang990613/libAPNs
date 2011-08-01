﻿// Copyright (C) <2011> by <Scott Moak>
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
namespace libAPNs.Connection
{
    using System.Security.Cryptography.X509Certificates;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    internal class SandboxFeedbackConnection : APNSConnection
    {
        internal const string Feedback_Sandbox_Host = "feedback.sandbox.push.apple.com";
        internal const int Feedback_Sandbox_Port = 2196;

        public SandboxFeedbackConnection(X509Certificate2 certificate) : base(certificate)
        {
            this.host = Feedback_Sandbox_Host;
            this.port = Feedback_Sandbox_Port;
        }
    }
}