﻿using SciMaterials.DAL.Models.Base;

namespace SciMaterials.DAL.Models;

public class Comment : BaseModel
{
    public Guid? ParentId { get; set; }
    public Guid AuthorId { get; set; }
    public string Text { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public Guid ResourceId { get; set; }
    public Author Author { get; set; } = null!;
    public Resource Resource { get; set; } = null!;
}
