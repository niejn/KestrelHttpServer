// <auto-generated />
namespace Microsoft.AspNetCore.Server.Kestrel.Core
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class CoreStrings
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.AspNetCore.Server.Kestrel.Core.CoreStrings", typeof(CoreStrings).GetTypeInfo().Assembly);

        /// <summary>
        /// Bad request.
        /// </summary>
        internal static string BadRequest
        {
            get => GetString("BadRequest");
        }

        /// <summary>
        /// Bad request.
        /// </summary>
        internal static string FormatBadRequest()
            => GetString("BadRequest");

        /// <summary>
        /// Bad chunk size data.
        /// </summary>
        internal static string BadRequest_BadChunkSizeData
        {
            get => GetString("BadRequest_BadChunkSizeData");
        }

        /// <summary>
        /// Bad chunk size data.
        /// </summary>
        internal static string FormatBadRequest_BadChunkSizeData()
            => GetString("BadRequest_BadChunkSizeData");

        /// <summary>
        /// Bad chunk suffix.
        /// </summary>
        internal static string BadRequest_BadChunkSuffix
        {
            get => GetString("BadRequest_BadChunkSuffix");
        }

        /// <summary>
        /// Bad chunk suffix.
        /// </summary>
        internal static string FormatBadRequest_BadChunkSuffix()
            => GetString("BadRequest_BadChunkSuffix");

        /// <summary>
        /// Chunked request incomplete.
        /// </summary>
        internal static string BadRequest_ChunkedRequestIncomplete
        {
            get => GetString("BadRequest_ChunkedRequestIncomplete");
        }

        /// <summary>
        /// Chunked request incomplete.
        /// </summary>
        internal static string FormatBadRequest_ChunkedRequestIncomplete()
            => GetString("BadRequest_ChunkedRequestIncomplete");

        /// <summary>
        /// The message body length cannot be determined because the final transfer coding was set to '{detail}' instead of 'chunked'.
        /// </summary>
        internal static string BadRequest_FinalTransferCodingNotChunked
        {
            get => GetString("BadRequest_FinalTransferCodingNotChunked");
        }

        /// <summary>
        /// The message body length cannot be determined because the final transfer coding was set to '{detail}' instead of 'chunked'.
        /// </summary>
        internal static string FormatBadRequest_FinalTransferCodingNotChunked(object detail)
            => string.Format(CultureInfo.CurrentCulture, GetString("BadRequest_FinalTransferCodingNotChunked", "detail"), detail);

        /// <summary>
        /// Request headers too long.
        /// </summary>
        internal static string BadRequest_HeadersExceedMaxTotalSize
        {
            get => GetString("BadRequest_HeadersExceedMaxTotalSize");
        }

        /// <summary>
        /// Request headers too long.
        /// </summary>
        internal static string FormatBadRequest_HeadersExceedMaxTotalSize()
            => GetString("BadRequest_HeadersExceedMaxTotalSize");

        /// <summary>
        /// Invalid characters in header name.
        /// </summary>
        internal static string BadRequest_InvalidCharactersInHeaderName
        {
            get => GetString("BadRequest_InvalidCharactersInHeaderName");
        }

        /// <summary>
        /// Invalid characters in header name.
        /// </summary>
        internal static string FormatBadRequest_InvalidCharactersInHeaderName()
            => GetString("BadRequest_InvalidCharactersInHeaderName");

        /// <summary>
        /// Invalid content length: {detail}
        /// </summary>
        internal static string BadRequest_InvalidContentLength_Detail
        {
            get => GetString("BadRequest_InvalidContentLength_Detail");
        }

        /// <summary>
        /// Invalid content length: {detail}
        /// </summary>
        internal static string FormatBadRequest_InvalidContentLength_Detail(object detail)
            => string.Format(CultureInfo.CurrentCulture, GetString("BadRequest_InvalidContentLength_Detail", "detail"), detail);

        /// <summary>
        /// Invalid Host header.
        /// </summary>
        internal static string BadRequest_InvalidHostHeader
        {
            get => GetString("BadRequest_InvalidHostHeader");
        }

        /// <summary>
        /// Invalid Host header.
        /// </summary>
        internal static string FormatBadRequest_InvalidHostHeader()
            => GetString("BadRequest_InvalidHostHeader");

        /// <summary>
        /// Invalid Host header: '{detail}'
        /// </summary>
        internal static string BadRequest_InvalidHostHeader_Detail
        {
            get => GetString("BadRequest_InvalidHostHeader_Detail");
        }

        /// <summary>
        /// Invalid Host header: '{detail}'
        /// </summary>
        internal static string FormatBadRequest_InvalidHostHeader_Detail(object detail)
            => string.Format(CultureInfo.CurrentCulture, GetString("BadRequest_InvalidHostHeader_Detail", "detail"), detail);

        /// <summary>
        /// Invalid request headers: missing final CRLF in header fields.
        /// </summary>
        internal static string BadRequest_InvalidRequestHeadersNoCRLF
        {
            get => GetString("BadRequest_InvalidRequestHeadersNoCRLF");
        }

        /// <summary>
        /// Invalid request headers: missing final CRLF in header fields.
        /// </summary>
        internal static string FormatBadRequest_InvalidRequestHeadersNoCRLF()
            => GetString("BadRequest_InvalidRequestHeadersNoCRLF");

        /// <summary>
        /// Invalid request header: '{detail}'
        /// </summary>
        internal static string BadRequest_InvalidRequestHeader_Detail
        {
            get => GetString("BadRequest_InvalidRequestHeader_Detail");
        }

        /// <summary>
        /// Invalid request header: '{detail}'
        /// </summary>
        internal static string FormatBadRequest_InvalidRequestHeader_Detail(object detail)
            => string.Format(CultureInfo.CurrentCulture, GetString("BadRequest_InvalidRequestHeader_Detail", "detail"), detail);

        /// <summary>
        /// Invalid request line.
        /// </summary>
        internal static string BadRequest_InvalidRequestLine
        {
            get => GetString("BadRequest_InvalidRequestLine");
        }

        /// <summary>
        /// Invalid request line.
        /// </summary>
        internal static string FormatBadRequest_InvalidRequestLine()
            => GetString("BadRequest_InvalidRequestLine");

        /// <summary>
        /// Invalid request line: '{detail}'
        /// </summary>
        internal static string BadRequest_InvalidRequestLine_Detail
        {
            get => GetString("BadRequest_InvalidRequestLine_Detail");
        }

        /// <summary>
        /// Invalid request line: '{detail}'
        /// </summary>
        internal static string FormatBadRequest_InvalidRequestLine_Detail(object detail)
            => string.Format(CultureInfo.CurrentCulture, GetString("BadRequest_InvalidRequestLine_Detail", "detail"), detail);

        /// <summary>
        /// Invalid request target: '{detail}'
        /// </summary>
        internal static string BadRequest_InvalidRequestTarget_Detail
        {
            get => GetString("BadRequest_InvalidRequestTarget_Detail");
        }

        /// <summary>
        /// Invalid request target: '{detail}'
        /// </summary>
        internal static string FormatBadRequest_InvalidRequestTarget_Detail(object detail)
            => string.Format(CultureInfo.CurrentCulture, GetString("BadRequest_InvalidRequestTarget_Detail", "detail"), detail);

        /// <summary>
        /// {detail} request contains no Content-Length or Transfer-Encoding header.
        /// </summary>
        internal static string BadRequest_LengthRequired
        {
            get => GetString("BadRequest_LengthRequired");
        }

        /// <summary>
        /// {detail} request contains no Content-Length or Transfer-Encoding header.
        /// </summary>
        internal static string FormatBadRequest_LengthRequired(object detail)
            => string.Format(CultureInfo.CurrentCulture, GetString("BadRequest_LengthRequired", "detail"), detail);

        /// <summary>
        /// {detail} request contains no Content-Length header.
        /// </summary>
        internal static string BadRequest_LengthRequiredHttp10
        {
            get => GetString("BadRequest_LengthRequiredHttp10");
        }

        /// <summary>
        /// {detail} request contains no Content-Length header.
        /// </summary>
        internal static string FormatBadRequest_LengthRequiredHttp10(object detail)
            => string.Format(CultureInfo.CurrentCulture, GetString("BadRequest_LengthRequiredHttp10", "detail"), detail);

        /// <summary>
        /// Malformed request: invalid headers.
        /// </summary>
        internal static string BadRequest_MalformedRequestInvalidHeaders
        {
            get => GetString("BadRequest_MalformedRequestInvalidHeaders");
        }

        /// <summary>
        /// Malformed request: invalid headers.
        /// </summary>
        internal static string FormatBadRequest_MalformedRequestInvalidHeaders()
            => GetString("BadRequest_MalformedRequestInvalidHeaders");

        /// <summary>
        /// Method not allowed.
        /// </summary>
        internal static string BadRequest_MethodNotAllowed
        {
            get => GetString("BadRequest_MethodNotAllowed");
        }

        /// <summary>
        /// Method not allowed.
        /// </summary>
        internal static string FormatBadRequest_MethodNotAllowed()
            => GetString("BadRequest_MethodNotAllowed");

        /// <summary>
        /// Request is missing Host header.
        /// </summary>
        internal static string BadRequest_MissingHostHeader
        {
            get => GetString("BadRequest_MissingHostHeader");
        }

        /// <summary>
        /// Request is missing Host header.
        /// </summary>
        internal static string FormatBadRequest_MissingHostHeader()
            => GetString("BadRequest_MissingHostHeader");

        /// <summary>
        /// Multiple Content-Length headers.
        /// </summary>
        internal static string BadRequest_MultipleContentLengths
        {
            get => GetString("BadRequest_MultipleContentLengths");
        }

        /// <summary>
        /// Multiple Content-Length headers.
        /// </summary>
        internal static string FormatBadRequest_MultipleContentLengths()
            => GetString("BadRequest_MultipleContentLengths");

        /// <summary>
        /// Multiple Host headers.
        /// </summary>
        internal static string BadRequest_MultipleHostHeaders
        {
            get => GetString("BadRequest_MultipleHostHeaders");
        }

        /// <summary>
        /// Multiple Host headers.
        /// </summary>
        internal static string FormatBadRequest_MultipleHostHeaders()
            => GetString("BadRequest_MultipleHostHeaders");

        /// <summary>
        /// Request line too long.
        /// </summary>
        internal static string BadRequest_RequestLineTooLong
        {
            get => GetString("BadRequest_RequestLineTooLong");
        }

        /// <summary>
        /// Request line too long.
        /// </summary>
        internal static string FormatBadRequest_RequestLineTooLong()
            => GetString("BadRequest_RequestLineTooLong");

        /// <summary>
        /// Request timed out.
        /// </summary>
        internal static string BadRequest_RequestTimeout
        {
            get => GetString("BadRequest_RequestTimeout");
        }

        /// <summary>
        /// Request timed out.
        /// </summary>
        internal static string FormatBadRequest_RequestTimeout()
            => GetString("BadRequest_RequestTimeout");

        /// <summary>
        /// Request contains too many headers.
        /// </summary>
        internal static string BadRequest_TooManyHeaders
        {
            get => GetString("BadRequest_TooManyHeaders");
        }

        /// <summary>
        /// Request contains too many headers.
        /// </summary>
        internal static string FormatBadRequest_TooManyHeaders()
            => GetString("BadRequest_TooManyHeaders");

        /// <summary>
        /// Unexpected end of request content.
        /// </summary>
        internal static string BadRequest_UnexpectedEndOfRequestContent
        {
            get => GetString("BadRequest_UnexpectedEndOfRequestContent");
        }

        /// <summary>
        /// Unexpected end of request content.
        /// </summary>
        internal static string FormatBadRequest_UnexpectedEndOfRequestContent()
            => GetString("BadRequest_UnexpectedEndOfRequestContent");

        /// <summary>
        /// Unrecognized HTTP version: '{detail}'
        /// </summary>
        internal static string BadRequest_UnrecognizedHTTPVersion
        {
            get => GetString("BadRequest_UnrecognizedHTTPVersion");
        }

        /// <summary>
        /// Unrecognized HTTP version: '{detail}'
        /// </summary>
        internal static string FormatBadRequest_UnrecognizedHTTPVersion(object detail)
            => string.Format(CultureInfo.CurrentCulture, GetString("BadRequest_UnrecognizedHTTPVersion", "detail"), detail);

        /// <summary>
        /// Requests with 'Connection: Upgrade' cannot have content in the request body.
        /// </summary>
        internal static string BadRequest_UpgradeRequestCannotHavePayload
        {
            get => GetString("BadRequest_UpgradeRequestCannotHavePayload");
        }

        /// <summary>
        /// Requests with 'Connection: Upgrade' cannot have content in the request body.
        /// </summary>
        internal static string FormatBadRequest_UpgradeRequestCannotHavePayload()
            => GetString("BadRequest_UpgradeRequestCannotHavePayload");

        /// <summary>
        /// Failed to bind to http://[::]:{port} (IPv6Any). Attempting to bind to http://0.0.0.0:{port} instead.
        /// </summary>
        internal static string FallbackToIPv4Any
        {
            get => GetString("FallbackToIPv4Any");
        }

        /// <summary>
        /// Failed to bind to http://[::]:{port} (IPv6Any). Attempting to bind to http://0.0.0.0:{port} instead.
        /// </summary>
        internal static string FormatFallbackToIPv4Any(object port)
            => string.Format(CultureInfo.CurrentCulture, GetString("FallbackToIPv4Any", "port"), port);

        /// <summary>
        /// Cannot write to response body after connection has been upgraded.
        /// </summary>
        internal static string ResponseStreamWasUpgraded
        {
            get => GetString("ResponseStreamWasUpgraded");
        }

        /// <summary>
        /// Cannot write to response body after connection has been upgraded.
        /// </summary>
        internal static string FormatResponseStreamWasUpgraded()
            => GetString("ResponseStreamWasUpgraded");

        /// <summary>
        /// Kestrel does not support big-endian architectures.
        /// </summary>
        internal static string BigEndianNotSupported
        {
            get => GetString("BigEndianNotSupported");
        }

        /// <summary>
        /// Kestrel does not support big-endian architectures.
        /// </summary>
        internal static string FormatBigEndianNotSupported()
            => GetString("BigEndianNotSupported");

        /// <summary>
        /// Maximum request buffer size ({requestBufferSize}) must be greater than or equal to maximum request header size ({requestHeaderSize}).
        /// </summary>
        internal static string MaxRequestBufferSmallerThanRequestHeaderBuffer
        {
            get => GetString("MaxRequestBufferSmallerThanRequestHeaderBuffer");
        }

        /// <summary>
        /// Maximum request buffer size ({requestBufferSize}) must be greater than or equal to maximum request header size ({requestHeaderSize}).
        /// </summary>
        internal static string FormatMaxRequestBufferSmallerThanRequestHeaderBuffer(object requestBufferSize, object requestHeaderSize)
            => string.Format(CultureInfo.CurrentCulture, GetString("MaxRequestBufferSmallerThanRequestHeaderBuffer", "requestBufferSize", "requestHeaderSize"), requestBufferSize, requestHeaderSize);

        /// <summary>
        /// Maximum request buffer size ({requestBufferSize}) must be greater than or equal to maximum request line size ({requestLineSize}).
        /// </summary>
        internal static string MaxRequestBufferSmallerThanRequestLineBuffer
        {
            get => GetString("MaxRequestBufferSmallerThanRequestLineBuffer");
        }

        /// <summary>
        /// Maximum request buffer size ({requestBufferSize}) must be greater than or equal to maximum request line size ({requestLineSize}).
        /// </summary>
        internal static string FormatMaxRequestBufferSmallerThanRequestLineBuffer(object requestBufferSize, object requestLineSize)
            => string.Format(CultureInfo.CurrentCulture, GetString("MaxRequestBufferSmallerThanRequestLineBuffer", "requestBufferSize", "requestLineSize"), requestBufferSize, requestLineSize);

        /// <summary>
        /// Server has already started.
        /// </summary>
        internal static string ServerAlreadyStarted
        {
            get => GetString("ServerAlreadyStarted");
        }

        /// <summary>
        /// Server has already started.
        /// </summary>
        internal static string FormatServerAlreadyStarted()
            => GetString("ServerAlreadyStarted");

        /// <summary>
        /// Unknown transport mode: '{mode}'.
        /// </summary>
        internal static string UnknownTransportMode
        {
            get => GetString("UnknownTransportMode");
        }

        /// <summary>
        /// Unknown transport mode: '{mode}'.
        /// </summary>
        internal static string FormatUnknownTransportMode(object mode)
            => string.Format(CultureInfo.CurrentCulture, GetString("UnknownTransportMode", "mode"), mode);

        /// <summary>
        /// Invalid non-ASCII or control character in header: {character}
        /// </summary>
        internal static string InvalidAsciiOrControlChar
        {
            get => GetString("InvalidAsciiOrControlChar");
        }

        /// <summary>
        /// Invalid non-ASCII or control character in header: {character}
        /// </summary>
        internal static string FormatInvalidAsciiOrControlChar(object character)
            => string.Format(CultureInfo.CurrentCulture, GetString("InvalidAsciiOrControlChar", "character"), character);

        /// <summary>
        /// Invalid Content-Length: "{value}". Value must be a positive integral number.
        /// </summary>
        internal static string InvalidContentLength_InvalidNumber
        {
            get => GetString("InvalidContentLength_InvalidNumber");
        }

        /// <summary>
        /// Invalid Content-Length: "{value}". Value must be a positive integral number.
        /// </summary>
        internal static string FormatInvalidContentLength_InvalidNumber(object value)
            => string.Format(CultureInfo.CurrentCulture, GetString("InvalidContentLength_InvalidNumber", "value"), value);

        /// <summary>
        /// Value must be null or a non-negative number.
        /// </summary>
        internal static string NonNegativeNumberOrNullRequired
        {
            get => GetString("NonNegativeNumberOrNullRequired");
        }

        /// <summary>
        /// Value must be null or a non-negative number.
        /// </summary>
        internal static string FormatNonNegativeNumberOrNullRequired()
            => GetString("NonNegativeNumberOrNullRequired");

        /// <summary>
        /// Value must be a non-negative number.
        /// </summary>
        internal static string NonNegativeNumberRequired
        {
            get => GetString("NonNegativeNumberRequired");
        }

        /// <summary>
        /// Value must be a non-negative number.
        /// </summary>
        internal static string FormatNonNegativeNumberRequired()
            => GetString("NonNegativeNumberRequired");

        /// <summary>
        /// Value must be a positive number.
        /// </summary>
        internal static string PositiveNumberRequired
        {
            get => GetString("PositiveNumberRequired");
        }

        /// <summary>
        /// Value must be a positive number.
        /// </summary>
        internal static string FormatPositiveNumberRequired()
            => GetString("PositiveNumberRequired");

        /// <summary>
        /// Value must be null or a positive number.
        /// </summary>
        internal static string PositiveNumberOrNullRequired
        {
            get => GetString("PositiveNumberOrNullRequired");
        }

        /// <summary>
        /// Value must be null or a positive number.
        /// </summary>
        internal static string FormatPositiveNumberOrNullRequired()
            => GetString("PositiveNumberOrNullRequired");

        /// <summary>
        /// Unix socket path must be absolute.
        /// </summary>
        internal static string UnixSocketPathMustBeAbsolute
        {
            get => GetString("UnixSocketPathMustBeAbsolute");
        }

        /// <summary>
        /// Unix socket path must be absolute.
        /// </summary>
        internal static string FormatUnixSocketPathMustBeAbsolute()
            => GetString("UnixSocketPathMustBeAbsolute");

        /// <summary>
        /// Failed to bind to address {address}.
        /// </summary>
        internal static string AddressBindingFailed
        {
            get => GetString("AddressBindingFailed");
        }

        /// <summary>
        /// Failed to bind to address {address}.
        /// </summary>
        internal static string FormatAddressBindingFailed(object address)
            => string.Format(CultureInfo.CurrentCulture, GetString("AddressBindingFailed", "address"), address);

        /// <summary>
        /// No listening endpoints were configured. Binding to {address} by default.
        /// </summary>
        internal static string BindingToDefaultAddress
        {
            get => GetString("BindingToDefaultAddress");
        }

        /// <summary>
        /// No listening endpoints were configured. Binding to {address} by default.
        /// </summary>
        internal static string FormatBindingToDefaultAddress(object address)
            => string.Format(CultureInfo.CurrentCulture, GetString("BindingToDefaultAddress", "address"), address);

        /// <summary>
        /// HTTPS endpoints can only be configured using {methodName}.
        /// </summary>
        internal static string ConfigureHttpsFromMethodCall
        {
            get => GetString("ConfigureHttpsFromMethodCall");
        }

        /// <summary>
        /// HTTPS endpoints can only be configured using {methodName}.
        /// </summary>
        internal static string FormatConfigureHttpsFromMethodCall(object methodName)
            => string.Format(CultureInfo.CurrentCulture, GetString("ConfigureHttpsFromMethodCall", "methodName"), methodName);

        /// <summary>
        /// A path base can only be configured using {methodName}.
        /// </summary>
        internal static string ConfigurePathBaseFromMethodCall
        {
            get => GetString("ConfigurePathBaseFromMethodCall");
        }

        /// <summary>
        /// A path base can only be configured using {methodName}.
        /// </summary>
        internal static string FormatConfigurePathBaseFromMethodCall(object methodName)
            => string.Format(CultureInfo.CurrentCulture, GetString("ConfigurePathBaseFromMethodCall", "methodName"), methodName);

        /// <summary>
        /// Dynamic port binding is not supported when binding to localhost. You must either bind to 127.0.0.1:0 or [::1]:0, or both.
        /// </summary>
        internal static string DynamicPortOnLocalhostNotSupported
        {
            get => GetString("DynamicPortOnLocalhostNotSupported");
        }

        /// <summary>
        /// Dynamic port binding is not supported when binding to localhost. You must either bind to 127.0.0.1:0 or [::1]:0, or both.
        /// </summary>
        internal static string FormatDynamicPortOnLocalhostNotSupported()
            => GetString("DynamicPortOnLocalhostNotSupported");

        /// <summary>
        /// Failed to bind to address {endpoint}: address already in use.
        /// </summary>
        internal static string EndpointAlreadyInUse
        {
            get => GetString("EndpointAlreadyInUse");
        }

        /// <summary>
        /// Failed to bind to address {endpoint}: address already in use.
        /// </summary>
        internal static string FormatEndpointAlreadyInUse(object endpoint)
            => string.Format(CultureInfo.CurrentCulture, GetString("EndpointAlreadyInUse", "endpoint"), endpoint);

        /// <summary>
        /// Invalid URL: '{url}'.
        /// </summary>
        internal static string InvalidUrl
        {
            get => GetString("InvalidUrl");
        }

        /// <summary>
        /// Invalid URL: '{url}'.
        /// </summary>
        internal static string FormatInvalidUrl(object url)
            => string.Format(CultureInfo.CurrentCulture, GetString("InvalidUrl", "url"), url);

        /// <summary>
        /// Unable to bind to {address} on the {interfaceName} interface: '{error}'.
        /// </summary>
        internal static string NetworkInterfaceBindingFailed
        {
            get => GetString("NetworkInterfaceBindingFailed");
        }

        /// <summary>
        /// Unable to bind to {address} on the {interfaceName} interface: '{error}'.
        /// </summary>
        internal static string FormatNetworkInterfaceBindingFailed(object address, object interfaceName, object error)
            => string.Format(CultureInfo.CurrentCulture, GetString("NetworkInterfaceBindingFailed", "address", "interfaceName", "error"), address, interfaceName, error);

        /// <summary>
        /// Overriding address(es) '{addresses}'. Binding to endpoints defined in {methodName} instead.
        /// </summary>
        internal static string OverridingWithKestrelOptions
        {
            get => GetString("OverridingWithKestrelOptions");
        }

        /// <summary>
        /// Overriding address(es) '{addresses}'. Binding to endpoints defined in {methodName} instead.
        /// </summary>
        internal static string FormatOverridingWithKestrelOptions(object addresses, object methodName)
            => string.Format(CultureInfo.CurrentCulture, GetString("OverridingWithKestrelOptions", "addresses", "methodName"), addresses, methodName);

        /// <summary>
        /// Overriding endpoints defined in UseKestrel() because {settingName} is set to true. Binding to address(es) '{addresses}' instead.
        /// </summary>
        internal static string OverridingWithPreferHostingUrls
        {
            get => GetString("OverridingWithPreferHostingUrls");
        }

        /// <summary>
        /// Overriding endpoints defined in UseKestrel() because {settingName} is set to true. Binding to address(es) '{addresses}' instead.
        /// </summary>
        internal static string FormatOverridingWithPreferHostingUrls(object settingName, object addresses)
            => string.Format(CultureInfo.CurrentCulture, GetString("OverridingWithPreferHostingUrls", "settingName", "addresses"), settingName, addresses);

        /// <summary>
        /// Unrecognized scheme in server address '{address}'. Only 'http://' is supported.
        /// </summary>
        internal static string UnsupportedAddressScheme
        {
            get => GetString("UnsupportedAddressScheme");
        }

        /// <summary>
        /// Unrecognized scheme in server address '{address}'. Only 'http://' is supported.
        /// </summary>
        internal static string FormatUnsupportedAddressScheme(object address)
            => string.Format(CultureInfo.CurrentCulture, GetString("UnsupportedAddressScheme", "address"), address);

        /// <summary>
        /// Headers are read-only, response has already started.
        /// </summary>
        internal static string HeadersAreReadOnly
        {
            get => GetString("HeadersAreReadOnly");
        }

        /// <summary>
        /// Headers are read-only, response has already started.
        /// </summary>
        internal static string FormatHeadersAreReadOnly()
            => GetString("HeadersAreReadOnly");

        /// <summary>
        /// An item with the same key has already been added.
        /// </summary>
        internal static string KeyAlreadyExists
        {
            get => GetString("KeyAlreadyExists");
        }

        /// <summary>
        /// An item with the same key has already been added.
        /// </summary>
        internal static string FormatKeyAlreadyExists()
            => GetString("KeyAlreadyExists");

        /// <summary>
        /// Setting the header {name} is not allowed on responses with status code {statusCode}.
        /// </summary>
        internal static string HeaderNotAllowedOnResponse
        {
            get => GetString("HeaderNotAllowedOnResponse");
        }

        /// <summary>
        /// Setting the header {name} is not allowed on responses with status code {statusCode}.
        /// </summary>
        internal static string FormatHeaderNotAllowedOnResponse(object name, object statusCode)
            => string.Format(CultureInfo.CurrentCulture, GetString("HeaderNotAllowedOnResponse", "name", "statusCode"), name, statusCode);

        /// <summary>
        /// {name} cannot be set because the response has already started.
        /// </summary>
        internal static string ParameterReadOnlyAfterResponseStarted
        {
            get => GetString("ParameterReadOnlyAfterResponseStarted");
        }

        /// <summary>
        /// {name} cannot be set because the response has already started.
        /// </summary>
        internal static string FormatParameterReadOnlyAfterResponseStarted(object name)
            => string.Format(CultureInfo.CurrentCulture, GetString("ParameterReadOnlyAfterResponseStarted", "name"), name);

        /// <summary>
        /// Request processing didn't complete within the shutdown timeout.
        /// </summary>
        internal static string RequestProcessingAborted
        {
            get => GetString("RequestProcessingAborted");
        }

        /// <summary>
        /// Request processing didn't complete within the shutdown timeout.
        /// </summary>
        internal static string FormatRequestProcessingAborted()
            => GetString("RequestProcessingAborted");

        /// <summary>
        /// Response Content-Length mismatch: too few bytes written ({written} of {expected}).
        /// </summary>
        internal static string TooFewBytesWritten
        {
            get => GetString("TooFewBytesWritten");
        }

        /// <summary>
        /// Response Content-Length mismatch: too few bytes written ({written} of {expected}).
        /// </summary>
        internal static string FormatTooFewBytesWritten(object written, object expected)
            => string.Format(CultureInfo.CurrentCulture, GetString("TooFewBytesWritten", "written", "expected"), written, expected);

        /// <summary>
        /// Response Content-Length mismatch: too many bytes written ({written} of {expected}).
        /// </summary>
        internal static string TooManyBytesWritten
        {
            get => GetString("TooManyBytesWritten");
        }

        /// <summary>
        /// Response Content-Length mismatch: too many bytes written ({written} of {expected}).
        /// </summary>
        internal static string FormatTooManyBytesWritten(object written, object expected)
            => string.Format(CultureInfo.CurrentCulture, GetString("TooManyBytesWritten", "written", "expected"), written, expected);

        /// <summary>
        /// The response has been aborted due to an unhandled application exception.
        /// </summary>
        internal static string UnhandledApplicationException
        {
            get => GetString("UnhandledApplicationException");
        }

        /// <summary>
        /// The response has been aborted due to an unhandled application exception.
        /// </summary>
        internal static string FormatUnhandledApplicationException()
            => GetString("UnhandledApplicationException");

        /// <summary>
        /// Writing to the response body is invalid for responses with status code {statusCode}.
        /// </summary>
        internal static string WritingToResponseBodyNotSupported
        {
            get => GetString("WritingToResponseBodyNotSupported");
        }

        /// <summary>
        /// Writing to the response body is invalid for responses with status code {statusCode}.
        /// </summary>
        internal static string FormatWritingToResponseBodyNotSupported(object statusCode)
            => string.Format(CultureInfo.CurrentCulture, GetString("WritingToResponseBodyNotSupported", "statusCode"), statusCode);

        /// <summary>
        /// Connection shutdown abnormally.
        /// </summary>
        internal static string ConnectionShutdownError
        {
            get => GetString("ConnectionShutdownError");
        }

        /// <summary>
        /// Connection shutdown abnormally.
        /// </summary>
        internal static string FormatConnectionShutdownError()
            => GetString("ConnectionShutdownError");

        /// <summary>
        /// Connection processing ended abnormally.
        /// </summary>
        internal static string RequestProcessingEndError
        {
            get => GetString("RequestProcessingEndError");
        }

        /// <summary>
        /// Connection processing ended abnormally.
        /// </summary>
        internal static string FormatRequestProcessingEndError()
            => GetString("RequestProcessingEndError");

        /// <summary>
        /// Cannot upgrade a non-upgradable request. Check IHttpUpgradeFeature.IsUpgradableRequest to determine if a request can be upgraded.
        /// </summary>
        internal static string CannotUpgradeNonUpgradableRequest
        {
            get => GetString("CannotUpgradeNonUpgradableRequest");
        }

        /// <summary>
        /// Cannot upgrade a non-upgradable request. Check IHttpUpgradeFeature.IsUpgradableRequest to determine if a request can be upgraded.
        /// </summary>
        internal static string FormatCannotUpgradeNonUpgradableRequest()
            => GetString("CannotUpgradeNonUpgradableRequest");

        /// <summary>
        /// Request cannot be upgraded because the server has already opened the maximum number of upgraded connections.
        /// </summary>
        internal static string UpgradedConnectionLimitReached
        {
            get => GetString("UpgradedConnectionLimitReached");
        }

        /// <summary>
        /// Request cannot be upgraded because the server has already opened the maximum number of upgraded connections.
        /// </summary>
        internal static string FormatUpgradedConnectionLimitReached()
            => GetString("UpgradedConnectionLimitReached");

        /// <summary>
        /// IHttpUpgradeFeature.UpgradeAsync was already called and can only be called once per connection.
        /// </summary>
        internal static string UpgradeCannotBeCalledMultipleTimes
        {
            get => GetString("UpgradeCannotBeCalledMultipleTimes");
        }

        /// <summary>
        /// IHttpUpgradeFeature.UpgradeAsync was already called and can only be called once per connection.
        /// </summary>
        internal static string FormatUpgradeCannotBeCalledMultipleTimes()
            => GetString("UpgradeCannotBeCalledMultipleTimes");

        /// <summary>
        /// Request body too large.
        /// </summary>
        internal static string BadRequest_RequestBodyTooLarge
        {
            get => GetString("BadRequest_RequestBodyTooLarge");
        }

        /// <summary>
        /// Request body too large.
        /// </summary>
        internal static string FormatBadRequest_RequestBodyTooLarge()
            => GetString("BadRequest_RequestBodyTooLarge");

        /// <summary>
        /// The maximum request body size cannot be modified after the app has already started reading from the request body.
        /// </summary>
        internal static string MaxRequestBodySizeCannotBeModifiedAfterRead
        {
            get => GetString("MaxRequestBodySizeCannotBeModifiedAfterRead");
        }

        /// <summary>
        /// The maximum request body size cannot be modified after the app has already started reading from the request body.
        /// </summary>
        internal static string FormatMaxRequestBodySizeCannotBeModifiedAfterRead()
            => GetString("MaxRequestBodySizeCannotBeModifiedAfterRead");

        /// <summary>
        /// The maximum request body size cannot be modified after the request has be upgraded.
        /// </summary>
        internal static string MaxRequestBodySizeCannotBeModifiedForUpgradedRequests
        {
            get => GetString("MaxRequestBodySizeCannotBeModifiedForUpgradedRequests");
        }

        /// <summary>
        /// The maximum request body size cannot be modified after the request has be upgraded.
        /// </summary>
        internal static string FormatMaxRequestBodySizeCannotBeModifiedForUpgradedRequests()
            => GetString("MaxRequestBodySizeCannotBeModifiedForUpgradedRequests");

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
