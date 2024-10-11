using SnivysCustomRolesAbilities.Abilities;

namespace CustomRoles.Roles;

using System.Collections.Generic;
using CustomRoles.API;

using Exiled.API.Features;
using Exiled.API.Features.Attributes;
using Exiled.API.Features.Spawn;
using Exiled.CustomRoles.API.Features;
using Exiled.Events.EventArgs.Player;
using Exiled.Events.Handlers;
using Exiled.Events.EventArgs.Scp330;
using InventorySystem.Items.Usables.Scp330;
using MEC;
using PlayerRoles;

[CustomRole(RoleTypeId.ChaosConscript)]
public class JuggernautChaos : CustomRole, ICustomRole
{
    public int Chance { get; set; } = 10;

    public StartTeam StartTeam { get; set; } = StartTeam.Chaos;

    public override uint Id { get; set; } = 39;

    public override RoleTypeId Role { get; set; } = RoleTypeId.ChaosConscript;

    public override int MaxHealth { get; set; } = 100;

    public override string Name { get; set; } = "Juggernaut Chaos";

    public override string Description { get; set; } = "A Juggernaunt of a Chaos member";

    public override string CustomInfo { get; set; } = "Juggernaut Chaos";

    public override SpawnProperties SpawnProperties { get; set; } = new()
    {
        Limit = 1,
        RoleSpawnPoints = new List<RoleSpawnPoint>
        {
            new()
            {
                Role = RoleTypeId.ChaosConscript,
                Chance = 100,
            },
        },
    };

    public override List<string> Inventory { get; set; } = new()
    {
        $"{ItemType.KeycardChaosInsurgency}",
        $"{ItemType.GrenadeHE}",
        $"{ItemType.GrenadeHE}",
        $"{ItemType.GrenadeHE}",
        $"{ItemType.ArmorCombat}",
    };
    
    public override List<CustomAbility>? CustomAbilities { get; set; } = new()
    {
        new GivingCandyAbility(),
    };
}