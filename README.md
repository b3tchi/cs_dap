```bash
dotnet build
```
debug via cli
--run arg to start imediatly
```bashintegratedTerminal
~/.local/share/nvim/dapinstall/dnetcs/netcoredbg/netcoredbg --run --interpreter=cli -- /usr/bin/dotnet ./bin/Debug/net6.0/main.dll
```

```bash
~/.local/share/nvim/dapinstall/dnetcs/netcoredbg/netcoredbg --run --server --interpreter=vscode -- /usr/bin/dotnet ./bin/Debug/net6.0/main.dll
```

```bash
~/.local/share/nvim/dapinstall/dnetcs/netcoredbg/netcoredbg --help
```

get pid of the project
```bash
dotnet build
dotnet run &
appid=$!
while [[ -z $dbpid ]];do
dbpid=$(ps --no-headers -o pid --ppid $appid)
donet
# echo "found $appid $dpid"
fg
```

run debugger with attach
```
:lua require'dap'.run({dap config})
```

```bash
echo$(ps --no-headers -o pid --ppid 102437)
```

```bash
ppid=154789
cfg='{type="netcoredbg", request="attach", processId=<PID>}'
cmd=":lua require'dap'.run(<CFG>)"

cmdc=$cmd
cmdc="${cmdc/<CFG>/${cfg}}"
cmdc="${cmdc/<PID>/${ppid}}"
echo $cmdc
tmux send-keys -t cs_debug:nvim.1 $cmdc
```

```bash
dotnet build
dotnet run &
appid=$!
ppid=""
while [[ -z $ppid ]];do
ppid=$(ps --no-headers -o pid --ppid $appid)
done
echo "found $appid $ppid"
# ppid=
cfg='{type="netcoredbg", request="attach", processId=<PID>}'
cmd=":lua require'dap'.run(<CFG>)"

cmdc=$cmd
cmdc="${cmdc/<CFG>/${cfg}}"
cmdc="${cmdc/<PID>/${ppid}}"
tmux send-keys -t cs_debug:nvim.1 $cmdc C-m
fg
```
