<perm>
1. |raidablebases.allow| -- <t>Allows player to use the available ADMIN commands. This is NOT recommended as players can use the command 'rb' already.</t>
2. |raidablebases.canbypass| - <t>permission (or to be flying) to bypass dome restrictions (this previously worked for admins, but now requires the permission instead)</t>
3. |raidablebases.blockbypass| - <t>permission to bypass Owning More Than One Raid settings for Clans/Friends/Teams</t>
4. |raidablebases.mapteleport| - <t>Teleporting to map marker now simply requires this permission and to be enabled in config</t>
5. |raidablebases.ddraw| <t>allows support for FauxAdmin users</t>
6. |raidablebases.config| <t>allows use of the rb.config command in-game (server console does not require this permission)</t>
7. |raidablebases.banned| <t>bans the user from entering any raids - DO NOT GIVE THIS TO THE DEFAULT GROUP LOL</t>
</perm>

<comm>
1. |rb| - <t>for players to see the ladder (also for admins to see the status of each raid going on, which includes showing the allies and owners of each raid)</t>
2. |rb grid| - <t>see the grid and all monument names</t>
3. |rb debug| - <t>shows important debug information about why a maintained or scheduled event is not spawning</t>
4. |rb resettime| - <t>reset the time for the next scheduled event</t>
5. |rbe| - <t>spawns a base at the position you are looking at. You cannot spawn a base on a player (including yourself)</t>
6. |rbe draw| - <t>draw the raids radius</t>
7. |rbe despawn| - <t>despawn a base near you</t>
8. |rbe despawnall| - <t>despawn all bases</t>
9. |rbe [basename] [difficulty]| - <t>spawn a raid at the location you are looking at</t>
10. |rbe expire steamid|playername| - <t>removes a lockout for a specific player</t>
11. |rbe expireall|
12. |rbevent [basename] [difficulty]| - <t>spawn a raid randomly on the map - and teleport to it if using the command in-game</t>
13. |rb.reloadconfig| - <t>allows you to reload the config without needing to reload the plugin. Some changes are not applied immediately, and no changes are retroactive to bases that are already spawned.</t>
14. |rb.config| - <t>allows you to edit the config by adding, removing, and listing bases. Requires the permission raidablebases.config when not being used from the server console.</t>
15. |rb ui [lockouts|status]| - <t>toggle ui on/off, or optional the lockouts or status</t>
16. |rb.toggle| - <t>toggles Maintained Events and Scheduled Events on/off, if enabled in the config, until plugin reloads</t>
17. |rbe setowner name| - <t>Sets the player as the owner of the raid</t>
18. |rbe clearowner| - <t>Clears the owner of the raid</t>
</comm>
