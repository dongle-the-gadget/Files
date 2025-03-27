using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Win32;
using Windows.Win32.UI.Shell;
using Windows.Win32.UI.Shell.PropertiesSystem;

namespace Files.App.Actions
{
	internal sealed class AlwaysKeepOnDeviceAction : IAction
	{
		private readonly IContentPageContext context;

		public string Label => "[TOBELOCAL] Always keep on this device";

		public string Description => "[TOBELOCAL] Download the selected file(s) and prevent the operating system from deleting them, even when the disk is full.";

		public RichGlyph Glyph => new("\uEBD3");

		public bool IsExecutable
		{
			get => context.SelectedItems.Count > 0 && context.PageType == ContentPageTypes.CloudDrive;
		}

		public AlwaysKeepOnDeviceAction()
		{
			context = Ioc.Default.GetRequiredService<IContentPageContext>();
		}

		public Task ExecuteAsync(object? parameter = null)
		{
			throw new NotImplementedException();
		}
	}
}
