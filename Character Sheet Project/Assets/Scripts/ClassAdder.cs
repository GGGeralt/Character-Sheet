using TMPro;
using UnityEngine;
using static TMPro.TMP_Dropdown;

public class ClassAdder : MonoBehaviour
{
    public TMP_Dropdown classDropdown;
    public void Start()
    {
        classDropdown.options.Clear();
        foreach (CharacterClass characterClass in ClassManager.Instance.classes)
        {
            classDropdown.options.Add(new OptionData(characterClass.className));
        }
    }

    public void AddClass()
    {
        print("ADDING CLASS " + classDropdown.options[classDropdown.value].text);
    }
}
