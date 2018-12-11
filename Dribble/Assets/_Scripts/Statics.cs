using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Statics {
    public static string selectedCharacter = "female";

    public static void SetCharacter(string character)
    {
        selectedCharacter = character;
    }

    public static string GetCharacter()
    {
        return selectedCharacter;
    }
}