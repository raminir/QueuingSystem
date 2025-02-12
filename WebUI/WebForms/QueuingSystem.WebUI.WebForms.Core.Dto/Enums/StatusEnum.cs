using System.ComponentModel.DataAnnotations;

namespace QueuingSystem.WebUI.WebForms.Core.Dto
{
    public enum StatusEnum
    {
        [Display(Name = "در حال انتظار")]
        Waiting = 1,
        [Display(Name = "فراخوان شده")]
        InProgress = 2,
        [Display(Name = "انجام شده")]
        Done = 3,
        [Display(Name = "عدم مراجعه")]
        cancel = 4,
    }
}
