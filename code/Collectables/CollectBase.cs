using Sandbox;

public partial class CollectBase : BaseCarriable
{
	public virtual string ModelPath => "";
	
	public PickupTrigger PickupTrigger { get; protected set; }

	public override void Spawn()
	{
		base.Spawn();
	}
	
	public override bool CanCarry( Entity carrier )
	{
		return true;
	}
		
	public override void OnCarryStart( Entity carrier )
	{
		base.OnCarryStart( carrier );
	}
}

