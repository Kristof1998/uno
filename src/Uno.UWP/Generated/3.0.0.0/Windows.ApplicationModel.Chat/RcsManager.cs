#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Chat
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class RcsManager 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.ApplicationModel.Chat.RcsEndUserMessageManager GetEndUserMessageManager()
		{
			throw new global::System.NotImplementedException("The member RcsEndUserMessageManager RcsManager.GetEndUserMessageManager() is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.ApplicationModel.Chat.RcsTransport>> GetTransportsAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<RcsTransport>> RcsManager.GetTransportsAsync() is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Chat.RcsTransport> GetTransportAsync( string transportId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<RcsTransport> RcsManager.GetTransportAsync(string transportId) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.Foundation.IAsyncAction LeaveConversationAsync( global::Windows.ApplicationModel.Chat.ChatConversation conversation)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction RcsManager.LeaveConversationAsync(ChatConversation conversation) is not implemented in Uno.");
		}
		#endif
	}
}
