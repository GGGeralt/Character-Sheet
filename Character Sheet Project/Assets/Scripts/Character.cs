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
    public List<CharacterClass> classes;
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

    public Character(string name, string race, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma) : this(name)
    {
        this.race = race;
        this.level = 0;
        this.health = 0;
        this.spells = new List<SpellData>();
        this.classes = new List<CharacterClass>();
        this.inventory = new List<ItemData>();
        this.strength = strength;
        this.dexterity = dexterity;
        this.constitution = constitution;
        this.intelligence = intelligence;
        this.wisdom = wisdom;
        this.charisma = charisma;
    }
}
