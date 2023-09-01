using System;
using System.Collections.Generic;
using Dime.Scheduler.Sdk.Import;
using RestSharp;
using t = System.Threading.Tasks;

namespace Dime.Scheduler.Sdk
{
    public class ImportEndpoint : Endpoint, IImportEndpoint
    {
        public ImportEndpoint(AuthenticationOptions opts)
            : base(opts)
        {
        }

        public async t.Task<ImportSet> ProcessAsync(IEnumerable<IImportRequestable> requestParameters, TransactionType transactionType)
        {
            try
            {
                IEnumerable<ImportRequest> result = await Execute(Routes.Import.InsertData, Method.Post, requestParameters.ToImportRequest(transactionType));
                return new ImportSet() { Status = 200, Success = true };
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
                ImportResult importResult = await Execute<ImportResult, IEnumerable<ImportRequest>>(Routes.Import.Insert, Method.Post, new List<ImportRequest> { requestParameters.ToImportRequest(transactionType) });

                return new ImportSet()
                {
                    Status = importResult.StatusCode,
                    Success = importResult.StatusCode == 200,
                    Message = importResult.Content
                };
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