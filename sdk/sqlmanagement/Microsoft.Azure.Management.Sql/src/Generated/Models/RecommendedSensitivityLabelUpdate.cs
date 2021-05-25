// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A recommended sensitivity label update operation.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class RecommendedSensitivityLabelUpdate : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the RecommendedSensitivityLabelUpdate
        /// class.
        /// </summary>
        public RecommendedSensitivityLabelUpdate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RecommendedSensitivityLabelUpdate
        /// class.
        /// </summary>
        /// <param name="op">Possible values include: 'enable',
        /// 'disable'</param>
        /// <param name="schema">Schema name of the column to update.</param>
        /// <param name="table">Table name of the column to update.</param>
        /// <param name="column">Column name to update.</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        public RecommendedSensitivityLabelUpdate(RecommendedSensitivityLabelUpdateKind op, string schema, string table, string column, string id = default(string), string name = default(string), string type = default(string))
            : base(id, name, type)
        {
            Op = op;
            Schema = schema;
            Table = table;
            Column = column;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'enable', 'disable'
        /// </summary>
        [JsonProperty(PropertyName = "properties.op")]
        public RecommendedSensitivityLabelUpdateKind Op { get; set; }

        /// <summary>
        /// Gets or sets schema name of the column to update.
        /// </summary>
        [JsonProperty(PropertyName = "properties.schema")]
        public string Schema { get; set; }

        /// <summary>
        /// Gets or sets table name of the column to update.
        /// </summary>
        [JsonProperty(PropertyName = "properties.table")]
        public string Table { get; set; }

        /// <summary>
        /// Gets or sets column name to update.
        /// </summary>
        [JsonProperty(PropertyName = "properties.column")]
        public string Column { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Schema == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Schema");
            }
            if (Table == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Table");
            }
            if (Column == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Column");
            }
        }
    }
}
