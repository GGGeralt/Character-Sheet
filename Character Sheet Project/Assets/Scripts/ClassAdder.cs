using TMPro;
using UnityEngine;
using static TMPro.TMP_Dropdown;

public class ClassAdder : MonoBehaviour
{
    public TMP_Dropdown classDropdown;
    public TextMeshProUGUI classDescriptionLabel;
    public void Start()
    {
        classDropdown.options.Clear();
        foreach (CharacterClass characterClass in ClassManager.Instance.classes)
        {
            classDropdown.options.Add(new OptionData(characterClass.className));
        }

        classDescriptionLabel.text = ClassManager.Instance.GetClass(classDropdown.options[classDropdown.value].text).levels[0];

        classDropdown.onValueChanged.AddListener(UpdateDescription);
    }

    private void UpdateDescription(int arg0)
    {
        classDescriptionLabel.text = ClassManager.Instance.GetClass(classDropdown.options[classDropdown.value].text).levels[0];
    }

    public void AddClass()
    {
        print("ADDING CLASS " + ClassManager.Instance.GetClass(classDropdown.options[classDropdown.value].text).levels[0]);
    }
}
