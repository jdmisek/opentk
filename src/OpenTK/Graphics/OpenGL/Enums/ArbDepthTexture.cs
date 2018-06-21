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

namespace OpenTK.Graphics.OpenGL
{
    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbDepthTexture
    {
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT16_ARB = 0x81A5
        /// </summary>
        DepthComponent16Arb = 0x81a5,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT24_ARB = 0x81A6
        /// </summary>
        DepthComponent24Arb = 0x81a6,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32_ARB = 0x81A7
        /// </summary>
        DepthComponent32Arb = 0x81a7,

        /// <summary>
        /// Original was GL_TEXTURE_DEPTH_SIZE_ARB = 0x884A
        /// </summary>
        TextureDepthSizeArb = 0x884a,

        /// <summary>
        /// Original was GL_DEPTH_TEXTURE_MODE_ARB = 0x884B
        /// </summary>
        DepthTextureModeArb = 0x884b
    }
}