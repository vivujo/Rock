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
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Runtime.Serialization;
using Rock.Data;

namespace Rock.Model
{
    /// <summary>
    /// Information about of the set of attendance records for the people that were checked-in.
    /// This helps group attendances together when multiple people were checked in during the same checkin session.
    /// </summary>
    [RockDomain( "Event" )]
    [Table( "AttendanceCheckInSession" )]
    [DataContract]
    [CodeGenerateRest( DisableEntitySecurity = true )]
    [Rock.SystemGuid.EntityTypeGuid( "D60A20A7-98A2-45B5-BF7E-A327E4090940")]
    public class AttendanceCheckInSession : Entity<AttendanceCheckInSession>
    {
        #region Entity Properties

        /// <summary>
        /// Gets or sets the Id of the <see cref="Rock.Model.Device"/> that was used (the device where the person checked in from).
        /// </summary>
        /// <value>
        /// A <see cref="System.Int32"/> representing the Id of the <see cref="Rock.Model.Device"/> that was used.
        /// </value>
        [DataMember]
        public int? DeviceId { get; set; }

        /// <summary>
        /// Gets or sets the client ip address.
        /// </summary>
        /// <value>
        /// The client ip address.
        /// </value>
        [DataMember]
        [MaxLength( 45 )]
        public string ClientIpAddress { get; set; }

        #endregion Entity Properties

        #region Navigation Properties

        /// <summary>
        /// Gets or sets the <see cref="Rock.Model.Device"/> that was used to check in
        /// </summary>
        /// <value>
        /// The <see cref="Rock.Model.Device"/> that was used to check in
        /// </value>
        [DataMember]
        public virtual Device Device { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Rock.Model.Attendance">Attendances</see> associated with this session
        /// </summary>
        /// <value>
        /// The attendances.
        /// </value>
        [DataMember]
        public virtual ICollection<Attendance> Attendances { get; set; }

        #endregion Navigation Properties
    }

    /// <summary>
    /// 
    /// </summary>
    public class AttendanceCheckInSessionConfiguration : EntityTypeConfiguration<AttendanceCheckInSession>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttendanceCheckInSessionConfiguration"/> class.
        /// </summary>
        public AttendanceCheckInSessionConfiguration()
        {
            this.HasOptional( c => c.Device ).WithMany().HasForeignKey( c => c.DeviceId ).WillCascadeOnDelete( false );

            // the Migration will manually add a ON DELETE SET NULL for AttendanceCheckInSessionId
            this.HasMany( c => c.Attendances ).WithOptional( a => a.AttendanceCheckInSession ).HasForeignKey( a => a.AttendanceCheckInSessionId ).WillCascadeOnDelete( true );
        }
    }
}
