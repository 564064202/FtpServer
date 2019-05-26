// <copyright file="ICommunicationService.cs" company="Fubar Development Junker">
// Copyright (c) Fubar Development Junker. All rights reserved.
// </copyright>

using System.Threading;
using System.Threading.Tasks;

using JetBrains.Annotations;

namespace FubarDev.FtpServer.ConnectionHandlers
{
    /// <summary>
    /// Basic API for a communication service.
    /// </summary>
    public interface ICommunicationService : IBasicCommunicationService
    {
        /// <summary>
        /// Gets the current status.
        /// </summary>
        ConnectionStatus Status { get; }

        /// <summary>
        /// Pauses the communication service.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The task.</returns>
        [NotNull]
        Task PauseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Continues the communication service.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The task.</returns>
        [NotNull]
        Task ContinueAsync(CancellationToken cancellationToken);
    }
}
