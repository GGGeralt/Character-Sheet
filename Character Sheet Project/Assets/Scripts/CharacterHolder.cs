using UnityEngine;

public class CharacterHolder : MonoBehaviour
{
    public Character character;
    //[SerializeField] private Image background;
    //[SerializeField] private Image portrait;

    public void SetUpCharacter(Character character)
    {
        this.character = character;
        //background.sprite = character.background;
        //portrait.sprite = character.portrait;
    }

    public void ChoseCharacter()
    {
        CharacterManager.Instance.SetChosenCharacter(character);
        CharacterManager.Instance.isChosen = true;
        CharacterManager.Instance.UpdateLayoutData();
    }
}
