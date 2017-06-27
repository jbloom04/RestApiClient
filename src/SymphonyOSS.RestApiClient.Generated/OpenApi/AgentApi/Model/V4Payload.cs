﻿// Licensed to the Symphony Software Foundation (SSF) under one
// or more contributor license agreements.  See the NOTICE file
// distributed with this work for additional information
// regarding copyright ownership.  The SSF licenses this file
// to you under the Apache License, Version 2.0 (the
// "License"); you may not use this file except in compliance
// with the License.  You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, either express or implied.  See the License for the
// specific language governing permissions and limitations
// under the License.
/* 
 * Agent API
 *
 * This document refers to Symphony API calls to send and receive messages and content. They need the on-premise Agent installed to perform decryption/encryption of content.  - sessionToken and keyManagerToken can be obtained by calling the authenticationAPI on the symphony back end and the key manager respectively. Refer to the methods described in authenticatorAPI.yaml. - Actions are defined to be atomic, ie will succeed in their entirety or fail and have changed nothing. - If it returns a 40X status then it will have sent no message to any stream even if a request to aome subset of the requested streams would have succeeded. - If this contract cannot be met for any reason then this is an error and the response code will be 50X. - MessageML is a markup language for messages. See reference here: https://developers.symphony.com/documentation/message_format_reference 
 *
 * OpenAPI spec version: current
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace SymphonyOSS.RestApiClient.Generated.OpenApi.AgentApi.Model
{
    /// <summary>
    /// V4Payload
    /// </summary>
    [DataContract]
    public partial class V4Payload :  IEquatable<V4Payload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V4Payload" /> class.
        /// </summary>
        /// <param name="MessageSent">MessageSent.</param>
        /// <param name="SharedPost">SharedPost.</param>
        /// <param name="InstantMessageCreated">InstantMessageCreated.</param>
        /// <param name="RoomCreated">RoomCreated.</param>
        /// <param name="RoomUpdated">RoomUpdated.</param>
        /// <param name="RoomDeactivated">RoomDeactivated.</param>
        /// <param name="RoomReactivated">RoomReactivated.</param>
        /// <param name="UserJoinedRoom">UserJoinedRoom.</param>
        /// <param name="UserLeftRoom">UserLeftRoom.</param>
        /// <param name="RoomMemberPromotedToOwner">RoomMemberPromotedToOwner.</param>
        /// <param name="RoomMemberDemotedFromOwner">RoomMemberDemotedFromOwner.</param>
        /// <param name="ConnectionRequested">ConnectionRequested.</param>
        /// <param name="ConnectionAccepted">ConnectionAccepted.</param>
        /// <param name="MessageSuppressed">MessageSuppressed.</param>
        public V4Payload(V4MessageSent MessageSent = default(V4MessageSent), V4SharedPost SharedPost = default(V4SharedPost), V4InstantMessageCreated InstantMessageCreated = default(V4InstantMessageCreated), V4RoomCreated RoomCreated = default(V4RoomCreated), V4RoomUpdated RoomUpdated = default(V4RoomUpdated), V4RoomDeactivated RoomDeactivated = default(V4RoomDeactivated), V4RoomReactivated RoomReactivated = default(V4RoomReactivated), V4UserJoinedRoom UserJoinedRoom = default(V4UserJoinedRoom), V4UserLeftRoom UserLeftRoom = default(V4UserLeftRoom), V4RoomMemberPromotedToOwner RoomMemberPromotedToOwner = default(V4RoomMemberPromotedToOwner), V4RoomMemberDemotedFromOwner RoomMemberDemotedFromOwner = default(V4RoomMemberDemotedFromOwner), V4ConnectionRequested ConnectionRequested = default(V4ConnectionRequested), V4ConnectionAccepted ConnectionAccepted = default(V4ConnectionAccepted), V4MessageSuppressed MessageSuppressed = default(V4MessageSuppressed))
        {
            this.MessageSent = MessageSent;
            this.SharedPost = SharedPost;
            this.InstantMessageCreated = InstantMessageCreated;
            this.RoomCreated = RoomCreated;
            this.RoomUpdated = RoomUpdated;
            this.RoomDeactivated = RoomDeactivated;
            this.RoomReactivated = RoomReactivated;
            this.UserJoinedRoom = UserJoinedRoom;
            this.UserLeftRoom = UserLeftRoom;
            this.RoomMemberPromotedToOwner = RoomMemberPromotedToOwner;
            this.RoomMemberDemotedFromOwner = RoomMemberDemotedFromOwner;
            this.ConnectionRequested = ConnectionRequested;
            this.ConnectionAccepted = ConnectionAccepted;
            this.MessageSuppressed = MessageSuppressed;
        }
        
        /// <summary>
        /// Gets or Sets MessageSent
        /// </summary>
        [DataMember(Name="messageSent", EmitDefaultValue=false)]
        public V4MessageSent MessageSent { get; set; }
        /// <summary>
        /// Gets or Sets SharedPost
        /// </summary>
        [DataMember(Name="sharedPost", EmitDefaultValue=false)]
        public V4SharedPost SharedPost { get; set; }
        /// <summary>
        /// Gets or Sets InstantMessageCreated
        /// </summary>
        [DataMember(Name="instantMessageCreated", EmitDefaultValue=false)]
        public V4InstantMessageCreated InstantMessageCreated { get; set; }
        /// <summary>
        /// Gets or Sets RoomCreated
        /// </summary>
        [DataMember(Name="roomCreated", EmitDefaultValue=false)]
        public V4RoomCreated RoomCreated { get; set; }
        /// <summary>
        /// Gets or Sets RoomUpdated
        /// </summary>
        [DataMember(Name="roomUpdated", EmitDefaultValue=false)]
        public V4RoomUpdated RoomUpdated { get; set; }
        /// <summary>
        /// Gets or Sets RoomDeactivated
        /// </summary>
        [DataMember(Name="roomDeactivated", EmitDefaultValue=false)]
        public V4RoomDeactivated RoomDeactivated { get; set; }
        /// <summary>
        /// Gets or Sets RoomReactivated
        /// </summary>
        [DataMember(Name="roomReactivated", EmitDefaultValue=false)]
        public V4RoomReactivated RoomReactivated { get; set; }
        /// <summary>
        /// Gets or Sets UserJoinedRoom
        /// </summary>
        [DataMember(Name="userJoinedRoom", EmitDefaultValue=false)]
        public V4UserJoinedRoom UserJoinedRoom { get; set; }
        /// <summary>
        /// Gets or Sets UserLeftRoom
        /// </summary>
        [DataMember(Name="userLeftRoom", EmitDefaultValue=false)]
        public V4UserLeftRoom UserLeftRoom { get; set; }
        /// <summary>
        /// Gets or Sets RoomMemberPromotedToOwner
        /// </summary>
        [DataMember(Name="roomMemberPromotedToOwner", EmitDefaultValue=false)]
        public V4RoomMemberPromotedToOwner RoomMemberPromotedToOwner { get; set; }
        /// <summary>
        /// Gets or Sets RoomMemberDemotedFromOwner
        /// </summary>
        [DataMember(Name="roomMemberDemotedFromOwner", EmitDefaultValue=false)]
        public V4RoomMemberDemotedFromOwner RoomMemberDemotedFromOwner { get; set; }
        /// <summary>
        /// Gets or Sets ConnectionRequested
        /// </summary>
        [DataMember(Name="connectionRequested", EmitDefaultValue=false)]
        public V4ConnectionRequested ConnectionRequested { get; set; }
        /// <summary>
        /// Gets or Sets ConnectionAccepted
        /// </summary>
        [DataMember(Name="connectionAccepted", EmitDefaultValue=false)]
        public V4ConnectionAccepted ConnectionAccepted { get; set; }
        /// <summary>
        /// Gets or Sets MessageSuppressed
        /// </summary>
        [DataMember(Name="messageSuppressed", EmitDefaultValue=false)]
        public V4MessageSuppressed MessageSuppressed { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V4Payload {\n");
            sb.Append("  MessageSent: ").Append(MessageSent).Append("\n");
            sb.Append("  SharedPost: ").Append(SharedPost).Append("\n");
            sb.Append("  InstantMessageCreated: ").Append(InstantMessageCreated).Append("\n");
            sb.Append("  RoomCreated: ").Append(RoomCreated).Append("\n");
            sb.Append("  RoomUpdated: ").Append(RoomUpdated).Append("\n");
            sb.Append("  RoomDeactivated: ").Append(RoomDeactivated).Append("\n");
            sb.Append("  RoomReactivated: ").Append(RoomReactivated).Append("\n");
            sb.Append("  UserJoinedRoom: ").Append(UserJoinedRoom).Append("\n");
            sb.Append("  UserLeftRoom: ").Append(UserLeftRoom).Append("\n");
            sb.Append("  RoomMemberPromotedToOwner: ").Append(RoomMemberPromotedToOwner).Append("\n");
            sb.Append("  RoomMemberDemotedFromOwner: ").Append(RoomMemberDemotedFromOwner).Append("\n");
            sb.Append("  ConnectionRequested: ").Append(ConnectionRequested).Append("\n");
            sb.Append("  ConnectionAccepted: ").Append(ConnectionAccepted).Append("\n");
            sb.Append("  MessageSuppressed: ").Append(MessageSuppressed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as V4Payload);
        }

        /// <summary>
        /// Returns true if V4Payload instances are equal
        /// </summary>
        /// <param name="other">Instance of V4Payload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V4Payload other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MessageSent == other.MessageSent ||
                    this.MessageSent != null &&
                    this.MessageSent.Equals(other.MessageSent)
                ) && 
                (
                    this.SharedPost == other.SharedPost ||
                    this.SharedPost != null &&
                    this.SharedPost.Equals(other.SharedPost)
                ) && 
                (
                    this.InstantMessageCreated == other.InstantMessageCreated ||
                    this.InstantMessageCreated != null &&
                    this.InstantMessageCreated.Equals(other.InstantMessageCreated)
                ) && 
                (
                    this.RoomCreated == other.RoomCreated ||
                    this.RoomCreated != null &&
                    this.RoomCreated.Equals(other.RoomCreated)
                ) && 
                (
                    this.RoomUpdated == other.RoomUpdated ||
                    this.RoomUpdated != null &&
                    this.RoomUpdated.Equals(other.RoomUpdated)
                ) && 
                (
                    this.RoomDeactivated == other.RoomDeactivated ||
                    this.RoomDeactivated != null &&
                    this.RoomDeactivated.Equals(other.RoomDeactivated)
                ) && 
                (
                    this.RoomReactivated == other.RoomReactivated ||
                    this.RoomReactivated != null &&
                    this.RoomReactivated.Equals(other.RoomReactivated)
                ) && 
                (
                    this.UserJoinedRoom == other.UserJoinedRoom ||
                    this.UserJoinedRoom != null &&
                    this.UserJoinedRoom.Equals(other.UserJoinedRoom)
                ) && 
                (
                    this.UserLeftRoom == other.UserLeftRoom ||
                    this.UserLeftRoom != null &&
                    this.UserLeftRoom.Equals(other.UserLeftRoom)
                ) && 
                (
                    this.RoomMemberPromotedToOwner == other.RoomMemberPromotedToOwner ||
                    this.RoomMemberPromotedToOwner != null &&
                    this.RoomMemberPromotedToOwner.Equals(other.RoomMemberPromotedToOwner)
                ) && 
                (
                    this.RoomMemberDemotedFromOwner == other.RoomMemberDemotedFromOwner ||
                    this.RoomMemberDemotedFromOwner != null &&
                    this.RoomMemberDemotedFromOwner.Equals(other.RoomMemberDemotedFromOwner)
                ) && 
                (
                    this.ConnectionRequested == other.ConnectionRequested ||
                    this.ConnectionRequested != null &&
                    this.ConnectionRequested.Equals(other.ConnectionRequested)
                ) && 
                (
                    this.ConnectionAccepted == other.ConnectionAccepted ||
                    this.ConnectionAccepted != null &&
                    this.ConnectionAccepted.Equals(other.ConnectionAccepted)
                ) && 
                (
                    this.MessageSuppressed == other.MessageSuppressed ||
                    this.MessageSuppressed != null &&
                    this.MessageSuppressed.Equals(other.MessageSuppressed)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.MessageSent != null)
                    hash = hash * 59 + this.MessageSent.GetHashCode();
                if (this.SharedPost != null)
                    hash = hash * 59 + this.SharedPost.GetHashCode();
                if (this.InstantMessageCreated != null)
                    hash = hash * 59 + this.InstantMessageCreated.GetHashCode();
                if (this.RoomCreated != null)
                    hash = hash * 59 + this.RoomCreated.GetHashCode();
                if (this.RoomUpdated != null)
                    hash = hash * 59 + this.RoomUpdated.GetHashCode();
                if (this.RoomDeactivated != null)
                    hash = hash * 59 + this.RoomDeactivated.GetHashCode();
                if (this.RoomReactivated != null)
                    hash = hash * 59 + this.RoomReactivated.GetHashCode();
                if (this.UserJoinedRoom != null)
                    hash = hash * 59 + this.UserJoinedRoom.GetHashCode();
                if (this.UserLeftRoom != null)
                    hash = hash * 59 + this.UserLeftRoom.GetHashCode();
                if (this.RoomMemberPromotedToOwner != null)
                    hash = hash * 59 + this.RoomMemberPromotedToOwner.GetHashCode();
                if (this.RoomMemberDemotedFromOwner != null)
                    hash = hash * 59 + this.RoomMemberDemotedFromOwner.GetHashCode();
                if (this.ConnectionRequested != null)
                    hash = hash * 59 + this.ConnectionRequested.GetHashCode();
                if (this.ConnectionAccepted != null)
                    hash = hash * 59 + this.ConnectionAccepted.GetHashCode();
                if (this.MessageSuppressed != null)
                    hash = hash * 59 + this.MessageSuppressed.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}