﻿using System;

namespace RocksmithToolkitLib.DLCPackage
{
    public class SongInfo
    {
        // DO NOT change variable names ... hidden dependancies
        // REM This is Manifest JSON File Data
        //
        public string Album { get; set; }
        public string AlbumSort { get; set; } // new
        public string Artist { get; set; }
        public string ArtistSort { get; set; }
        public int AverageTempo { get; set; }
        public string SongDisplayName { get; set; }
        public string SongDisplayNameSort { get; set; }
        public string JapaneseSongName { get; set; } // new, optional
        public string JapaneseArtistName { get; set; } // new, optional
        public int SongYear { get; set; }
    }
}
