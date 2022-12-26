//  Author:
//       Julien Dubromez<j.dubromez.it@gmail.com>
//
//  Copyright (c) 2015 Teeknofil
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Text;

namespace crisis {
    /// <summary>
    /// Interface for Permutations, Combinations and any other classes that present
    /// a collection of collections based on an input collection.  The enumerators that 
    /// this class inherits defines the mechanism for enumerating through the collections.  
    /// </summary>
    /// <typeparam name="T">The of the elements in the collection, not the type of the collection.</typeparam>
    interface IMetaCollection<T> : IEnumerable<IList<T>> {
        /// <summary>
        /// The count of items in the collection.  This is not inherited from
        /// ICollection since this meta-collection cannot be extended by users.
        /// </summary>
        long Count { get; }

        /// <summary>
        /// The type of the meta-collection, determining how the collections are 
        /// determined from the inputs.
        /// </summary>
        GenerateOption Type { get; }

        /// <summary>
        /// The upper index of the meta-collection, which is the size of the input collection.
        /// </summary>
        int UpperIndex { get; }

        /// <summary>
        /// The lower index of the meta-collection, which is the size of each output collection.
        /// </summary>
        int LowerIndex { get; }
    }

}
