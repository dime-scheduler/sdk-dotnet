using System;
using System.Collections.Generic;
using Dime.Scheduler.Sdk.Import;
using RestSharp;
using t = System.Threading.Tasks;

namespace Dime.Scheduler.Sdk
{
    public class ImportEndpoint : Endpoint<ImportRequest>, IImportEndpoint
    {
        public ImportEndpoint(AuthenticationOptions opts)
            : base(opts)
        {
        }

        internal ImportEndpoint(IDimeSchedulerRestClient<ImportRequest> restClient)
            : base(restClient)
        {
        }

        public async t.Task<ImportSet> ProcessAsync(IEnumerable<IImportRequestable> requestParameters, TransactionType transactionType)
        {
            try
            {
                return await Execute<ImportSet>(Routes.Import.InsertData, Method.Post, requestParameters.ToImportRequest(transactionType));
            }
            catch (WebApiException ex)
            {
                return new ImportSet() { Status = (int)ex.StatusCode, Success = false, Message = ex.Error };
            }
            catch (Exception ex)
            {
                return new ImportSet() { Status = 500, Success = false, Message = ex.Message };
            }
        }

        public async t.Task<ImportSet> ProcessAsync(IImportRequestable requestParameters, TransactionType transactionType)
        {
            try
            {
                return await Execute<ImportSet>(Routes.Import.Insert, Method.Post, requestParameters.ToImportRequest(transactionType));
            }
            catch (WebApiException ex)
            {
                return new ImportSet() { Status = (int)ex.StatusCode, Success = false, Message = ex.Error };
            }
            catch (Exception ex)
            {
                return new ImportSet() { Status = 500, Success = false, Message = ex.Message };
            }
        }
    }
}