using PixelPlanetUtils.Canvas;
using System.Runtime.Serialization;
using CommandLine;

namespace PixelPlanetUtils.NetworkInteraction
{
    [DataContract(Name = "pixel")]
    class PixelPlacingData
    {
        [DataMember(Name = "cn")]
        public byte Canvas { get; set; }

        [DataMember(Name = "clr")]
        public EarthPixelColor Color { get; set; }

        [DataMember(Name = "x")]
        public int AbsoluteX;

        [DataMember(Name = "y")]
        public int AbsoluteY;

        [DataMember(Name = "token")]
        public object Token = null;
    }
}