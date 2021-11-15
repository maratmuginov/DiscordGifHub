namespace DiscordGifHub.Presentation.Models.InternalGifObjects
{
    /// <summary>
    /// Data structure representing how Discord internally store
    /// favourite gifs in local storage
    /// </summary>
    /// <param name="Url">The URL that the gif is found at</param>
    /// <param name="Src">The URI of the gif</param>
    /// <param name="Width">Width in pixels</param>
    /// <param name="Height">Height in pixel</param>
    /// <param name="Format">The format of the source (image/video)</param>
    public record DiscordGif(
        string Url,
        string Src,
        int Width,
        int Height,
        GifFormat Format);
}