using System.IO;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    public static CharacterManager Instance;


    [SerializeField] private Character chosenCharacter;

    public bool isChosen = false;

    //[SerializeField] private Sprite background;
    //[SerializeField] private Sprite portrait;
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(Instance);
        }
        else
        {
            Instance = this;
        }
    }

    public void SetChosenCharacter(Character character)
    {
        chosenCharacter = character;
    }

    public Character GetChosenCharacter()
    {
        return chosenCharacter;
    }


    public void UpdateLayoutData()
    {
        DescriptionMenuManager.Instance.LoadData();
    }

    public void CreateCharacter()
    {
        Character character = new Character("GGGeralt");
        //character.background = background;
        //character.portrait = portrait;
        File.WriteAllText($"{GroupManager.Instance.directory}\\{character.name}.char", JsonUtility.ToJson(character, true));
        GroupManager.Instance.LoadCharacters();
    }
}
