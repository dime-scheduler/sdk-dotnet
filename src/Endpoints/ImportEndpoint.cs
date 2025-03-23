using System;
using System.Collections.Generic;
using Dime.Scheduler.Entities;
using RestSharp;
using t = System.Threading.Tasks;

namespace Dime.Scheduler
{
    internal class ImportEndpoint : Endpoint, IImportEndpoint
    {
        internal ImportEndpoint(EndpointOptions opts) : base(opts)
        {
        }

        public async t.Task<ImportSet> ProcessAsync(IEnumerable<IImportEntity> requestParameters, TransactionType transactionType)
        {
            try
            {
                Result response = await ExecuteAsync(Routes.Import.InsertData, Method.Post, requestParameters.ToImportRequest(transactionType));
                return new ImportSet() { Status = response.IsSuccess ? 200 : 500, Success = response.IsSuccess, Message = response.Error?.Message };
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

        public async t.Task<ImportSet> ProcessAsync(IImportEntity requestParameters, TransactionType transactionType)
        {
            try
            {
                Result response = await ExecuteAsync<IEnumerable<ImportRequest>>(Routes.Import.Insert, Method.Post, [requestParameters.ToImportRequest(transactionType)]);
                return new ImportSet() { Status = response.IsSuccess ? 200 : 500, Success = response.IsSuccess, Message = response.Error?.Message };
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