
using Sandbox;

[Library("stm_coin", Title = "Coin")]
partial class Coin : CollectBase
{
	public virtual string ModelPath => "models/citizen_props/coin01.vmdl";
	
	public override void Spawn()
	{
		base.Spawn();
		
		SetModel( ModelPath );
	}
	
	public override void OnCarryStart( Entity carrier )
	{
		base.OnCarryStart( carrier );
		Delete();
	}
}

