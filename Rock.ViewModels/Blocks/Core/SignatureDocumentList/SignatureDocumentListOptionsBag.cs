﻿// <copyright>
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
//

namespace Rock.ViewModels.Blocks.Core.SignatureDocumentList
{
    /// <summary>
    /// The Signature Document List Options Bag
    /// </summary>
    public class SignatureDocumentListOptionsBag
    {
        /// <summary>
        /// Gets or sets the boolean value whether to show a document type.
        /// </summary>
        public bool ShowDocumentType { get; set; }

        /// <summary>
        /// Gets or set the boolean value determining who can view.
        /// </summary>
        public bool CanView { get; set; }
    }
}
