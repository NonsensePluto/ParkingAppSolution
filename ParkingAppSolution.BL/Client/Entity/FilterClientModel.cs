namespace ParkingAppSolution.BL.Client.Entity;

public class FilterClientModel
{
    public int PassportNumber { get; set; }
    public string PhoneNumberPart { get; set; }
    public string? EmailPart { get; set; }
    public string PasswordHash { get; set; }
    public byte PersonalSale { get; set; }
}