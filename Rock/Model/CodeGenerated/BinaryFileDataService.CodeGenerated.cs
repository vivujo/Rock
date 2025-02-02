//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// <copyright>
// Copyright by the Spark Development Network
//
// Licensed under the Rock Community License (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.rockrms.com/license
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;

using Rock.Data;

namespace Rock.Model
{
    /// <summary>
    /// BinaryFileData Service class
    /// </summary>
    public partial class BinaryFileDataService : Service<BinaryFileData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BinaryFileDataService"/> class
        /// </summary>
        /// <param name="context">The context.</param>
        public BinaryFileDataService(RockContext context) : base(context)
        {
        }

        /// <summary>
        /// Determines whether this instance can delete the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="errorMessage">The error message.</param>
        /// <returns>
        ///   <c>true</c> if this instance can delete the specified item; otherwise, <c>false</c>.
        /// </returns>
        public bool CanDelete( BinaryFileData item, out string errorMessage )
        {
            errorMessage = string.Empty;
            return true;
        }
    }

    [HasQueryableAttributes( typeof( BinaryFileData.BinaryFileDataQueryableAttributeValue ), nameof( BinaryFileDataAttributeValues ) )]
    public partial class BinaryFileData
    {
        /// <summary>
        /// Gets the entity attribute values. This should only be used inside
        /// LINQ statements when building a where clause for the query. This
        /// property should only be used inside LINQ statements for filtering
        /// or selecting values. Do <b>not</b> use it for accessing the
        /// attributes after the entity has been loaded.
        /// </summary>
        public virtual ICollection<BinaryFileDataQueryableAttributeValue> BinaryFileDataAttributeValues { get; set; } 

        /// <inheritdoc/>
        public class BinaryFileDataQueryableAttributeValue : QueryableAttributeValue
        {
        }
    }

    /// <summary>
    /// Generated Extension Methods
    /// </summary>
    public static partial class BinaryFileDataExtensionMethods
    {
        /// <summary>
        /// Clones this BinaryFileData object to a new BinaryFileData object
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="deepCopy">if set to <c>true</c> a deep copy is made. If false, only the basic entity properties are copied.</param>
        /// <returns></returns>
        public static BinaryFileData Clone( this BinaryFileData source, bool deepCopy )
        {
            if (deepCopy)
            {
                return source.Clone() as BinaryFileData;
            }
            else
            {
                var target = new BinaryFileData();
                target.CopyPropertiesFrom( source );
                return target;
            }
        }

        /// <summary>
        /// Clones this BinaryFileData object to a new BinaryFileData object with default values for the properties in the Entity and Model base classes.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        public static BinaryFileData CloneWithoutIdentity( this BinaryFileData source )
        {
            var target = new BinaryFileData();
            target.CopyPropertiesFrom( source );

            target.Id = 0;
            target.Guid = Guid.NewGuid();
            target.ForeignKey = null;
            target.ForeignId = null;
            target.ForeignGuid = null;
            target.CreatedByPersonAliasId = null;
            target.CreatedDateTime = RockDateTime.Now;
            target.ModifiedByPersonAliasId = null;
            target.ModifiedDateTime = RockDateTime.Now;

            return target;
        }

        /// <summary>
        /// Copies the properties from another BinaryFileData object to this BinaryFileData object
        /// </summary>
        /// <param name="target">The target.</param>
        /// <param name="source">The source.</param>
        public static void CopyPropertiesFrom( this BinaryFileData target, BinaryFileData source )
        {
            target.Id = source.Id;
            target.Content = source.Content;
            target.ForeignGuid = source.ForeignGuid;
            target.ForeignKey = source.ForeignKey;
            target.CreatedDateTime = source.CreatedDateTime;
            target.ModifiedDateTime = source.ModifiedDateTime;
            target.CreatedByPersonAliasId = source.CreatedByPersonAliasId;
            target.ModifiedByPersonAliasId = source.ModifiedByPersonAliasId;
            target.Guid = source.Guid;
            target.ForeignId = source.ForeignId;

        }
    }
}
