﻿namespace SymphonyOSS.RestApiClient.Tests
{
    using System;
    using Api;
    using Api.AgentApi;
    using Authentication;
    using Generated.OpenApi.AgentApi.Client;
    using Generated.OpenApi.AgentApi.Model;
    using Moq;
    using Xunit;

    /// <summary>
    /// Summary description for UtilApiTest
    /// </summary>
    public class UtilApiTest
    {
        private readonly UtilApi _utilApi;

        private readonly Mock<IApiExecutor> _apiExecutorMock;

        public UtilApiTest()
        {
            var sessionManagerMock = new Mock<IAuthTokens>();
            sessionManagerMock.Setup(obj => obj.SessionToken).Returns("sessionToken");
            sessionManagerMock.Setup(obj => obj.KeyManagerToken).Returns("keyManagerToken");
            var configuration = new Configuration();
            _apiExecutorMock = new Mock<IApiExecutor>();
            _utilApi = new UtilApi(sessionManagerMock.Object, configuration, _apiExecutorMock.Object);
        }
        
        [Fact]
        public void EnsureEcho_uses_retry_strategy()
        {
            const string msg = "Hello!";
            _utilApi.Echo(msg);
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, string, SimpleMessage, SimpleMessage>>(), "sessionToken", "keyManagerToken", new SimpleMessage(msg)));
        }

        [Fact]
        public void EnsureObsolete_uses_retry_strategy()
        {
            const string msg = "Obsolete!";
            _utilApi.Obsolete(msg);
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, string, SimpleMessage, SimpleMessage>>(), "sessionToken", "keyManagerToken", new SimpleMessage(msg)));
        }
    }
}
