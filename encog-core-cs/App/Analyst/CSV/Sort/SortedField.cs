/*
 * Encog(tm) Core v3.0 - Java Version
 * http://www.heatonresearch.com/encog/
 * http://code.google.com/p/encog-java/
 
 * Copyright 2008-2011 Heaton Research, Inc.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *   
 * For more information on Heaton Research copyrights, licenses 
 * and trademarks visit:
 * http://www.heatonresearch.com/copyright
 */
// --------------------------------------------------------------------------------------------------
// This file was automatically generated by J2CS Translator (http://j2cstranslator.sourceforge.net/). 
// Version 1.3.6.20110331_01     
// 5/5/11 3:32 PM    
// ${CustomMessageForDisclaimer}                                                                             
// --------------------------------------------------------------------------------------------------
using System;
using System.Text;

namespace Encog.App.Analyst.CSV.Sort
{
    /// <summary>
    /// Specifies how a field is to be sorted by SortCSV.
    /// </summary>
    ///
    public class SortedField
    {
        /// <summary>
        /// The index of the field.
        /// </summary>
        ///
        private int index;

        /// <summary>
        /// The type of sort.
        /// </summary>
        ///
        private SortType sortType;

        /// <summary>
        /// Construct the object.
        /// </summary>
        ///
        /// <param name="theIndexindex">The index of the sorted field.</param>
        /// <param name="t">The type of sort, the type of object.</param>
        /// <param name="theAscending">True, if this is an ascending sort.</param>
        public SortedField(int theIndexindex, SortType t,
                           bool theAscending)
        {
            index = theIndexindex;
            Ascending = theAscending;
            sortType = t;
        }


        /// <value>the index to set</value>
        public int Index
        {
            /// <returns>the index</returns>
            get { return index; }
            /// <param name="theIndex">the index to set</param>
            set { index = value; }
        }


        /// <value>the sortType to set</value>
        public SortType SortType
        {
            /// <returns>the sortType</returns>
            get { return sortType; }
            /// <param name="theSortType">the sortType to set</param>
            set { sortType = value; }
        }


        /// <value>the ascending to set</value>
        public bool Ascending { /// <returns>the ascending</returns>
            get; /// <param name="theAscending">the ascending to set</param>
            set; }


        /// <summary>
        /// 
        /// </summary>
        ///
        public override sealed String ToString()
        {
            var result = new StringBuilder("[");
            result.Append(GetType().Name);
            result.Append(" index=");
            result.Append(index);
            result.Append(", type=");
            result.Append(sortType);

            result.Append("]");
            return result.ToString();
        }
    }
}