// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DataflowStorageAccountsOperations.
    /// </summary>
    public static partial class DataflowStorageAccountsOperationsExtensions
    {
            /// <summary>
            /// Returns a list of dataflow storage accounts the user has access to.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: StorageAccount.Read.All or
            /// StorageAccount.ReadWrite.All &lt;br/&gt;To set the permissions scope, see
            /// [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static DataflowStorageAccounts GetDataflowStorageAccounts(this IDataflowStorageAccountsOperations operations)
            {
                return operations.GetDataflowStorageAccountsAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of dataflow storage accounts the user has access to.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: StorageAccount.Read.All or
            /// StorageAccount.ReadWrite.All &lt;br/&gt;To set the permissions scope, see
            /// [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DataflowStorageAccounts> GetDataflowStorageAccountsAsync(this IDataflowStorageAccountsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDataflowStorageAccountsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}