#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Storage
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SystemAudioProperties 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string EncodingBitrate
		{
			get
			{
				throw new global::System.NotImplementedException("The member string SystemAudioProperties.EncodingBitrate is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Storage.SystemAudioProperties.EncodingBitrate.get
	}
}
