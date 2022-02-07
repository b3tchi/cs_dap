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
dbpid=$("ps --ppid $appid")
fg 
```

```
:lua require'dap'.run({dap config})
```

```bash
pgrep -a main
#find process to attach debuger with main.dll name of runtime
#its process under dot net run
```
