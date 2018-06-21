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

namespace OpenTK.Graphics.ES30
{
    /// <summary>
    /// Used in GL.CompressedTexSubImage2D, GL.CompressedTexSubImage3D and 15 other functions
    /// </summary>
    public enum PixelFormat
    {
        /// <summary>
        /// Original was GL_Alpha = 0X1906
        /// </summary>
        Alpha = 0X1906,

        /// <summary>
        /// Original was GL_Rgb = 0X1907
        /// </summary>
        Rgb = 0X1907,

        /// <summary>
        /// Original was GL_Rgba = 0X1908
        /// </summary>
        Rgba = 0X1908,

        /// <summary>
        /// Original was GL_Luminance = 0X1909
        /// </summary>
        Luminance = 0X1909,

        /// <summary>
        /// Original was GL_UNSIGNED_SHORT = 0x1403
        /// </summary>
        UnsignedShort = 0x1403,

        /// <summary>
        /// Original was GL_UNSIGNED_INT = 0x1405
        /// </summary>
        UnsignedInt = 0x1405,

        /// <summary>
        /// Original was GL_COLOR_INDEX = 0x1900
        /// </summary>
        ColorIndex = 0x1900,

        /// <summary>
        /// Original was GL_STENCIL_INDEX = 0x1901
        /// </summary>
        StencilIndex = 0x1901,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT = 0x1902
        /// </summary>
        DepthComponent = 0x1902,

        /// <summary>
        /// Original was GL_RED = 0x1903
        /// </summary>
        Red = 0x1903,

        /// <summary>
        /// Original was GL_RED_EXT = 0x1903
        /// </summary>
        RedExt = 0x1903,

        /// <summary>
        /// Original was GL_GREEN = 0x1904
        /// </summary>
        Green = 0x1904,

        /// <summary>
        /// Original was GL_BLUE = 0x1905
        /// </summary>
        Blue = 0x1905,

        /// <summary>
        /// Original was GL_LUMINANCE_ALPHA = 0x190A
        /// </summary>
        LuminanceAlpha = 0x190a,

        /// <summary>
        /// Original was GL_R = 0x2002
        /// </summary>
        R = 0x2002,

        /// <summary>
        /// Original was GL_ABGR_EXT = 0x8000
        /// </summary>
        AbgrExt = 0x8000,

        /// <summary>
        /// Original was GL_CMYK_EXT = 0x800C
        /// </summary>
        CmykExt = 0x800c,

        /// <summary>
        /// Original was GL_CMYKA_EXT = 0x800D
        /// </summary>
        CmykaExt = 0x800d,

        /// <summary>
        /// Original was GL_YCRCB_422_SGIX = 0x81BB
        /// </summary>
        Ycrcb422Sgix = 0x81bb,

        /// <summary>
        /// Original was GL_YCRCB_444_SGIX = 0x81BC
        /// </summary>
        Ycrcb444Sgix = 0x81bc,

        /// <summary>
        /// Original was GL_RG = 0x8227
        /// </summary>
        Rg = 0x8227,

        /// <summary>
        /// Original was GL_RG_INTEGER = 0x8228
        /// </summary>
        RgInteger = 0x8228,

        /// <summary>
        /// Original was GL_DEPTH_STENCIL = 0x84F9
        /// </summary>
        DepthStencil = 0x84f9,

        /// <summary>
        /// Original was GL_RED_INTEGER = 0x8D94
        /// </summary>
        RedInteger = 0x8d94,

        /// <summary>
        /// Original was GL_RGB_INTEGER = 0x8D98
        /// </summary>
        RgbInteger = 0x8d98,

        /// <summary>
        /// Original was GL_RGBA_INTEGER = 0x8D99
        /// </summary>
        RgbaInteger = 0x8d99
    }
}