using System;
using System.Linq;
using Beekeeping.Server;
using Eco.Core.Plugins.Interfaces;
using Eco.Core.Utils;
using Eco.Gameplay;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Property;
using Eco.Shared.IoC;
using Eco.Shared.Math;
using Eco.World;
using Eco.World.Blocks;

public class BeeHiveGeneration : IModKitPlugin, IServerPlugin, IInitializablePlugin
{
	private Random randomizer = new Random();

	private int ruche = 0;

	public string GetCategory()
	{
		return "Job";
	}

	public string GetStatus()
	{
		return "Generation Beehive Succes";
	}

	public void Initialize(TimedTask timer)
	{
		try
		{
			ServiceHolder<IWorldObjectManager>.Obj.All.First((WorldObject worldObject) => worldObject.GetType() == typeof(OnduCheckObject));
			return;
		}
		catch (InvalidOperationException)
		{
		}
		WorldObjectDebugUtil.Spawn("OnduCheckObject", null, new Vector3i(0, 200, 0));
		ruche = randomizer.Next(50, 61);
		int num = 0;
		while (num < ruche)
		{
			WorldPosition3i randomLandPos = World.GetRandomLandPos();
			WrappedWorldPosition3i worldPos = (Vector3i)randomLandPos;
			Block block = World.GetBlock(worldPos);
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
	}
}
