using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GitJediMasterModels;

public class GitJediMaster
{
    [Required]
    public int Id { get; set; }

    [Required, StringLength(100)]
    [Display(Name="Jedi Name")]
    public string Name { get; set; }
}