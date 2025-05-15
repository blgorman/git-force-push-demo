using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GitJediMasterModels;

public class GitJediMaster
{
    [Required]
    public int Id { get; set; }

}