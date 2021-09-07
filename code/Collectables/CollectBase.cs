using Sandbox;

public partial class CollectBase : BaseCarriable, IRespawnableEntity
{
	public virtual string ModelPath => "";
	
	public PickupTrigger PickupTrigger { get; protected set; }

	public override void Spawn()
	{
		base.Spawn();
		CollisionGroup = CollisionGroup.Interactive;
		PickupTrigger = new PickupTrigger();
		PickupTrigger.SetParent( this );
	}
	
	public override bool CanCarry( Entity carrier )
	{
		return base.CanCarry( carrier );
	}
		
	public override void OnCarryStart( Entity carrier )
	{
		base.OnCarryStart( carrier );
	}
}

