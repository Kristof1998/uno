#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Chat
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class RcsServiceKindSupportedChangedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.ApplicationModel.Chat.RcsServiceKind ServiceKind
		{
			get
			{
				throw new global::System.NotImplementedException("The member RcsServiceKind RcsServiceKindSupportedChangedEventArgs.ServiceKind is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Chat.RcsServiceKindSupportedChangedEventArgs.ServiceKind.get
	}
}
