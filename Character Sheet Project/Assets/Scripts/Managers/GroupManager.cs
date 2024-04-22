using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class GroupManager : MonoBehaviour
{
    public static GroupManager Instance;
    public string directory;
    [SerializeField] private GameObject characterGameObject;
    [SerializeField] private GameObject groupPanel;

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

        Directory.CreateDirectory($"{Application.dataPath}\\Characters");
        directory = $"{Application.dataPath}\\Characters";
        LoadCharacters();
    }

    public void ChooseGroup()
    {
        directory = EditorUtility.OpenFolderPanel("Select Directory", directory, "");
    }

    public List<Character> LoadCharacters()
    {
        foreach (Transform child in groupPanel.transform)
        {
            Destroy(child.gameObject);
        }

        DirectoryInfo dir = new DirectoryInfo(directory);
        foreach (FileInfo info in dir.GetFiles("*.char"))
        {
            Character character = JsonUtility.FromJson<Character>(info.OpenText().ReadToEnd());
            CharacterHolder characterHolder = Instantiate(characterGameObject, groupPanel.transform).GetComponent<CharacterHolder>();
            characterHolder.SetUpCharacter(character);

        }
        return null;
    }
}
