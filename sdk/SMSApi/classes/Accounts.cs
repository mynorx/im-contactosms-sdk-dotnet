﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace InteractuaMovil.ContactoSms.Api
{
    internal class Accounts : ApiRequest, interfaces.IAccounts
    {
        internal Accounts(string ApiKey, string SecretKey, string ApiUrl) : base (ApiKey, SecretKey, ApiUrl) { }
        internal Accounts(string ApiKey, string SecretKey, string ApiUrl, string ProxyAddress, string Username, string Password) : base(ApiKey, SecretKey, ApiUrl, ProxyAddress, Username, Password) { }

        /// <summary>
        /// Returns the account general information
        /// </summary>
        /// <returns>List<T></returns>
        public ResponseObjects.ApiResponse<AccountStatusResponse> Status()
        {
            ResponseObjects.ApiResponse<AccountStatusResponse> serverResponse = this.RequestToApi<AccountStatusResponse>("account/status", request.get, null, null);
            return serverResponse;
            //object serverResponse = this.RequestToApi("account/status", request.get, null, null);
            //if (serverResponse.GetType() == typeof(List<string>))
            //    return serverResponse;
            //else
            //    return JsonConvert.DeserializeObject<AccountStatusResponse>((string)serverResponse);
        }
    }
}
