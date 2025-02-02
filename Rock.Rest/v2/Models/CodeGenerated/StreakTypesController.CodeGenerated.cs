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
//

using System.Collections.Generic;
using System.Net;

using Microsoft.AspNetCore.Mvc;

using Rock.Rest.Filters;
using Rock.Security;
using Rock.ViewModels.Core;
using Rock.ViewModels.Rest.Models;

namespace Rock.Rest.v2.Models
{
#if WEBFORMS
    using FromBodyAttribute = System.Web.Http.FromBodyAttribute;
    using IActionResult = System.Web.Http.IHttpActionResult;
    using RoutePrefixAttribute = System.Web.Http.RoutePrefixAttribute;
    using RouteAttribute = System.Web.Http.RouteAttribute;
    using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
    using HttpPostAttribute = System.Web.Http.HttpPostAttribute;
    using HttpPutAttribute = System.Web.Http.HttpPutAttribute;
    using HttpPatchAttribute = System.Web.Http.HttpPatchAttribute;
    using HttpDeleteAttribute = System.Web.Http.HttpDeleteAttribute;
#endif

    /// <summary>
    /// Provides data API endpoints for Streak Types.
    /// </summary>
    [RoutePrefix( "api/v2/models/streaktypes" )]
    [Rock.SystemGuid.RestControllerGuid( "07fa0f40-89cc-5de5-951f-51ae047590cb" )]
    public partial class StreakTypesController : ApiControllerBase
    {
        /// <summary>
        /// Gets a single item from the database.
        /// </summary>
        /// <param name="id">The identifier as either an Id, Guid or IdKey value.</param>
        /// <returns>The requested item.</returns>
        [HttpGet]
        [Route( "{id}" )]
        [Authenticate]
        [Secured( Security.Authorization.EXECUTE_READ )]
        [ExcludeSecurityActions( Security.Authorization.EXECUTE_WRITE, Security.Authorization.EXECUTE_UNRESTRICTED_WRITE )]
        [ProducesResponseType( HttpStatusCode.OK, Type = typeof( Rock.Model.StreakType ) )]
        [ProducesResponseType( HttpStatusCode.BadRequest )]
        [ProducesResponseType( HttpStatusCode.NotFound )]
        [ProducesResponseType( HttpStatusCode.Unauthorized )]
        [SystemGuid.RestActionGuid( "d33d6b75-c55e-5cfa-924c-660272502405" )]
        public IActionResult GetItem( string id )
        {
            var helper = new CrudEndpointHelper<Rock.Model.StreakType, Rock.Model.StreakTypeService>( this );

            helper.IsSecurityIgnored = IsCurrentPersonAuthorized( Security.Authorization.EXECUTE_UNRESTRICTED_READ );

            return helper.Get( id );
        }

        /// <summary>
        /// Creates a new item in the database.
        /// </summary>
        /// <param name="value">The item to be created.</param>
        /// <returns>An object that contains the new identifier values.</returns>
        [HttpPost]
        [Route( "" )]
        [Authenticate]
        [Secured( Security.Authorization.EXECUTE_WRITE )]
        [ExcludeSecurityActions( Security.Authorization.EXECUTE_READ, Security.Authorization.EXECUTE_UNRESTRICTED_READ )]
        [ProducesResponseType( HttpStatusCode.Created, Type = typeof( CreatedAtResponseBag ) )]
        [ProducesResponseType( HttpStatusCode.BadRequest )]
        [ProducesResponseType( HttpStatusCode.NotFound )]
        [ProducesResponseType( HttpStatusCode.Unauthorized )]
        [SystemGuid.RestActionGuid( "10ea0db4-fc3d-5175-9d02-731b956c70fd" )]
        public IActionResult PostItem( [FromBody] Rock.Model.StreakType value )
        {
            var helper = new CrudEndpointHelper<Rock.Model.StreakType, Rock.Model.StreakTypeService>( this );

            helper.IsSecurityIgnored = IsCurrentPersonAuthorized( Security.Authorization.EXECUTE_UNRESTRICTED_WRITE );

            return helper.Create( value );
        }

        /// <summary>
        /// Performs a full update of the item. All property values must be
        /// specified.
        /// </summary>
        /// <param name="id">The identifier as either an Id, Guid or IdKey value.</param>
        /// <param name="value">The item that represents all the new values.</param>
        /// <returns>An empty response.</returns>
        [HttpPut]
        [Route( "{id}" )]
        [Authenticate]
        [Secured( Security.Authorization.EXECUTE_WRITE )]
        [ExcludeSecurityActions( Security.Authorization.EXECUTE_READ, Security.Authorization.EXECUTE_UNRESTRICTED_READ )]
        [ProducesResponseType( HttpStatusCode.NoContent )]
        [ProducesResponseType( HttpStatusCode.BadRequest )]
        [ProducesResponseType( HttpStatusCode.NotFound )]
        [ProducesResponseType( HttpStatusCode.Unauthorized )]
        [SystemGuid.RestActionGuid( "b6aade86-ecf4-5176-827b-0c6f26543f8a" )]
        public IActionResult PutItem( string id, [FromBody] Rock.Model.StreakType value )
        {
            var helper = new CrudEndpointHelper<Rock.Model.StreakType, Rock.Model.StreakTypeService>( this );

            helper.IsSecurityIgnored = IsCurrentPersonAuthorized( Security.Authorization.EXECUTE_UNRESTRICTED_WRITE );

            return helper.Update( id, value );
        }

        /// <summary>
        /// Performs a partial update of the item. Only specified property keys
        /// will be updated.
        /// </summary>
        /// <param name="id">The identifier as either an Id, Guid or IdKey value.</param>
        /// <param name="values">An object that identifies the properties and values to be updated.</param>
        /// <returns>An empty response.</returns>
        [HttpPatch]
        [Route( "{id}" )]
        [Authenticate]
        [Secured( Security.Authorization.EXECUTE_WRITE )]
        [ExcludeSecurityActions( Security.Authorization.EXECUTE_READ, Security.Authorization.EXECUTE_UNRESTRICTED_READ )]
        [ProducesResponseType( HttpStatusCode.NoContent )]
        [ProducesResponseType( HttpStatusCode.BadRequest )]
        [ProducesResponseType( HttpStatusCode.NotFound )]
        [ProducesResponseType( HttpStatusCode.Unauthorized )]
        [SystemGuid.RestActionGuid( "b7c6e93a-572a-5554-8633-aa01ff47bbba" )]
        public IActionResult PatchItem( string id, [FromBody] Dictionary<string, object> values )
        {
            var helper = new CrudEndpointHelper<Rock.Model.StreakType, Rock.Model.StreakTypeService>( this );

            helper.IsSecurityIgnored = IsCurrentPersonAuthorized( Security.Authorization.EXECUTE_UNRESTRICTED_WRITE );

            return helper.Patch( id, values );
        }

        /// <summary>
        /// Deletes a single item from the database.
        /// </summary>
        /// <param name="id">The identifier as either an Id, Guid or IdKey value.</param>
        /// <returns>An empty response.</returns>
        [HttpDelete]
        [Route( "{id}" )]
        [Authenticate]
        [Secured( Security.Authorization.EXECUTE_WRITE )]
        [ExcludeSecurityActions( Security.Authorization.EXECUTE_READ, Security.Authorization.EXECUTE_UNRESTRICTED_READ )]
        [ProducesResponseType( HttpStatusCode.NoContent )]
        [ProducesResponseType( HttpStatusCode.BadRequest )]
        [ProducesResponseType( HttpStatusCode.NotFound )]
        [ProducesResponseType( HttpStatusCode.Unauthorized )]
        [SystemGuid.RestActionGuid( "03d7b73c-72e2-5d0d-a873-c305ae2b537c" )]
        public IActionResult DeleteItem( string id )
        {
            var helper = new CrudEndpointHelper<Rock.Model.StreakType, Rock.Model.StreakTypeService>( this );

            helper.IsSecurityIgnored = IsCurrentPersonAuthorized( Security.Authorization.EXECUTE_UNRESTRICTED_WRITE );

            return helper.Delete( id );
        }

        /// <summary>
        /// Gets all the attribute values for the specified item.
        /// </summary>
        /// <param name="id">The identifier as either an Id, Guid or IdKey value.</param>
        /// <returns>An array of objects that represent all the attribute values.</returns>
        [HttpGet]
        [Route( "{id}/attributevalues" )]
        [Authenticate]
        [Secured( Security.Authorization.EXECUTE_READ )]
        [ExcludeSecurityActions( Security.Authorization.EXECUTE_WRITE, Security.Authorization.EXECUTE_UNRESTRICTED_WRITE )]
        [ProducesResponseType( HttpStatusCode.OK, Type = typeof( Dictionary<string, ModelAttributeValueBag> ) )]
        [ProducesResponseType( HttpStatusCode.BadRequest )]
        [ProducesResponseType( HttpStatusCode.NotFound )]
        [ProducesResponseType( HttpStatusCode.Unauthorized )]
        [SystemGuid.RestActionGuid( "8cc26e89-343a-5a20-b37f-813c37fe4c6d" )]
        public IActionResult GetAttributeValues( string id )
        {
            var helper = new CrudEndpointHelper<Rock.Model.StreakType, Rock.Model.StreakTypeService>( this );

            helper.IsSecurityIgnored = IsCurrentPersonAuthorized( Security.Authorization.EXECUTE_UNRESTRICTED_READ );

            return helper.GetAttributeValues( id );
        }

        /// <summary>
        /// Performs a partial update of attribute values for the item. Only
        /// attributes specified will be updated.
        /// </summary>
        /// <param name="id">The identifier as either an Id, Guid or IdKey value.</param>
        /// <param name="values">An object that identifies the attribute keys and raw values to be updated.</param>
        /// <returns>An empty response.</returns>
        [HttpPatch]
        [Route( "{id}/attributevalues" )]
        [Authenticate]
        [Secured( Security.Authorization.EXECUTE_WRITE )]
        [ExcludeSecurityActions( Security.Authorization.EXECUTE_READ, Security.Authorization.EXECUTE_UNRESTRICTED_READ )]
        [ProducesResponseType( HttpStatusCode.NoContent )]
        [ProducesResponseType( HttpStatusCode.BadRequest )]
        [ProducesResponseType( HttpStatusCode.NotFound )]
        [ProducesResponseType( HttpStatusCode.Unauthorized )]
        [SystemGuid.RestActionGuid( "e4b1d237-3ace-5e3c-b550-696e93637b6b" )]
        public IActionResult PatchAttributeValues( string id, [FromBody] Dictionary<string, string> values )
        {
            var helper = new CrudEndpointHelper<Rock.Model.StreakType, Rock.Model.StreakTypeService>( this );

            helper.IsSecurityIgnored = IsCurrentPersonAuthorized( Security.Authorization.EXECUTE_UNRESTRICTED_WRITE );

            return helper.PatchAttributeValues( id, values );
        }

        /// <summary>
        /// Performs a search of items using the specified user query.
        /// </summary>
        /// <param name="query">Query options to be applied.</param>
        /// <returns>An array of objects returned by the query.</returns>
        [HttpPost]
        [Route( "search" )]
        [Authenticate]
        [Secured( Security.Authorization.EXECUTE_UNRESTRICTED_READ )]
        [ExcludeSecurityActions( Security.Authorization.EXECUTE_READ, Security.Authorization.EXECUTE_WRITE, Security.Authorization.EXECUTE_UNRESTRICTED_WRITE )]
        [ProducesResponseType( HttpStatusCode.OK, Type = typeof( object ) )]
        [SystemGuid.RestActionGuid( "ec9e309c-5cb0-51a2-bf74-af0f34c1afa6" )]
        public IActionResult PostSearch( [FromBody] EntitySearchQueryBag query )
        {
            var helper = new CrudEndpointHelper<Rock.Model.StreakType, Rock.Model.StreakTypeService>( this );

            return helper.Search( query );
        }

        /// <summary>
        /// Performs a search of items using the specified system query.
        /// </summary>
        /// <param name="searchKey">The key that identifies the entity search query to execute.</param>
        /// <returns>An array of objects returned by the query.</returns>
        [HttpGet]
        [Route( "search/{searchKey}" )]
        [Authenticate]
        [Secured( Security.Authorization.EXECUTE_READ )]
        [ExcludeSecurityActions( Security.Authorization.EXECUTE_WRITE, Security.Authorization.EXECUTE_UNRESTRICTED_WRITE )]
        [ProducesResponseType( HttpStatusCode.OK, Type = typeof( object ) )]
        [ProducesResponseType( HttpStatusCode.NotFound )]
        [ProducesResponseType( HttpStatusCode.Unauthorized )]
        [SystemGuid.RestActionGuid( "1cccf756-f2c2-5c1a-9d07-8445ebcfc9c5" )]
        public IActionResult GetSearchByKey( string searchKey )
        {
            var helper = new CrudEndpointHelper<Rock.Model.StreakType, Rock.Model.StreakTypeService>( this );

            helper.IsSecurityIgnored = IsCurrentPersonAuthorized( Security.Authorization.EXECUTE_UNRESTRICTED_READ );

            return helper.Search( searchKey, null );
        }

        /// <summary>
        /// Performs a search of items using the specified system query.
        /// </summary>
        /// <param name="query">Additional query refinement options to be applied.</param>
        /// <param name="searchKey">The key that identifies the entity search query to execute.</param>
        /// <returns>An array of objects returned by the query.</returns>
        [HttpPost]
        [Route( "search/{searchKey}" )]
        [Authenticate]
        [Secured( Security.Authorization.EXECUTE_READ )]
        [ExcludeSecurityActions( Security.Authorization.EXECUTE_WRITE, Security.Authorization.EXECUTE_UNRESTRICTED_WRITE )]
        [ProducesResponseType( HttpStatusCode.OK, Type = typeof( object ) )]
        [ProducesResponseType( HttpStatusCode.BadRequest )]
        [ProducesResponseType( HttpStatusCode.NotFound )]
        [ProducesResponseType( HttpStatusCode.Unauthorized )]
        [SystemGuid.RestActionGuid( "ce127f25-5ab7-53a1-880a-345640c99b38" )]
        public IActionResult PostSearchByKey( string searchKey, [FromBody] EntitySearchQueryBag query )
        {
            var helper = new CrudEndpointHelper<Rock.Model.StreakType, Rock.Model.StreakTypeService>( this );

            helper.IsSecurityIgnored = IsCurrentPersonAuthorized( Security.Authorization.EXECUTE_UNRESTRICTED_READ );

            return helper.Search( searchKey, query );
        }
    }
}
