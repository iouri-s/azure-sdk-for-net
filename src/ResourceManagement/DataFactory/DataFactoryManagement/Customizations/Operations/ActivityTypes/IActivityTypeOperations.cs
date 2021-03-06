﻿//
// Copyright (c) Microsoft.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.DataFactories.Common.Models;
using Microsoft.Azure.Management.DataFactories.Registration.Models;

namespace Microsoft.Azure.Management.DataFactories
{
    /// <summary>
    /// Operations for managing data factory ActivityTypes.
    /// </summary>
    public interface IActivityTypeOperations
    {
        /// <summary>
        /// Delete an ActivityType instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// The name of the data factory.
        /// </param>
        /// <param name='activityTypeName'>
        /// The name of the activityType.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResponse> BeginDeleteAsync(
            string resourceGroupName,
            string dataFactoryName,
            string activityTypeName,
            CancellationToken cancellationToken);

        /// <summary>
        /// Create or update an ActivityType.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// The name of the data factory.
        /// </param>
        /// <param name='parameters'>
        /// The parameters required to create or update an ActivityType
        /// definition.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The create or update ActivityType operation response.
        /// </returns>
        Task<ActivityTypeCreateOrUpdateResponse> CreateOrUpdateAsync(
            string resourceGroupName,
            string dataFactoryName,
            ActivityTypeCreateOrUpdateParameters parameters,
            CancellationToken cancellationToken);

        /// <summary>
        /// Create or update an ActivityType.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// The name of the data factory.
        /// </param>
        /// <param name='activityTypeName'>
        /// An ActivityType name.
        /// </param>
        /// <param name='parameters'>
        /// The parameters required to create or update an ActivityType
        /// definition.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The create or update ActivityType operation response.
        /// </returns>
        Task<ActivityTypeCreateOrUpdateResponse> CreateOrUpdateWithRawJsonContentAsync(
            string resourceGroupName,
            string dataFactoryName,
            string activityTypeName,
            ActivityTypeCreateOrUpdateWithRawJsonContentParameters parameters,
            CancellationToken cancellationToken);

        /// <summary>
        /// Delete an ActivityType instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// The name of the data factory.
        /// </param>
        /// <param name='activityTypeName'>
        /// The name of the activityType.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResponse> DeleteAsync(
            string resourceGroupName,
            string dataFactoryName,
            string activityTypeName,
            CancellationToken cancellationToken);

        /// <summary>
        /// Gets an ActivityType instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// The name of the data factory.
        /// </param>
        /// <param name='parameters'>
        /// Parameters specifying how to get an ActivityType definition.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get ActivityType operation response.
        /// </returns>
        Task<ActivityTypeGetResponse> GetAsync(
            string resourceGroupName,
            string dataFactoryName,
            ActivityTypeGetParameters parameters,
            CancellationToken cancellationToken);

        /// <summary>
        /// Gets the first page of ActivityType instances with the link to the
        /// next page.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// The name of the data factory.
        /// </param>
        /// <param name='parameters'>
        /// Parameters specifying how to return a list of ActivityType
        /// definitions.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List ActivityType operation response.
        /// </returns>
        Task<ActivityTypeListResponse> ListAsync(
            string resourceGroupName,
            string dataFactoryName,
            ActivityTypeListParameters parameters,
            CancellationToken cancellationToken);

        /// <summary>
        /// Gets the next page of ActivityType instances with the link to the
        /// next page.
        /// </summary>
        /// <param name='nextLink'>
        /// The url to the next ActivityTypes page.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List ActivityType operation response.
        /// </returns>
        Task<ActivityTypeListResponse> ListNextAsync(string nextLink, CancellationToken cancellationToken);
    }
}
