using Sandbox;
using System;
using System.Linq;
using System.Numerics;

partial class STMPlayer : Player
{
	
	private bool CanDoubleJump = true;
	private TimeSince timeSinceJump;
	private int DoubleJumpHeight = 425;
	
	public void InitialSpawn()
	{
		while ( RenderColor == Color.White )
		{
			RenderColor = Color.Random;
		}
		
		Respawn();
	}

	public override void Respawn()
	{
		SetModel( "models/citizen/citizen.vmdl" );
		
		Controller = new WalkController();
		Animator = new StandardPlayerAnimator();
		Camera = new STMCamera();

		EnableAllCollisions = true;
		EnableDrawing = true;
		EnableHideInFirstPerson = true;
		EnableShadowInFirstPerson = true;
		
		CanDoubleJump = true;
		
		base.Respawn();
	}

	/// <summary>
	/// Called every tick, clientside and serverside.
	/// </summary>
	public override void Simulate( Client cl )
	{
		base.Simulate( cl );
		SimulateActiveChild( cl, ActiveChild );

		TickPlayerUse();
		
		if ( !Controller.HasEvent( "jump" ) && Input.Pressed( InputButton.Jump ) && CanDoubleJump )
		{
			Velocity += new Vector3( 0, 0, DoubleJumpHeight );
			CanDoubleJump = false;
			timeSinceJump = 0;
		}

		if ( timeSinceJump >= 3 )
			CanDoubleJump = true;
		
		if ( Input.ActiveChild != null )
		{
			ActiveChild = Input.ActiveChild;
		}
	}

	public override void OnKilled()
	{
		base.OnKilled();

		EnableDrawing = false;
	}
}
