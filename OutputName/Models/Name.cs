using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OutputName.Models;

public class Name
{
    [Range(1,100)]
    [DisplayName("Ім'я користувача")]
    public string FirstName { set; get; }
}