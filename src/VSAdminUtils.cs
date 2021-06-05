
using Vintagestory.API.Common;
using Vintagestory.API.Client;
using Vintagestory.API.Server;

[assembly: ModInfo( "vsmod-admin-utils",
	Description = "Admin Utilities",
	Website     = "https://github.com/maldaris/vsmod-adminutils",
	Authors     = new []{ "Maldaris" } )]

namespace VSMod.Books
{
	public class BooksMod : ModSystem
	{
		public override void Start(ICoreAPI api)
		{
            base.Start(api);
		}
		
		public override void StartClientSide(ICoreClientAPI api)
		{
			base.StartClientSide(api);
		}
		
		public override void StartServerSide(ICoreServerAPI api)
		{
			base.StartServerSide(api);
		}
	}
}