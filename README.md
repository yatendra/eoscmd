[Download linux-x64, osx-x64 or win-x64 build](https://github.com/yatendra/eoscmd/releases)

**eoscmd** is a cross-platform tool to access EOS blockchain from command line. It is implemented using .Net core and uses [EOSDotNet](https://github.com/eosnewyork/EOSDotNet) from EOSNewYork. Currenctly It is published for win-x64, linux-x64 and osx-x64 platforms. Other platforms that it can be built for are listed [here](https://docs.microsoft.com/en-us/dotnet/core/rid-catalog). Its capabilities include - 

 1. Generate keys
 2. Push action - with off-chain/offline signing using private key in WIF
 3. Push transaction - with off-chain/offline signing using private key in WIF
 4. Get account
 5. Get currency balance
 6. Get table rows
 7. Get info
 8.  Abi bin to json
 9. Abi json to bin
 10. Get block
 11. Get abi
 12. Get code
 13. Get raw code and abi 
 14. Get producer schedule

## Using eoscmd

 1. Download the and unzip the zip file for your platform from [here](https://github.com/eosnewyork/EOSDotNet/releases)
 2. run eoscmd
>./eoscmd

## Help
Execute - 
> ./eoscmd

or 
> ./eoscmd -?
````
$ ./eoscmd 
Usage - eoscmd <action> -options

GlobalOption   Description
Help (-?)      Show help

Actions

  new_keypair  - new_keypair : Generate new keypair


  get_info <host>  - get_info : Get global blockchain information

    Option       Description
    host* (-h)   URL of the API that will be queried. This is a sticky param and will be remembered
                 after you've used it once.

  abi_bin_to_json <host> <code> <action> <binargs>  - abi_bin_to_json : Convert binary abi to json format

    Option          Description
    code* (-c)      Contract name
    action* (-a)    Action name
    binargs* (-b)   Binary arguments
    host* (-h)      URL of the API that will be queried. This is a sticky param and will be
                    remembered after you've used it once.

  abi_json_to_bin <host> <code> <action> <args>  - abi_json_to_bin : Convert json abi to binary format

    Option         Description
    code* (-c)     Contract name
    action* (-a)   Action name
    args* (-ar)    Json arguments 
    host* (-h)     URL of the API that will be queried. This is a sticky param and will be remembered
                   after you've used it once.

  get_account <host> <account_name>  - get_account : Get account information

    Option               Description
    account_name* (-a)   Account name
    host* (-h)           URL of the API that will be queried. This is a sticky param and will be
                         remembered after you've used it once.

  get_block <host> <block_num_or_id>  - get_block : Get block information

    Option                  Description
    block_num_or_id* (-b)   Block number or id
    host* (-h)              URL of the API that will be queried. This is a sticky param and will be
                            remembered after you've used it once.

  get_abi <host> <account_name>  - get_abi : Get abi for account

    Option               Description
    account_name* (-a)   Account name
    host* (-h)           URL of the API that will be queried. This is a sticky param and will be
                         remembered after you've used it once.

  get_code <host> <account_name> <code_as_wasm>  - get_code : Get code for account

    Option               Description
    account_name* (-a)   Account name
    code_as_wasm* (-c)   Code as wasm
    host* (-h)           URL of the API that will be queried. This is a sticky param and will be
                         remembered after you've used it once.

  get_raw_code_and_abi <host> <account_name>  - get_raw_code_and_abi : Get raw code and abi for account

    Option               Description
    account_name* (-a)   Account name
    host* (-h)           URL of the API that will be queried. This is a sticky param and will be
                         remembered after you've used it once.

  get_currency_balance <host> <account> <code> <symbol>  - get_currency_balance : Get currency balance

    Option          Description
    account* (-a)   Account name
    code* (-c)      Contract name
    symbol* (-s)    Currency symbol
    host* (-h)      URL of the API that will be queried. This is a sticky param and will be
                    remembered after you've used it once.

  get_table_rows <host> <code> <scope> <table> <lower_bound> <limit> [<upper_bound>]  - get_table_rows : Get table rows

    Option              Description
    code* (-c)          Contract name
    scope* (-s)         Scope
    table* (-t)         Table name 
    lower_bound* (-l)   Lower bound  [Default='0'] 
    limit* (-li)        Limit  [Default='10'] 
    upper_bound (-u)    Upper bound  [Default='-1'] 
    host* (-h)          URL of the API that will be queried. This is a sticky param and will be
                        remembered after you've used it once.

  get_producer_schedule <host>  - get_producer_schedule : Get produces schedule

    Option       Description
    host* (-h)   URL of the API that will be queried. This is a sticky param and will be remembered
                 after you've used it once.

  push_action <host> <account> <action> <permission_actor> <permission_name> <code> <args> <private_keys>  - push_action : Push an action as a transaction

    Option                   Description
    account* (-a)            Account name
    action* (-ac)            Action name
    permission_actor* (-p)   Permission actor
    permission_name* (-pe)   Permission name
    code* (-c)               Contract name
    args* (-ar)              Action arguments json string
    private_keys* (-pk)      Private keys in WIF format as json array
    host* (-h)               URL of the API that will be queried. This is a sticky param and will be
                             remembered after you've used it once.

  push_transaction <host> <actions> <private_keys>  - push_transaction : Push a transaction

    Option               Description
    actions* (-a)        Actions as json array
    private_keys* (-p)   Private keys in WIF format as json array
    host* (-h)           URL of the API that will be queried. This is a sticky param and will be
                         remembered after you've used it once.

````
