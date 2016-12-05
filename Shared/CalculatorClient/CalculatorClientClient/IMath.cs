﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Rest;

namespace CalculatorClient
{
    public partial interface IMath
    {
        /// <summary>
        /// Adds value 1 to value 2
        /// </summary>
        /// <param name='value1'>
        /// Required. Format - double.
        /// </param>
        /// <param name='value2'>
        /// Required. Format - double.
        /// </param>
        /// <param name='ocpApimSubscriptionKey'>
        /// Required. subscription key in header
        /// </param>
        /// <param name='subscriptionKey'>
        /// Optional. subscription key in url
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<double>> AddWithOperationResponseAsync(double value1, double value2, string ocpApimSubscriptionKey, string subscriptionKey = null, CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        
        /// <summary>
        /// Divides value 1 by value 2
        /// </summary>
        /// <param name='value1'>
        /// Required. Format - double.
        /// </param>
        /// <param name='value2'>
        /// Required. Format - double.
        /// </param>
        /// <param name='ocpApimSubscriptionKey'>
        /// Required. subscription key in header
        /// </param>
        /// <param name='subscriptionKey'>
        /// Optional. subscription key in url
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<double>> DivideWithOperationResponseAsync(double value1, double value2, string ocpApimSubscriptionKey, string subscriptionKey = null, CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        
        /// <summary>
        /// Multiplies value 1 and value 2
        /// </summary>
        /// <param name='value1'>
        /// Required. Format - double.
        /// </param>
        /// <param name='value2'>
        /// Required. Format - double.
        /// </param>
        /// <param name='ocpApimSubscriptionKey'>
        /// Required. subscription key in header
        /// </param>
        /// <param name='subscriptionKey'>
        /// Optional. subscription key in url
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<double>> MultiplyWithOperationResponseAsync(double value1, double value2, string ocpApimSubscriptionKey, string subscriptionKey = null, CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        
        /// <summary>
        /// Raises value 1 to the power of value 2
        /// </summary>
        /// <param name='value1'>
        /// Required. Format - double.
        /// </param>
        /// <param name='value2'>
        /// Required. Format - double.
        /// </param>
        /// <param name='ocpApimSubscriptionKey'>
        /// Required. subscription key in header
        /// </param>
        /// <param name='subscriptionKey'>
        /// Optional. subscription key in url
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<double>> PowerWithOperationResponseAsync(double value1, double value2, string ocpApimSubscriptionKey, string subscriptionKey = null, CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        
        /// <summary>
        /// Subtracts value 2 from value 1
        /// </summary>
        /// <param name='value1'>
        /// Required. Format - double.
        /// </param>
        /// <param name='value2'>
        /// Required. Format - double.
        /// </param>
        /// <param name='ocpApimSubscriptionKey'>
        /// Required. subscription key in header
        /// </param>
        /// <param name='subscriptionKey'>
        /// Optional. subscription key in url
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<double>> SubtractWithOperationResponseAsync(double value1, double value2, string ocpApimSubscriptionKey, string subscriptionKey = null, CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
}