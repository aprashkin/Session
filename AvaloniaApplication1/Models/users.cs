namespace AvaloniaApplication1.Models;

public class users
{
    private int _count;
    public string FirstName { get; set; }
    public string SecondName { get; set; }
    public bool IsAdmin { get; set; }

    public users(string firstName, string secondName, bool isAdmin)
    {
        FirstName = firstName;
        SecondName = secondName;
        IsAdmin = isAdmin;
    }
}