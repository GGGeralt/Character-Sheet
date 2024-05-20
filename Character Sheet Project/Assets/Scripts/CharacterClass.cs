
using System.Collections.Generic;
using UnityEngine;

public enum ClassType
{
    FullMartial,
    FullCaster,
    HalfHalf
}

[CreateAssetMenu(fileName = "New Class", menuName = "Create new Class")]
public class CharacterClass : ScriptableObject
{
    public string className;
    public string description;
    public ClassType type;
    [Multiline]
    public List<string> levels = new List<string>(20);
}
