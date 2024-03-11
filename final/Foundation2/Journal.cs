using System

public class PromtGenerator
{
public List<string> Prompt {get; seat;}
     public PromtGenerator (){
        Promts = new List<string>{
            "What was the best part of your day?",
            "Write about an experience where you felt the spirit with you today",
            "Who was the most interested person you interact with today?",
        }
     }
     public string GenerateRandomPrompt(){
        GenerateRandomPrompt random = new GenerateRandomPrompt();
        int index = random.Next(Prompts.count);
        return Promts[index]
     }
}