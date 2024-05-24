using System.Collections.Generic;
using System.Linq;
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

    public CharacterClass GetClass(string className)
    {
        return classes.First(c => c.className == className);
    }
}
