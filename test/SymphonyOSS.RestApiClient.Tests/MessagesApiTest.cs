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

using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using SymphonyOSS.RestApiClient.Entities;

namespace SymphonyOSS.RestApiClient.Tests
{
    using System;
    using Api;
    using Api.AgentApi;
    using Authentication;
    using Generated.OpenApi.AgentApi;
    using Message = Entities.Message;
    using Moq;
    using Xunit;

    public class MessagesApiTest
    {
        private readonly Mock<IApiExecutor> _apiExecutorMock;

        private readonly MessagesApi _messagesApi;

        public MessagesApiTest()
        {
            var sessionManagerMock = new Mock<IAuthTokens>();
            sessionManagerMock.Setup(obj => obj.SessionToken).Returns("sessionToken");
            sessionManagerMock.Setup(obj => obj.KeyManagerToken).Returns("keyManagerToken");
            _apiExecutorMock = new Mock<IApiExecutor>();
            _messagesApi = new MessagesApi(sessionManagerMock.Object, "", new HttpClient(), _apiExecutorMock.Object);
        }

        [Fact]
        public void EnsurePostMessage_uses_retry_strategy()
        {
            const string sid = "sid";
            var message = new Message(sid, "body");
            var v2Message = new V2Message() {
                Id = "id", Timestamp = "1477297302", StreamId = sid, Message = "body", FromUserId = 0};
            _apiExecutorMock.Setup(apiExecutor => apiExecutor.Execute(It.IsAny<Func<string, string, string, V2MessageSubmission, CancellationToken, Task<V2Message>>>(), sid, "sessionToken", "keyManagerToken", It.IsAny<V2MessageSubmission>(), default(CancellationToken))).Returns(v2Message);
            _messagesApi.PostMessage(message);
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, string, string, V2MessageSubmission, CancellationToken, Task<V2Message>>>(), sid, "sessionToken", "keyManagerToken", It.IsAny<V2MessageSubmission>(), default(CancellationToken)));
        }

        [Fact]
        public void EnsureGet_uses_retry_strategy()
        {
            const string sid = "sid";
            _messagesApi.GetMessages(sid, 0);
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, long, string, string, int?, int?, CancellationToken, Task<System.Collections.ObjectModel.ObservableCollection<V4Message>>>>(), sid, 0, "sessionToken", "keyManagerToken", (int?)null, (int?)null, default(CancellationToken)));
        }
    }
}
