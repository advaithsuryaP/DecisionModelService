using DecisionModelService.Core.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DecisionModelService.Core.Entities;

[Table("DecisionModels")]
public class DecisionModelEntity
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(200)]
    public required string Name { get; set; }

    [MaxLength(1000)]
    public string? Description { get; set; }

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Version must be a positive number.")]
    public required int Version { get; set; }

    [Required]
    [MaxLength(100)]
    public required string VersionName { get; set; }

    public string? Documentation { get; set; }

    public string? DocumentationMIMEType { get; set; }

    public string? ImageURL { get; set; }

    public Guid OwnerId { get; set; }

    public OwnerType OwnerType { get; set; }

    public string? Expression { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
