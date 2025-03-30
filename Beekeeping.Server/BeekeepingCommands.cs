using Eco.Gameplay;
using Eco.Gameplay.Property;
using Eco.Gameplay.Systems.Chat;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using Eco.Shared.Math;
using Eco.World;
using Eco.World.Blocks;

namespace Beekeeping.Server;

[ChatCommandHandler]
public class BeekeepingCommands
{
	[ChatSubCommand("Util", "To generate new swarms. After texting command, enter the number of new hives you want to get.", "GenerateSwarm", ChatAuthorizationLevel.Admin)]
	public static void Swarm(IChatClient chatClient, int swarm)
	{
		int num = swarm;
		if (swarm < 150)
		{
			while (num < swarm + swarm)
			{
				WorldPosition3i randomLandPos = World.GetRandomLandPos();
				Block block = World.GetBlock((WrappedWorldPosition3i)(Vector3i)randomLandPos);
				if (block is DirtBlock && !(block is DesertSandBlock))
				{
					int y = randomLandPos.y + 1;
					randomLandPos.y = y;
					if (PropertyManager.GetPlotFromWorldPos((Vector2i)randomLandPos)?.Owners == null)
					{
						WorldObjectDebugUtil.Spawn("OnduOccupiedSauvageBeehiveObject", null, (Vector3i)randomLandPos);
						num++;
					}
				}
			}
			chatClient.MsgLoc($"{swarm} new swarms have appeared on the map.");
		}
		else
		{
			chatClient.MsgLoc($"The maximum number of swarms allowed is 150. Try again with a lower value.");
		}
	}
}
