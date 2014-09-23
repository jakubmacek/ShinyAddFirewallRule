# ShinyAddFirewallRule

The aim of this project is to simplify adding rules for outbound connections to Windows Firewall. 
I use UAC at the highest level, so AFAIK you need to run this program with elevation. I have it pinned
in the start menu and use Ctrl + Shift + click.

There's only one form with a combobox list that shows all currently running processes. When you pick one,
the name of the rules gets pre-filled and you can change it. I use "_Program:" prefix, so the rules are
grouped together in the Windows Firewall MMC snap-in.

Clicking the button runs netsh.exe and creates outbound rule allowing all traffic for given executable path.
