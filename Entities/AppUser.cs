namespace API.Entities;

public class AppUser
{
    public int Id { get; set; }  //Primitive integer datatype - it will use to autoincrement in database

    public required string UserName { get; set; } //referenced data type - we are using required here because it will give warning message which means we need to define null or any empty string or we need to use ? (optional) operator as well or we need to use to define value as "" empty string.

}

