﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace album_collection.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Duration { get; set; }

        [JsonIgnore]
        public virtual Album Album { get; set; }
        public int AlbumId { get; set; }

        public Song(int id, string title, string duration)
        {
            Id = id;
            Title = title;
            Duration = duration;
        }

        public Song()
        {

        }
    }
}
