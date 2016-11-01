using Nethereum.JsonRpc.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Nethereum.RPC.Eth.DTOs;
using System.Net.Http;

namespace Nethereum.Uport
{

    //public class UportInterceptor: RequestInterceptor
    //{
    //    public UportInterceptor()
    //    {
    //    }

    //    private Task<RpcResponse> GetAddress()
    //    {
    //       // return "";
    //    }

    //    private Task<RpcResponse> GetAddressAsArray()
    //    {
    //       // return "";
    //    }

    //    public override Task<RpcResponse> InterceptSendRequestAsync(Func<RpcRequest, string, Task<RpcResponse>> interceptedSendRequestAsync, RpcRequest request, string route = null)
    //    {
    //        switch (request.Method)
    //        {
    //            case "eth_coinbase":
    //                return GetAddress();

    //            case "eth_accounts":
    //                return GetAddressAsArray();



    //            //case 'eth_sendTransaction':
    //            //              let txParams = payload.params[0]
    //            //  async.waterfall([
    //            //    self.validateTransaction.bind(self, txParams),
    //            //    self.txParamsToUri.bind(self, txParams),
    //            //    self.signAndReturnTxHash.bind(self)
    //            //  ], end)
    //            //  return

    //            default:
    //        }

    
    //   }

    //    public override Task<RpcResponse> InterceptSendRequestAsync(Func<string, string, object[], Task<RpcResponse>> interceptedSendRequestAsync, string method, string route = null, params object[] paramList)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
