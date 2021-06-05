# VSAdminUtilities

Adds several utility commands to aid in administrating a Vintage Story server, as well as QoL commands for claims management.

## Usage

### User Commands

* `/landutils delcuboid` Removes a cuboid from the claim that the player is standing in, if they own it, or if they are an administrator.

### Admin Commands

* `/landutils adminfreehere` Removes a claim the user is standing in, if they are an administrator.
* `/anchor new <role name> <x y z/"here"> <tickspeed=60>` Creates a new movement anchor, which forces connected clients with the specified role to remain at the designated position, each tick at the specified delay. Useful for situations where you need to ensure a player has read rules, or stops moving long enough for you to investigate cheat/hack accusations, et al.
* `/anchor list` Lists the active anchors, their role, position, and tick rate.
* `/anchor del <index>` Removes a specified anchor, and unregisters event listeners from players with the associated role.
* `/anchor modify <index> <role|loc|tickspeed> <value>` Alters an existing anchor with the provided value, and refreshes the event handlers.
* `/anchor reload` Reloads the anchor configuration from disk.
* `/setplayerspawn <name> <x> <y> <z>` Sets a player's respawn position as if they had used a temporal gear at that position. If no positional argument is provided, uses the player's position. Requires positional arguments if the specified player is offline.
* `/roleattributes set <role> <attribute> <value> <tickspeed=60>` Sets the specified attribute to the provided value on each player client with a given role every tick with the specified tick speed. Supported attributes include: `gamemode`, `movespeed`, `miningdelay`
* `/roleattributes list <role>` Lists the active overrides on the specified role, including the attribute, value, and tick speed.
* `/roleattributes del <role> <attribute|"all">` Deletes the specified role's override, or all overrides.

## Contributing

VSCode tasks/launch configurations are provided in the `.vscode` folder. Make sure you follow [this guide](https://github.com/copygirl/howto-example-mod) when setting up your dev environment.

## Credits

Special thanks

* The /vm/ Vintage Story server for inspiration and feedback on the mod

## LICENSE

Licensed under the MIT License. Copyright 2021 Maldaris.

[See LICENSE.md](LICENSE) for details.
