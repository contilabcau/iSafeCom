using UnityEngine;

public class WorldInfo : MonoBehaviour
{
    [SerializeField, TextArea] private string gameStory;
    [SerializeField, TextArea] private string simulatedEnvironment;

    public string GetPrompt()
    {
        return $"Game Story: {gameStory}\n" +
               $"Simulated Environment:: {simulatedEnvironment}\n";
    }
}