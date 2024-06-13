using TMPro;
using UnityEngine;

public class DetailsHolder : MonoBehaviour
{
    public CharacterClass characterClass;
    [Space]
    public TextMeshProUGUI nameLabel;
    public TextMeshProUGUI descriptionLabel;

    public bool isHidden = true;

    public void UpdateData()
    {
        nameLabel.text = characterClass.name;
        descriptionLabel.text = characterClass.description;
    }

    public void ChangeShowState()
    {
        isHidden = !isHidden;
        if (isHidden == false)
        {
            print("HIDDEN");
            descriptionLabel.transform.parent.gameObject.SetActive(true);
            (gameObject.transform as RectTransform).sizeDelta = new Vector2(0, 200);
        }
        else
        {
            print("NOT HIDDEN");
            descriptionLabel.transform.parent.gameObject.SetActive(false);
            (gameObject.transform as RectTransform).sizeDelta = new Vector2(0, 60);
        }
    }
}
