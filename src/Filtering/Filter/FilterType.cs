// <copyright file="IFilterFilterType.cs" company="Math.NET">
// Math.NET Filtering, part of the Math.NET Project
// http://filtering.mathdotnet.com
// http://github.com/mathnet/mathnet-filtering
//
// Copyright (c) 2009-2014 Math.NET
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
// </copyright>

namespace MathNet.Filtering.Filter
{
    /// <summary>
    /// Frequency Filter Type
    /// </summary>
    public enum FilterType
    {
        /// <summary>LowPass, lets only low frequencies pass.</summary>
        LowPass,

        /// <summary>HighPass, lets only high frequencies pass.</summary>
        HighPass,

        /// <summary>BandPass, lets only frequencies pass that are inside of a band.</summary>
        BandPass,

        /// <summary>BandStop, lets only frequencies pass that are outside of a band.</summary>
        BandStop,

        /// <summary>Other behavior.</summary>
        Other
    }
}
