using TMPro;
using UnityEngine;

public class DescriptionMenuManager : MonoBehaviour
{
    public static DescriptionMenuManager Instance;

    [SerializeField] TextMeshProUGUI strengthScoreText;
    [SerializeField] TextMeshProUGUI dexterityScoreText;
    [SerializeField] TextMeshProUGUI constitutionScoreText;
    [SerializeField] TextMeshProUGUI intelligenceScoreText;
    [SerializeField] TextMeshProUGUI wisdomScoreText;
    [SerializeField] TextMeshProUGUI charismaScoreText;

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

    public void LoadData()
    {
        if (CharacterManager.Instance.isChosen != false)
        {
            strengthScoreText.text = CharacterManager.Instance.GetChosenCharacter().strength.ToString();
            dexterityScoreText.text = CharacterManager.Instance.GetChosenCharacter().dexterity.ToString();
            constitutionScoreText.text = CharacterManager.Instance.GetChosenCharacter().constitution.ToString();
            intelligenceScoreText.text = CharacterManager.Instance.GetChosenCharacter().intelligence.ToString();
            wisdomScoreText.text = CharacterManager.Instance.GetChosenCharacter().wisdom.ToString();
            charismaScoreText.text = CharacterManager.Instance.GetChosenCharacter().charisma.ToString();
        }
    }
}
