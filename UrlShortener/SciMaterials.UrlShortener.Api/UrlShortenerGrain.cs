﻿using Orleans.Runtime;

namespace SciMaterials.UrlShortener.Api;

public class UrlShortenerGrain : Grain, IUrlShortenerGrain
{
	private readonly IPersistentState<UrlDetails> _state;

	public UrlShortenerGrain([PersistentState(stateName: "url", storageName: "urls")] IPersistentState<UrlDetails> state)
	{
		_state = state;
	}

	public async Task SetUrl(string fullUrl)
	{
		_state.State = new UrlDetails()
		{
			ShortenedRouteSegment = this.GetPrimaryKeyString(),
			FullUrl = fullUrl
		};
		await _state.WriteStateAsync();
	}

	public Task<string> GetUrl()
	{
		return Task.FromResult(_state.State.FullUrl);
	}
}