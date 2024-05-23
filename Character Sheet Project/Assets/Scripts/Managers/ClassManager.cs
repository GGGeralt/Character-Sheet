using System.Collections.Generic;
using UnityEngine;

public class ClassManager : MonoBehaviour
{
    public static ClassManager Instance;
    public List<CharacterClass> classes = new List<CharacterClass>();

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

    public void GetClass(string className)
    {
        //return classes.Where((characterCLass) => characterCLass.className == className);
    }
}
