using System;
using System.Collections.Generic;
using eoscmd.Arguments;
using EOSNewYork.EOSCore.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PowerArgs;
using Action = EOSNewYork.EOSCore.Params.Action;

namespace eoscmd
{
    [TabCompletion]
    [ArgExceptionBehavior(ArgExceptionPolicy.StandardExceptionHandling)]
    public class EOSCmd
    {
        [HelpHook, ArgShortcut("-?"), ArgDescription("Show help")]
        public bool Help { get; set; }

        [ArgActionMethod, ArgDescription("new_keypair : Generate new keypair")]
        public void new_keypair()
        {
            OutputJson(KeyManager.GenerateKeyPair());
        }
        [ArgActionMethod, ArgDescription("get_info : Get global blockchain information")]
        public void get_info([ArgRequired]BaseArguments args)
        {
            OutputJson(ChainAPIProvider.GetInstance(args.host.AbsoluteUri).GetInfo());
        }
        [ArgActionMethod, ArgDescription("abi_bin_to_json : Convert binary abi to json format")]
        public void abi_bin_to_json([ArgRequired]AbiBinToJsonArguments args)
        {
            OutputJson(ChainAPIProvider.GetInstance(args.host.AbsoluteUri).GetAbiBinToJson(args.code, args.action, args.binargs));
        }
        [ArgActionMethod, ArgDescription("abi_json_to_bin : Convert json abi to binary format")]
        public void abi_json_to_bin([ArgRequired]AbiJsonToBinArguments args)
        {
            if(IsValidJson(args.args))
            {
                object argsObject = JsonConvert.DeserializeObject(args.args);
                OutputJson(ChainAPIProvider.GetInstance(args.host.AbsoluteUri).GetAbiJsonToBin(args.code, args.action, argsObject));
            }
        }
        [ArgActionMethod, ArgDescription("get_account : Get account information")]
        public void get_account([ArgRequired]AccountArguments args)
        {
            OutputJson(ChainAPIProvider.GetInstance(args.host.AbsoluteUri).GetAccount(args.account_name));
        }
        [ArgActionMethod, ArgDescription("get_block : Get block information")]
        public void get_block([ArgRequired]BlockArguments args)
        {
            OutputJson(ChainAPIProvider.GetInstance(args.host.AbsoluteUri).GetBlock(args.block_num_or_id));
        }
        [ArgActionMethod, ArgDescription("get_abi : Get abi for account")]
        public void get_abi([ArgRequired]AccountArguments args)
        {
            OutputJson(ChainAPIProvider.GetInstance(args.host.AbsoluteUri).GetAbi(args.account_name));
        }
        [ArgActionMethod, ArgDescription("get_code : Get code for account")]
        public void get_code([ArgRequired]CodeArguments args)
        {
            OutputJson(ChainAPIProvider.GetInstance(args.host.AbsoluteUri).GetCode(args.account_name, args.code_as_wasm));
        }
        [ArgActionMethod, ArgDescription("get_raw_code_and_abi : Get raw code and abi for account")]
        public void get_raw_code_and_abi([ArgRequired]AccountArguments args)
        {
            OutputJson(ChainAPIProvider.GetInstance(args.host.AbsoluteUri).GetRawCodeAndAbi(args.account_name));
        }
        [ArgActionMethod, ArgDescription("get_currency_balance : Get currency balance")]
        public void get_currency_balance([ArgRequired]CurrencyBalanceArguments args)
        {
            OutputJson(ChainAPIProvider.GetInstance(args.host.AbsoluteUri).GetCurrencyBalance(args.account, args.code, args.symbol));
        }
        [ArgActionMethod, ArgDescription("get_table_rows : Get table rows")]
        public void get_table_rows([ArgRequired]TableRowsArguments args)
        {
            OutputJson(ChainAPIProvider.GetInstance(args.host.AbsoluteUri).GetTableRows(args.scope, args.code, args.table, "true", args.lower_bound, args.upper_bound, args.limit));
        }
        [ArgActionMethod, ArgDescription("get_producer_schedule : Get produces schedule")]
        public void get_producer_schedule([ArgRequired]BaseArguments args)
        {
            OutputJson(ChainAPIProvider.GetInstance(args.host.AbsoluteUri).GetProducerSchedule());
        }
        [ArgActionMethod, ArgDescription("push_action : Push an action as a transaction")]
        public void push_action([ArgRequired]PushActionArguments args)
        {
            if(IsValidJson(args.args))
            {
                Action action = new ActionUtility(args.host.AbsoluteUri).GetActionObject(args.action, args.permission_actor, args.permission_name, args.code, JsonConvert.DeserializeObject(args.args));
                List<string> privateKeys = JsonConvert.DeserializeObject<List<string>>(args.private_keys);
                OutputJson(ChainAPIProvider.GetInstance(args.host.AbsoluteUri).PushTransaction(new [] { action }, privateKeys));
            }
        }
        [ArgActionMethod, ArgDescription("push_transaction : Push a transaction")]
        public void push_transaction([ArgRequired]PushTransactionArguments args)
        {
            if(IsValidJson(args.actions) && IsValidJson(args.private_keys))
            {
                Action[] actions = JsonConvert.DeserializeObject<Action[]>(args.actions);
                List<string> privateKeys = JsonConvert.DeserializeObject<List<string>>(args.private_keys);
                OutputJson(ChainAPIProvider.GetInstance(args.host.AbsoluteUri).PushTransaction(actions, privateKeys));
            }
        }
        private static bool IsValidJson(string value)
        {
            value = value.Trim();
            if ((value.StartsWith("{") && value.EndsWith("}")) || //For object
                (value.StartsWith("[") && value.EndsWith("]"))) //For array
            {
                try
                {
                    var obj = JToken.Parse(value);
                    return true;
                }
                catch (JsonReaderException jex)
                {
                    //Exception in parsing json
                    Console.WriteLine(jex.Message);
                    return false;
                }
                catch (Exception ex) //some other exception
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        private static void OutputJson<T>(T apiResult)
        {
            string json = JsonConvert.SerializeObject(apiResult, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}
