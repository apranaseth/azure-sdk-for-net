// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(TabularSourceConverter))]
    public partial class TabularSource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(QueryTimeout))
            {
                writer.WritePropertyName("queryTimeout");
                writer.WriteObjectValue(QueryTimeout);
            }
            if (Optional.IsCollectionDefined(AdditionalColumns))
            {
                writer.WritePropertyName("additionalColumns");
                writer.WriteStartArray();
                foreach (var item in AdditionalColumns)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(SourceRetryCount))
            {
                writer.WritePropertyName("sourceRetryCount");
                writer.WriteObjectValue(SourceRetryCount);
            }
            if (Optional.IsDefined(SourceRetryWait))
            {
                writer.WritePropertyName("sourceRetryWait");
                writer.WriteObjectValue(SourceRetryWait);
            }
            if (Optional.IsDefined(MaxConcurrentConnections))
            {
                writer.WritePropertyName("maxConcurrentConnections");
                writer.WriteObjectValue(MaxConcurrentConnections);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static TabularSource DeserializeTabularSource(JsonElement element)
        {
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AmazonMWSSource": return AmazonMWSSource.DeserializeAmazonMWSSource(element);
                    case "AmazonRedshiftSource": return AmazonRedshiftSource.DeserializeAmazonRedshiftSource(element);
                    case "AzureMariaDBSource": return AzureMariaDBSource.DeserializeAzureMariaDBSource(element);
                    case "AzureMySqlSource": return AzureMySqlSource.DeserializeAzureMySqlSource(element);
                    case "AzurePostgreSqlSource": return AzurePostgreSqlSource.DeserializeAzurePostgreSqlSource(element);
                    case "AzureSqlSource": return AzureSqlSource.DeserializeAzureSqlSource(element);
                    case "AzureTableSource": return AzureTableSource.DeserializeAzureTableSource(element);
                    case "CassandraSource": return CassandraSource.DeserializeCassandraSource(element);
                    case "ConcurSource": return ConcurSource.DeserializeConcurSource(element);
                    case "CouchbaseSource": return CouchbaseSource.DeserializeCouchbaseSource(element);
                    case "Db2Source": return Db2Source.DeserializeDb2Source(element);
                    case "DrillSource": return DrillSource.DeserializeDrillSource(element);
                    case "DynamicsAXSource": return DynamicsAXSource.DeserializeDynamicsAXSource(element);
                    case "EloquaSource": return EloquaSource.DeserializeEloquaSource(element);
                    case "GoogleAdWordsSource": return GoogleAdWordsSource.DeserializeGoogleAdWordsSource(element);
                    case "GoogleBigQuerySource": return GoogleBigQuerySource.DeserializeGoogleBigQuerySource(element);
                    case "GreenplumSource": return GreenplumSource.DeserializeGreenplumSource(element);
                    case "HBaseSource": return HBaseSource.DeserializeHBaseSource(element);
                    case "HiveSource": return HiveSource.DeserializeHiveSource(element);
                    case "HubspotSource": return HubspotSource.DeserializeHubspotSource(element);
                    case "ImpalaSource": return ImpalaSource.DeserializeImpalaSource(element);
                    case "InformixSource": return InformixSource.DeserializeInformixSource(element);
                    case "JiraSource": return JiraSource.DeserializeJiraSource(element);
                    case "MagentoSource": return MagentoSource.DeserializeMagentoSource(element);
                    case "MariaDBSource": return MariaDBSource.DeserializeMariaDBSource(element);
                    case "MarketoSource": return MarketoSource.DeserializeMarketoSource(element);
                    case "MySqlSource": return MySqlSource.DeserializeMySqlSource(element);
                    case "NetezzaSource": return NetezzaSource.DeserializeNetezzaSource(element);
                    case "OdbcSource": return OdbcSource.DeserializeOdbcSource(element);
                    case "OracleServiceCloudSource": return OracleServiceCloudSource.DeserializeOracleServiceCloudSource(element);
                    case "PaypalSource": return PaypalSource.DeserializePaypalSource(element);
                    case "PhoenixSource": return PhoenixSource.DeserializePhoenixSource(element);
                    case "PostgreSqlSource": return PostgreSqlSource.DeserializePostgreSqlSource(element);
                    case "PrestoSource": return PrestoSource.DeserializePrestoSource(element);
                    case "QuickBooksSource": return QuickBooksSource.DeserializeQuickBooksSource(element);
                    case "ResponsysSource": return ResponsysSource.DeserializeResponsysSource(element);
                    case "SalesforceMarketingCloudSource": return SalesforceMarketingCloudSource.DeserializeSalesforceMarketingCloudSource(element);
                    case "SalesforceSource": return SalesforceSource.DeserializeSalesforceSource(element);
                    case "SapBwSource": return SapBwSource.DeserializeSapBwSource(element);
                    case "SapCloudForCustomerSource": return SapCloudForCustomerSource.DeserializeSapCloudForCustomerSource(element);
                    case "SapEccSource": return SapEccSource.DeserializeSapEccSource(element);
                    case "SapHanaSource": return SapHanaSource.DeserializeSapHanaSource(element);
                    case "SapOpenHubSource": return SapOpenHubSource.DeserializeSapOpenHubSource(element);
                    case "SapTableSource": return SapTableSource.DeserializeSapTableSource(element);
                    case "ServiceNowSource": return ServiceNowSource.DeserializeServiceNowSource(element);
                    case "ShopifySource": return ShopifySource.DeserializeShopifySource(element);
                    case "SparkSource": return SparkSource.DeserializeSparkSource(element);
                    case "SqlDWSource": return SqlDWSource.DeserializeSqlDWSource(element);
                    case "SqlMISource": return SqlMISource.DeserializeSqlMISource(element);
                    case "SqlServerSource": return SqlServerSource.DeserializeSqlServerSource(element);
                    case "SqlSource": return SqlSource.DeserializeSqlSource(element);
                    case "SquareSource": return SquareSource.DeserializeSquareSource(element);
                    case "SybaseSource": return SybaseSource.DeserializeSybaseSource(element);
                    case "TeradataSource": return TeradataSource.DeserializeTeradataSource(element);
                    case "VerticaSource": return VerticaSource.DeserializeVerticaSource(element);
                    case "XeroSource": return XeroSource.DeserializeXeroSource(element);
                    case "ZohoSource": return ZohoSource.DeserializeZohoSource(element);
                }
            }
            Optional<object> queryTimeout = default;
            Optional<IList<AdditionalColumns>> additionalColumns = default;
            string type = default;
            Optional<object> sourceRetryCount = default;
            Optional<object> sourceRetryWait = default;
            Optional<object> maxConcurrentConnections = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("queryTimeout"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    queryTimeout = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("additionalColumns"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<AdditionalColumns> array = new List<AdditionalColumns>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.AdditionalColumns.DeserializeAdditionalColumns(item));
                    }
                    additionalColumns = array;
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceRetryCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sourceRetryCount = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("sourceRetryWait"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sourceRetryWait = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxConcurrentConnections = property.Value.GetObject();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new TabularSource(type, sourceRetryCount.Value, sourceRetryWait.Value, maxConcurrentConnections.Value, additionalProperties, queryTimeout.Value, Optional.ToList(additionalColumns));
        }

        internal partial class TabularSourceConverter : JsonConverter<TabularSource>
        {
            public override void Write(Utf8JsonWriter writer, TabularSource model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override TabularSource Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeTabularSource(document.RootElement);
            }
        }
    }
}
