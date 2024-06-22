using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.CustomRoles.API.Features;
using PlayerRoles;
using PluginAPI.Roles;

namespace CustomRoles.Abilities;

public class RemoveDisguise : ActiveAbility
{
    public override string Name { get; set; } = "Remove Disguise";

    public override string Description { get; set; } =
        "This removes your disguise, once it's off, you cannot put it back on, activate carefully";

    public override float Duration { get; set; } = 0f;
    public override float Cooldown { get; set; } = 900f;

    protected override void AbilityUsed(Player player)
    {
        player.Role.Set(RoleTypeId.ChaosRifleman, SpawnReason.ForceClass, RoleSpawnFlags.None);
    }
}