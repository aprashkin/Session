namespace AvaloniaApplication1.Models;

public class users
{
    private int _count;
    public string FirstName { get; set; }
    public string SecondName { get; set; }
    public bool IsAdmin = false;

    public users(int count, bool isAdmin)
    {
        _count = count;
        IsAdmin = isAdmin;
    }
}