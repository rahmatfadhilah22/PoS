using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.BaseModel;
public class BaseModel
{
    public int Id { get; set; }
    [Column("Create_Date")]
    public DateTime CreteDate { get; set; }
    [Column("Modify_Date")]
    public DateTime ModifyDate { get; set; }
}
