﻿using System.Text.RegularExpressions;

namespace HoNAvatarManager.Core.Extensions
{
    internal static class AvatarKeyExtensions
    {
        public static string ParseAvatarKey(this string avatarKey)
        {
            var keyRegex = new Regex(@"Hero_[a-zA-Z]+\.(?<key>.+)");
            var match = keyRegex.Match(avatarKey);

            return match.Success ? match.Groups["key"].Value : avatarKey;
        }
    }
}
