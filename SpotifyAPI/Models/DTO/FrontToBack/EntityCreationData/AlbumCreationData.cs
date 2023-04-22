﻿using Models.Entities.Enums;

namespace Models.DTO.FrontToBack.EntityCreationData;

public class AlbumCreationData : EntityCreationData
{
    public string AuthorId { get; set; }
    public AlbumType AlbumType { get; set; }
    public int ReleaseYear { get; set; }
}