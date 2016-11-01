using Nethereum.RPC.Eth.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nethereum.Uport
{
    public class UriBuilder
    {
        private static string GetNextUriParameterSymbol(string uri)
        {
            if (uri.Contains("?")) return "&"; else return "?";
        }
        private static string AppendCallBackUrl(string uri, Topic topic)
        {
            return uri + GetNextUriParameterSymbol(uri) + "callback_url=" + topic.Url;
        }
        public static string BuildTransactionUri(TransactionInput txParams, Topic topic)
        {
            string uri = BuildUriFromTransactionParameters(txParams);
            return AppendCallBackUrl(uri, topic);
        }

        public static string BuildAddressUri(Topic topic)
        {
            var uri = "ethereum:me";
            return AppendCallBackUrl(uri, topic);
        }

        private static string BuildUriFromTransactionParameters(TransactionInput txParams)
        {
            var uri = "ethereum:" + txParams.To;
            var symbol = string.Empty;

            if (string.IsNullOrEmpty(txParams.To))
            {
                throw new Exception("Contract creation is not supported");
            }

            if (txParams.Value != null)
            {
                uri += GetNextUriParameterSymbol(uri) + "value=" + txParams.Value.Value.ToString();
            }

            if (txParams.Data != null)
            {
                symbol = GetNextUriParameterSymbol(uri);
                uri += symbol + "bytecode=" + txParams.Data;
            }

            if (txParams.Gas != null)
            {
                symbol = GetNextUriParameterSymbol(uri);
                uri += symbol + "gas=" + txParams.Gas.Value.ToString();
            }

            return uri;
        }
    }
}
