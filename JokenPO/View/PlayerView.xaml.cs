using JokenPO.ViewModel;

namespace JokenPO.View;

public partial class PlayerView : ContentPage
{
	public PlayerView()
	{
		InitializeComponent();
		BindingContext = new PlayerViewModel();
	}
}