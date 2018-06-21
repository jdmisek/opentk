//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2015 Stefanos Apostolopoulos for the Open Toolkit Library
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//

using System;

namespace OpenTK.Graphics.ES20
{
    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SyncStatus
    {
        /// <summary>
        /// Original was GL_ALREADY_SIGNALED = 0x911A
        /// </summary>
        AlreadySignaled = 0x911a,

        /// <summary>
        /// Original was GL_TIMEOUT_EXPIRED = 0x911B
        /// </summary>
        TimeoutExpired = 0x911b,

        /// <summary>
        /// Original was GL_CONDITION_SATISFIED = 0x911C
        /// </summary>
        ConditionSatisfied = 0x911c,

        /// <summary>
        /// Original was GL_WAIT_FAILED = 0x911D
        /// </summary>
        WaitFailed = 0x911d
    }
}