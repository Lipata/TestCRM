using Bunit;
using Microsoft.Extensions.DependencyInjection;
using CRM_App.Pages;

namespace TestCRM_App
{
	public class TestAccount_Sample
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbTabsModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbExpansionPanelModule),
				typeof(IgbAvatarModule),
				typeof(IgbCheckboxModule),
				typeof(IgbListModule),
				typeof(IgbChipModule));
			var componentUnderTest = ctx.RenderComponent<Account_Sample>();
			Assert.NotNull(componentUnderTest);
		}
	}
}