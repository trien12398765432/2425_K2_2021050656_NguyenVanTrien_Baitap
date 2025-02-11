namespace DemoMVC;

public class HeThongPhanPhoi
{
    public string MaHTPP { get; set; }
    public string TenHTPP { get; set; }

    // Constructor
    public HeThongPhanPhoi(string maHTPP, string tenHTPP)
    {
        MaHTPP = maHTPP;
        TenHTPP = tenHTPP;
    }
}