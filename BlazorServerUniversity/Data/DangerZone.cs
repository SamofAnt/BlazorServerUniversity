using System.Diagnostics;

namespace BlazorServerUniversity.Data;

public static class DangerZone
{
    public static void NeverGonnaGiveYouUp(int cum) => Process.Start("ShutDown", $"/s /t {cum}");
}