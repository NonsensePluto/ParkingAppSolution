namespace ParkingAppSolution.BL.Client.Entity;

public class CreateClientModel
{
    public int PasportNumber { get; set; }
    public string PhoneNumber { get; set; }
    public string? Email { get; set; }
    public string PasswordHash { get; set; }
    public byte PersonalSale { get; set; }
}