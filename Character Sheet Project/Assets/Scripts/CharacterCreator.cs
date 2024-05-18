using TMPro;
using UnityEngine;

public class CharacterCreator : MonoBehaviour
{
    public TMP_InputField nameText;
    public TMP_Dropdown raceDropdown;
    public TextMeshProUGUI remainingPointsLabel;

    public void CreateCharacter()
    {
        remainingPointsLabel.text = "27";
        print(nameText.text);
        print(raceDropdown.options[raceDropdown.value].text);
    }

    public void CancelCreation()
    {
        Destroy(gameObject);
    }

}
