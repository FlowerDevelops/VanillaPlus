using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;

public class ProgrammerOptionsGroup : AbstractOptionGroup<JesterRole>
{
    public override string GroupName => "Jester";
    public override uint GroupPriority => 0; // display first
}