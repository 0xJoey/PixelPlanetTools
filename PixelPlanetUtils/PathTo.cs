﻿using System;
using System.IO;

namespace PixelPlanetUtils
{
    public static class PathTo
    {
        public static readonly string AppFolder =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "PixelPlanetTools");

        public static readonly string Fingerprint = Path.Combine(AppFolder, "fingerprint.bin");
    }
}