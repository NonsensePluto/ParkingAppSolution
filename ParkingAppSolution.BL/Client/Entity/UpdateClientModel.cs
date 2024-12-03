namespace ParkingAppSolution.BL.Client.Entity;

public class UpdateClientModel
{
    public int Id { get; set; }
    
    public int PasportNumber { get; set; }
    public string PhoneNumber { get; set; }
    public string? Email { get; set; }
    public string PasswordHash { get; set; }
    public byte PersonalSale { get; set; }
}