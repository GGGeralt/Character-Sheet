using UnityEngine;

public enum SpellType
{
    SingleTarget,
    MultiTarget,
    SkillShot,
    AreaOfEffect
}

public enum TargetCreature
{
    Enemy,
    Ally
}


[CreateAssetMenu(fileName = "new Spell", menuName = "Create New Spell")]
public class SpellData : ScriptableObject
{
    public string spellName;
    public Sprite image;
    public SpellType type;
    public TargetCreature targetCreature;
    public int spellLevel;
}
