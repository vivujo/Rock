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
    /// Provides data API endpoints for Workflow Action Forms.
    /// </summary>
    [RoutePrefix( "api/v2/models/workflowactionforms" )]
    [Rock.SystemGuid.RestControllerGuid( "925bb66f-cb64-5e89-97fb-87a7becaa276" )]
    public partial class WorkflowActionFormsController : ApiControllerBase
    {
        /// <summary>
        /// Gets a single item from the database.
        /// </summary>
        /// <param name="id">The identifier as either an Id, Guid or IdKey value.</param>
        /// <returns>The requested item.</returns>
        [HttpGet]
        [Route( "{id}" )]
        [Authenticate]
        [Secured( Security.Authorization.EXECUTE_UNRESTRICTED_READ )]
        [ExcludeSecurityActions( Security.Authorization.EXECUTE_READ, Security.Authorization.EXECUTE_WRITE, Security.Authorization.EXECUTE_UNRESTRICTED_WRITE )]
        [ProducesResponseType( HttpStatusCode.OK, Type = typeof( Rock.Model.WorkflowActionForm ) )]
        [ProducesResponseType( HttpStatusCode.BadRequest )]
        [ProducesResponseType( HttpStatusCode.NotFound )]
        [ProducesResponseType( HttpStatusCode.Unauthorized )]
        [SystemGuid.RestActionGuid( "1b0b3b06-bb13-5e63-a172-1ff1ff3f5ad4" )]
        public IActionResult GetItem( string id )
        {
            var helper = new CrudEndpointHelper<Rock.Model.WorkflowActionForm, Rock.Model.WorkflowActionFormService>( this );

            helper.IsSecurityIgnored = true;

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
        [Secured( Security.Authorization.EXECUTE_UNRESTRICTED_WRITE )]
        [ExcludeSecurityActions( Security.Authorization.EXECUTE_WRITE, Security.Authorization.EXECUTE_READ, Security.Authorization.EXECUTE_UNRESTRICTED_READ )]
        [ProducesResponseType( HttpStatusCode.Created, Type = typeof( CreatedAtResponseBag ) )]
        [ProducesResponseType( HttpStatusCode.BadRequest )]
        [ProducesResponseType( HttpStatusCode.NotFound )]
        [ProducesResponseType( HttpStatusCode.Unauthorized )]
        [SystemGuid.RestActionGuid( "d5a905af-35b0-50e1-9810-b245eb245605" )]
        public IActionResult PostItem( [FromBody] Rock.Model.WorkflowActionForm value )
        {
            var helper = new CrudEndpointHelper<Rock.Model.WorkflowActionForm, Rock.Model.WorkflowActionFormService>( this );

            helper.IsSecurityIgnored = true;

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
        [Secured( Security.Authorization.EXECUTE_UNRESTRICTED_WRITE )]
        [ExcludeSecurityActions( Security.Authorization.EXECUTE_WRITE, Security.Authorization.EXECUTE_READ, Security.Authorization.EXECUTE_UNRESTRICTED_READ )]
        [ProducesResponseType( HttpStatusCode.NoContent )]
        [ProducesResponseType( HttpStatusCode.BadRequest )]
        [ProducesResponseType( HttpStatusCode.NotFound )]
        [ProducesResponseType( HttpStatusCode.Unauthorized )]
        [SystemGuid.RestActionGuid( "954edce7-814d-5363-80f0-3c6a73ed5d4e" )]
        public IActionResult PutItem( string id, [FromBody] Rock.Model.WorkflowActionForm value )
        {
            var helper = new CrudEndpointHelper<Rock.Model.WorkflowActionForm, Rock.Model.WorkflowActionFormService>( this );

            helper.IsSecurityIgnored = true;

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
        [Secured( Security.Authorization.EXECUTE_UNRESTRICTED_WRITE )]
        [ExcludeSecurityActions( Security.Authorization.EXECUTE_WRITE, Security.Authorization.EXECUTE_READ, Security.Authorization.EXECUTE_UNRESTRICTED_READ )]
        [ProducesResponseType( HttpStatusCode.NoContent )]
        [ProducesResponseType( HttpStatusCode.BadRequest )]
        [ProducesResponseType( HttpStatusCode.NotFound )]
        [ProducesResponseType( HttpStatusCode.Unauthorized )]
        [SystemGuid.RestActionGuid( "2d1cc2bf-5707-5922-b570-1157e987dd47" )]
        public IActionResult PatchItem( string id, [FromBody] Dictionary<string, object> values )
        {
            var helper = new CrudEndpointHelper<Rock.Model.WorkflowActionForm, Rock.Model.WorkflowActionFormService>( this );

            helper.IsSecurityIgnored = true;

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
        [Secured( Security.Authorization.EXECUTE_UNRESTRICTED_WRITE )]
        [ExcludeSecurityActions( Security.Authorization.EXECUTE_WRITE, Security.Authorization.EXECUTE_READ, Security.Authorization.EXECUTE_UNRESTRICTED_READ )]
        [ProducesResponseType( HttpStatusCode.NoContent )]
        [ProducesResponseType( HttpStatusCode.BadRequest )]
        [ProducesResponseType( HttpStatusCode.NotFound )]
        [ProducesResponseType( HttpStatusCode.Unauthorized )]
        [SystemGuid.RestActionGuid( "8efeb907-374d-51dd-bb22-1018b6d8bcda" )]
        public IActionResult DeleteItem( string id )
        {
            var helper = new CrudEndpointHelper<Rock.Model.WorkflowActionForm, Rock.Model.WorkflowActionFormService>( this );

            helper.IsSecurityIgnored = true;

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
        [Secured( Security.Authorization.EXECUTE_UNRESTRICTED_READ )]
        [ExcludeSecurityActions( Security.Authorization.EXECUTE_READ, Security.Authorization.EXECUTE_WRITE, Security.Authorization.EXECUTE_UNRESTRICTED_WRITE )]
        [ProducesResponseType( HttpStatusCode.OK, Type = typeof( Dictionary<string, ModelAttributeValueBag> ) )]
        [ProducesResponseType( HttpStatusCode.BadRequest )]
        [ProducesResponseType( HttpStatusCode.NotFound )]
        [ProducesResponseType( HttpStatusCode.Unauthorized )]
        [SystemGuid.RestActionGuid( "ed628ccc-0b59-5218-a1f4-3c21d5c5c8f9" )]
        public IActionResult GetAttributeValues( string id )
        {
            var helper = new CrudEndpointHelper<Rock.Model.WorkflowActionForm, Rock.Model.WorkflowActionFormService>( this );

            helper.IsSecurityIgnored = true;

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
        [Secured( Security.Authorization.EXECUTE_UNRESTRICTED_WRITE )]
        [ExcludeSecurityActions( Security.Authorization.EXECUTE_WRITE, Security.Authorization.EXECUTE_READ, Security.Authorization.EXECUTE_UNRESTRICTED_READ )]
        [ProducesResponseType( HttpStatusCode.NoContent )]
        [ProducesResponseType( HttpStatusCode.BadRequest )]
        [ProducesResponseType( HttpStatusCode.NotFound )]
        [ProducesResponseType( HttpStatusCode.Unauthorized )]
        [SystemGuid.RestActionGuid( "c0bbec76-3698-55d0-931a-7279ffff8141" )]
        public IActionResult PatchAttributeValues( string id, [FromBody] Dictionary<string, string> values )
        {
            var helper = new CrudEndpointHelper<Rock.Model.WorkflowActionForm, Rock.Model.WorkflowActionFormService>( this );

            helper.IsSecurityIgnored = true;

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
        [SystemGuid.RestActionGuid( "4e346901-6a36-5faa-9d35-344a075a3256" )]
        public IActionResult PostSearch( [FromBody] EntitySearchQueryBag query )
        {
            var helper = new CrudEndpointHelper<Rock.Model.WorkflowActionForm, Rock.Model.WorkflowActionFormService>( this );

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
        [SystemGuid.RestActionGuid( "da4d28c5-0c27-52ff-874b-9eb2edf26cfd" )]
        public IActionResult GetSearchByKey( string searchKey )
        {
            var helper = new CrudEndpointHelper<Rock.Model.WorkflowActionForm, Rock.Model.WorkflowActionFormService>( this );

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
        [SystemGuid.RestActionGuid( "2adae197-9ce6-5843-9d24-657a33da1784" )]
        public IActionResult PostSearchByKey( string searchKey, [FromBody] EntitySearchQueryBag query )
        {
            var helper = new CrudEndpointHelper<Rock.Model.WorkflowActionForm, Rock.Model.WorkflowActionFormService>( this );

            helper.IsSecurityIgnored = IsCurrentPersonAuthorized( Security.Authorization.EXECUTE_UNRESTRICTED_READ );

            return helper.Search( searchKey, query );
        }
    }
}
