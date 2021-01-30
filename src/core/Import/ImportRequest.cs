namespace Dime.Scheduler.Sdk.Import
{
    public class ImportRequest : IImportRequestable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportRequest"/> class
        /// </summary>
        public ImportRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportRequest"/> class
        /// </summary>
        public ImportRequest(string storedProcedureName, string[] parameterNames, string[] parameterValues)
        {
            StoredProcedureName = storedProcedureName;
            ParameterNames = parameterNames;
            ParameterValues = parameterValues;
        }

        /// <summary>
        /// The name of the stored procedure to execute
        /// </summary>
        public string StoredProcedureName { get; set; }

        /// <summary>
        /// The collection of parameters to pass to the stored procedure
        /// </summary>
        public string[] ParameterNames { get; set; }

        /// <summary>
        /// The collection of values to pass to the stored procedure
        /// </summary>
        public string[] ParameterValues { get; set; }

        public ImportRequest ToImportRequest() => this;
    }
}