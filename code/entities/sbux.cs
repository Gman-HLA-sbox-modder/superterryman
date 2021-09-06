 using Sandbox;
using System;

[Library( "ent_sbux", Title = "s&bux", Spawnable = true )]
public partial class CoinEntity : Prop, IUse
{
	public float MaxSpeed { get; set; } = 1000.0f;
	public float SpeedMul { get; set; } = 1.2f;

	public override void Spawn()
	{
		base.Spawn();

		SetModel("models/citizen_props/coin01.vmdl");
		SetupPhysicsFromModel( PhysicsMotionType.Dynamic, false );
	}

	public bool IsUsable( Entity user )
	{
		return true;
	}

	public bool OnUse( Entity user )
	{
		if ( user is Player player )
		{
			Delete();
		}

		return false;
	}
}
