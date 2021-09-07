using Sandbox.UI;

	/// <summary>
	/// This is the HUD entity. It creates a RootPanel clientside, which can be accessed
	/// via RootPanel on this entity, or Local.Hud.
	/// </summary>
public partial class STMHud : Sandbox.HudEntity<RootPanel>
{
	public STMHud()
	{
		if ( IsClient )
		{
			RootPanel.AddChild<NameTags>();
			RootPanel.AddChild<ChatBox>();
			RootPanel.AddChild<KillFeed>();
			RootPanel.AddChild<VoiceList>();
		}
	}
}
