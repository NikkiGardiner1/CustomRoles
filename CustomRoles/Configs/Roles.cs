namespace CustomRoles.Configs;

using System.Collections.Generic;
using CustomRoles.Roles;

public class Roles
{
    public List<ContainmentScientist> ContainmentScientists { get; set; } = new()
    {
        new ContainmentScientist(),
    };
    public List<LightGuard> LightGuards { get; set; } = new()
    {
        new LightGuard(),
    };
    public List<Biochemist> Biochemists { get; set; } = new()
    {
        new Biochemist(),
    };
    public List<ContainmentGuard> ContainmentGuards { get; set; } = new()
    {
        new ContainmentGuard(),
    };
    public List<BorderPatrol> BorderPatrols { get; set; } = new()
    {
        new BorderPatrol(),
    };
    public List<Nightfall> Nightfalls { get; set; } = new()
    {
        new Nightfall(),
    };
}