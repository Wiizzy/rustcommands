<perm>
|turretloadouts.autotoggle| -- <t>For players with this permission, deploying a turret will automatically power it on, but only if it was filled with a weapon and ammo.</t>
|turretloadouts.autotoggle.samsite| -- <t>For players with this permission, deploying a sam site will automatically power it on.</t>
|turretloadouts.manage| -- <t>Allows the player to use tl, tl help|list, and tl <loadout name>.</t>
|turretloadouts.manage.custom| -- <t>Allows the player to manage custom loadouts using tl save|update|rename|delete, according to their allowed loadout ruleset. Also allows the commands from the turretloadouts.manage permission.</t>
</perm>

<comm>
|tl| -- <t>Display your active turret loadout, including weapon, loaded ammo, attachments and reserve ammo.</t>
|tl help| -- <t>Display help information about the commands you are allowed to use.</t>
|tl list| -- <t>List your loadouts, including default and custom.</t>
|tl <loadout name>| -- <t>Activate or deactivate the specified loadout. The active loadout applies when you deploy a turret. Having no active loadout will allow you to deploy a turret without adding any items to it.</t>
|tl save <name>| -- <t>Save a custom loadout with the turret you are aiming at.</t>
|tl update <name>| -- <t>Update an existing custom loadout with the turret you are aiming at.</t>
|tl rename <name> <new name>| -- <t>Rename a custom loadout.</t>
|tl delete <name>| -- <t>Delete a custom loadout.</t>
</comm>
