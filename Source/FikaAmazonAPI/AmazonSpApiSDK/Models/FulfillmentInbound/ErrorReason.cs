/* 
 * Selling Partner API for Fulfillment Inbound
 *
 * The Selling Partner API for Fulfillment Inbound lets you create applications that create and update inbound shipments of inventory to Amazon's fulfillment network.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentInbound
{
    /// <summary>
    /// The reason that the ASIN is invalid.
    /// </summary>
    /// <value>The reason that the ASIN is invalid.</value>

    public enum ErrorReason
    {

        /// <summary>
        /// Enum DoesNotExist for value: DoesNotExist
        /// </summary>

        DoesNotExist,

        /// <summary>
        /// Enum InvalidASIN for value: InvalidASIN
        /// </summary>

        InvalidASIN
    }

}