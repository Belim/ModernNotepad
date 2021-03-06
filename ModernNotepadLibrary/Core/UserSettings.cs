﻿namespace ModernNotepadLibrary.Core
{
    public class UserSettings
    {
        public bool? IsDarkThemeEnabled { get; set; } = null;

        public bool IsSpellCheckingEnabled { get; set; } = false;

        public bool IsStatusBarVisible { get; set; } = true;

        public bool IsWordWrapEnabled { get; set; } = true;
    }
}
