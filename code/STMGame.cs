
using Sandbox;
using Sandbox.UI.Construct;
using System;
using System.IO;
using System.Threading.Tasks;

	
[Library("Super Terry Man")]
public partial class STMGame : Sandbox.Game
{
	public STMGame()
	{
		if ( IsServer )
		{
			new STMHud();
		}
	}
	public override void ClientJoined( Client client )
	{
		base.ClientJoined( client );

		var player = new STMPlayer();
		client.Pawn = player;

		player.InitialSpawn();
	}
}
