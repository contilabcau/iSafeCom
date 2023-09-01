using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Occupation
{
    Construction_Safety_Manager,
    Taxi_Driver,
    Software_Engineer,
    Drug_Dealer,
    Hardware_Hacker
}

public enum Talent
{
    Safety_Inspection,
    Dancing,
    Magic,
    Brain_Control
}

public enum Personality
{
    Teacher,
    Social,
    Political,
    Opportunist,
    Artistic
}

public class NpcInfo : MonoBehaviour
{
    [SerializeField] private string npcName = "";
    [SerializeField] private Occupation npcOccupation;
    [SerializeField] private Talent npcTalents;
    [SerializeField] private Personality npcPersonality;

    public string GetPrompt()
    {
        return $"NPC Name: {npcName}\n" +
               $"NPC Occupation: {npcOccupation.ToString()}\n" +
               $"NPC Talent: {npcTalents.ToString()}\n" +
               $"NPC Personality: {npcPersonality.ToString()}\n";
    }
}
