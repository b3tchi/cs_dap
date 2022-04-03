```bash
dotnet build
```
debug via cli
--run arg to start imediatly
```bash
# integratedTerminal
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
tmux send-keys -t cs_debug@main:1.1 $cmdc C-m
fg
```
current buffer type

```vim
:echom getbufvar(bufnr(),'&filetype')
```
```vim
:echom VimuxPromptCommand()
```

```vim
" call VimuxRunCommand('dotnet build')
call VimuxRunCommand('dotnet run')
lua << EOF
function shll(ppid)
function sleep(n)
  os.execute("sleep " .. tonumber(n))
end
local result
try = 10
while( result == nil or result == '' )
do
print(result)
local handle = io.popen("ps --no-headers -o pid --ppid " .. ppid)
result = handle:read("*a")
handle:close()
try = try - 1
sleep(1)
print(try)
if ( try == 0 ) then
break
end
end
return result

end

  local panepid = 168779
  local appid = shll(panepid)
  local dbgpid = shll(appid)

  print(panepid)
  print(appid)
  print(dbgpid)

local cfg = {type="netcoredbg", request="attach", processId=dbgpid}
require'dap'.run(cfg)

-- vim.cmd([[
--  echom VimuxRunCommand('dotnet run')
-- ]])
EOF

```
-a all sessions
-s current session
```bash
tmux list-panes -s -F "#{pane_current_command} #{pane_pid} #{session_name}"
```
