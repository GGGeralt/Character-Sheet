using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    public static CharacterManager Instance;

    [SerializeField] GameObject characterCreationMenu;

    [SerializeField] private Character chosenCharacter;
    [SerializeField] Canvas canvas;
    private CharacterCreator creator;

    public bool isChosen = false;

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
        if (creator == null)
        {
            creator = Instantiate(characterCreationMenu, canvas.transform).GetComponent<CharacterCreator>();
        }
        //Character character = new Character("GGGeralt");
        ////character.background = background;
        ////character.portrait = portrait;
        //File.WriteAllText($"{GroupManager.Instance.directory}\\{character.name}.char", JsonUtility.ToJson(character, true));
        //GroupManager.Instance.LoadCharacters();
    }
}
