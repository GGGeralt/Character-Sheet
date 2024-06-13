using TMPro;
using UnityEngine;

public class CharacterCreator : MonoBehaviour
{
    [SerializeField] TMP_InputField nameText;
    [SerializeField] TMP_Dropdown raceDropdown;
    [SerializeField] TextMeshProUGUI remainingPointsLabel;

    [SerializeField] int points = 27;



    [SerializeField] int strScore = 8;
    [SerializeField] int dexScore = 8;
    [SerializeField] int conScore = 8;

    [SerializeField] int intScore = 8;
    [SerializeField] int wisScore = 8;
    [SerializeField] int chaScore = 8;

    [SerializeField] TMP_InputField strength;
    [SerializeField] TMP_InputField dexterity;
    [SerializeField] TMP_InputField constitution;

    [SerializeField] TMP_InputField intelligence;
    [SerializeField] TMP_InputField wisdom;
    [SerializeField] TMP_InputField charisma;


    private void Awake()
    {
        UpdateAll();
    }

    public void CreateCharacter()
    {
        print(nameText.text);
        print(raceDropdown.options[raceDropdown.value].text);
    }

    private void UpdateAll()
    {
        remainingPointsLabel.text = points.ToString();

        strength.text = strScore.ToString();
        dexterity.text = dexScore.ToString();
        constitution.text = conScore.ToString();

        intelligence.text = intScore.ToString();
        wisdom.text = wisScore.ToString();
        charisma.text = chaScore.ToString();
    }

    public void CancelCreation()
    {
        Destroy(gameObject);
    }

    public void IncreaseStat(string name)
    {
        switch (name)
        {
            case "strength":
                strScore++;
                break;
            case "dexterity":
                dexScore++;
                break;
            case "constitution":
                conScore++;
                break;

            case "intelligence":
                intScore++;
                break;
            case "wisdom":
                wisScore++;
                break;
            case "charisma":
                chaScore++;
                break;
            default:
                print("ERROR");
                break;
        }
        UpdateAll();
    }

    private int GetPointCost(int value, int change)
    {
        return 0;
    }


    /*
     * 8  0
     * 9  1
     * 10 2
     * 11 3
     * 12 4
     * 13 5
     * 14 7
     * 15 9
     */
}
