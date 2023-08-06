namespace MinecraftLaunch.Modules.Models.Launch;

public class GameWindowConfig {
    public int Width { get; set; } = 854;


    public int Height { get; set; } = 480;


    public bool IsFullscreen { get; set; }

    public static implicit operator GameWindowConfig(bool isFullscreen = false) => new() {
        IsFullscreen = isFullscreen,
    };
}
