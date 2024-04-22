using System;
using System.Collections.Generic;

[Serializable]
public class Character
{
    //public Sprite background;
    //public Sprite portrait;

    public string name;
    public string race;
    public int level;
    public int health;
    public List<SpellData> spells;
    public List<string> classes;
    public List<ItemData> inventory;

    public int strength;
    public int dexterity;
    public int constitution;
    public int intelligence;
    public int wisdom;
    public int charisma;

    public Character()
    {
    }

    public Character(string name)
    {
        this.name = name;
    }
}
