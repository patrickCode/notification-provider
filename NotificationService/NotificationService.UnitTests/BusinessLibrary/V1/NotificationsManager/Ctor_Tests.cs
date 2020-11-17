﻿// <autogenerated />
// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

namespace NotificationService.UnitTests.BusinessLibrary.V1.NotificationsManager_Tests
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using Microsoft.Extensions.Logging;
    using Moq;
    using NotificationService.BusinessLibrary.Business.V1;
    using NotificationService.Contracts;
    using NotificationService.Contracts.Entities.Web;
    using NotificationService.Contracts.Models.Graph;
    using NotificationService.Data.Interfaces;
    using NUnit.Framework;

    /// <summary>
    /// Test class.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class Ctor_Tests: NotificationsTestsBase
    {
        /// <summary>
        /// Ctors the null repository.
        /// </summary>
        [Test]
        public void Ctor_NullRepository()
        {
            this.SetupBase();
            var ex = Assert.Throws<ArgumentNullException>(() => new NotificationsManager(null, this.loggerMock.Object));
            Assert.IsTrue(ex.ParamName.Equals("notificationsRepository", StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// Ctors the null logger.
        /// </summary>
        [Test]
        public void Ctor_NullLogger()
        {
            this.SetupBase();
            var ex = Assert.Throws<ArgumentNullException>(() => new NotificationsManager(this.notificationsRepositoryMock.Object, null));
            Assert.IsTrue(ex.ParamName.Equals("logger", StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// Ctors the valid input.
        /// </summary>
        [Test]
        public void Ctor_ValidInput()
        {
            this.SetupBase();
            var controller = new NotificationsManager(this.notificationsRepositoryMock.Object, this.loggerMock.Object);
            Assert.IsTrue(controller.GetType().FullName.Equals(typeof(NotificationsManager).FullName, StringComparison.Ordinal));
        }
    }
}