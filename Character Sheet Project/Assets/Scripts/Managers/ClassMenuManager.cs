using UnityEngine;

public class ClassMenuManager : MonoBehaviour
{
    public GameObject ClassAddPanel;

    public void AddClass()
    {
        Instantiate(ClassAddPanel);
    }
}
