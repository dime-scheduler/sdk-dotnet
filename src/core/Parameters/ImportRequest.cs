namespace Dime.Scheduler.Sdk
{
    public class ImportRequest
    {
        #region Constructor

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

        #endregion Constructor

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
    }
}