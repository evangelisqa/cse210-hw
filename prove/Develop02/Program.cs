using System;

public class PromtGenerator{
public List<string> Prompts {get; set;}
     public PromtGenerator (){
        Prompts = new List<string>{
            "What was the best part of your day?",
            "Write about an experience where you felt the spirit with you today",
            "Who was the most interested person you interact with today?",
        };
     }
     public string GenerateRandomPrompt(){
        Random random = new Random();
        int index = random.Next(Prompts.Count);
        return Prompts[index];
     }
}