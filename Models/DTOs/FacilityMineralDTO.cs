namespace examineAPI.Models.DTOs;
public class FacilityMineralDTO
{
    public int Id { get; set; }
    public int FacilityId { get; set; }
    public int MineralId { get; set; }
    public int Quantity { get; set; }
    public Mineral Mineral { get; set; }
    public Facilities Facility { get; set; }
}