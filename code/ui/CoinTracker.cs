using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

partial class CoinTracker : Panel
{
	private static int curCoins = 0;
	public static Label CoinLbl;
	
	public CoinTracker()
	{
		StyleSheet.Load( "/ui/CoinTracker.scss" );
		CoinLbl = Add.Label( "Coins: " + curCoins, "coins" );
	}

	[ClientRpc]
	public static void UpdateTracker(int newAmount)
	{
		CoinLbl.Text = "Coins: " + newAmount;
	}
}
